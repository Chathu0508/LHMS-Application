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
    public partial class FrmTaskTrack : Form
    {
        public FrmTaskTrack()
        {
            InitializeComponent();
        }

        taskBLL t = new taskBLL();
        TaskDal dal = new TaskDal();
        tracklogBll tb = new tracklogBll();
        tracklogDal tdal = new tracklogDal();
        userDal udal = new userDal();

        public void clear()
        {
        }

        private void FrmTaskTrack_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvTasks.DataSource = dt;

            DataTable dtl = tdal.Select();
            dgvTasklog.DataSource = dtl;

        }
        private void dgvTasklog_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int rowIndex = e.RowIndex;
            txtId.Text = dgvTasklog.Rows[rowIndex].Cells[00].Value.ToString();
            txtTaskid.Text = dgvTasklog.Rows[rowIndex].Cells[01].Value.ToString();
            txtnumberofstages.Text = dgvTasklog.Rows[rowIndex].Cells[02].Value.ToString();
            txtcompletesatges.Text = dgvTasklog.Rows[rowIndex].Cells[03].Value.ToString();
            txtpendingsatges.Text = dgvTasklog.Rows[rowIndex].Cells[03].Value.ToString();
        }

        private void dgvTasks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtTaskid.Text = dgvTasks.Rows[rowIndex].Cells[00].Value.ToString();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            tb.taskId = Convert.ToInt32(txtTaskid.Text);
            tb.numberofstages = Convert.ToInt32(txtnumberofstages.Text);
            tb.completesatges = txtnumberofstages.Text;
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
    }
}
