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

namespace QLHFC.PresentationTier
{
    public partial class FormCTHD : Form
    {
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001;";
        string query_select = "SELECT * FROM hfc.cthd";
        string query_select_TD = "SELECT * FROM hfc.thucdon";
        string query_select_HD = "SELECT * FROM hfc.hoadon";
        public FormCTHD()
        {
            InitializeComponent();
        }

        private void FormCTHD_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strconn);
            conn.Open();
            adap = new MySqlDataAdapter(query_select, conn);
            cmd = new MySqlCommandBuilder(adap);
            mytable = new DataTable();
            adap.Fill(mytable);
            MySqlCommand loadtd = new MySqlCommand(query_select_TD, conn);
            MySqlDataReader readtd = loadtd.ExecuteReader();

            while (readtd.Read())
            {
                cmbTD.Items.Add(readtd[1]);
                cmbPrice.Items.Add(readtd[2]);
            }
            conn.Close();
            conn.Open();
            MySqlCommand loadhd = new MySqlCommand(query_select_HD, conn);
            MySqlDataReader readhd = loadhd.ExecuteReader();

            while (readhd.Read())
            {
                cmbID_HD.Items.Add(readhd[0]);
            }
            conn.Close();
            dgvCTHD.DataSource = mytable;
            txtGiamGia.Text = "0";
        }
        private void Read_Data()
        {
            conn.Open();
            adap = new MySqlDataAdapter(query_select, conn);
            cmd = new MySqlCommandBuilder(adap);
            mytable = new DataTable();
            adap.Fill(mytable);
            conn.Close();
            dgvCTHD.DataSource = mytable;
        }
        private void btnAddCTHD_Click(object sender, EventArgs e)
        {
            conn.Open();
            DateTime theDate = DateTime.Now;
            theDate.ToString("dd/MM/yyyy H:mm:ss");
            string query_insert = "INSERT INTO hfc.cthd (ID_HD,TenMonAn,SL,Gia,KhuyenMai,TongTien) VALUES ('" + cmbID_HD.Text + "','" + cmbTD.Text + "','" + txtSL.Text + "','" + cmbPrice.Text + "','" + txtGiamGia.Text + "%','" + txtTotal.Text + "')";
            MySqlCommand command = new MySqlCommand(query_insert, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        private void cmbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tongTien = 0;
                decimal TienGiam = 0;
                if (txtGiamGia.Text == "0")
                {
                    tongTien = (decimal)(int.Parse(txtSL.Text) * decimal.Parse(cmbPrice.Text));
                }
                else
                {
                    tongTien = (decimal)(int.Parse(txtSL.Text) * decimal.Parse(cmbPrice.Text)) - (decimal)(int.Parse(txtSL.Text) * decimal.Parse(cmbPrice.Text) * int.Parse(txtGiamGia.Text) / 100);
                }
                txtTotal.Text = tongTien.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập Số lượng trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query_delete = "DELETE FROM hfc.cthd WHERE ID_HD = '" + int.Parse(cmbID_HD.Text) + "'";
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
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgvCTHD.Width, this.dgvCTHD.Height);
            dgvCTHD.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgvCTHD.Width, this.dgvCTHD.Height));
            e.Graphics.DrawImage(bmp, 100, 140);
            e.Graphics.DrawString("Chi tiết hóa đơn", new Font("Arial", 40, FontStyle.Bold), Brushes.Red, new Point(220, 30));
            e.Graphics.DrawString("_________________________________________________________", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, new Point(0, 40));
            //e.Graphics.DrawString("ID_HD: " + dgvCTHD.DataSource, new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new Point(0, 50));
            e.Graphics.DrawString("Ngày in CTHD: " + DateTime.Now.ToString("dd-MM-yyy hh:mm"), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 110));
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
