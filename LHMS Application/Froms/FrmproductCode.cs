using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBSQLHelper;

namespace LHMS_Application.Froms
{
    public partial class FrmproductCode : Form
    {
        public FrmproductCode()
        {
            InitializeComponent();
        }

        private void FrmproductCode_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            var Productcode = SQLHelper.ExecQueryDataAsDataTable("select * from tbl_productCod");
            dgvProductcode.DataSource = Productcode;
        }
        public string CreateAutoID()
        {
            return SQLHelper.ExecQuerySacalar($@"SELECT CONCAT('MASV', RIGHT(CONCAT('0000000000',ISNULL(right(max(masv),10),0) + 1),10))
                                            FROM dbo.tbl_productCode where masv like 'MASV%'").ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            txtprodcode.Text=CreateAutoID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productCode = txtprodcode.Text.Trim();
            var product = txtprodname.Text.Trim();
            var sql_insert = $@"INSERT INTO dbo.tbl_sinhvien
                                (
                                    productCode,
                                    product
                                )
                                VALUES
                                (   @productCode,
                                   @product
                                 )";

            //var affectRow = SQLHelper.ExecQueryNonData(sql_insert, new { productCode = masv, tensv = tensinhvien });
            //// fix insert sql injection
            //if (affectRow > 0)
            //{
            //    // Insert success
            //    LoadData();
            //    txtprodcode.Text = CreateAutoID();
            //    txtprodname.Text = "";
            //    txtprodname.Focus();
            //}
            //else
            //{
            //    MessageBox.Show("Insert fails");
            //}

        }
    }
}
