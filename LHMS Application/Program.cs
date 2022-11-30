using LHMS_Application.Forms;
using LHMS_Application.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //Application.Run(new FrmOpening());
            //Application.Run(new FrmLogin());
            //Application.Run(new frmDashboardAD());
            //Application.Run(new frmFactoryHDashboard());
            Application.Run(new frmDepartmentHDashboard());
        }
    }
}
