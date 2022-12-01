namespace LHMS_Application.Froms
{
    partial class FrmTaskTrack
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
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.dgvTasklog = new System.Windows.Forms.DataGridView();
            this.lbltaskID = new System.Windows.Forms.Label();
            this.txtTaskid = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtnumberofstages = new System.Windows.Forms.TextBox();
            this.lblnumberofstages = new System.Windows.Forms.Label();
            this.txtpendingsatges = new System.Windows.Forms.TextBox();
            this.lblpendingsatges = new System.Windows.Forms.Label();
            this.txtcompletesatges = new System.Windows.Forms.TextBox();
            this.lblcompletesatges = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasklog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTasks
            // 
            this.dgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(484, 12);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.Size = new System.Drawing.Size(444, 302);
            this.dgvTasks.TabIndex = 0;
            this.dgvTasks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTasks_RowHeaderMouseClick);
            // 
            // dgvTasklog
            // 
            this.dgvTasklog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasklog.BackgroundColor = System.Drawing.Color.White;
            this.dgvTasklog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasklog.Location = new System.Drawing.Point(484, 323);
            this.dgvTasklog.Name = "dgvTasklog";
            this.dgvTasklog.RowHeadersWidth = 51;
            this.dgvTasklog.RowTemplate.Height = 24;
            this.dgvTasklog.Size = new System.Drawing.Size(444, 302);
            this.dgvTasklog.TabIndex = 11;
            this.dgvTasklog.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTasklog_RowHeaderMouseClick);
            // 
            // lbltaskID
            // 
            this.lbltaskID.AutoSize = true;
            this.lbltaskID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskID.Location = new System.Drawing.Point(39, 99);
            this.lbltaskID.Name = "lbltaskID";
            this.lbltaskID.Size = new System.Drawing.Size(69, 21);
            this.lbltaskID.TabIndex = 12;
            this.lbltaskID.Text = "Task ID";
            // 
            // txtTaskid
            // 
            this.txtTaskid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaskid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskid.Location = new System.Drawing.Point(43, 134);
            this.txtTaskid.Name = "txtTaskid";
            this.txtTaskid.Size = new System.Drawing.Size(383, 28);
            this.txtTaskid.TabIndex = 13;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(43, 63);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(383, 28);
            this.txtId.TabIndex = 15;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(39, 28);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(78, 21);
            this.lblid.TabIndex = 14;
            this.lblid.Text = "Track ID";
            // 
            // txtnumberofstages
            // 
            this.txtnumberofstages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumberofstages.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumberofstages.Location = new System.Drawing.Point(43, 218);
            this.txtnumberofstages.Name = "txtnumberofstages";
            this.txtnumberofstages.Size = new System.Drawing.Size(383, 28);
            this.txtnumberofstages.TabIndex = 17;
            // 
            // lblnumberofstages
            // 
            this.lblnumberofstages.AutoSize = true;
            this.lblnumberofstages.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumberofstages.Location = new System.Drawing.Point(39, 183);
            this.lblnumberofstages.Name = "lblnumberofstages";
            this.lblnumberofstages.Size = new System.Drawing.Size(158, 21);
            this.lblnumberofstages.TabIndex = 16;
            this.lblnumberofstages.Text = "Number of Stages";
            // 
            // txtpendingsatges
            // 
            this.txtpendingsatges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpendingsatges.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpendingsatges.Location = new System.Drawing.Point(43, 381);
            this.txtpendingsatges.Name = "txtpendingsatges";
            this.txtpendingsatges.Size = new System.Drawing.Size(383, 28);
            this.txtpendingsatges.TabIndex = 19;
            // 
            // lblpendingsatges
            // 
            this.lblpendingsatges.AutoSize = true;
            this.lblpendingsatges.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpendingsatges.Location = new System.Drawing.Point(39, 346);
            this.lblpendingsatges.Name = "lblpendingsatges";
            this.lblpendingsatges.Size = new System.Drawing.Size(138, 21);
            this.lblpendingsatges.TabIndex = 18;
            this.lblpendingsatges.Text = "Pending Satges";
            // 
            // txtcompletesatges
            // 
            this.txtcompletesatges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcompletesatges.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompletesatges.Location = new System.Drawing.Point(43, 297);
            this.txtcompletesatges.Name = "txtcompletesatges";
            this.txtcompletesatges.Size = new System.Drawing.Size(383, 28);
            this.txtcompletesatges.TabIndex = 21;
            // 
            // lblcompletesatges
            // 
            this.lblcompletesatges.AutoSize = true;
            this.lblcompletesatges.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompletesatges.Location = new System.Drawing.Point(39, 262);
            this.lblcompletesatges.Name = "lblcompletesatges";
            this.lblcompletesatges.Size = new System.Drawing.Size(155, 21);
            this.lblcompletesatges.TabIndex = 20;
            this.lblcompletesatges.Text = "Complete Satges";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(43, 442);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(383, 52);
            this.btnadd.TabIndex = 22;
            this.btnadd.Text = "Add Tarck";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(43, 500);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(383, 52);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Update Tarck";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(43, 558);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(383, 52);
            this.btndelete.TabIndex = 24;
            this.btndelete.Text = "Delete Tarck";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // FrmTaskTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 633);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtcompletesatges);
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
            this.Name = "FrmTaskTrack";
            this.Text = "FrmTaskTrack";
            this.Load += new System.EventHandler(this.FrmTaskTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasklog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridView dgvTasklog;
        private System.Windows.Forms.Label lbltaskID;
        private System.Windows.Forms.TextBox txtTaskid;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtnumberofstages;
        private System.Windows.Forms.Label lblnumberofstages;
        private System.Windows.Forms.TextBox txtpendingsatges;
        private System.Windows.Forms.Label lblpendingsatges;
        private System.Windows.Forms.TextBox txtcompletesatges;
        private System.Windows.Forms.Label lblcompletesatges;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
    }
}