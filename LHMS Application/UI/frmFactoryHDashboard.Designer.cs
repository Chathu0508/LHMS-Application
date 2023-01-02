namespace LHMS_Application.UI
{
    partial class frmFactoryHDashboard
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
            this.btnlogout = new System.Windows.Forms.Button();
            this.btntacktrack = new System.Windows.Forms.Button();
            this.btnlogtrack = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.pnllogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btncloseChildFrom = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelDesktopPanal = new System.Windows.Forms.Panel();
            this.pnlmenu.SuspendLayout();
            this.pnllogo.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlmenu.Controls.Add(this.btnlogout);
            this.pnlmenu.Controls.Add(this.btntacktrack);
            this.pnlmenu.Controls.Add(this.btnlogtrack);
            this.pnlmenu.Controls.Add(this.btnUser);
            this.pnlmenu.Controls.Add(this.pnllogo);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(220, 573);
            this.pnlmenu.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Image = global::LHMS_Application.Properties.Resources.people;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(0, 513);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(220, 60);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = " - Logout";
            this.btnlogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btntacktrack
            // 
            this.btntacktrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntacktrack.FlatAppearance.BorderSize = 0;
            this.btntacktrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntacktrack.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntacktrack.ForeColor = System.Drawing.Color.White;
            this.btntacktrack.Image = global::LHMS_Application.Properties.Resources.people;
            this.btntacktrack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntacktrack.Location = new System.Drawing.Point(0, 200);
            this.btntacktrack.Name = "btntacktrack";
            this.btntacktrack.Size = new System.Drawing.Size(220, 60);
            this.btntacktrack.TabIndex = 3;
            this.btntacktrack.Text = " - Task Update check";
            this.btntacktrack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntacktrack.UseVisualStyleBackColor = true;
            this.btntacktrack.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlogtrack
            // 
            this.btnlogtrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnlogtrack.FlatAppearance.BorderSize = 0;
            this.btnlogtrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogtrack.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogtrack.ForeColor = System.Drawing.Color.White;
            this.btnlogtrack.Image = global::LHMS_Application.Properties.Resources.task;
            this.btnlogtrack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogtrack.Location = new System.Drawing.Point(0, 140);
            this.btnlogtrack.Name = "btnlogtrack";
            this.btnlogtrack.Size = new System.Drawing.Size(220, 60);
            this.btnlogtrack.TabIndex = 2;
            this.btnlogtrack.Text = " - log track";
            this.btnlogtrack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlogtrack.UseVisualStyleBackColor = true;
            this.btnlogtrack.Click += new System.EventHandler(this.btnlogtrack_Click);
            // 
            // btnUser
            // 
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::LHMS_Application.Properties.Resources.people;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(0, 80);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(220, 60);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = " - User Create";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // pnllogo
            // 
            this.pnllogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(56)))));
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
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "LockHood (Pvt) Ltd.";
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(149)))));
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btncloseChildFrom);
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(862, 80);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(748, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(90, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dashboard";
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(784, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btncloseChildFrom
            // 
            this.btncloseChildFrom.Dock = System.Windows.Forms.DockStyle.Left;
            this.btncloseChildFrom.FlatAppearance.BorderSize = 0;
            this.btncloseChildFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncloseChildFrom.Image = global::LHMS_Application.Properties.Resources.close__1_;
            this.btncloseChildFrom.Location = new System.Drawing.Point(0, 0);
            this.btncloseChildFrom.Name = "btncloseChildFrom";
            this.btncloseChildFrom.Size = new System.Drawing.Size(75, 80);
            this.btncloseChildFrom.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(820, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktopPanal
            // 
            this.panelDesktopPanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanal.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanal.Name = "panelDesktopPanal";
            this.panelDesktopPanal.Size = new System.Drawing.Size(862, 493);
            this.panelDesktopPanal.TabIndex = 2;
            // 
            // frmFactoryHDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 573);
            this.Controls.Add(this.panelDesktopPanal);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlmenu);
            this.Name = "frmFactoryHDashboard";
            this.Text = "frmFactoryHDashboard";
            this.pnlmenu.ResumeLayout(false);
            this.pnllogo.ResumeLayout(false);
            this.pnllogo.PerformLayout();
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Panel pnllogo;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Button btncloseChildFrom;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btntacktrack;
        private System.Windows.Forms.Button btnlogtrack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPanal;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}