namespace LHMS_Application.Froms
{
    partial class FrmLogTrack
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
            this.dgvlogtrack = new System.Windows.Forms.DataGridView();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogtrack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlogtrack
            // 
            this.dgvlogtrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlogtrack.BackgroundColor = System.Drawing.Color.White;
            this.dgvlogtrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlogtrack.GridColor = System.Drawing.Color.Black;
            this.dgvlogtrack.Location = new System.Drawing.Point(13, 13);
            this.dgvlogtrack.Name = "dgvlogtrack";
            this.dgvlogtrack.RowHeadersWidth = 51;
            this.dgvlogtrack.RowTemplate.Height = 24;
            this.dgvlogtrack.Size = new System.Drawing.Size(1087, 606);
            this.dgvlogtrack.TabIndex = 0;
            // 
            // btnexport
            // 
            this.btnexport.Location = new System.Drawing.Point(839, 643);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(261, 46);
            this.btnexport.TabIndex = 1;
            this.btnexport.Text = "Expot to Excel";
            this.btnexport.UseVisualStyleBackColor = true;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btnimport
            // 
            this.btnimport.Location = new System.Drawing.Point(13, 643);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(261, 46);
            this.btnimport.TabIndex = 2;
            this.btnimport.Text = "Improt to DB";
            this.btnimport.UseVisualStyleBackColor = true;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // FrmLogTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 723);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.dgvlogtrack);
            this.Name = "FrmLogTrack";
            this.Text = "FrmLogTrack";
            this.Load += new System.EventHandler(this.FrmLogTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogtrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlogtrack;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnimport;
    }
}