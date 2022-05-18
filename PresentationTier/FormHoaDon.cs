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
    public partial class FormHoaDon : Form
    {
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001;";
        string query_select = "SELECT * FROM hfc.hoadon";
        string query_select_KH = "SELECT * FROM hfc.khachhang";
        string query_select_NV = "SELECT * FROM hfc.nhanvien";
        public FormHoaDon()
        {
            InitializeComponent();
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy H:mm");
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
                conn.Open();
                MySqlCommand loadnv = new MySqlCommand(query_select_NV, conn);
                MySqlDataReader readnv = loadnv.ExecuteReader();
                while (readnv.Read())
                {
                    cmbNV.Items.Add(readnv[1]);
                }
                conn.Close();
                dgvHD.DataSource = mytable;
            }
            catch (MySqlException)
            {
                MessageBox.Show("Lỗi kết nối MySQL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
        private void btnCreateHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query_insert = "INSERT INTO hfc.hoadon (TenKH,TenNV,Ngay) VALUES ('" + cmbKH.Text + "','" + cmbNV.Text+ "','" + DateTime.Now.ToString(txtDate.Text) + "')";
                MySqlCommand command = new MySqlCommand(query_insert, conn);
                command.ExecuteNonQuery();
                conn.Close();
                Read_Data();
            }
            catch (MySqlException)
            {
                MessageBox.Show("Lỗi kết nối MySQL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDelHD_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_delete = "DELETE FROM hfc.hoadon WHERE ID_HD = '" + int.Parse(txtID_HD.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_delete, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        private void btnUpdateHD_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_edit = "UPDATE hfc.hoadon SET TenKH ='" + cmbKH.Text + "', TenNV ='" + cmbNV.Text + "' WHERE ID_HD = '" + int.Parse(txtID_HD.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_edit, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHD.Rows[e.RowIndex];
            txtID_HD.Text = Convert.ToString(row.Cells["ID_HD"].Value);
            cmbKH.Text = Convert.ToString(row.Cells["TenKH"].Value);
            cmbNV.Text = Convert.ToString(row.Cells["TenNV"].Value);
            Read_Data();
        }
        private void button1_Click(object sender, EventArgs e)
        {
                FormCTHD f = new FormCTHD();
                f.Show();
        }
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.dgvHD.Width, this.dgvHD.Height);
            dgvHD.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgvHD.Width, this.dgvHD.Height));
            e.Graphics.DrawImage(bmp, 0, 120);
            e.Graphics.DrawString("Hóa đơn", new Font("Arial", 40, FontStyle.Bold), Brushes.Red, new Point(300, 30));
            e.Graphics.DrawString("_________________________________________________________", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, new Point(0, 40));
            e.Graphics.DrawString("Ngày in Hóa đơn: " + txtDate.Text, new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, 70));
        }
    }
}
