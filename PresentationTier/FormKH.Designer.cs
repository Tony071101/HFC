namespace QLHFC.PresentationTier
{
    partial class FormKH
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchKH = new System.Windows.Forms.TextBox();
            this.cmbSearchKH = new System.Windows.Forms.ComboBox();
            this.txtSDT_KH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditKH = new System.Windows.Forms.Button();
            this.btnDelKH = new System.Windows.Forms.Button();
            this.btnAddKH = new System.Windows.Forms.Button();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.txtID_KH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSearchKH);
            this.panel1.Controls.Add(this.cmbSearchKH);
            this.panel1.Controls.Add(this.txtSDT_KH);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiaChiKH);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNameKH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEditKH);
            this.panel1.Controls.Add(this.btnDelKH);
            this.panel1.Controls.Add(this.btnAddKH);
            this.panel1.Controls.Add(this.dgvKH);
            this.panel1.Controls.Add(this.txtID_KH);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 508);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchKH
            // 
            this.txtSearchKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchKH.BackColor = System.Drawing.Color.Turquoise;
            this.txtSearchKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchKH.Location = new System.Drawing.Point(581, 159);
            this.txtSearchKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchKH.Name = "txtSearchKH";
            this.txtSearchKH.Size = new System.Drawing.Size(332, 29);
            this.txtSearchKH.TabIndex = 19;
            this.txtSearchKH.TextChanged += new System.EventHandler(this.txtSearchKH_TextChanged);
            // 
            // cmbSearchKH
            // 
            this.cmbSearchKH.AutoCompleteCustomSource.AddRange(new string[] {
            "ID",
            "Họ Tên",
            "Địa Chỉ",
            "SĐT",
            "Username",
            "Password"});
            this.cmbSearchKH.FormattingEnabled = true;
            this.cmbSearchKH.Items.AddRange(new object[] {
            "ID_KH",
            "TenKH",
            "DiaChiKH",
            "SDT_KH"});
            this.cmbSearchKH.Location = new System.Drawing.Point(491, 159);
            this.cmbSearchKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSearchKH.Name = "cmbSearchKH";
            this.cmbSearchKH.Size = new System.Drawing.Size(85, 23);
            this.cmbSearchKH.TabIndex = 18;
            // 
            // txtSDT_KH
            // 
            this.txtSDT_KH.BackColor = System.Drawing.Color.Turquoise;
            this.txtSDT_KH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSDT_KH.Location = new System.Drawing.Point(541, 71);
            this.txtSDT_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSDT_KH.Name = "txtSDT_KH";
            this.txtSDT_KH.Size = new System.Drawing.Size(372, 29);
            this.txtSDT_KH.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(491, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "SĐT:";
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.BackColor = System.Drawing.Color.Turquoise;
            this.txtDiaChiKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiaChiKH.Location = new System.Drawing.Point(570, 27);
            this.txtDiaChiKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(344, 29);
            this.txtDiaChiKH.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(491, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "ĐỊA CHỈ:";
            // 
            // txtNameKH
            // 
            this.txtNameKH.BackColor = System.Drawing.Color.Turquoise;
            this.txtNameKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameKH.Location = new System.Drawing.Point(175, 69);
            this.txtNameKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameKH.Name = "txtNameKH";
            this.txtNameKH.Size = new System.Drawing.Size(280, 29);
            this.txtNameKH.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "TÊN KHÁCH HÀNG:";
            // 
            // btnEditKH
            // 
            this.btnEditKH.BackColor = System.Drawing.Color.Turquoise;
            this.btnEditKH.Location = new System.Drawing.Point(343, 152);
            this.btnEditKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditKH.Name = "btnEditKH";
            this.btnEditKH.Size = new System.Drawing.Size(111, 44);
            this.btnEditKH.TabIndex = 5;
            this.btnEditKH.Text = "Sửa";
            this.btnEditKH.UseVisualStyleBackColor = false;
            this.btnEditKH.Click += new System.EventHandler(this.btnEditKH_Click);
            // 
            // btnDelKH
            // 
            this.btnDelKH.BackColor = System.Drawing.Color.Turquoise;
            this.btnDelKH.Location = new System.Drawing.Point(226, 153);
            this.btnDelKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelKH.Name = "btnDelKH";
            this.btnDelKH.Size = new System.Drawing.Size(111, 44);
            this.btnDelKH.TabIndex = 4;
            this.btnDelKH.Text = "Xóa";
            this.btnDelKH.UseVisualStyleBackColor = false;
            this.btnDelKH.Click += new System.EventHandler(this.btnDelKH_Click);
            // 
            // btnAddKH
            // 
            this.btnAddKH.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddKH.Location = new System.Drawing.Point(109, 152);
            this.btnAddKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddKH.Name = "btnAddKH";
            this.btnAddKH.Size = new System.Drawing.Size(111, 44);
            this.btnAddKH.TabIndex = 3;
            this.btnAddKH.Text = "Thêm";
            this.btnAddKH.UseVisualStyleBackColor = false;
            this.btnAddKH.Click += new System.EventHandler(this.btnAddKH_Click);
            // 
            // dgvKH
            // 
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(3, 201);
            this.dgvKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvKH.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.RowTemplate.Height = 29;
            this.dgvKH.Size = new System.Drawing.Size(918, 298);
            this.dgvKH.TabIndex = 2;
            this.dgvKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellContentClick);
            // 
            // txtID_KH
            // 
            this.txtID_KH.BackColor = System.Drawing.Color.Turquoise;
            this.txtID_KH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID_KH.Location = new System.Drawing.Point(46, 27);
            this.txtID_KH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_KH.Name = "txtID_KH";
            this.txtID_KH.ReadOnly = true;
            this.txtID_KH.Size = new System.Drawing.Size(408, 29);
            this.txtID_KH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLHFC.Properties.Resources.download__5_;
            this.pictureBox1.Location = new System.Drawing.Point(10, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // FormKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 508);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKH";
            this.Load += new System.EventHandler(this.FormKH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnEditKH;
        private Button btnDelKH;
        private Button btnAddKH;
        private DataGridView dgvKH;
        private TextBox txtID_KH;
        private Label label1;
        private TextBox txtSDT_KH;
        private Label label4;
        private TextBox txtDiaChiKH;
        private Label label3;
        private TextBox txtNameKH;
        private Label label2;
        private ComboBox cmbSearchKH;
        private TextBox txtSearchKH;
        private PictureBox pictureBox1;
    }
}