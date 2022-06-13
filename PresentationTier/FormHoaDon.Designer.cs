namespace QLHFC.PresentationTier
{
    partial class FormHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.txtSearchHD = new System.Windows.Forms.TextBox();
            this.cmbSearchHD = new System.Windows.Forms.ComboBox();
            this.btnDelHD = new System.Windows.Forms.Button();
            this.btnUpdateHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_HD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbKH = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHD
            // 
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(3, 177);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHD.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHD.RowTemplate.Height = 29;
            this.dgvHD.Size = new System.Drawing.Size(1049, 489);
            this.dgvHD.TabIndex = 2;
            this.dgvHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellContentClick);
            // 
            // txtSearchHD
            // 
            this.txtSearchHD.BackColor = System.Drawing.Color.Turquoise;
            this.txtSearchHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchHD.Location = new System.Drawing.Point(187, 131);
            this.txtSearchHD.Name = "txtSearchHD";
            this.txtSearchHD.Size = new System.Drawing.Size(332, 34);
            this.txtSearchHD.TabIndex = 7;
            this.txtSearchHD.TextChanged += new System.EventHandler(this.txtSearchHD_TextChanged);
            // 
            // cmbSearchHD
            // 
            this.cmbSearchHD.BackColor = System.Drawing.Color.Turquoise;
            this.cmbSearchHD.FormattingEnabled = true;
            this.cmbSearchHD.Items.AddRange(new object[] {
            "ID_HD",
            "TenKH",
            "TenNV"});
            this.cmbSearchHD.Location = new System.Drawing.Point(116, 137);
            this.cmbSearchHD.Name = "cmbSearchHD";
            this.cmbSearchHD.Size = new System.Drawing.Size(65, 28);
            this.cmbSearchHD.TabIndex = 8;
            // 
            // btnDelHD
            // 
            this.btnDelHD.BackColor = System.Drawing.Color.Cyan;
            this.btnDelHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelHD.ForeColor = System.Drawing.Color.Red;
            this.btnDelHD.Location = new System.Drawing.Point(792, 17);
            this.btnDelHD.Name = "btnDelHD";
            this.btnDelHD.Size = new System.Drawing.Size(127, 59);
            this.btnDelHD.TabIndex = 10;
            this.btnDelHD.Text = "Xóa";
            this.btnDelHD.UseVisualStyleBackColor = false;
            this.btnDelHD.Click += new System.EventHandler(this.btnDelHD_Click);
            // 
            // btnUpdateHD
            // 
            this.btnUpdateHD.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdateHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateHD.ForeColor = System.Drawing.Color.Red;
            this.btnUpdateHD.Location = new System.Drawing.Point(659, 17);
            this.btnUpdateHD.Name = "btnUpdateHD";
            this.btnUpdateHD.Size = new System.Drawing.Size(127, 59);
            this.btnUpdateHD.TabIndex = 11;
            this.btnUpdateHD.Text = "Sửa";
            this.btnUpdateHD.UseVisualStyleBackColor = false;
            this.btnUpdateHD.Click += new System.EventHandler(this.btnUpdateHD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID:";
            // 
            // txtID_HD
            // 
            this.txtID_HD.BackColor = System.Drawing.Color.Turquoise;
            this.txtID_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID_HD.Location = new System.Drawing.Point(56, 9);
            this.txtID_HD.Name = "txtID_HD";
            this.txtID_HD.ReadOnly = true;
            this.txtID_HD.Size = new System.Drawing.Size(70, 34);
            this.txtID_HD.TabIndex = 14;
            this.txtID_HD.TextChanged += new System.EventHandler(this.txtID_HD_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "TÊN KHÁCH HÀNG:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tìm kiếm:";
            // 
            // cmbKH
            // 
            this.cmbKH.BackColor = System.Drawing.Color.Turquoise;
            this.cmbKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKH.FormattingEnabled = true;
            this.cmbKH.Location = new System.Drawing.Point(215, 43);
            this.cmbKH.Name = "cmbKH";
            this.cmbKH.Size = new System.Drawing.Size(304, 36);
            this.cmbKH.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTongtien);
            this.panel1.Controls.Add(this.txtKM);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.txtTenMon);
            this.panel1.Controls.Add(this.txtNV);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbKH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtID_HD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUpdateHD);
            this.panel1.Controls.Add(this.btnDelHD);
            this.panel1.Controls.Add(this.cmbSearchHD);
            this.panel1.Controls.Add(this.txtSearchHD);
            this.panel1.Controls.Add(this.dgvHD);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 678);
            this.panel1.TabIndex = 1;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(525, 43);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(101, 27);
            this.txtTongtien.TabIndex = 38;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(465, 10);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(101, 27);
            this.txtKM.TabIndex = 37;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(358, 10);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(101, 27);
            this.txtGia.TabIndex = 36;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(251, 9);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(101, 27);
            this.txtSL.TabIndex = 35;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(144, 10);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(101, 27);
            this.txtTenMon.TabIndex = 34;
            // 
            // txtNV
            // 
            this.txtNV.BackColor = System.Drawing.Color.Turquoise;
            this.txtNV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNV.Location = new System.Drawing.Point(773, 82);
            this.txtNV.Name = "txtNV";
            this.txtNV.ReadOnly = true;
            this.txtNV.Size = new System.Drawing.Size(270, 34);
            this.txtNV.TabIndex = 33;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Turquoise;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.Location = new System.Drawing.Point(215, 87);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(304, 34);
            this.txtDate.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ngày lập hóa đơn:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Cyan;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.Red;
            this.btnPrint.Location = new System.Drawing.Point(925, 17);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 60);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(659, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 52);
            this.button1.TabIndex = 28;
            this.button1.Text = "CHI TIẾT HÓA ĐƠN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(659, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 28);
            this.label4.TabIndex = 26;
            this.label4.Text = "Họ Tên NV:";
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
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1055, 678);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvHD;
        private TextBox txtSearchHD;
        private ComboBox cmbSearchHD;
        private Button btnDelHD;
        private Button btnUpdateHD;
        private Label label1;
        private TextBox txtID_HD;
        private Label label2;
        private Label label3;
        private ComboBox cmbKH;
        private Panel panel1;
        private Label label4;
        private Button button1;
        private Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private TextBox txtDate;
        private Label label5;
        private TextBox txtNV;
        private TextBox txtTongtien;
        private TextBox txtKM;
        private TextBox txtGia;
        private TextBox txtSL;
        private TextBox txtTenMon;
    }
}