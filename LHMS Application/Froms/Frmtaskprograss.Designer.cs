namespace LHMS_Application.Froms
{
    partial class Frmtaskprograss
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
            this.Dgvtaskprogress = new System.Windows.Forms.DataGridView();
            this.lblSerach = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnexport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvtaskprogress)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgvtaskprogress
            // 
            this.Dgvtaskprogress.BackgroundColor = System.Drawing.Color.White;
            this.Dgvtaskprogress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvtaskprogress.Location = new System.Drawing.Point(23, 29);
            this.Dgvtaskprogress.Name = "Dgvtaskprogress";
            this.Dgvtaskprogress.RowHeadersWidth = 51;
            this.Dgvtaskprogress.RowTemplate.Height = 24;
            this.Dgvtaskprogress.Size = new System.Drawing.Size(1096, 477);
            this.Dgvtaskprogress.TabIndex = 0;
            // 
            // lblSerach
            // 
            this.lblSerach.AutoSize = true;
            this.lblSerach.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerach.Location = new System.Drawing.Point(23, 529);
            this.lblSerach.Name = "lblSerach";
            this.lblSerach.Size = new System.Drawing.Size(71, 21);
            this.lblSerach.TabIndex = 1;
            this.lblSerach.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Location = new System.Drawing.Point(23, 566);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1096, 22);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnexport
            // 
            this.btnexport.FlatAppearance.BorderSize = 0;
            this.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.Location = new System.Drawing.Point(904, 627);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(215, 51);
            this.btnexport.TabIndex = 3;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // Frmtaskprograss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1147, 701);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSerach);
            this.Controls.Add(this.Dgvtaskprogress);
            this.Name = "Frmtaskprograss";
            this.Text = "Frmtaskprograss";
            this.Load += new System.EventHandler(this.Frmtaskprograss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvtaskprogress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgvtaskprogress;
        private System.Windows.Forms.Label lblSerach;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnexport;
    }
}