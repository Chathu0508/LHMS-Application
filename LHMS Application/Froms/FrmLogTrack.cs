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
    public partial class FrmLogTrack : Form
    {
        LogTrackBll ltu = new LogTrackBll();
        LogTrackDal ltdal = new LogTrackDal();
        public FrmLogTrack()
        {
            InitializeComponent();
        }

        private void FrmLogTrack_Load(object sender, EventArgs e)
        {
            DataTable dt = ltdal.Select();
            dgvlogtrack.DataSource = dt;

        }
    }
}
