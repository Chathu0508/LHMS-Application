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
    public partial class Frmtaskprograss : Form
    {
        TracklogBll tb = new TracklogBll();
        tracklogDal tdal = new tracklogDal();
        userDal udal = new userDal();

        public Frmtaskprograss()
        {
            InitializeComponent();
        }

        private void Frmtaskprograss_Load(object sender, EventArgs e)
        {
            DataTable dt = tdal.Select();
            Dgvtaskprogress.DataSource = dt;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = tdal.Search(keywords);
                Dgvtaskprogress.DataSource = dt;
            }
            else
            {
                DataTable dt = tdal.Select();
                Dgvtaskprogress.DataSource = dt;
            }

        }
    }
}
