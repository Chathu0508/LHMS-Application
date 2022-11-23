﻿namespace LHMS_Application.Froms
{
    partial class FrmDealersAndCustomer
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblaname = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDeal_cus = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeal_cus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(34, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(209, 21);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Dealer and customer ID";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(270, 46);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(277, 28);
            this.txtId.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(270, 165);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(277, 28);
            this.txtname.TabIndex = 3;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(34, 108);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(54, 21);
            this.lbltype.TabIndex = 2;
            this.lbltype.Text = "Type ";
            // 
            // lblaname
            // 
            this.lblaname.AutoSize = true;
            this.lblaname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaname.Location = new System.Drawing.Point(34, 167);
            this.lblaname.Name = "lblaname";
            this.lblaname.Size = new System.Drawing.Size(176, 21);
            this.lblaname.TabIndex = 4;
            this.lblaname.Text = "Name of the person";
            // 
            // cmbtype
            // 
            this.cmbtype.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Dealer",
            "Customer"});
            this.cmbtype.Location = new System.Drawing.Point(270, 108);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(219, 29);
            this.cmbtype.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(34, 233);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(124, 21);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email Address";
            // 
            // txtemail
            // 
            this.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(270, 231);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(277, 28);
            this.txtemail.TabIndex = 6;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(34, 307);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(153, 21);
            this.lblContact.TabIndex = 9;
            this.lblContact.Text = "Contact Number";
            // 
            // txtcontact
            // 
            this.txtcontact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcontact.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcontact.Location = new System.Drawing.Point(270, 305);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(277, 28);
            this.txtcontact.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(34, 370);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(219, 21);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Personal or Work Address";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(270, 368);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 120);
            this.textBox1.TabIndex = 10;
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(38, 542);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(238, 42);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add Deatils";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(291, 542);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 42);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Deatils";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(848, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 42);
            this.button1.TabIndex = 14;
            this.button1.Text = "Update Deatils";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvDeal_cus
            // 
            this.dgvDeal_cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeal_cus.Location = new System.Drawing.Point(587, 46);
            this.dgvDeal_cus.Name = "dgvDeal_cus";
            this.dgvDeal_cus.RowHeadersWidth = 51;
            this.dgvDeal_cus.RowTemplate.Height = 24;
            this.dgvDeal_cus.Size = new System.Drawing.Size(434, 366);
            this.dgvDeal_cus.TabIndex = 15;
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(587, 470);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(434, 28);
            this.txtsearch.TabIndex = 17;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(583, 433);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(253, 21);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Search Dealer and customer ";
            // 
            // FrmDealersAndCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 607);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvDeal_cus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.cmbtype);
            this.Controls.Add(this.lblaname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
            this.Name = "FrmDealersAndCustomer";
            this.Text = "FrmDealersAndCustomer";
            this.Load += new System.EventHandler(this.FrmDealersAndCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeal_cus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblaname;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDeal_cus;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblSearch;
    }
}