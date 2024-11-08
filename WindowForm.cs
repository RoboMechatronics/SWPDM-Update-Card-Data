using EPDM.Interop.epdm;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SWPDM_Update_Card_Data
{
    public partial class WindowForm : Form
    {
        Dictionary<string, string> Parameters = new Dictionary<string, string>();
        string[] Field = { "Center of Web", "Desciption", "Probe", "Tip", "Total Length", "Dut Plunger", "Preload", "Tip Extension", "Center-Top MGP", " Center-Bottom MGP" };
        UpdateProbeParameter swPDMAddin;

        public WindowForm(UpdateProbeParameter swAddin)
        {
            InitializeComponent();

            swPDMAddin = swAddin;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Parameters.Clear();
            switch (this.tabControl.SelectedTab.Text)
            {
                case "Way 1":
                    if (swPDMAddin.GetPpoData.Length == 1)
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

                        WriteCardData(Parameters);
                    }
                    else
                    {
                        tabControl.SelectedTab = Way2_tab;
                    }
                    break;

                case "Way 2":
                    break;
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            swPDMAddin = null;
            Parameters = null;
            Close();
        }
        public void WriteCardData(Dictionary<string, string> Parameters)
        {
            try
            {
                IEdmVault5 myVault;

                myVault = swPDMAddin.GetVault5;
                
                //IEdmFolder5 Folder = default(IEdmFolder5);

                //Folder = myVault.RootFolder;

                //MessageBox.Show(Folder.ParentFolder.ToString());

                // Check out file

                // Set Card Data

                // Check in file
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("HRESULT = 0x" + ex.ErrorCode.ToString("X") + " " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
