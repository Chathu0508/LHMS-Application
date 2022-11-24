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
    public partial class FrmDealersAndCustomer : Form
    {
        public FrmDealersAndCustomer()
        {
            InitializeComponent();
        }
        dealcusBll dc = new dealcusBll();
        dealcusDal dal = new dealcusDal();

        private void FrmDealersAndCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }
    }
}
