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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        CategoryBll c = new CategoryBll();
        categoryDal dal = new categoryDal();
        userDal udal = new userDal();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the values from the category form
            c.title = txtTitle.Text;
            c.description = txtdescription.Text;
            c.added_date = DateTime.Now;

            //getting ID in Added bt field
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);

            //passign the id of logged in User in added by field 
            c.added_by = usr.id;

            //creating boolane method to insert data into database
            bool success = dal.Insert(c);

            //if the category in inserted success than the value of the success will be true else it will be false.
            if (success == true)
            {
                //newcategory insert was successfull
                MessageBox.Show("New Category Inserted successfully.");

                //clear the text in the teaxtboxes
                clear();

                //refreash the data grid
                DataTable dt = dal.Select();
                dgvcategory.DataSource = dt;
            }
            else
            {
                //newcategory insert was Failed
                MessageBox.Show("New Category Inserted Failed.");
            }

        }
        public void clear()
        {
            txtID.Text = "";
            txtTitle.Text = "";
            txtdescription.Text = "";
            txtsearch.Text = "";
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvcategory.DataSource = dt;
        }

        private void dgvcategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //find the row index of the categories click on the grid
            int RowIndex = e.RowIndex;

            txtID.Text = dgvcategory.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvcategory.Rows[RowIndex].Cells[1].Value.ToString();
            txtdescription.Text = dgvcategory.Rows[RowIndex].Cells[2].Value.ToString();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            c.id = int.Parse(txtID.Text);
            c.title = txtTitle.Text;
            c.description = txtdescription.Text;
            c.added_date = DateTime.Now;

            //getting ID in Added bt field
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);

            //passign the id of logged in User in added by field 
            c.added_by = usr.id;

            //creating Boolean variable to update categories and check 
            bool success = dal.Update(c);

            //If the category is updated succesffully then the value of success will br ture else it will be fales. 
            if (success == true)
            {
                //Categories updated Successfully 
                MessageBox.Show("Categories are updated successfully");
                clear();

                DataTable dt = dal.Select();
                dgvcategory.DataSource = dt;
            }
            else
            {
                //Categories updated failer
                MessageBox.Show("Categories are failed to updated");
            }

        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            //get the id that need to delete the from teh database.
            c.id = int.Parse(txtID.Text);

            //Creating boolane variable to delete the cateogory.
            bool success = dal.Delete(c);

            if (success == true)
            {
                MessageBox.Show("This category is removed from the system.");
                clear();

                DataTable dt = dal.Select();
                dgvcategory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to remove the category. TRY Again.");
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvcategory.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvcategory.DataSource = dt;
            }

        }
    }
}

