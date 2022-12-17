namespace LHMS_Application.Froms
{
    partial class FrmTaskTrackAD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcompletesatges = new System.Windows.Forms.Label();
            this.txtpendingsatges = new System.Windows.Forms.TextBox();
            this.lblpendingsatges = new System.Windows.Forms.Label();
            this.txtnumberofstages = new System.Windows.Forms.TextBox();
            this.lblnumberofstages = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtTaskid = new System.Windows.Forms.TextBox();
            this.lbltaskID = new System.Windows.Forms.Label();
            this.dgvTasklog = new System.Windows.Forms.DataGridView();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTAsk = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cmbComplete = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasklog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcompletesatges
            // 
            this.lblcompletesatges.AutoSize = true;
            this.lblcompletesatges.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompletesatges.Location = new System.Drawing.Point(20, 320);
            this.lblcompletesatges.Name = "lblcompletesatges";
            this.lblcompletesatges.Size = new System.Drawing.Size(155, 21);
            this.lblcompletesatges.TabIndex = 33;
            this.lblcompletesatges.Text = "Complete Satges";
            // 
            // txtpendingsatges
            // 
            this.txtpendingsatges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpendingsatges.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpendingsatges.Location = new System.Drawing.Point(24, 439);
            this.txtpendingsatges.Name = "txtpendingsatges";
            this.txtpendingsatges.Size = new System.Drawing.Size(383, 28);
            this.txtpendingsatges.TabIndex = 32;
            // 
            // lblpendingsatges
            // 
            this.lblpendingsatges.AutoSize = true;
            this.lblpendingsatges.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpendingsatges.Location = new System.Drawing.Point(20, 404);
            this.lblpendingsatges.Name = "lblpendingsatges";
            this.lblpendingsatges.Size = new System.Drawing.Size(138, 21);
            this.lblpendingsatges.TabIndex = 31;
            this.lblpendingsatges.Text = "Pending Satges";
            // 
            // txtnumberofstages
            // 
            this.txtnumberofstages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumberofstages.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumberofstages.Location = new System.Drawing.Point(24, 276);
            this.txtnumberofstages.Name = "txtnumberofstages";
            this.txtnumberofstages.Size = new System.Drawing.Size(383, 28);
            this.txtnumberofstages.TabIndex = 30;
            // 
            // lblnumberofstages
            // 
            this.lblnumberofstages.AutoSize = true;
            this.lblnumberofstages.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberofstages.Location = new System.Drawing.Point(20, 241);
            this.lblnumberofstages.Name = "lblnumberofstages";
            this.lblnumberofstages.Size = new System.Drawing.Size(158, 21);
            this.lblnumberofstages.TabIndex = 29;
            this.lblnumberofstages.Text = "Number of Stages";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(24, 121);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(383, 28);
            this.txtId.TabIndex = 28;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(20, 86);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(78, 21);
            this.lblid.TabIndex = 27;
            this.lblid.Text = "Track ID";
            // 
            // txtTaskid
            // 
            this.txtTaskid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskid.Location = new System.Drawing.Point(24, 192);
            this.txtTaskid.Name = "txtTaskid";
            this.txtTaskid.Size = new System.Drawing.Size(383, 28);
            this.txtTaskid.TabIndex = 26;
            // 
            // lbltaskID
            // 
            this.lbltaskID.AutoSize = true;
            this.lbltaskID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskID.Location = new System.Drawing.Point(20, 157);
            this.lbltaskID.Name = "lbltaskID";
            this.lbltaskID.Size = new System.Drawing.Size(69, 21);
            this.lbltaskID.TabIndex = 25;
            this.lbltaskID.Text = "Task ID";
            // 
            // dgvTasklog
            // 
            this.dgvTasklog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasklog.BackgroundColor = System.Drawing.Color.White;
            this.dgvTasklog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasklog.Location = new System.Drawing.Point(451, 427);
            this.dgvTasklog.Name = "dgvTasklog";
            this.dgvTasklog.RowHeadersWidth = 51;
            this.dgvTasklog.RowTemplate.Height = 24;
            this.dgvTasklog.Size = new System.Drawing.Size(641, 302);
            this.dgvTasklog.TabIndex = 24;
            this.dgvTasklog.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTasklog_RowHeaderMouseClick);
            // 
            // dgvTasks
            // 
            this.dgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(451, 64);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.Size = new System.Drawing.Size(641, 302);
            this.dgvTasks.TabIndex = 23;
            this.dgvTasks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTasks_RowHeaderMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(24, 502);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(383, 52);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add the Task";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // lblTAsk
            // 
            this.lblTAsk.AutoSize = true;
            this.lblTAsk.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTAsk.Location = new System.Drawing.Point(104, 30);
            this.lblTAsk.Name = "lblTAsk";
            this.lblTAsk.Size = new System.Drawing.Size(217, 27);
            this.lblTAsk.TabIndex = 37;
            this.lblTAsk.Text = "Daily Task Update";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "Daily Task Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "Daily Task Update Table";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(24, 571);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(383, 52);
            this.btnupdate.TabIndex = 40;
            this.btnupdate.Text = "Update the Task";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // cmbComplete
            // 
            this.cmbComplete.FormattingEnabled = true;
            this.cmbComplete.Items.AddRange(new object[] {
            "All stages are Completed"});
            this.cmbComplete.Location = new System.Drawing.Point(24, 367);
            this.cmbComplete.Name = "cmbComplete";
            this.cmbComplete.Size = new System.Drawing.Size(383, 24);
            this.cmbComplete.TabIndex = 41;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(24, 642);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(383, 52);
            this.btndelete.TabIndex = 42;
            this.btndelete.Text = "Delete the Task";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::LHMS_Application.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(750, 368);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(149, 53);
            this.btnRefresh.TabIndex = 43;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FrmTaskTrackAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 741);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cmbComplete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTAsk);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblcompletesatges);
            this.Controls.Add(this.txtpendingsatges);
            this.Controls.Add(this.lblpendingsatges);
            this.Controls.Add(this.txtnumberofstages);
            this.Controls.Add(this.lblnumberofstages);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txtTaskid);
            this.Controls.Add(this.lbltaskID);
            this.Controls.Add(this.dgvTasklog);
            this.Controls.Add(this.dgvTasks);
            this.Name = "FrmTaskTrackAD";
            this.Text = "FrmTaskTrackAD";
            this.Load += new System.EventHandler(this.FrmTaskTrackAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasklog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblcompletesatges;
        private System.Windows.Forms.TextBox txtpendingsatges;
        private System.Windows.Forms.Label lblpendingsatges;
        private System.Windows.Forms.TextBox txtnumberofstages;
        private System.Windows.Forms.Label lblnumberofstages;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtTaskid;
        private System.Windows.Forms.Label lbltaskID;
        private System.Windows.Forms.DataGridView dgvTasklog;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblTAsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.ComboBox cmbComplete;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnRefresh;
    }
}