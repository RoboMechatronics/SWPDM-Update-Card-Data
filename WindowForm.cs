﻿using EPDM.Interop.epdm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace SWPDM_Update_Card_Data
{
    public partial class WindowForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        #region Private Variables
        private Dictionary<string, string> Parameters = new Dictionary<string, string>();
        private Dictionary<string, string>[] ParametersArray;
        private readonly string[] Field = { "Center of Web", "Description", "Probe", "Tip", "Total Length", "Dut Plunger", "Preload", "Tip Extension", "Center-Top MGP", "Center-Bottom MGP" };
        private UpdateProbeParameter swPDMAddin;
        private UndoCheckoutFiles UndoCheckOut;
        #endregion

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="swAddin"></param>
        public WindowForm(UpdateProbeParameter swAddin)
        {
            InitializeComponent();

            swPDMAddin = swAddin;

            if (swPDMAddin.GetPpoData.Count == 1)
            {
                this.label11.Text = swPDMAddin.GetPpoData.Values.ElementAt(0);
                ParametersArray = null;
            }
            else
            {
                ParametersArray = new Dictionary<string, string>[swPDMAddin.GetPpoData.Count];
            }
        }

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateCardData_button_Click(object sender, EventArgs e)
        {
            Parameters.Clear();

            switch (this.tabControl.SelectedTab.Text)
            {
                case "Way 1":
                    if (HasData(CenterOfWeb_textBox.Text)==true && 
                        HasData(Description_textBox.Text)==true &&
                        HasData(Probe_textBox.Text) == true &&
                        HasData(TipType_textBox.Text) == true &&
                        HasData(TotalLength_textBox.Text) == true &&
                        HasData(DutPlunger_textBox.Text) == true &&
                        HasData(Preload_textBox.Text) == true &&
                        HasData(TipExtension_textBox.Text) == true &&
                        HasData(CenterTopMGP_textBox.Text) == true &&
                        HasData(CenterBottom_textBox.Text) == true)
                    {
                        if (swPDMAddin.GetPpoData.Count == 1) // If you choose one probe.
                        {
                            // Get Center of Web
                            Parameters.Add(Field[0], CenterOfWeb_textBox.Text);
                            // Get Desciption
                            Parameters.Add(Field[1], Description_textBox.Text);
                            // Get Probe type
                            Parameters.Add(Field[2], Probe_textBox.Text);
                            // Get Tip type
                            Parameters.Add(Field[3], TipType_textBox.Text);
                            // Get Total Length
                            Parameters.Add(Field[4], TotalLength_textBox.Text);
                            // Get Dut Plunger
                            Parameters.Add(Field[5], DutPlunger_textBox.Text);
                            // Get Preload
                            Parameters.Add(Field[6], Preload_textBox.Text);
                            // Get Tip Extension
                            Parameters.Add(Field[7], TipExtension_textBox.Text);
                            // Get Center-Top MGP
                            Parameters.Add(Field[8], CenterTopMGP_textBox.Text);
                            // Get Center-Bottom MGP
                            Parameters.Add(Field[9], CenterBottom_textBox.Text);

                            // Get Card Data
                            UpdateCardData(ref Parameters);
                        }
                        else // If you choose two or more probes.
                        {
                            tabControl.SelectedTab = Way2_tab;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill data into the textboxes below");
                    }

                    break;

                case "Way 2":

                    string content = PasteFromClipboard_richTextBox.Text;

                    if (!String.IsNullOrEmpty(content) && content != "")
                    {
                        UpdateCardData(ref ParametersArray); // for single and multi probes.
                    }
                    else
                    {
                        MessageBox.Show("Please paste data into textbox below or move to | Way 1 | tab.");
                    }
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_button_Click(object sender, EventArgs e)
        {
            swPDMAddin = null;
            Parameters = null;
            Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Parameters"></param>
        public void UpdateCardData(ref Dictionary<string, string> Parameters)
        {
            try
            {
                #region Local Variables
                IEdmVault5 MyVault = swPDMAddin.GetVault5;
                IEdmFile5 file;
                Dictionary<int, string> ppoData = new Dictionary<int, string>();
                int lParentFolderID = swPDMAddin.GetParentFolderID;
                int lParentWnd = swPDMAddin.GetParentWnd;
                #endregion

                PasteFromClipboard_richTextBox.Text = "";
                ppoData = swPDMAddin.GetPpoData;
                foreach (KeyValuePair<int, string> p in ppoData){
                    // Get file
                    file = (IEdmFile5)MyVault.GetObject(EdmObjectType.EdmObject_File, p.Key);

                    // Check out this file
                    file.LockFile(lParentFolderID, this.Handle.ToInt32());

                    // Prepair if error happends
                    UndoCheckOut = new UndoCheckoutFiles(MyVault, p.Key, swPDMAddin.GetParentFolderID, this.Handle.ToInt32());

                    // Update variables
                    IEdmEnumeratorVariable5 vars = (IEdmEnumeratorVariable5)file.GetEnumeratorVariable(file.GetLocalPath(swPDMAddin.GetParentFolderID));
                    IEdmStrLst5 ConfigNames = (IEdmStrLst5)file.GetConfigurations();

                    // Get Po
                    IEdmPos5 pos = ConfigNames.GetHeadPosition();
                    string CurConfig = "";
                    while (!pos.IsNull){
                        CurConfig = ConfigNames.GetNext(pos);
                        for (int i = 0; i < Parameters.Count; i++){
                            vars.SetVar(Field[i], CurConfig, Parameters[Field[i]]);
                        }
                    }

                    //Close the file that is openning for access by this interface.
                    IEdmEnumeratorVariable8 vars8 = (IEdmEnumeratorVariable8)vars;
                    vars8.CloseFile(true);

                    // Check in this file
                    file.UnlockFile(this.Handle.ToInt32(), "Update card data and properties");
                    MessageBox.Show("Completed!");
                    Close();
                }
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                // Show error content
                MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + " " + ex.Message);
                // Undo check out file if error
                UndoCheckOut.Undo();
            }
            catch (Exception ex)
            {
                // Show error content
                MessageBox.Show(ex.Message + "\nUndo Check Out!!!");
                // Undo check out file if error
                UndoCheckOut.Undo();
            }
            // Delete object
            UndoCheckOut = null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ParametersArray"></param>
        public void UpdateCardData(ref Dictionary<string, string>[] ParametersArray) 
        { 
            MessageBox.Show("Debug only, " + ParametersArray.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool HasData(string s)
        {
            if (!string.IsNullOrEmpty(s) && s != "") return true;
            
            return false;
        }
        #endregion
    }
}
