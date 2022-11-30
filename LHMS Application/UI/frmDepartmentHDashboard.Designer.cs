namespace LHMS_Application.UI
{
    partial class frmDepartmentHDashboard
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
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanal = new System.Windows.Forms.Panel();
            this.btntask = new System.Windows.Forms.Button();
            this.btncloseChildFrom = new System.Windows.Forms.Button();
            this.pnlmenu.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.Controls.Add(this.btntask);
            this.pnlmenu.Controls.Add(this.pnllogo);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(220, 635);
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
            // pnlTitleBar
            // 
            this.pnlTitleBar.Controls.Add(this.btncloseChildFrom);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(220, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(972, 80);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(410, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(44, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // panelDesktopPanal
            // 
            this.panelDesktopPanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanal.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanal.Name = "panelDesktopPanal";
            this.panelDesktopPanal.Size = new System.Drawing.Size(972, 555);
            this.panelDesktopPanal.TabIndex = 2;
            // 
            // btntask
            // 
            this.btntask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntask.FlatAppearance.BorderSize = 0;
            this.btntask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntask.Location = new System.Drawing.Point(0, 80);
            this.btntask.Name = "btntask";
            this.btntask.Size = new System.Drawing.Size(220, 65);
            this.btntask.TabIndex = 1;
            this.btntask.Text = "Task";
            this.btntask.UseVisualStyleBackColor = true;
            this.btntask.Click += new System.EventHandler(this.btntask_Click);
            // 
            // btncloseChildFrom
            // 
            this.btncloseChildFrom.Location = new System.Drawing.Point(6, 12);
            this.btncloseChildFrom.Name = "btncloseChildFrom";
            this.btncloseChildFrom.Size = new System.Drawing.Size(75, 62);
            this.btncloseChildFrom.TabIndex = 1;
            this.btncloseChildFrom.Text = "button1";
            this.btncloseChildFrom.UseVisualStyleBackColor = true;
            // 
            // frmDepartmentHDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 635);
            this.Controls.Add(this.panelDesktopPanal);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlmenu);
            this.Name = "frmDepartmentHDashboard";
            this.Text = "frmDepartmentHDashboard";
            this.pnlmenu.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Panel pnllogo;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPanal;
        private System.Windows.Forms.Button btntask;
        private System.Windows.Forms.Button btncloseChildFrom;
    }
}