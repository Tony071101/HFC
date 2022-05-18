namespace QLHFC.PresentationTier
{
    partial class FormNV
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
            this.pnlNhanVien = new System.Windows.Forms.Panel();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtPassword_NV = new System.Windows.Forms.TextBox();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.txtUsername_NV = new System.Windows.Forms.TextBox();
            this.txtSDT_NV = new System.Windows.Forms.TextBox();
            this.txtAddress_NV = new System.Windows.Forms.TextBox();
            this.txtName_NV = new System.Windows.Forms.TextBox();
            this.txtID_NV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNhanVien
            // 
            this.pnlNhanVien.Controls.Add(this.cmbSearch);
            this.pnlNhanVien.Controls.Add(this.txtSearch);
            this.pnlNhanVien.Controls.Add(this.btnDel);
            this.pnlNhanVien.Controls.Add(this.btnEdit);
            this.pnlNhanVien.Controls.Add(this.txtPassword_NV);
            this.pnlNhanVien.Controls.Add(this.dgvNV);
            this.pnlNhanVien.Controls.Add(this.txtUsername_NV);
            this.pnlNhanVien.Controls.Add(this.txtSDT_NV);
            this.pnlNhanVien.Controls.Add(this.txtAddress_NV);
            this.pnlNhanVien.Controls.Add(this.txtName_NV);
            this.pnlNhanVien.Controls.Add(this.txtID_NV);
            this.pnlNhanVien.Controls.Add(this.label4);
            this.pnlNhanVien.Controls.Add(this.label5);
            this.pnlNhanVien.Controls.Add(this.label6);
            this.pnlNhanVien.Controls.Add(this.label3);
            this.pnlNhanVien.Controls.Add(this.label2);
            this.pnlNhanVien.Controls.Add(this.label1);
            this.pnlNhanVien.Controls.Add(this.btnAdd);
            this.pnlNhanVien.Location = new System.Drawing.Point(1, 1);
            this.pnlNhanVien.Name = "pnlNhanVien";
            this.pnlNhanVien.Size = new System.Drawing.Size(1061, 675);
            this.pnlNhanVien.TabIndex = 3;
            // 
            // cmbSearch
            // 
            this.cmbSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "ID",
            "Họ Tên",
            "Địa Chỉ",
            "SĐT",
            "Username",
            "Password"});
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "ID_NV",
            "TenNV",
            "DiaChiNV",
            "SDT_NV",
            "Username",
            "Password"});
            this.cmbSearch.Location = new System.Drawing.Point(516, 237);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(97, 28);
            this.cmbSearch.TabIndex = 17;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(619, 237);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(432, 34);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(201, 230);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(121, 54);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(386, 230);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 54);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtPassword_NV
            // 
            this.txtPassword_NV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword_NV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword_NV.Location = new System.Drawing.Point(619, 158);
            this.txtPassword_NV.Name = "txtPassword_NV";
            this.txtPassword_NV.Size = new System.Drawing.Size(432, 34);
            this.txtPassword_NV.TabIndex = 12;
            // 
            // dgvNV
            // 
            this.dgvNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(0, 311);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.RowTemplate.Height = 29;
            this.dgvNV.Size = new System.Drawing.Size(1051, 361);
            this.dgvNV.TabIndex = 0;
            this.dgvNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtUsername_NV
            // 
            this.txtUsername_NV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername_NV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername_NV.Location = new System.Drawing.Point(619, 86);
            this.txtUsername_NV.Name = "txtUsername_NV";
            this.txtUsername_NV.Size = new System.Drawing.Size(432, 34);
            this.txtUsername_NV.TabIndex = 11;
            // 
            // txtSDT_NV
            // 
            this.txtSDT_NV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSDT_NV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSDT_NV.Location = new System.Drawing.Point(564, 21);
            this.txtSDT_NV.Name = "txtSDT_NV";
            this.txtSDT_NV.Size = new System.Drawing.Size(487, 34);
            this.txtSDT_NV.TabIndex = 10;
            // 
            // txtAddress_NV
            // 
            this.txtAddress_NV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress_NV.Location = new System.Drawing.Point(85, 158);
            this.txtAddress_NV.Name = "txtAddress_NV";
            this.txtAddress_NV.Size = new System.Drawing.Size(422, 34);
            this.txtAddress_NV.TabIndex = 9;
            // 
            // txtName_NV
            // 
            this.txtName_NV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName_NV.Location = new System.Drawing.Point(85, 86);
            this.txtName_NV.Name = "txtName_NV";
            this.txtName_NV.Size = new System.Drawing.Size(422, 34);
            this.txtName_NV.TabIndex = 8;
            // 
            // txtID_NV
            // 
            this.txtID_NV.BackColor = System.Drawing.Color.Silver;
            this.txtID_NV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID_NV.Location = new System.Drawing.Point(44, 21);
            this.txtID_NV.Name = "txtID_NV";
            this.txtID_NV.ReadOnly = true;
            this.txtID_NV.Size = new System.Drawing.Size(463, 34);
            this.txtID_NV.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(516, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(516, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(516, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 54);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 678);
            this.Controls.Add(this.pnlNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNV";
            this.Load += new System.EventHandler(this.FormNV_Load);
            this.pnlNhanVien.ResumeLayout(false);
            this.pnlNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlNhanVien;
        private Button btnDel;
        private Button btnEdit;
        private TextBox txtPassword_NV;
        private DataGridView dgvNV;
        private TextBox txtUsername_NV;
        private TextBox txtSDT_NV;
        private TextBox txtAddress_NV;
        private TextBox txtName_NV;
        private TextBox txtID_NV;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private TextBox txtSearch;
        private ComboBox cmbSearch;
    }
}