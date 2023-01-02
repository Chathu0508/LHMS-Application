namespace LHMS_Application.Froms
{
    partial class FrmproductCode
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
            this.dgvProductcode = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblProdcode = new System.Windows.Forms.Label();
            this.lblprodname = new System.Windows.Forms.Label();
            this.txtprodcode = new System.Windows.Forms.TextBox();
            this.txtprodname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductcode)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductcode
            // 
            this.dgvProductcode.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductcode.Location = new System.Drawing.Point(24, 206);
            this.dgvProductcode.Name = "dgvProductcode";
            this.dgvProductcode.RowHeadersWidth = 51;
            this.dgvProductcode.RowTemplate.Height = 24;
            this.dgvProductcode.Size = new System.Drawing.Size(480, 389);
            this.dgvProductcode.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::LHMS_Application.Properties.Resources.save;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(286, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 52);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImage = global::LHMS_Application.Properties.Resources.add;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(226, 137);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(54, 52);
            this.btnadd.TabIndex = 1;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblProdcode
            // 
            this.lblProdcode.AutoSize = true;
            this.lblProdcode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdcode.Location = new System.Drawing.Point(20, 27);
            this.lblProdcode.Name = "lblProdcode";
            this.lblProdcode.Size = new System.Drawing.Size(129, 21);
            this.lblProdcode.TabIndex = 3;
            this.lblProdcode.Text = "Product Code";
            // 
            // lblprodname
            // 
            this.lblprodname.AutoSize = true;
            this.lblprodname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodname.Location = new System.Drawing.Point(20, 93);
            this.lblprodname.Name = "lblprodname";
            this.lblprodname.Size = new System.Drawing.Size(132, 21);
            this.lblprodname.TabIndex = 4;
            this.lblprodname.Text = "Product Name";
            // 
            // txtprodcode
            // 
            this.txtprodcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprodcode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprodcode.Location = new System.Drawing.Point(175, 25);
            this.txtprodcode.Name = "txtprodcode";
            this.txtprodcode.Size = new System.Drawing.Size(216, 28);
            this.txtprodcode.TabIndex = 5;
            // 
            // txtprodname
            // 
            this.txtprodname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtprodname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprodname.Location = new System.Drawing.Point(175, 93);
            this.txtprodname.Name = "txtprodname";
            this.txtprodname.Size = new System.Drawing.Size(291, 28);
            this.txtprodname.TabIndex = 6;
            // 
            // FrmproductCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 635);
            this.Controls.Add(this.txtprodname);
            this.Controls.Add(this.txtprodcode);
            this.Controls.Add(this.lblprodname);
            this.Controls.Add(this.lblProdcode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvProductcode);
            this.Name = "FrmproductCode";
            this.Text = "FrmproductCode";
            this.Load += new System.EventHandler(this.FrmproductCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductcode;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblProdcode;
        private System.Windows.Forms.Label lblprodname;
        private System.Windows.Forms.TextBox txtprodcode;
        private System.Windows.Forms.TextBox txtprodname;
    }
}