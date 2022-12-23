namespace LHMS_Application.Froms
{
    partial class FrmtaskAD
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
            this.btnAddtask = new System.Windows.Forms.Button();
            this.cmbDevepartment = new System.Windows.Forms.ComboBox();
            this.cmbFactory = new System.Windows.Forms.ComboBox();
            this.lblFactory = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDapertment = new System.Windows.Forms.Label();
            this.lbldiscription = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvtask = new System.Windows.Forms.DataGridView();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtask)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddtask
            // 
            this.btnAddtask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddtask.FlatAppearance.BorderSize = 0;
            this.btnAddtask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtask.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtask.ForeColor = System.Drawing.Color.White;
            this.btnAddtask.Location = new System.Drawing.Point(32, 327);
            this.btnAddtask.Name = "btnAddtask";
            this.btnAddtask.Size = new System.Drawing.Size(450, 44);
            this.btnAddtask.TabIndex = 43;
            this.btnAddtask.Text = "Add Task ";
            this.btnAddtask.UseVisualStyleBackColor = false;
            this.btnAddtask.Click += new System.EventHandler(this.btnAddtask_Click);
            // 
            // cmbDevepartment
            // 
            this.cmbDevepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDevepartment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDevepartment.FormattingEnabled = true;
            this.cmbDevepartment.Items.AddRange(new object[] {
            "Sales & Marketing ",
            "Purchasing ",
            "Finance",
            "IT ",
            "HR",
            "R&D ",
            "Engineering Design ",
            "Engineering",
            "Factory Management"});
            this.cmbDevepartment.Location = new System.Drawing.Point(207, 258);
            this.cmbDevepartment.Name = "cmbDevepartment";
            this.cmbDevepartment.Size = new System.Drawing.Size(275, 29);
            this.cmbDevepartment.TabIndex = 42;
            // 
            // cmbFactory
            // 
            this.cmbFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFactory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFactory.FormattingEnabled = true;
            this.cmbFactory.Items.AddRange(new object[] {
            "Fac 01",
            "Fac 02",
            "Fac 03"});
            this.cmbFactory.Location = new System.Drawing.Point(207, 194);
            this.cmbFactory.Name = "cmbFactory";
            this.cmbFactory.Size = new System.Drawing.Size(275, 29);
            this.cmbFactory.TabIndex = 41;
            // 
            // lblFactory
            // 
            this.lblFactory.AutoSize = true;
            this.lblFactory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactory.Location = new System.Drawing.Point(29, 197);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.Size = new System.Drawing.Size(72, 21);
            this.lblFactory.TabIndex = 40;
            this.lblFactory.Text = "Factory";
            // 
            // txtDiscription
            // 
            this.txtDiscription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscription.Location = new System.Drawing.Point(207, 135);
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(275, 21);
            this.txtDiscription.TabIndex = 39;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(207, 82);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(275, 21);
            this.txtTitle.TabIndex = 38;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(207, 21);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(275, 21);
            this.txtID.TabIndex = 37;
            // 
            // lblDapertment
            // 
            this.lblDapertment.AutoSize = true;
            this.lblDapertment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapertment.Location = new System.Drawing.Point(29, 261);
            this.lblDapertment.Name = "lblDapertment";
            this.lblDapertment.Size = new System.Drawing.Size(113, 21);
            this.lblDapertment.TabIndex = 36;
            this.lblDapertment.Text = "Department";
            // 
            // lbldiscription
            // 
            this.lbldiscription.AutoSize = true;
            this.lbldiscription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscription.Location = new System.Drawing.Point(29, 135);
            this.lbldiscription.Name = "lbldiscription";
            this.lbldiscription.Size = new System.Drawing.Size(95, 21);
            this.lbldiscription.TabIndex = 35;
            this.lbldiscription.Text = "Discription";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(28, 82);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(136, 21);
            this.lbltitle.TabIndex = 34;
            this.lbltitle.Text = "Title of the task";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(29, 21);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(69, 21);
            this.lblid.TabIndex = 33;
            this.lblid.Text = "Task ID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(32, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(449, 48);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "Deleta Task ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvtask
            // 
            this.dgvtask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtask.BackgroundColor = System.Drawing.Color.White;
            this.dgvtask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtask.Location = new System.Drawing.Point(512, 21);
            this.dgvtask.Name = "dgvtask";
            this.dgvtask.RowHeadersWidth = 51;
            this.dgvtask.RowTemplate.Height = 24;
            this.dgvtask.Size = new System.Drawing.Size(611, 636);
            this.dgvtask.TabIndex = 45;
            this.dgvtask.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvtask_RowHeaderMouseClick);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(32, 390);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(449, 48);
            this.btnupdate.TabIndex = 46;
            this.btnupdate.Text = "Update Task ";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // FrmtaskAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 698);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgvtask);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddtask);
            this.Controls.Add(this.cmbDevepartment);
            this.Controls.Add(this.cmbFactory);
            this.Controls.Add(this.lblFactory);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblDapertment);
            this.Controls.Add(this.lbldiscription);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.lblid);
            this.Name = "FrmtaskAD";
            this.Text = "FrmtaskAD";
            this.Load += new System.EventHandler(this.FrmtaskAD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddtask;
        private System.Windows.Forms.ComboBox cmbDevepartment;
        private System.Windows.Forms.ComboBox cmbFactory;
        private System.Windows.Forms.Label lblFactory;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDapertment;
        private System.Windows.Forms.Label lbldiscription;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvtask;
        private System.Windows.Forms.Button btnupdate;
    }
}