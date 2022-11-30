﻿using LHMS_Application.BLL;
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
    public partial class FrmTaskTrack : Form
    {
        public FrmTaskTrack()
        {
            InitializeComponent();
        }

        taskBLL t = new taskBLL();
        TaskDal dal = new TaskDal();

        private void FrmTaskTrack_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvTasks.DataSource = dt;

        }
    }
}
