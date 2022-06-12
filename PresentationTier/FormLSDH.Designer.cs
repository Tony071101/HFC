namespace QLHFC.PresentationTier
{
    partial class FormLSDH
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
            this.dgvLSDH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSDH)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLSDH
            // 
            this.dgvLSDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLSDH.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLSDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLSDH.Location = new System.Drawing.Point(12, 12);
            this.dgvLSDH.Name = "dgvLSDH";
            this.dgvLSDH.RowHeadersWidth = 51;
            this.dgvLSDH.RowTemplate.Height = 29;
            this.dgvLSDH.Size = new System.Drawing.Size(776, 426);
            this.dgvLSDH.TabIndex = 0;
            // 
            // FormLSDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLSDH);
            this.Name = "FormLSDH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử đặt hàng";
            this.Load += new System.EventHandler(this.FormLSDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLSDH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvLSDH;
    }
}