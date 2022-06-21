namespace QLHFC.PresentationTier
{
    partial class FormCheckinCheckout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCheckinCheckout = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckinCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheckinCheckout
            // 
            this.dgvCheckinCheckout.AllowUserToAddRows = false;
            this.dgvCheckinCheckout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckinCheckout.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckinCheckout.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCheckinCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckinCheckout.Location = new System.Drawing.Point(12, 12);
            this.dgvCheckinCheckout.Name = "dgvCheckinCheckout";
            this.dgvCheckinCheckout.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCheckinCheckout.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCheckinCheckout.RowTemplate.Height = 29;
            this.dgvCheckinCheckout.Size = new System.Drawing.Size(776, 426);
            this.dgvCheckinCheckout.TabIndex = 3;
            // 
            // FormCheckinCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCheckinCheckout);
            this.Name = "FormCheckinCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheckinCheckout";
            this.Load += new System.EventHandler(this.FormCheckinCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckinCheckout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvCheckinCheckout;
    }
}