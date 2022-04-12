namespace QLHFC
{
    partial class FormAdmin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDate = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tpFood = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFindFood = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdjustFood = new System.Windows.Forms.Button();
            this.btnDelFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpUser = new System.Windows.Forms.TabPage();
            this.panel15 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtDisplayname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.btnAdjustUser = new System.Windows.Forms.Button();
            this.btnDelUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tcAdmin.SuspendLayout();
            this.tpBill.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tpFood.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpUser.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpFood);
            this.tcAdmin.Controls.Add(this.tpUser);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1117, 614);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel2);
            this.tpBill.Controls.Add(this.panel1);
            this.tpBill.Location = new System.Drawing.Point(4, 29);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(1109, 581);
            this.tpBill.TabIndex = 0;
            this.tpBill.Text = "Doanh thu";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDate);
            this.panel2.Controls.Add(this.dtpkDate);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 34);
            this.panel2.TabIndex = 1;
            // 
            // btnDate
            // 
            this.btnDate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDate.Location = new System.Drawing.Point(259, 1);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(94, 29);
            this.btnDate.TabIndex = 1;
            this.btnDate.Text = "Thống kê";
            this.btnDate.UseVisualStyleBackColor = true;
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(3, 3);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(250, 27);
            this.dtpkDate.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBill);
            this.panel1.Location = new System.Drawing.Point(6, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 533);
            this.panel1.TabIndex = 0;
            // 
            // dgvBill
            // 
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Location = new System.Drawing.Point(3, 4);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 29;
            this.dgvBill.Size = new System.Drawing.Size(1091, 526);
            this.dgvBill.TabIndex = 0;
            // 
            // tpFood
            // 
            this.tpFood.Controls.Add(this.panel6);
            this.tpFood.Controls.Add(this.panel5);
            this.tpFood.Controls.Add(this.panel4);
            this.tpFood.Controls.Add(this.panel3);
            this.tpFood.Location = new System.Drawing.Point(4, 29);
            this.tpFood.Name = "tpFood";
            this.tpFood.Padding = new System.Windows.Forms.Padding(3);
            this.tpFood.Size = new System.Drawing.Size(1109, 581);
            this.tpFood.TabIndex = 1;
            this.tpFood.Text = "Thực đơn";
            this.tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(566, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(537, 569);
            this.panel6.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.txtFoodPrice);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 221);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(531, 69);
            this.panel9.TabIndex = 4;
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtFoodPrice.Location = new System.Drawing.Point(143, 20);
            this.txtFoodPrice.Multiline = true;
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(385, 35);
            this.txtFoodPrice.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá tiền:";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Controls.Add(this.textBox2);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 145);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(531, 69);
            this.panel8.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(157, 20);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(371, 35);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên món:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.txtFoodID);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(531, 69);
            this.panel7.TabIndex = 2;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtFoodID.Location = new System.Drawing.Point(123, 20);
            this.txtFoodID.Multiline = true;
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.Size = new System.Drawing.Size(405, 35);
            this.txtFoodID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số ID:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnFindFood);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(554, 61);
            this.panel5.TabIndex = 2;
            // 
            // btnFindFood
            // 
            this.btnFindFood.Location = new System.Drawing.Point(336, 3);
            this.btnFindFood.Name = "btnFindFood";
            this.btnFindFood.Size = new System.Drawing.Size(111, 55);
            this.btnFindFood.TabIndex = 1;
            this.btnFindFood.Text = "Tìm";
            this.btnFindFood.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 27);
            this.textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAdjustFood);
            this.panel4.Controls.Add(this.btnDelFood);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Location = new System.Drawing.Point(6, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(117, 502);
            this.panel4.TabIndex = 1;
            // 
            // btnAdjustFood
            // 
            this.btnAdjustFood.Location = new System.Drawing.Point(3, 379);
            this.btnAdjustFood.Name = "btnAdjustFood";
            this.btnAdjustFood.Size = new System.Drawing.Size(111, 78);
            this.btnAdjustFood.TabIndex = 2;
            this.btnAdjustFood.Text = "Sửa";
            this.btnAdjustFood.UseVisualStyleBackColor = true;
            // 
            // btnDelFood
            // 
            this.btnDelFood.Location = new System.Drawing.Point(3, 210);
            this.btnDelFood.Name = "btnDelFood";
            this.btnDelFood.Size = new System.Drawing.Size(111, 78);
            this.btnDelFood.TabIndex = 1;
            this.btnDelFood.Text = "Xóa";
            this.btnDelFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(3, 33);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(111, 78);
            this.btnAddFood.TabIndex = 0;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(129, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 502);
            this.panel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(425, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpUser
            // 
            this.tpUser.Controls.Add(this.panel15);
            this.tpUser.Controls.Add(this.panel10);
            this.tpUser.Controls.Add(this.panel14);
            this.tpUser.Location = new System.Drawing.Point(4, 29);
            this.tpUser.Name = "tpUser";
            this.tpUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpUser.Size = new System.Drawing.Size(1109, 581);
            this.tpUser.TabIndex = 2;
            this.tpUser.Text = "Khách hàng";
            this.tpUser.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.dataGridView2);
            this.panel15.Location = new System.Drawing.Point(129, 70);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(434, 502);
            this.panel15.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(425, 496);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Location = new System.Drawing.Point(569, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(534, 569);
            this.panel10.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.Controls.Add(this.txtPassword);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Location = new System.Drawing.Point(6, 220);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(525, 69);
            this.panel11.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(164, 20);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(358, 35);
            this.txtPassword.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu:";
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.txtDisplayname);
            this.panel12.Controls.Add(this.label5);
            this.panel12.Location = new System.Drawing.Point(6, 145);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(525, 69);
            this.panel12.TabIndex = 3;
            // 
            // txtDisplayname
            // 
            this.txtDisplayname.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtDisplayname.Location = new System.Drawing.Point(200, 20);
            this.txtDisplayname.Multiline = true;
            this.txtDisplayname.Name = "txtDisplayname";
            this.txtDisplayname.Size = new System.Drawing.Size(322, 35);
            this.txtDisplayname.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên hiển thị:";
            // 
            // panel13
            // 
            this.panel13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel13.Controls.Add(this.txtUsername);
            this.panel13.Controls.Add(this.label6);
            this.panel13.Location = new System.Drawing.Point(3, 70);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(528, 69);
            this.panel13.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(226, 20);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(299, 35);
            this.txtUsername.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên tài khoản:";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.btnAdjustUser);
            this.panel14.Controls.Add(this.btnDelUser);
            this.panel14.Controls.Add(this.btnAddUser);
            this.panel14.Location = new System.Drawing.Point(9, 70);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(117, 502);
            this.panel14.TabIndex = 5;
            // 
            // btnAdjustUser
            // 
            this.btnAdjustUser.Location = new System.Drawing.Point(3, 398);
            this.btnAdjustUser.Name = "btnAdjustUser";
            this.btnAdjustUser.Size = new System.Drawing.Size(111, 78);
            this.btnAdjustUser.TabIndex = 2;
            this.btnAdjustUser.Text = "Sửa";
            this.btnAdjustUser.UseVisualStyleBackColor = true;
            // 
            // btnDelUser
            // 
            this.btnDelUser.Location = new System.Drawing.Point(3, 218);
            this.btnDelUser.Name = "btnDelUser";
            this.btnDelUser.Size = new System.Drawing.Size(111, 78);
            this.btnDelUser.TabIndex = 1;
            this.btnDelUser.Text = "Xóa";
            this.btnDelUser.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(3, 33);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(111, 78);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 638);
            this.Controls.Add(this.tcAdmin);
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.tcAdmin.ResumeLayout(false);
            this.tpBill.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tpFood.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpUser.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private Panel panel2;
        private Button btnDate;
        private DateTimePicker dtpkDate;
        private Panel panel1;
        private DataGridView dgvBill;
        private TabPage tpFood;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Button btnAdjustFood;
        private Button btnDelFood;
        private Button btnAddFood;
        private Panel panel3;
        private TabPage tpUser;
        private Button btnFindFood;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Panel panel8;
        private TextBox textBox2;
        private Label label2;
        private Panel panel7;
        private TextBox txtFoodID;
        private Label label1;
        private Panel panel9;
        private TextBox txtFoodPrice;
        private Label label3;
        private Panel panel15;
        private DataGridView dataGridView2;
        private Panel panel10;
        private Panel panel11;
        private TextBox txtPassword;
        private Label label4;
        private Panel panel12;
        private TextBox txtDisplayname;
        private Label label5;
        private Panel panel13;
        private TextBox txtUsername;
        private Label label6;
        private Panel panel14;
        private Button btnAdjustUser;
        private Button btnDelUser;
        private Button btnAddUser;
    }
}