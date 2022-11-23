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

namespace LHMS_Application.Forms
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }
        categoryDal cdal = new categoryDal();
        productBll p = new productBll();
        productDal pdal = new productDal();
        userDal udal = new userDal();

        private void btnadd_Click(object sender, EventArgs e)
        {
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            //Getting the user name 
            String loggedUsr = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUsr);

            p.added_by = usr.id;

            //cretaing boolane Variable to check if the product added successfully or not
            bool success = pdal.Insert(p);

            //if the product added successfully then the value of success will be greater than 0
            if (success == true)
            {
                MessageBox.Show("Product added successfully");
                //calling for the claer method
                Clear();

                //referance the data grid view
                DataTable dt = pdal.Select();
                dgvProduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed added product successfully");
            }
        }
        public void Clear()
        {
            txtprodID.Text = "";
            txtName.Text = "";
            cmbCategory.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";
        }

        private void Product_Load(object sender, EventArgs e)
        {
            //creating a datatable to hold the categories from Data Table
            DataTable categoriesDT = cdal.Select();

            //Specify Data Source for category ComboBox
            cmbCategory.DataSource = categoriesDT;

            //Specify Display member and avalue member s from the data table. 
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";


            //load all the producted in data grid view
            DataTable dt = pdal.Select();
            dgvProduct.DataSource = dt;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtprodID.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.added_date = DateTime.Now;

            //Getting Username of logged in user for addedby
            //Getting the user name 
            String loggedUsr = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUsr);

            p.added_by = usr.id;

            //cretaing boolane Variable to check if the product added successfully or not
            bool success = pdal.Update(p);

            //if the product added successfully then the value of success will be greater than 0
            if (success == true)
            {
                MessageBox.Show("Product updated successfully");
                //calling for the claer method
                Clear();

                //referance the data grid view
                DataTable dt = pdal.Select();
                dgvProduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed update the product successfully");
            }
        }

        private void dgvProduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //create a integer varible to know which product was click 
            int rowIndex = e.RowIndex;

            //display  the value on Respective texboxes 
            txtprodID.Text = dgvProduct.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProduct.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProduct.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProduct.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProduct.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //Get the id of the product to be delete
            p.id = int.Parse(txtprodID.Text);

            //cretaing boolane Variable to check if the product added successfully or not
            bool success = pdal.Delete(p);

            //if the product added successfully then the value of success will be greater than 0
            if (success == true)
            {
                MessageBox.Show("Product delete successfully");
                //calling for the claer method
                Clear();

                //referance the data grid view
                DataTable dt = pdal.Select();
                dgvProduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed delete the product successfully");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the Keywords from th forms
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                //Search the product
                DataTable dt = pdal.Search(keywords);
                dgvProduct.DataSource = dt;
            }
            else
            {
                //Search the product
                DataTable dt = pdal.Select();
                dgvProduct.DataSource = dt;
            }
        }

    }
}

