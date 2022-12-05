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

namespace LHMS_Application.Froms
{
    public partial class Frminvenroty_tracklog : Form
    {
        //to get the ids from the Database
        productDal pdal = new productDal();
        categoryDal cdal = new categoryDal(); 

        //inventory bll and dal froms
        inventoryDal dal = new inventoryDal();
        inventorybll ibl = new inventorybll();
        public Frminvenroty_tracklog()
        {
            InitializeComponent();
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
    }
}
