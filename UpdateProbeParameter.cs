using EPDM.Interop.epdm;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SWPDM_Update_Card_Data
{
    public class UpdateProbeParameter : IEdmAddIn5
    {
        #region Private Variables
        private const int CommandID = 1;
        private const string AddInName = "Update Card Data";
        private const int AddInVersion = 1;
        private EdmCmd mPoCmd;
        private Dictionary<int, string> FilePathList;
        private IEdmVault5 mVault5;
        private int mParentFolderID;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="poInfo"></param>
        /// <param name="poVault"></param>
        /// <param name="poCmdMgr"></param>
        public void GetAddInInfo(ref EdmAddInInfo poInfo, IEdmVault5 poVault, IEdmCmdMgr5 poCmdMgr)
        {
            poInfo.mbsAddInName = AddInName;
            poInfo.mbsCompany = "No Company name";
            poInfo.mbsDescription = "Update Card Data for MEM Probes only.";
            poInfo.mlAddInVersion = AddInVersion;

            poInfo.mlRequiredVersionMajor = 6;
            poInfo.mlRequiredVersionMinor = 4;

            // Register a menu command
            poCmdMgr.AddCmd(CommandID, AddInName, (int)EdmMenuFlags.EdmMenu_Nothing);

            // Get current Vault
            mVault5 = poVault;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="poCmd"></param>
        /// <param name="ppoData"></param>
        public void OnCmd(ref EdmCmd poCmd, ref EdmCmdData[] ppoData)
        {
            FilePathList = new Dictionary<int, string>();

            if (poCmd.meCmdType == EdmCmdType.EdmCmd_Menu)
            {
                if (poCmd.mlCmdID == 1)
                {
                    mPoCmd = poCmd;

                    // Get ID and full path of the selected files.
                    mParentFolderID = ppoData[0].mlObjectID3;
                    foreach (EdmCmdData p in ppoData)
                    {
                        FilePathList.Add(p.mlObjectID1, p.mbsStrData1);
                    }

                    WindowForm myform = new WindowForm(this);

                    myform.Show();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public EdmCmd GetPoCMD
        { get { return mPoCmd; } }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<int, string> GetPpoData
        { get { return FilePathList; } }

        /// <summary>
        /// 
        /// </summary>
        public IEdmVault5 GetVault5
        { get { return mVault5; } }

        /// <summary>
        /// 
        /// </summary>
        public int GetParentFolderID
        { get { return mParentFolderID; } }

        /// <summary>
        /// 
        /// </summary>
        public int GetParentWnd
        { get { return mPoCmd.mlParentWnd; } }
    }

    /// <summary>
    /// This class is used for undoing checkout file related to the error that updating card data process.  
    /// Input: IEdmVault5 CurrentVault, int fileID, int ParentFolderID, int ParentHandleID
    /// Output: No
    /// </summary>
    public class UndoCheckoutFiles
    {
        #region Private Variables
        private int m_fileID;
        private int m_ParentHandleID;
        private int m_ParentFolderID;
        private IEdmVault5 m_CurrentVault;
        private IEdmFile5 file;
        #endregion

        /// <summary>
        /// A constructor is used for passing Input variables value
        /// </summary>
        /// <param name="CurrentVault"></param>
        /// <param name="fileID"></param>
        /// <param name="ParentFolderID"></param>
        /// <param name="ParentHandleID"></param>
        public UndoCheckoutFiles(IEdmVault5 CurrentVault, int fileID, int ParentFolderID, int ParentHandleID)
        {
            m_fileID = fileID;
            m_ParentHandleID = ParentHandleID;
            m_CurrentVault = CurrentVault;
            m_ParentFolderID = ParentFolderID;
        }

        /// <summary>
        /// This method is used to perform "Undo Check Out" files.
        /// Input: No
        /// Output: No
        /// </summary>
        public void Undo()
        {
            file = (IEdmFile5)m_CurrentVault.GetObject(EdmObjectType.EdmObject_File, m_fileID);

            IEdmEnumeratorVariable5 vars = (IEdmEnumeratorVariable5)file.GetEnumeratorVariable(file.GetLocalPath(m_ParentFolderID));

            IEdmEnumeratorVariable8 vars8 = (IEdmEnumeratorVariable8)vars;
            vars8.CloseFile(true);

            file.UndoLockFile(m_ParentHandleID);
        }
    }
}
