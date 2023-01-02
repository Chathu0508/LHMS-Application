using LHMS_Application.BLL;
using LHMS_Application.Dal;
using LHMS_Application.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            DbConnection db = DbConnection.getInstance();

            db.OpenCon();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tbl_task INNER JOIN task_Log ON tbl_task.id = task_Log.taskId WHERE taskId = 1 ", db.conn);
            SqlDataAdapter dr = new SqlDataAdapter();
            dr.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dr.Fill(dt);

            Dgvtaskprogress.DataSource = dt;
            Dgvtaskprogress.Columns[0].HeaderText = "id";
            Dgvtaskprogress.Columns[1].HeaderText = "title";
            Dgvtaskprogress.Columns[2].HeaderText = "description";
            Dgvtaskprogress.Columns[3].HeaderText = "factory";
            Dgvtaskprogress.Columns[4].HeaderText = "numberofstages";
            Dgvtaskprogress.Columns[5].HeaderText = "completesatges";
            Dgvtaskprogress.Columns[6].HeaderText = "pendingsatges";

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

        private void btnexport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Response.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (Dgvtaskprogress.Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {

                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < Dgvtaskprogress.Columns.Count; i++)
                        {
                            wr.Write(Dgvtaskprogress.Columns[i].Name.ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (Dgvtaskprogress.Rows.Count); i++)
                        {
                            for (int j = 0; j < Dgvtaskprogress.Columns.Count; j++)
                            {
                                if (Dgvtaskprogress.Rows[i].Cells[j].Value != null)
                                {
                                    wr.Write(Convert.ToString(Dgvtaskprogress.Rows[i].Cells[j].Value.ToString()) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MessageBox.Show(this, "Data saved in Excel format at location " + savefile.FileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Zero record to export , perform a operation first", "Can't export file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }
    
    }
}
