namespace LHMS_Application.Forms
{
    partial class FrmSalesnMarketing
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btndel_cus = new System.Windows.Forms.Button();
            this.panelDesktopPanal = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(86)))));
            this.pnlMenu.Controls.Add(this.btnSales);
            this.pnlMenu.Controls.Add(this.btnPurchase);
            this.pnlMenu.Controls.Add(this.btndel_cus);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 657);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSales
            // 
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Image = global::LHMS_Application.Properties.Resources.percent;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 150);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(220, 75);
            this.btnSales.TabIndex = 3;
            this.btnSales.Text = "Sales Forms";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = global::LHMS_Application.Properties.Resources.purchase;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(0, 75);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(220, 75);
            this.btnPurchase.TabIndex = 2;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btndel_cus
            // 
            this.btndel_cus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndel_cus.FlatAppearance.BorderSize = 0;
            this.btndel_cus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel_cus.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel_cus.ForeColor = System.Drawing.Color.White;
            this.btndel_cus.Image = global::LHMS_Application.Properties.Resources.people__1_;
            this.btndel_cus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndel_cus.Location = new System.Drawing.Point(0, 0);
            this.btndel_cus.Name = "btndel_cus";
            this.btndel_cus.Size = new System.Drawing.Size(220, 75);
            this.btndel_cus.TabIndex = 1;
            this.btndel_cus.Text = "Dealer _Customer";
            this.btndel_cus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndel_cus.UseVisualStyleBackColor = true;
            this.btndel_cus.Click += new System.EventHandler(this.btndel_cus_Click);
            // 
            // panelDesktopPanal
            // 
            this.panelDesktopPanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanal.Location = new System.Drawing.Point(220, 0);
            this.panelDesktopPanal.Name = "panelDesktopPanal";
            this.panelDesktopPanal.Size = new System.Drawing.Size(850, 657);
            this.panelDesktopPanal.TabIndex = 1;
            // 
            // FrmSalesnMarketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 657);
            this.Controls.Add(this.panelDesktopPanal);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSalesnMarketing";
            this.Text = "Sales and Marketing";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btndel_cus;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Panel panelDesktopPanal;
    }
}