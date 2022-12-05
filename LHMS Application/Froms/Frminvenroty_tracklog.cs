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
    public partial class Frminvenroty_tracklog : Form
    {
        //to get the ids from the Database
        productDal pdal = new productDal();
        categoryDal cdal = new categoryDal();
        userDal udal = new userDal();

        //inventory bll and dal froms
        inventoryDal dal = new inventoryDal();
        inventorybll ibl = new inventorybll();
        public Frminvenroty_tracklog()
        {
            InitializeComponent();
        }
        public void clear()
        {
            txtID.Text = "";
            txtproductid.Text = "";
            txtcategoryid.Text = "";
            txttotinv.Text = "";
            txtasswqty.Text = "";
            txtleftover.Text = "";
        }

        private void Frminvenroty_tracklog_Load(object sender, EventArgs e)
        {
            DataTable dt = pdal.Select();
            dgvproduct.DataSource = dt;

            DataTable dtl = cdal.Select();
            dgvCatorgry.DataSource = dtl;

            DataTable dts = dal.Select();
            dgvInventory.DataSource = dts;
        }

        private void dgvCatorgry_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtcategoryid.Text = dgvCatorgry.Rows[rowIndex].Cells[00].Value.ToString();

        }

        private void dgvproduct_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtproductid.Text = dgvproduct.Rows[rowIndex].Cells[00].Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            ibl.category_id = Convert.ToInt32(txtcategoryid.Text);
            ibl.product_id = Convert.ToInt32(txtproductid.Text);
            ibl.total_qty = Convert.ToInt32(txttotinv.Text);
            ibl.assign_qty = Convert.ToInt32(txtasswqty.Text);
            ibl.leftover_qty = Convert.ToInt32(txtleftover.Text);
            ibl.Added_date = DateTime.Now;

            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);

            ibl.added_by = usr.id;

            bool success = dal.Insert(ibl);

            if (success == true)
            {
                MessageBox.Show("Successfully Update Daily Tasks .");

                clear();

                DataTable dt = dal.Select();
                dgvInventory.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to Update the Daily Tasks.");
            }


        }
    }
}
