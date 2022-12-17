using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Forms;
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
    public partial class FrmPurchaseandsales : Form
    {
        public FrmPurchaseandsales()
        {
            InitializeComponent();
        }

        dealcusDal dcdal = new dealcusDal();

        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            //get the transaction type from the main dashboard
            //string type = frmDashboardAD.transactiontype;
            //set the value on the lbltitle;
            //lbltop.Text = type;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get the keyword for the text box
            string keyword =  txtSearch.Text;

            if (keyword == "")
            {
                //clear the textbox.
                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            //write the code to get the details and values on text 
            dealcusBll dc = dcdal.SearchDealerCustomerFortransaction(keyword);

            //now transfer or set the value from deacustbll to textbox
            txtName.Text = dc.name;
            txtEmail.Text = dc.email;
            txtContact.Text = dc.contact;
            txtAddress.Text = dc.address;
        }
    }
}
