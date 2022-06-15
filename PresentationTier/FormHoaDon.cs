using MySql.Data.MySqlClient;
using System.Data;

namespace QLHFC.PresentationTier
{
    public partial class FormHoaDon : Form
    {
        //Khai báo và kết nối MySQL
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001;";
        string query_select = "SELECT * FROM hfc.hoadon";
        string query_select_KH = "SELECT * FROM hfc.khachhang";
        public FormHoaDon()
        {
            InitializeComponent();
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            //Show database
            //txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy H:mm");
            try
            {
                conn = new MySqlConnection(strconn);
                conn.Open();
                adap = new MySqlDataAdapter(query_select, conn);
                cmd = new MySqlCommandBuilder(adap);
                mytable = new DataTable();
                adap.Fill(mytable);
                MySqlCommand loadkh = new MySqlCommand(query_select_KH, conn);
                MySqlDataReader readkh = loadkh.ExecuteReader();
                while (readkh.Read())
                {
                    cmbKH.Items.Add(readkh[1]);
                }
                conn.Close();
                dgvHD.DataSource = mytable;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Lỗi kết nối MySQL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.dgvHD.Columns["TenMonAn"].Visible = false;
            this.dgvHD.Columns["SL"].Visible = false;
            this.dgvHD.Columns["Gia"].Visible = false;
            this.dgvHD.Columns["KhuyenMai"].Visible = false;
            this.dgvHD.Columns["TongTien"].Visible = false;
            txtTenMon.Visible = false;
            txtSL.Visible = false;
            txtGia.Visible = false;
            txtKM.Visible = false;
            txtTongtien.Visible = false;
            txtNV.ReadOnly = true;
        }
        //Cập nhật dữ liệu tức thời
        private void Read_Data()
        {
            conn.Open();
            adap = new MySqlDataAdapter(query_select, conn);
            cmd = new MySqlCommandBuilder(adap);
            mytable = new DataTable();
            adap.Fill(mytable);
            conn.Close();
            dgvHD.DataSource = mytable;
        }
        //Hàm thêm
        private void btnCreateHoaDon_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    conn.Open();
            //    string query_insert = "INSERT INTO hfc.hoadon (TenKH,TenNV,Ngay) VALUES ('" + cmbKH.Text + "','" + cmbNV.Text+ "','" + DateTime.Now.ToString(txtDate.Text) + "')";
            //    MySqlCommand command = new MySqlCommand(query_insert, conn);
            //    command.ExecuteNonQuery();
            //    conn.Close();
            //    Read_Data();
            //}
            //catch (MySqlException)
            //{
            //    MessageBox.Show("Lỗi kết nối MySQL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        //Hàm xóa
        private void btnDelHD_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_delete = "DELETE FROM hfc.hoadon WHERE ID_HD = '" + int.Parse(txtID_HD.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_delete, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        //Hàm sửa
        private void btnUpdateHD_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_edit = "UPDATE hfc.hoadon SET TenKH ='" + cmbKH.Text + "', TenNV ='" + txtNV.Text + "' WHERE ID_HD = '" + int.Parse(txtID_HD.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_edit, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }

        //Đọc dữ liệu từ datagridview ra textbox/combobox/picturebox
        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHD.Rows[e.RowIndex];
            txtID_HD.Text = Convert.ToString(row.Cells["ID_HD"].Value);
            cmbKH.Text = Convert.ToString(row.Cells["TenKH"].Value);
            txtNV.Text = Convert.ToString(row.Cells["TenNV"].Value);
            txtDate.Text = Convert.ToString(row.Cells["Ngay"].Value);
            txtTenMon.Text = Convert.ToString(row.Cells["TenMonAn"].Value);
            txtSL.Text = Convert.ToString(row.Cells["SL"].Value);
            txtGia.Text = Convert.ToString(row.Cells["Gia"].Value);
            txtKM.Text = Convert.ToString(row.Cells["KhuyenMai"].Value);
            txtTongtien.Text = Convert.ToString(row.Cells["TongTien"].Value);
            Read_Data();
        }
        //Mở FormCTHD
        private void button1_Click(object sender, EventArgs e)
        {
            FormCTHD f = new FormCTHD();
            f.Show();
        }
        //Hàm tìm kiếm
        private void txtSearchHD_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query_search = "SELECT * FROM hfc.hoadon WHERE " + cmbSearchHD.Text + " like '%" + txtSearchHD.Text + "%'";
            MySqlCommand command = new MySqlCommand(query_search, conn);
            command.ExecuteNonQuery();
            adap = new MySqlDataAdapter(command);
            mytable = new DataTable();
            adap.Fill(mytable);
            conn.Close();
            dgvHD.DataSource = mytable;
        }
        //Hàm in
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgvHD.Width, this.dgvHD.Height);
            dgvHD.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgvHD.Width, this.dgvHD.Height));
            e.Graphics.DrawImage(bmp, 0, 140);
            e.Graphics.DrawString("Danh sách Hóa đơn", new Font("Arial", 40, FontStyle.Bold), Brushes.Red, new Point(150, 0));
            e.Graphics.DrawString("_________________________________________________________", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, new Point(0, 40));
            e.Graphics.DrawString("Ngày in Danh sách Hóa đơn: " + DateTime.Now.ToString("dd-MM-yyy hh:mm"), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, 70));
        }

        private void txtID_HD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
