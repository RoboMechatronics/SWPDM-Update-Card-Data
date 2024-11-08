using EPDM.Interop.epdm;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SWPDM_Update_Card_Data
{
    public class UpdateProbeParameter : IEdmAddIn5
    {
        private const int CmdID = 1;
        private const string AddInName = "Update Card Data";
        private const int AddInversion = 1;
        private EdmCmd mPoCmd;
        private EdmCmdData[] mPpoData;
        private IEdmVault5 mVault;

        public void GetAddInInfo(ref EdmAddInInfo poInfo, IEdmVault5 poVault, IEdmCmdMgr5 poCmdMgr)
        {
            poInfo.mbsAddInName = AddInName;
            poInfo.mbsCompany = "Initial";
            poInfo.mbsDescription = "Update Card Data for MEM Probes only.";
            poInfo.mlAddInVersion = AddInversion;

            poInfo.mlRequiredVersionMajor = 6;
            poInfo.mlRequiredVersionMinor = 4;

            // Register a menu command
            poCmdMgr.AddCmd(CmdID, AddInName, (int)EdmMenuFlags.EdmMenu_Nothing);

            mVault = poVault;
        }

        public void OnCmd(ref EdmCmd poCmd, ref EdmCmdData[] ppoData)
        {
            if (poCmd.meCmdType == EdmCmdType.EdmCmd_Menu)
            {
                if (poCmd.mlCmdID == 1)
                {
                    mPoCmd = poCmd;
                    mPpoData = ppoData;

                    WindowForm myform = new WindowForm(this);
                    myform.Show();
                }
            }
        }

        public EdmCmd GetPoCMD
        { get { return mPoCmd; } }

        public EdmCmdData[] GetPpoData
        { get { return mPpoData; } }

        public IEdmVault5 GetVault5
        { get { return mVault; } }

        public void WriteCardData(string FilePath, Dictionary<string, string> Parameters)
        {
            // Check out file

            // Set Card Data

            // Check in file
        }
    }
}
