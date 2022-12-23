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
    public partial class FrmtaskAD : Form
    {
        public FrmtaskAD()
        {
            InitializeComponent();
        }
        TaskBLL t = new TaskBLL();
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
                dgvtask.DataSource = dt;
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
            t.Id = int.Parse(txtID.Text);

            //Creating boolane variable to delete the cateogory.
            bool success = dal.Delete(t);

            if (success == true)
            {
                MessageBox.Show("This category is removed from the system.");
                clear();

                DataTable dt = dal.Select();
                dgvtask.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to remove the category. TRY Again.");
            }

        }

        private void dgvtasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmtaskAD_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvtask.DataSource = dt;

        }

        private void dgvtask_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtID.Text = dgvtask.Rows[rowIndex].Cells[00].Value.ToString();
            txtTitle.Text = dgvtask.Rows[rowIndex].Cells[01].Value.ToString();
            txtDiscription.Text = dgvtask.Rows[rowIndex].Cells[02].Value.ToString();
            cmbFactory.Text = dgvtask.Rows[rowIndex].Cells[03].Value.ToString();
            cmbDevepartment.Text = dgvtask.Rows[rowIndex].Cells[04].Value.ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            t.Id = Convert.ToInt32(txtID.Text);
            t.title = txtTitle.Text;
            t.description = txtDiscription.Text;
            t.factory = cmbFactory.Text;
            t.departments = cmbDevepartment.Text;
            t.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            t.added_by = usr.id;


            bool success = dal.Update(t);

            if (success)
            {
                MessageBox.Show("User Successfully updated");
                clear();
            }
            else
            {
                MessageBox.Show("Falied to update User");
            }
            DataTable dt = dal.Select();
            dgvtask.DataSource = dt;

        }
    }
}
