namespace QLHFC.PresentationTier
{
    partial class FormThucDon
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnPicture = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchMonAn = new System.Windows.Forms.TextBox();
            this.cmbSearchMonAn = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnDelFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.mySqlDataAdapter1 = new MySqlConnector.MySqlDataAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPicture);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSearchMonAn);
            this.panel1.Controls.Add(this.cmbSearchMonAn);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.txtTenMon);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIDMon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnUpdateFood);
            this.panel1.Controls.Add(this.btnDelFood);
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.dgvThucDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 677);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(570, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tìm kiếm:";
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Cyan;
            this.btnPicture.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPicture.ForeColor = System.Drawing.Color.Red;
            this.btnPicture.Location = new System.Drawing.Point(872, 49);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(143, 51);
            this.btnPicture.TabIndex = 21;
            this.btnPicture.Text = "Thêm Hình ảnh";
            this.btnPicture.UseVisualStyleBackColor = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.Location = new System.Drawing.Point(570, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchMonAn
            // 
            this.txtSearchMonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchMonAn.BackColor = System.Drawing.Color.Turquoise;
            this.txtSearchMonAn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchMonAn.Location = new System.Drawing.Point(778, 146);
            this.txtSearchMonAn.Name = "txtSearchMonAn";
            this.txtSearchMonAn.Size = new System.Drawing.Size(237, 34);
            this.txtSearchMonAn.TabIndex = 19;
            this.txtSearchMonAn.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbSearchMonAn
            // 
            this.cmbSearchMonAn.BackColor = System.Drawing.Color.Turquoise;
            this.cmbSearchMonAn.FormattingEnabled = true;
            this.cmbSearchMonAn.Items.AddRange(new object[] {
            "ID_MonAn",
            "TenMonAn",
            "Gia"});
            this.cmbSearchMonAn.Location = new System.Drawing.Point(680, 146);
            this.cmbSearchMonAn.Name = "cmbSearchMonAn";
            this.cmbSearchMonAn.Size = new System.Drawing.Size(92, 28);
            this.cmbSearchMonAn.TabIndex = 18;
            this.cmbSearchMonAn.SelectedIndexChanged += new System.EventHandler(this.cmbSearchMonAn_SelectedIndexChanged);
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.Turquoise;
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGia.Location = new System.Drawing.Point(116, 99);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(395, 34);
            this.txtGia.TabIndex = 11;
            // 
            // txtTenMon
            // 
            this.txtTenMon.BackColor = System.Drawing.Color.Turquoise;
            this.txtTenMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenMon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenMon.Location = new System.Drawing.Point(116, 53);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(395, 34);
            this.txtTenMon.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên món:";
            // 
            // txtIDMon
            // 
            this.txtIDMon.BackColor = System.Drawing.Color.Turquoise;
            this.txtIDMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDMon.Location = new System.Drawing.Point(116, 9);
            this.txtIDMon.Name = "txtIDMon";
            this.txtIDMon.ReadOnly = true;
            this.txtIDMon.Size = new System.Drawing.Size(395, 34);
            this.txtIDMon.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.BackColor = System.Drawing.Color.Cyan;
            this.btnUpdateFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateFood.ForeColor = System.Drawing.Color.Red;
            this.btnUpdateFood.Location = new System.Drawing.Point(405, 139);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(107, 48);
            this.btnUpdateFood.TabIndex = 4;
            this.btnUpdateFood.Text = "Sửa";
            this.btnUpdateFood.UseVisualStyleBackColor = false;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnDelFood
            // 
            this.btnDelFood.BackColor = System.Drawing.Color.Cyan;
            this.btnDelFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelFood.ForeColor = System.Drawing.Color.Red;
            this.btnDelFood.Location = new System.Drawing.Point(211, 139);
            this.btnDelFood.Name = "btnDelFood";
            this.btnDelFood.Size = new System.Drawing.Size(104, 48);
            this.btnDelFood.TabIndex = 3;
            this.btnDelFood.Text = "Xóa";
            this.btnDelFood.UseVisualStyleBackColor = false;
            this.btnDelFood.Click += new System.EventHandler(this.btnDelFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.Cyan;
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFood.ForeColor = System.Drawing.Color.Red;
            this.btnAddFood.Location = new System.Drawing.Point(11, 139);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(114, 48);
            this.btnAddFood.TabIndex = 2;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToAddRows = false;
            this.dgvThucDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThucDon.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvThucDon.Location = new System.Drawing.Point(11, 197);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvThucDon.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThucDon.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvThucDon.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvThucDon.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvThucDon.RowTemplate.Height = 70;
            this.dgvThucDon.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThucDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThucDon.Size = new System.Drawing.Size(1031, 468);
            this.dgvThucDon.TabIndex = 0;
            this.dgvThucDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThucDon_CellContentClick);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateBatchSize = 0;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // FormThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 677);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThucDon";
            this.Load += new System.EventHandler(this.FormThucDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private MySqlConnector.MySqlDataAdapter mySqlDataAdapter1;
        private Button btnUpdateFood;
        private Button btnDelFood;
        private Button btnAddFood;
        private DataGridView dgvThucDon;
        private TextBox txtGia;
        private TextBox txtTenMon;
        private Label label3;
        private Label label2;
        private TextBox txtIDMon;
        private Label label1;
        private ComboBox cmbSearchMonAn;
        private TextBox txtSearchMonAn;
        private Button btnPicture;
        private PictureBox pictureBox1;
        private Label label4;
    }
}