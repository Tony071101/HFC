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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbID_HD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelCTHD = new System.Windows.Forms.Button();
            this.btnAddCTHD = new System.Windows.Forms.Button();
            this.cmbPrice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "TÊN MÓN ĂN:";
            // 
            // cmbTD
            // 
            this.cmbTD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTD.FormattingEnabled = true;
            this.cmbTD.Location = new System.Drawing.Point(155, 40);
            this.cmbTD.Name = "cmbTD";
            this.cmbTD.Size = new System.Drawing.Size(300, 36);
            this.cmbTD.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(475, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 28);
            this.label4.TabIndex = 29;
            this.label4.Text = "SL:";
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSL.Location = new System.Drawing.Point(517, 21);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(69, 34);
            this.txtSL.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(475, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "TỔNG TIỀN:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(596, 106);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(192, 34);
            this.txtTotal.TabIndex = 32;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(12, 159);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCTHD.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTHD.RowTemplate.Height = 29;
            this.dgvCTHD.Size = new System.Drawing.Size(776, 475);
            this.dgvCTHD.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "ID_HD:";
            // 
            // cmbID_HD
            // 
            this.cmbID_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbID_HD.FormattingEnabled = true;
            this.cmbID_HD.Location = new System.Drawing.Point(89, 4);
            this.cmbID_HD.Name = "cmbID_HD";
            this.cmbID_HD.Size = new System.Drawing.Size(60, 36);
            this.cmbID_HD.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(475, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(-172, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 28);
            this.label7.TabIndex = 41;
            this.label7.Text = "ID:";
            // 
            // btnDelCTHD
            // 
            this.btnDelCTHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelCTHD.Location = new System.Drawing.Point(123, 100);
            this.btnDelCTHD.Name = "btnDelCTHD";
            this.btnDelCTHD.Size = new System.Drawing.Size(100, 53);
            this.btnDelCTHD.TabIndex = 39;
            this.btnDelCTHD.Text = "Xóa";
            this.btnDelCTHD.UseVisualStyleBackColor = true;
            this.btnDelCTHD.Click += new System.EventHandler(this.btnDelCTHD_Click);
            // 
            // btnAddCTHD
            // 
            this.btnAddCTHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCTHD.Location = new System.Drawing.Point(12, 100);
            this.btnAddCTHD.Name = "btnAddCTHD";
            this.btnAddCTHD.Size = new System.Drawing.Size(105, 53);
            this.btnAddCTHD.TabIndex = 38;
            this.btnAddCTHD.Text = "Thêm";
            this.btnAddCTHD.UseVisualStyleBackColor = true;
            this.btnAddCTHD.Click += new System.EventHandler(this.btnAddCTHD_Click);
            // 
            // cmbPrice
            // 
            this.cmbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPrice.FormattingEnabled = true;
            this.cmbPrice.Location = new System.Drawing.Point(526, 64);
            this.cmbPrice.Name = "cmbPrice";
            this.cmbPrice.Size = new System.Drawing.Size(262, 36);
            this.cmbPrice.TabIndex = 42;
            this.cmbPrice.SelectedIndexChanged += new System.EventHandler(this.cmbPrice_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(596, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Khuyến mãi:";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGiamGia.Location = new System.Drawing.Point(720, 21);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(35, 34);
            this.txtGiamGia.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(760, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 28);
            this.label8.TabIndex = 45;
            this.label8.Text = "%";
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPreview.Location = new System.Drawing.Point(229, 100);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 53);
            this.btnPreview.TabIndex = 46;
            this.btnPreview.Text = "In";
            this.btnPreview.UseVisualStyleBackColor = true;
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
            // FormCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 646);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelCTHD);
            this.Controls.Add(this.btnAddCTHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbID_HD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTD);
            this.Controls.Add(this.label6);
            this.Name = "FormCTHD";
            this.Text = "FormCTHD";
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
        private Label label1;
        private ComboBox cmbID_HD;
        private Label label3;
        private Label label7;
        private Button btnDelCTHD;
        private Button btnAddCTHD;
        private ComboBox cmbPrice;
        private Label label2;
        private TextBox txtGiamGia;
        private Label label8;
        private Button btnPreview;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}