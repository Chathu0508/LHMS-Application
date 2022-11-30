using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Froms
{
    public partial class FrmFHUserS : Form
    {
        public FrmFHUserS()
        {
            InitializeComponent();
        }

        UserBll u = new UserBll();
        userDal dal = new userDal();

        public void clear()
        {
            txtID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";
            cmbdepartment.Text = "";
            cmbFactory.Text = "";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //getting Username of the logged in User
            string loggedUser = FrmLogin.LoggedIn;

            // getting data from UI
            u.firstname = txtFirstName.Text;
            u.lastname = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.department = cmbdepartment.Text;
            u.Factory = cmbFactory.Text;
            u.added_Date = DateTime.Now;

            //get the username of the user
            string loggeduser = FrmLogin.LoggedIn;
            UserBll usr = dal.GetIDFromUsername(loggeduser);

            u.added_by = usr.id;

            //Insert in to Database. 
            bool success = dal.Insert(u);

            //if the data is Successfully inserted them the value of success will be true else it will  be fales. 
            if (success)
            {
                //Data successfully Insert 
                MessageBox.Show("Successfully create a user");
                clear();
            }
            else
            {
                //Data didnot insert Successfully.
                MessageBox.Show("Fail to create the user");
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void FrmFHUserS_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }
    }
}
