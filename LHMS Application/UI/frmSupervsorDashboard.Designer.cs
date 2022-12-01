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
            this.pnllogo = new System.Windows.Forms.Panel();
            this.pnltitle = new System.Windows.Forms.Panel();
            this.pnldashboard = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btncloseChildFrom = new System.Windows.Forms.Button();
            this.btntask = new System.Windows.Forms.Button();
            this.pnlmenu.SuspendLayout();
            this.pnltitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.Controls.Add(this.btntask);
            this.pnlmenu.Controls.Add(this.pnllogo);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(220, 679);
            this.pnlmenu.TabIndex = 0;
            // 
            // pnllogo
            // 
            this.pnllogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnllogo.Location = new System.Drawing.Point(0, 0);
            this.pnllogo.Name = "pnllogo";
            this.pnllogo.Size = new System.Drawing.Size(220, 80);
            this.pnllogo.TabIndex = 0;
            // 
            // pnltitle
            // 
            this.pnltitle.Controls.Add(this.btncloseChildFrom);
            this.pnltitle.Controls.Add(this.lbltitle);
            this.pnltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitle.Location = new System.Drawing.Point(220, 0);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(921, 80);
            this.pnltitle.TabIndex = 1;
            // 
            // pnldashboard
            // 
            this.pnldashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldashboard.Location = new System.Drawing.Point(220, 80);
            this.pnldashboard.Name = "pnldashboard";
            this.pnldashboard.Size = new System.Drawing.Size(921, 599);
            this.pnldashboard.TabIndex = 2;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Location = new System.Drawing.Point(449, 28);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(75, 16);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Dashboard";
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
            // 
            // btntask
            // 
            this.btntask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntask.FlatAppearance.BorderSize = 0;
            this.btntask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntask.Location = new System.Drawing.Point(0, 80);
            this.btntask.Name = "btntask";
            this.btntask.Size = new System.Drawing.Size(220, 61);
            this.btntask.TabIndex = 1;
            this.btntask.Text = "Update deatils";
            this.btntask.UseVisualStyleBackColor = true;
            this.btntask.Click += new System.EventHandler(this.btntask_Click);
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
    }
}