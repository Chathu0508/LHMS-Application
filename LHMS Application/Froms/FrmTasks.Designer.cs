namespace LHMS_Application.Forms
{
    partial class FrmTasks
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
            this.lblid = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbldiscription = new System.Windows.Forms.Label();
            this.lblDapertment = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.lblFactory = new System.Windows.Forms.Label();
            this.cmbFactory = new System.Windows.Forms.ComboBox();
            this.cmbDevepartment = new System.Windows.Forms.ComboBox();
            this.btnAddtask = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvtasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtasks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(40, 69);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(54, 16);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Task ID";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(40, 127);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(96, 16);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Title of the task";
            // 
            // lbldiscription
            // 
            this.lbldiscription.AutoSize = true;
            this.lbldiscription.Location = new System.Drawing.Point(40, 180);
            this.lbldiscription.Name = "lbldiscription";
            this.lbldiscription.Size = new System.Drawing.Size(70, 16);
            this.lbldiscription.TabIndex = 2;
            this.lbldiscription.Text = "Discription";
            // 
            // lblDapertment
            // 
            this.lblDapertment.AutoSize = true;
            this.lblDapertment.Location = new System.Drawing.Point(40, 301);
            this.lblDapertment.Name = "lblDapertment";
            this.lblDapertment.Size = new System.Drawing.Size(77, 16);
            this.lblDapertment.TabIndex = 3;
            this.lblDapertment.Text = "Department";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Location = new System.Drawing.Point(156, 66);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(275, 15);
            this.txtID.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Location = new System.Drawing.Point(156, 127);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(275, 15);
            this.txtTitle.TabIndex = 5;
            // 
            // txtDiscription
            // 
            this.txtDiscription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiscription.Location = new System.Drawing.Point(156, 177);
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(275, 15);
            this.txtDiscription.TabIndex = 6;
            // 
            // lblFactory
            // 
            this.lblFactory.AutoSize = true;
            this.lblFactory.Location = new System.Drawing.Point(40, 242);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.Size = new System.Drawing.Size(52, 16);
            this.lblFactory.TabIndex = 7;
            this.lblFactory.Text = "Factory";
            // 
            // cmbFactory
            // 
            this.cmbFactory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFactory.FormattingEnabled = true;
            this.cmbFactory.Items.AddRange(new object[] {
            "Fac 01",
            "Fac 02",
            "Fac 03"});
            this.cmbFactory.Location = new System.Drawing.Point(156, 238);
            this.cmbFactory.Name = "cmbFactory";
            this.cmbFactory.Size = new System.Drawing.Size(275, 25);
            this.cmbFactory.TabIndex = 28;
            // 
            // cmbDevepartment
            // 
            this.cmbDevepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbDevepartment.Location = new System.Drawing.Point(156, 297);
            this.cmbDevepartment.Name = "cmbDevepartment";
            this.cmbDevepartment.Size = new System.Drawing.Size(275, 25);
            this.cmbDevepartment.TabIndex = 29;
            // 
            // btnAddtask
            // 
            this.btnAddtask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnAddtask.FlatAppearance.BorderSize = 0;
            this.btnAddtask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtask.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtask.ForeColor = System.Drawing.Color.White;
            this.btnAddtask.Location = new System.Drawing.Point(43, 353);
            this.btnAddtask.Name = "btnAddtask";
            this.btnAddtask.Size = new System.Drawing.Size(388, 44);
            this.btnAddtask.TabIndex = 30;
            this.btnAddtask.Text = "Add Task ";
            this.btnAddtask.UseVisualStyleBackColor = false;
            this.btnAddtask.Click += new System.EventHandler(this.btnAddtask_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(43, 416);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(388, 34);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "Deleta Task ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvtasks
            // 
            this.dgvtasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtasks.Location = new System.Drawing.Point(460, 66);
            this.dgvtasks.Name = "dgvtasks";
            this.dgvtasks.RowHeadersWidth = 51;
            this.dgvtasks.RowTemplate.Height = 24;
            this.dgvtasks.Size = new System.Drawing.Size(638, 384);
            this.dgvtasks.TabIndex = 32;
            // 
            // FrmTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 478);
            this.Controls.Add(this.dgvtasks);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTasks";
            this.Text = "Tasks Details";
            ((System.ComponentModel.ISupportInitialize)(this.dgvtasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbldiscription;
        private System.Windows.Forms.Label lblDapertment;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label lblFactory;
        private System.Windows.Forms.ComboBox cmbFactory;
        private System.Windows.Forms.ComboBox cmbDevepartment;
        private System.Windows.Forms.Button btnAddtask;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvtasks;
    }
}