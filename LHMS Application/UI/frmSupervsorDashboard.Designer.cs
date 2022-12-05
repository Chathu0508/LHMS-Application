namespace LHMS_Application.UI
{
    partial class frmSupervsorDashboard
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
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btntask = new System.Windows.Forms.Button();
            this.pnllogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnltitle = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btncloseChildFrom = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pnldashboard = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlmenu.SuspendLayout();
            this.pnllogo.SuspendLayout();
            this.pnltitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlmenu.Controls.Add(this.btnLogout);
            this.pnlmenu.Controls.Add(this.btnInventory);
            this.pnlmenu.Controls.Add(this.btntask);
            this.pnlmenu.Controls.Add(this.pnllogo);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(220, 679);
            this.pnlmenu.TabIndex = 0;
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Location = new System.Drawing.Point(0, 141);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(220, 61);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory Qty deatils";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btntask
            // 
            this.btntask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntask.FlatAppearance.BorderSize = 0;
            this.btntask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntask.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntask.ForeColor = System.Drawing.Color.White;
            this.btntask.Location = new System.Drawing.Point(0, 80);
            this.btntask.Name = "btntask";
            this.btntask.Size = new System.Drawing.Size(220, 61);
            this.btntask.TabIndex = 1;
            this.btntask.Text = "Update deatils";
            this.btntask.UseVisualStyleBackColor = true;
            this.btntask.Click += new System.EventHandler(this.btntask_Click);
            // 
            // pnllogo
            // 
            this.pnllogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnllogo.Controls.Add(this.label1);
            this.pnllogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnllogo.Location = new System.Drawing.Point(0, 0);
            this.pnllogo.Name = "pnllogo";
            this.pnllogo.Size = new System.Drawing.Size(220, 80);
            this.pnllogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "LockHood (Pvt) Ltd.";
            // 
            // pnltitle
            // 
            this.pnltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(149)))));
            this.pnltitle.Controls.Add(this.btnMinimize);
            this.pnltitle.Controls.Add(this.btnMaximize);
            this.pnltitle.Controls.Add(this.btncloseChildFrom);
            this.pnltitle.Controls.Add(this.btnClose);
            this.pnltitle.Controls.Add(this.lbltitle);
            this.pnltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitle.Location = new System.Drawing.Point(220, 0);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(921, 80);
            this.pnltitle.TabIndex = 1;
            this.pnltitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltitle_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(805, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(841, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 12;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btncloseChildFrom
            // 
            this.btncloseChildFrom.FlatAppearance.BorderSize = 0;
            this.btncloseChildFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncloseChildFrom.Image = global::LHMS_Application.Properties.Resources.close__1_;
            this.btncloseChildFrom.Location = new System.Drawing.Point(7, 3);
            this.btncloseChildFrom.Name = "btncloseChildFrom";
            this.btncloseChildFrom.Size = new System.Drawing.Size(75, 71);
            this.btncloseChildFrom.TabIndex = 1;
            this.btncloseChildFrom.UseVisualStyleBackColor = true;
            this.btncloseChildFrom.Click += new System.EventHandler(this.btncloseChildFrom_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(877, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(339, 15);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(166, 34);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Dashboard";
            // 
            // pnldashboard
            // 
            this.pnldashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldashboard.Location = new System.Drawing.Point(220, 80);
            this.pnldashboard.Name = "pnldashboard";
            this.pnldashboard.Size = new System.Drawing.Size(921, 599);
            this.pnldashboard.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 618);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(220, 61);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmSupervsorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 679);
            this.Controls.Add(this.pnldashboard);
            this.Controls.Add(this.pnltitle);
            this.Controls.Add(this.pnlmenu);
            this.Name = "frmSupervsorDashboard";
            this.Text = "frmSupervsorDashboard";
            this.pnlmenu.ResumeLayout(false);
            this.pnllogo.ResumeLayout(false);
            this.pnllogo.PerformLayout();
            this.pnltitle.ResumeLayout(false);
            this.pnltitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Panel pnllogo;
        private System.Windows.Forms.Panel pnltitle;
        private System.Windows.Forms.Panel pnldashboard;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btntask;
        private System.Windows.Forms.Button btncloseChildFrom;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}