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

namespace LHMS_Application.Forms
{
    public partial class FrmTasks : Form
    {
        public FrmTasks()
        {
            InitializeComponent();
        }

        taskBLL t = new taskBLL();
        TaskDal dal = new TaskDal();
        userDal udal = new userDal();

        public void clear()
        {
            txtID.Text = "";
            txtTitle.Text = "";
            txtDiscription.Text = "";
            cmbFactory.Text = "";
            cmbDevepartment.Text = "";

        }
        private void btnAddtask_Click(object sender, EventArgs e)
        {
            //Get the values from the category form
            t.title = txtTitle.Text;
            t.description = txtDiscription.Text;
            t.factory = cmbFactory.Text;
            t.departments = cmbDevepartment.Text;
            t.added_date = DateTime.Now;

            //getting ID in Added bt field
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);

            //passign the id of logged in User in added by field 
            t.added_by = usr.id;

            //creating boolane method to insert data into database
            bool success = dal.Insert(t);

            //if the category in inserted success than the value of the success will be true else it will be false.
            if (success == true)
            {
                //newcategory insert was successfull
                MessageBox.Show("New task Inserted successfully.");

                //clear the text in the teaxtboxes
                clear();

                //refreash the data grid
                DataTable dt = dal.Select();
                dgvtasks.DataSource = dt;
            }
            else
            {
                //newcategory insert was Failed
                MessageBox.Show("New task Inserted Failed.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get the id that need to delete the from teh database.
            t.id = int.Parse(txtID.Text);

            //Creating boolane variable to delete the cateogory.
            bool success = dal.Delete(t);

            if (success == true)
            {
                MessageBox.Show("This category is removed from the system.");
                clear();

                DataTable dt = dal.Select();
                dgvtasks.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to remove the category. TRY Again.");
            }

        }
    }
}
