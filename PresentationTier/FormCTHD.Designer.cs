namespace QLHFC.PresentationTier
{
    partial class FormCTHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCTHD));
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTD = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelCTHD = new System.Windows.Forms.Button();
            this.btnAddCTHD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_HD = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(-1, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "TÊN MÓN ĂN:";
            // 
            // cmbTD
            // 
            this.cmbTD.BackColor = System.Drawing.Color.Turquoise;
            this.cmbTD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTD.FormattingEnabled = true;
            this.cmbTD.Location = new System.Drawing.Point(151, 48);
            this.cmbTD.Name = "cmbTD";
            this.cmbTD.Size = new System.Drawing.Size(286, 36);
            this.cmbTD.TabIndex = 28;
            this.cmbTD.SelectedIndexChanged += new System.EventHandler(this.cmbTD_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(474, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "SL:";
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.Turquoise;
            this.txtSL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSL.Location = new System.Drawing.Point(529, 5);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(69, 34);
            this.txtSL.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(398, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "TỔNG TIỀN:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Turquoise;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(529, 107);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(250, 34);
            this.txtTotal.TabIndex = 32;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(11, 159);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCTHD.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHD.RowTemplate.Height = 29;
            this.dgvCTHD.Size = new System.Drawing.Size(776, 475);
            this.dgvCTHD.TabIndex = 33;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(465, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(-171, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 28);
            this.label7.TabIndex = 41;
            this.label7.Text = "ID:";
            // 
            // btnDelCTHD
            // 
            this.btnDelCTHD.BackColor = System.Drawing.Color.Cyan;
            this.btnDelCTHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelCTHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelCTHD.Location = new System.Drawing.Point(123, 100);
            this.btnDelCTHD.Name = "btnDelCTHD";
            this.btnDelCTHD.Size = new System.Drawing.Size(101, 53);
            this.btnDelCTHD.TabIndex = 39;
            this.btnDelCTHD.Text = "Xóa";
            this.btnDelCTHD.UseVisualStyleBackColor = false;
            this.btnDelCTHD.Click += new System.EventHandler(this.btnDelCTHD_Click);
            // 
            // btnAddCTHD
            // 
            this.btnAddCTHD.BackColor = System.Drawing.Color.Cyan;
            this.btnAddCTHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddCTHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAddCTHD.Location = new System.Drawing.Point(11, 100);
            this.btnAddCTHD.Name = "btnAddCTHD";
            this.btnAddCTHD.Size = new System.Drawing.Size(105, 53);
            this.btnAddCTHD.TabIndex = 38;
            this.btnAddCTHD.Text = "Sửa";
            this.btnAddCTHD.UseVisualStyleBackColor = false;
            this.btnAddCTHD.Click += new System.EventHandler(this.btnAddCTHD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(604, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Khuyến mãi:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BackColor = System.Drawing.Color.Turquoise;
            this.txtGiamGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiamGia.Location = new System.Drawing.Point(729, 5);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(35, 34);
            this.txtGiamGia.TabIndex = 44;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(770, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 28);
            this.label8.TabIndex = 45;
            this.label8.Text = "%";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Cyan;
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPreview.Location = new System.Drawing.Point(229, 100);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(101, 53);
            this.btnPreview.TabIndex = 46;
            this.btnPreview.Text = "In";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID_HD:";
            // 
            // txtID_HD
            // 
            this.txtID_HD.BackColor = System.Drawing.Color.Turquoise;
            this.txtID_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID_HD.Location = new System.Drawing.Point(108, 6);
            this.txtID_HD.Name = "txtID_HD";
            this.txtID_HD.ReadOnly = true;
            this.txtID_HD.Size = new System.Drawing.Size(84, 34);
            this.txtID_HD.TabIndex = 47;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Turquoise;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(529, 48);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(250, 34);
            this.txtPrice.TabIndex = 48;
            // 
            // FormCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtID_HD);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelCTHD);
            this.Controls.Add(this.btnAddCTHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTD);
            this.Controls.Add(this.label6);
            this.Name = "FormCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.FormCTHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label6;
        private ComboBox cmbTD;
        private Label label4;
        private TextBox txtSL;
        private Label label5;
        private TextBox txtTotal;
        private DataGridView dgvCTHD;
        private Label label3;
        private Label label7;
        private Button btnDelCTHD;
        private Button btnAddCTHD;
        private Label label2;
        private TextBox txtGiamGia;
        private Label label8;
        private Button btnPreview;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label1;
        private TextBox txtID_HD;
        private TextBox txtPrice;
    }
}