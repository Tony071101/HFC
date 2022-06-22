namespace QLHFC.PresentationTier
{
    partial class FormHDNV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHDNV));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_HD = new System.Windows.Forms.TextBox();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.txtNV = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQR = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 28);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ngày lập hóa đơn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 28);
            this.label2.TabIndex = 33;
            this.label2.Text = "TÊN KHÁCH HÀNG:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID:";
            // 
            // txtID_HD
            // 
            this.txtID_HD.BackColor = System.Drawing.Color.Turquoise;
            this.txtID_HD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID_HD.Location = new System.Drawing.Point(56, 6);
            this.txtID_HD.Name = "txtID_HD";
            this.txtID_HD.ReadOnly = true;
            this.txtID_HD.Size = new System.Drawing.Size(70, 34);
            this.txtID_HD.TabIndex = 36;
            // 
            // txtKH
            // 
            this.txtKH.BackColor = System.Drawing.Color.Turquoise;
            this.txtKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKH.Location = new System.Drawing.Point(215, 39);
            this.txtKH.Name = "txtKH";
            this.txtKH.ReadOnly = true;
            this.txtKH.Size = new System.Drawing.Size(262, 34);
            this.txtKH.TabIndex = 37;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.Turquoise;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDate.Location = new System.Drawing.Point(215, 76);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(262, 34);
            this.txtDate.TabIndex = 38;
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
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
            this.dgvHD.Location = new System.Drawing.Point(12, 156);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvHD.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHD.RowTemplate.Height = 29;
            this.dgvHD.Size = new System.Drawing.Size(539, 510);
            this.dgvHD.TabIndex = 41;
            this.dgvHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellContentClick);
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(557, 156);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvCTHD.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCTHD.RowTemplate.Height = 29;
            this.dgvCTHD.Size = new System.Drawing.Size(486, 510);
            this.dgvCTHD.TabIndex = 42;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(119, 123);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(101, 27);
            this.txtTongtien.TabIndex = 47;
            // 
            // txtKM
            // 
            this.txtKM.Location = new System.Drawing.Point(549, 123);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(101, 27);
            this.txtKM.TabIndex = 46;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(227, 123);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(101, 27);
            this.txtGia.TabIndex = 45;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(334, 123);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(101, 27);
            this.txtSL.TabIndex = 44;
            // 
            // txtTenMon
            // 
            this.txtTenMon.Location = new System.Drawing.Point(441, 123);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(101, 27);
            this.txtTenMon.TabIndex = 43;
            this.txtTenMon.TextChanged += new System.EventHandler(this.txtTenMon_TextChanged);
            // 
            // txtNV
            // 
            this.txtNV.Location = new System.Drawing.Point(12, 123);
            this.txtNV.Name = "txtNV";
            this.txtNV.Size = new System.Drawing.Size(101, 27);
            this.txtNV.TabIndex = 48;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Cyan;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrint.ForeColor = System.Drawing.Color.Red;
            this.btnPrint.Location = new System.Drawing.Point(483, 39);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(68, 71);
            this.btnPrint.TabIndex = 49;
            this.btnPrint.Text = "In";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.Location = new System.Drawing.Point(656, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btnQR
            // 
            this.btnQR.BackColor = System.Drawing.Color.Cyan;
            this.btnQR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQR.ForeColor = System.Drawing.Color.Red;
            this.btnQR.Location = new System.Drawing.Point(913, 6);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(130, 64);
            this.btnQR.TabIndex = 51;
            this.btnQR.Text = "Mã QR";
            this.btnQR.UseVisualStyleBackColor = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(913, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 64);
            this.button2.TabIndex = 52;
            this.button2.Text = "In mã QR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormHDNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1055, 678);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtNV);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtKH);
            this.Controls.Add(this.txtID_HD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHDNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHDNV";
            this.Load += new System.EventHandler(this.FormHDNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Label label2;
        private Label label1;
        private TextBox txtID_HD;
        private TextBox txtKH;
        private TextBox txtDate;
        private DataGridView dgvHD;
        private DataGridView dgvCTHD;
        private TextBox txtTongtien;
        private TextBox txtKM;
        private TextBox txtGia;
        private TextBox txtSL;
        private TextBox txtTenMon;
        private TextBox txtNV;
        private Button btnPrint;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PictureBox pictureBox1;
        private Button btnQR;
        private Button button2;
    }
}