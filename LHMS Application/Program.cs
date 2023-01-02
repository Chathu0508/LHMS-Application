using LHMS_Application.Forms;
using LHMS_Application.Froms;
using LHMS_Application.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBSQLHelper;

namespace LHMS_Application
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SQLHelper.DATABASE = "LookHoodDB";
            SQLHelper.USERNAME_DB = "DESKTOP-RPB2NDQ\\MSSQL2019";

            //Frm ACCess -----------------------------------------------------
            //Application.Run(new FrmLogTrack());
            Application.Run(new FrmLogin());
            //Application.Run(new SampleTestUI());

        }
    }
}
