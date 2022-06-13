using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QLHFC.Classes;

namespace QLHFC.PresentationTier
{
    public partial class FormCTHD : Form
    {
        //khai báo và kết nối MySQL
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001;";
        string query_select_TD = "SELECT * FROM hfc.thucdon";
        string query_select_HD = "SELECT * FROM hfc.hoadon";
        public FormCTHD()
        {
            InitializeComponent();
        }

        private void FormCTHD_Load(object sender, EventArgs e)
        {
            //Show Database
            conn = new MySqlConnection(strconn);
            conn.Open();
            adap = new MySqlDataAdapter(query_select_HD, conn);
            cmd = new MySqlCommandBuilder(adap);
            mytable = new DataTable();
            adap.Fill(mytable);
            MySqlCommand loadtd = new MySqlCommand(query_select_TD, conn);
            MySqlDataReader readtd = loadtd.ExecuteReader();

            while (readtd.Read())
            {
                cmbTD.Items.Add(readtd[1]);
            }
            conn.Close();
            dgvCTHD.DataSource = mytable;
            this.dgvCTHD.Columns["TenKH"].Visible = false;
            this.dgvCTHD.Columns["TenNV"].Visible = false;
            this.dgvCTHD.Columns["Ngay"].Visible = false;
            if(UserDetails.UserName != "admin")
            {
                btnAddCTHD.Enabled = false;
                btnDelCTHD.Enabled = false;
                btnPreview.Enabled = false;
                cmbTD.Enabled = false;
                txtPrice.Enabled = false;
            }
        }
        //Cập nhật dữ liệu tức thời
        private void Read_Data()
        {
            conn.Open();
            adap = new MySqlDataAdapter(query_select_HD, conn);
            cmd = new MySqlCommandBuilder(adap);
            mytable = new DataTable();
            adap.Fill(mytable);
            conn.Close();
            dgvCTHD.DataSource = mytable;
        }
        //Hàm thêm
        private void btnAddCTHD_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_edit = "UPDATE hfc.hoadon SET TenMonAn ='" + cmbTD.Text + "', SL ='" + txtSL.Text + "', Gia = '"+txtPrice.Text+"', KhuyenMai = '"+txtGiamGia.Text+"', TongTien = '"+txtTotal.Text+"' WHERE ID_HD = '" + int.Parse(txtID_HD.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_edit, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
            //conn.Open();
            //DateTime theDate = DateTime.Now;
            //theDate.ToString("dd/MM/yyyy H:mm:ss");
            //string query_insert = "INSERT INTO hfc.cthd (ID_HD,TenMonAn,SL,Gia,KhuyenMai,TongTien) VALUES ('" + cmbID_HD.Text + "','" + cmbTD.Text + "','" + txtSL.Text + "','" + cmbPrice.Text + "','" + txtGiamGia.Text + "%','" + txtTotal.Text + "')";
            //MySqlCommand command = new MySqlCommand(query_insert, conn);
            //command.ExecuteNonQuery();
            //conn.Close();
            //Read_Data();
        }
        //Hàm tính khuyến mãi
        private void cmbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //Hàm xóa
        private void btnDelCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query_delete = "DELETE FROM hfc.cthd WHERE ID_HD = '" + int.Parse(txtID_HD.Text) + "'";
                MySqlCommand command = new MySqlCommand(query_delete, conn);
                command.ExecuteNonQuery();
                conn.Close();
                Read_Data();
            }
            catch(MySqlException)
            {
                MessageBox.Show("Vui lòng chọn ID Hóa Đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Hàm in
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgvCTHD.Width, this.dgvCTHD.Height);
            dgvCTHD.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgvCTHD.Width, this.dgvCTHD.Height));
            e.Graphics.DrawImage(bmp, 100, 140);
            e.Graphics.DrawString("Danh sách Chi tiết hóa đơn", new Font("Arial", 40, FontStyle.Bold), Brushes.Red, new Point(70, 0));
            e.Graphics.DrawString("_________________________________________________________", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, new Point(0, 40));
            //e.Graphics.DrawString("ID_HD: " + dgvCTHD.DataSource, new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new Point(0, 50));
            e.Graphics.DrawString("Ngày in Danh sách CTHD: " + DateTime.Now.ToString("dd-MM-yyy hh:mm"), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, 70));
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvCTHD.Rows[e.RowIndex];
            txtID_HD.Text = Convert.ToString(row.Cells["ID_HD"].Value);
            cmbTD.Text = Convert.ToString(row.Cells["TenMonAn"].Value);
            txtSL.Text = Convert.ToString(row.Cells["SL"].Value);
            txtPrice.Text = Convert.ToString(row.Cells["Gia"].Value);
            txtTotal.Text = Convert.ToString(row.Cells["TongTien"].Value);
            Read_Data();
        }

        private void cmbTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strconn);
            conn.Open();
            string query_select_price = "Select * from hfc.thucdon where TenMonAn = '" + cmbTD.Text + "'";
            MySqlCommand command = new MySqlCommand(query_select_price, conn);
            MySqlDataReader readprice = command.ExecuteReader();
            if (readprice.Read())
            {
                txtPrice.Text = readprice[2].ToString();
            }
            conn.Close();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tongTien = 0;
                if (txtGiamGia.Text == "0")
                {
                    tongTien = (decimal)(int.Parse(txtSL.Text) * decimal.Parse(txtPrice.Text));
                }
                else
                {
                    tongTien = (decimal)(int.Parse(txtSL.Text) * decimal.Parse(txtPrice.Text)) - (decimal)(int.Parse(txtSL.Text) * decimal.Parse(txtPrice.Text) * int.Parse(txtGiamGia.Text) / 100);
                }
                txtTotal.Text = tongTien.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập Số khuyến mãi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
