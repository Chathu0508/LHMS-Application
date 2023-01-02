using LHMS_Application.BLL;
using LHMS_Application.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.UI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        LoginBll l = new LoginBll();
        loginDal dal = new loginDal();
        public static string LoggedIn;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtusername.Text.Trim();
            l.password = txtpassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            // checking the login credentials
            bool sucess = dal.loginCheck(l);

            
            //Error Provider for the Username and Error Provider for the password

            if (string.IsNullOrEmpty(txtusername.Text.Trim()))
            {
                usernameerr.SetError(txtusername, "Username is Required");
            }
            else
            {
                usernameerr.SetError(txtusername, string.Empty);

            }
            if (string.IsNullOrEmpty(txtpassword.Text.Trim()))
            {
                passworderr.SetError(txtpassword, "Password is Required");
            }
            else
            {
                passworderr.SetError(txtpassword, string.Empty);
            }

            //if the both textboxs were fill the following code will run
            if (sucess == true)
            {
                //login successful
                MessageBox.Show("Login Success.");
                LoggedIn = l.username;

                // need to open Respective Forms based on the User type
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            //display admin Dashboard
                            frmDashboardAD admin = new frmDashboardAD();
                            admin.Show();
                            this.Hide();
                        }
                        break;

                    case "Factory Head":
                        {
                            //display user Dashboard
                            frmFactoryHDashboard user = new frmFactoryHDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    case "Department Head":
                        {
                            //display user Dashboard
                            frmDepartmentHDashboard user = new frmDepartmentHDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    case "Supervisor":
                        {
                            //display user Dashboard
                            frmSupervsorDashboard user = new frmSupervsorDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            // Display an Eorror Messsage 
                            MessageBox.Show("Invaild User type");
                        }
                        break;
                }
            }
            else
            {
                //login failed
                MessageBox.Show("Fail to login");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void txtusername_Validating(object sender, CancelEventArgs e)
        {
        }
    }
}
