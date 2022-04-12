namespace QLHFC
{
    partial class FormBill
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dgvInfoBill = new System.Windows.Forms.DataGridView();
            this.colBill_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnameUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoBill)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dgvInfoBill, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgvBill, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBill_ID,
            this.colnameUser,
            this.colTotalPrice,
            this.colDatetime});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(3, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 29;
            this.dgvBill.Size = new System.Drawing.Size(770, 207);
            this.dgvBill.TabIndex = 0;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // dgvInfoBill
            // 
            this.dgvInfoBill.AllowUserToAddRows = false;
            this.dgvInfoBill.AllowUserToDeleteRows = false;
            this.dgvInfoBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfoBill.Location = new System.Drawing.Point(3, 216);
            this.dgvInfoBill.Name = "dgvInfoBill";
            this.dgvInfoBill.ReadOnly = true;
            this.dgvInfoBill.RowHeadersWidth = 51;
            this.dgvInfoBill.Size = new System.Drawing.Size(770, 207);
            this.dgvInfoBill.TabIndex = 1;
            // 
            // colBill_ID
            // 
            this.colBill_ID.HeaderText = "Số hóa đơn";
            this.colBill_ID.MinimumWidth = 6;
            this.colBill_ID.Name = "colBill_ID";
            this.colBill_ID.ReadOnly = true;
            // 
            // colnameUser
            // 
            this.colnameUser.HeaderText = "Tên khách hàng";
            this.colnameUser.MinimumWidth = 6;
            this.colnameUser.Name = "colnameUser";
            this.colnameUser.ReadOnly = true;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.HeaderText = "Tổng tiền";
            this.colTotalPrice.MinimumWidth = 6;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.ReadOnly = true;
            // 
            // colDatetime
            // 
            this.colDatetime.HeaderText = "Ngày mua";
            this.colDatetime.MinimumWidth = 6;
            this.colDatetime.Name = "colDatetime";
            this.colDatetime.ReadOnly = true;
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvInfoBill;
        private DataGridView dgvBill;
        private DataGridViewTextBoxColumn colBill_ID;
        private DataGridViewTextBoxColumn colnameUser;
        private DataGridViewTextBoxColumn colTotalPrice;
        private DataGridViewTextBoxColumn colDatetime;
    }
}