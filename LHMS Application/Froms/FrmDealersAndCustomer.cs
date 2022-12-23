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
using System.Xml.Linq;

namespace LHMS_Application.Froms
{
    public partial class FrmDealersAndCustomer : Form
    {
        public FrmDealersAndCustomer()
        {
            InitializeComponent();
        }
        DealCusBll dc = new DealCusBll();
        dealcusDal dal = new dealcusDal();

        userDal udal = new userDal();

        private void FrmDealersAndCustomer_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvDeal_cus.DataSource = dt;

        }
        public void clear()
        {
            txtId.Text = "";
            cmbtype.Text = "";
            txtname.Text = "";
            txtemail.Text = "";
            txtcontact.Text = "";
            txtaddress.Text = "";
            txtsearch.Text = "";
        }


        private void btnadd_Click(object sender, EventArgs e)
        {
            //Get the values from the form
            dc.type = cmbtype.Text;
            dc.name = txtname.Text;
            dc.email = txtemail.Text;
            dc.contact = txtcontact.Text;
            dc.address = txtaddress.Text;
            dc.add_date = DateTime.Now;

            //getting ID in Added bt field
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);

            //passign the id of logged in User in added by field 
            dc.added_by = usr.id;

            //creating boolane method to insert data into database
            bool success = dal.Insert(dc);

            //if the Deal and customer in inserted success than the value of the success will be true else it will be false.
            if (success == true)
            {
                //new Deal and customer insert was successfull
                MessageBox.Show("New Deal and customer Inserted successfully.");

                //clear the text in the teaxtboxes
                clear();

                //refreash the data grid
                DataTable dt = dal.Select();
                dgvDeal_cus.DataSource = dt;
            }
            else
            {
                //new Deal and customer insert was Failed
                MessageBox.Show("New Deal and customer Inserted Failed.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtId.Text);
            dc.type = cmbtype.Text;
            dc.name = txtname.Text;
            dc.email = txtemail.Text;
            dc.contact = txtcontact.Text;
            dc.address = txtaddress.Text;
            dc.add_date = DateTime.Now;

            //getting ID in Added bt field
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);

            //passign the id of logged in User in added by field 
            dc.added_by = usr.id;

            //creating Boolean variable to update categories and check 
            bool success = dal.Update(dc);

            //If the Deal and customer is updated succesffully then the value of success will br ture else it will be fales. 
            if (success == true)
            {
                //Categories updated Successfully 
                MessageBox.Show("Deal and customer are updated successfully");
                clear();

                DataTable dt = dal.Select();
                dgvDeal_cus.DataSource = dt;
            }
            else
            {
                //Categories updated failer
                MessageBox.Show("Deal and customer are failed to updated");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the id that need to delete the from teh database.
            dc.id = int.Parse(txtId.Text);
            //Creating boolane variable to delete the Deal and customer.
            bool success = dal.Delete(dc);

            if (success == true)
            {
                MessageBox.Show("This Deal and customer is removed from the system.");
                clear();

                DataTable dt = dal.Select();
                dgvDeal_cus.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to remove the Deal and customer. TRY Again.");
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtsearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.Search(keywords);
                dgvDeal_cus.DataSource = dt;
            }
            else
            {
                DataTable dt = dal.Select();
                dgvDeal_cus.DataSource = dt;
            }

        }

        private void dgvDeal_cus_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //find the row index of the Deal and customer click on the grid
            int RowIndex = e.RowIndex;

            txtId.Text = dgvDeal_cus.Rows[RowIndex].Cells[0].Value.ToString();
            cmbtype.Text = dgvDeal_cus.Rows[RowIndex].Cells[1].Value.ToString();
            txtname.Text = dgvDeal_cus.Rows[RowIndex].Cells[2].Value.ToString();
            txtemail.Text = dgvDeal_cus.Rows[RowIndex].Cells[3].Value.ToString();
            txtcontact.Text = dgvDeal_cus.Rows[RowIndex].Cells[4].Value.ToString();
            txtaddress.Text = dgvDeal_cus.Rows[RowIndex].Cells[5].Value.ToString();

        }
    }
}
