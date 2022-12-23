using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Theme;
using LHMS_Application.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHMS_Application.Froms
{
    public partial class FrmTaskTrackAD : Form
    {
        public FrmTaskTrackAD()
        {
            InitializeComponent();
            LoadTheme();
        }
        TaskBLL t = new TaskBLL();
        TaskDal dal = new TaskDal();
        TracklogBll tb = new TracklogBll();
        tracklogDal tdal = new tracklogDal();
        userDal udal = new userDal();
        public void clear()
        {
            txtId.Text = "";
            txtTaskid.Text = "";
            txtnumberofstages.Text = "";
            cmbComplete.Text = "";
            txtpendingsatges.Text = "";
        }
        private void FrmTaskTrackAD_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvTasks.DataSource = dt;
            DataTable dtl = tdal.Select();
            dgvTasklog.DataSource = dtl;

        }
        private void dgvTasks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtTaskid.Text = dgvTasks.Rows[rowIndex].Cells[00].Value.ToString();

        }
        private void dgvTasklog_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvTasklog.Rows[rowIndex].Cells[00].Value.ToString();
            txtTaskid.Text = dgvTasklog.Rows[rowIndex].Cells[01].Value.ToString();
            txtnumberofstages.Text = dgvTasklog.Rows[rowIndex].Cells[02].Value.ToString();
            cmbComplete.Text = dgvTasklog.Rows[rowIndex].Cells[03].Value.ToString();
            txtpendingsatges.Text = dgvTasklog.Rows[rowIndex].Cells[04].Value.ToString();

        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
                label1.ForeColor = ThemeColor.SecondaryColor;
                label2.ForeColor = ThemeColor.SecondaryColor;
                lblTAsk.ForeColor = ThemeColor.PrimaryColor;
            }

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            tb.taskId = Convert.ToInt32(txtTaskid.Text);
            tb.numberofstages = Convert.ToInt32(txtnumberofstages.Text);
            tb.completesatges = cmbComplete.Text;
            tb.pendingsatges = Convert.ToInt32(txtpendingsatges.Text);
            tb.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            tb.add_by = usr.id;
            bool success = tdal.Insert(tb);
            if (success == true)
            {
                MessageBox.Show("Successfully Update Daily Tasks .");
                clear();
                DataTable dt = dal.Select();
                dgvTasklog.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to Update the Daily Tasks.");
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            tb.Id = Convert.ToInt32(txtId.Text);
            tb.taskId = Convert.ToInt32(txtTaskid.Text);
            tb.numberofstages = Convert.ToInt32(txtnumberofstages.Text);
            tb.completesatges = cmbComplete.Text;
            tb.pendingsatges = Convert.ToInt32(txtpendingsatges.Text);
            tb.added_date = DateTime.Now;
            string loggedUser = FrmLogin.LoggedIn;
            UserBll usr = udal.GetIDFromUsername(loggedUser);
            tb.add_by = usr.id;
            bool success = tdal.Update(tb);
            if (success == true)
            {
                MessageBox.Show("Successfully Update Daily Tasks .");
                clear();
                DataTable dt = dal.Select();
                dgvTasklog.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Fail to Update the Daily Tasks.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
