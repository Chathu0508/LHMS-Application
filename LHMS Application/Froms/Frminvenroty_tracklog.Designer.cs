namespace LHMS_Application.Froms
{
    partial class Frminvenroty_tracklog
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
            this.dgvCatorgry = new System.Windows.Forms.DataGridView();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.lblinv = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtcategoryid = new System.Windows.Forms.TextBox();
            this.lblceto = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.lblproduct = new System.Windows.Forms.Label();
            this.txttotinv = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtasswqty = new System.Windows.Forms.TextBox();
            this.lblAssignqty = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtleftover = new System.Windows.Forms.TextBox();
            this.lblLeftover = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatorgry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCatorgry
            // 
            this.dgvCatorgry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatorgry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatorgry.Location = new System.Drawing.Point(510, 12);
            this.dgvCatorgry.Name = "dgvCatorgry";
            this.dgvCatorgry.RowHeadersWidth = 51;
            this.dgvCatorgry.RowTemplate.Height = 24;
            this.dgvCatorgry.Size = new System.Drawing.Size(760, 244);
            this.dgvCatorgry.TabIndex = 0;
            this.dgvCatorgry.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCatorgry_RowHeaderMouseClick);
            // 
            // dgvproduct
            // 
            this.dgvproduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(510, 262);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.RowHeadersWidth = 51;
            this.dgvproduct.RowTemplate.Height = 24;
            this.dgvproduct.Size = new System.Drawing.Size(760, 244);
            this.dgvproduct.TabIndex = 1;
            this.dgvproduct.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvproduct_RowHeaderMouseDoubleClick);
            // 
            // dgvInventory
            // 
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(510, 512);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(760, 244);
            this.dgvInventory.TabIndex = 2;
            // 
            // lblinv
            // 
            this.lblinv.AutoSize = true;
            this.lblinv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinv.Location = new System.Drawing.Point(105, 46);
            this.lblinv.Name = "lblinv";
            this.lblinv.Size = new System.Drawing.Size(184, 21);
            this.lblinv.TabIndex = 3;
            this.lblinv.Text = "Inventory Qty Deatils";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(26, 95);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(111, 21);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "Inventory ID";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(30, 130);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(396, 28);
            this.txtID.TabIndex = 5;
            // 
            // txtcategoryid
            // 
            this.txtcategoryid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcategoryid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoryid.Location = new System.Drawing.Point(30, 206);
            this.txtcategoryid.Name = "txtcategoryid";
            this.txtcategoryid.Size = new System.Drawing.Size(396, 28);
            this.txtcategoryid.TabIndex = 7;
            // 
            // lblceto
            // 
            this.lblceto.AutoSize = true;
            this.lblceto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblceto.Location = new System.Drawing.Point(26, 171);
            this.lblceto.Name = "lblceto";
            this.lblceto.Size = new System.Drawing.Size(112, 21);
            this.lblceto.TabIndex = 6;
            this.lblceto.Text = "Category ID";
            // 
            // txtproductid
            // 
            this.txtproductid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproductid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductid.Location = new System.Drawing.Point(30, 296);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(396, 28);
            this.txtproductid.TabIndex = 9;
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduct.Location = new System.Drawing.Point(26, 261);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(99, 21);
            this.lblproduct.TabIndex = 8;
            this.lblproduct.Text = "Product ID";
            // 
            // txttotinv
            // 
            this.txttotinv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotinv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotinv.Location = new System.Drawing.Point(30, 460);
            this.txttotinv.Name = "txttotinv";
            this.txttotinv.Size = new System.Drawing.Size(396, 28);
            this.txttotinv.TabIndex = 11;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(120, 423);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(169, 21);
            this.lbltotal.TabIndex = 10;
            this.lbltotal.Text = "Total Inventory Qty";
            // 
            // txtasswqty
            // 
            this.txtasswqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtasswqty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtasswqty.Location = new System.Drawing.Point(30, 544);
            this.txtasswqty.Name = "txtasswqty";
            this.txtasswqty.Size = new System.Drawing.Size(396, 28);
            this.txtasswqty.TabIndex = 13;
            // 
            // lblAssignqty
            // 
            this.lblAssignqty.AutoSize = true;
            this.lblAssignqty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignqty.Location = new System.Drawing.Point(135, 508);
            this.lblAssignqty.Name = "lblAssignqty";
            this.lblAssignqty.Size = new System.Drawing.Size(139, 21);
            this.lblAssignqty.TabIndex = 12;
            this.lblAssignqty.Text = "Assign Qty daliy";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(105, 371);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(194, 21);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "Inventory Qty Amount";
            // 
            // txtleftover
            // 
            this.txtleftover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtleftover.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtleftover.Location = new System.Drawing.Point(30, 629);
            this.txtleftover.Name = "txtleftover";
            this.txtleftover.Size = new System.Drawing.Size(396, 28);
            this.txtleftover.TabIndex = 16;
            // 
            // lblLeftover
            // 
            this.lblLeftover.AutoSize = true;
            this.lblLeftover.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeftover.Location = new System.Drawing.Point(135, 593);
            this.lblLeftover.Name = "lblLeftover";
            this.lblLeftover.Size = new System.Drawing.Size(157, 21);
            this.lblLeftover.TabIndex = 15;
            this.lblLeftover.Text = "Leftover Qty daliy";
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(30, 693);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(396, 40);
            this.btnadd.TabIndex = 17;
            this.btnadd.Text = "Add Details";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Frminvenroty_tracklog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 764);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtleftover);
            this.Controls.Add(this.lblLeftover);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtasswqty);
            this.Controls.Add(this.lblAssignqty);
            this.Controls.Add(this.txttotinv);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.lblproduct);
            this.Controls.Add(this.txtcategoryid);
            this.Controls.Add(this.lblceto);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblinv);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.dgvproduct);
            this.Controls.Add(this.dgvCatorgry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frminvenroty_tracklog";
            this.Text = "invenroty_tracklog";
            this.Load += new System.EventHandler(this.Frminvenroty_tracklog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatorgry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCatorgry;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label lblinv;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtcategoryid;
        private System.Windows.Forms.Label lblceto;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label lblproduct;
        private System.Windows.Forms.TextBox txttotinv;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtasswqty;
        private System.Windows.Forms.Label lblAssignqty;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtleftover;
        private System.Windows.Forms.Label lblLeftover;
        private System.Windows.Forms.Button btnadd;
    }
}