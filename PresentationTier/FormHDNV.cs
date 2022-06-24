using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QLHFC.Classes;

namespace QLHFC.PresentationTier
{
    public partial class FormHDNV : Form
    {
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001;";
        string query_select_HD_TheoNV = "SELECT * FROM hfc.hoadon where TenNV = '" + UserDetails.Tennv + "'";
        public FormHDNV()
        {
            InitializeComponent();
        }

        private void FormHDNV_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strconn);
            conn.Open();
            adap = new MySqlDataAdapter(query_select_HD_TheoNV, conn);
            cmd = new MySqlCommandBuilder(adap);
            mytable = new DataTable();
            adap.Fill(mytable);
            conn.Close();
            dgvHD.DataSource = mytable;
            dgvCTHD.DataSource = mytable;
            this.dgvHD.Columns["TenMonAn"].Visible = false;
            this.dgvHD.Columns["SL"].Visible = false;
            this.dgvHD.Columns["Gia"].Visible = false;
            this.dgvHD.Columns["KhuyenMai"].Visible = false;
            this.dgvHD.Columns["TongTien"].Visible = false;
            this.dgvCTHD.Columns["TenKH"].Visible = false;
            this.dgvCTHD.Columns["TenNV"].Visible = false;
            this.dgvCTHD.Columns["Ngay"].Visible = false;
            this.dgvCTHD.Columns["ID_HD"].Visible = false;
            txtTenMon.Visible = false;
            txtSL.Visible = false;
            txtGia.Visible = false;
            txtKM.Visible = false;
            txtTongtien.Visible = false;
            txtNV.Visible = false;
            dgvHD.Columns[0].HeaderText = "ID Hóa đơn";
            dgvHD.Columns[1].HeaderText = "Tên Khách hàng";
            dgvHD.Columns[2].HeaderText = "Tên Nhân viên";
            dgvHD.Columns[3].HeaderText = "Ngày lập";
            dgvCTHD.Columns[4].HeaderText = "Tên món ăn";
            dgvCTHD.Columns[5].HeaderText = "Số lượng";
            dgvCTHD.Columns[6].HeaderText = "Giá món";
            dgvCTHD.Columns[7].HeaderText = "Khuyến mãi";
            dgvCTHD.Columns[8].HeaderText = "Tổng tiền";
            pictureBox1.Visible = false;
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHD.Rows[e.RowIndex];
            txtID_HD.Text = Convert.ToString(row.Cells["ID_HD"].Value);
            txtKH.Text = Convert.ToString(row.Cells["TenKH"].Value);
            txtNV.Text = Convert.ToString(row.Cells["TenNV"].Value);
            txtDate.Text = Convert.ToString(row.Cells["Ngay"].Value);
            txtTenMon.Text = Convert.ToString(row.Cells["TenMonAn"].Value);
            txtSL.Text = Convert.ToString(row.Cells["SL"].Value);
            txtGia.Text = Convert.ToString(row.Cells["Gia"].Value);
            txtKM.Text = Convert.ToString(row.Cells["KhuyenMai"].Value);
            txtTongtien.Text = Convert.ToString(row.Cells["TongTien"].Value);
        }

        private void txtTenMon_TextChanged(object sender, EventArgs e)
        {

        }
        //
        //Hàm in
        //
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if(pictureBox1.Visible == false)
            {
                e.Graphics.DrawString("Hóa đơn", new Font("Arial", 40, FontStyle.Bold), Brushes.Red, new Point(300, 30));
                e.Graphics.DrawString("_________________________________________________________", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, new Point(0, 40));
                e.Graphics.DrawString("Ngày in Hóa đơn: " + DateTime.Now.ToString("dd-MM-yyy hh:mm"), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, 70));
                e.Graphics.DrawString("Số Hóa đơn: " + txtID_HD.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 120));
                e.Graphics.DrawString("Họ tên Khách hàng: " + txtKH.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 150));
                e.Graphics.DrawString("Nhân viên lập hóa đơn: " + txtNV.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 180));
                e.Graphics.DrawString("Ngày lập Hóa đơn: " + txtDate.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(500, 120));
                e.Graphics.DrawString("Tên món ăn ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 210));
                e.Graphics.DrawString("Giá món ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(750, 210));
                e.Graphics.DrawString("Số lượng ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(270, 210));
                e.Graphics.DrawString("Khuyến mãi ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(500, 210));
                e.Graphics.DrawString("" + txtTenMon.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 230));
                e.Graphics.DrawString("" + txtGia.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(755, 230));
                e.Graphics.DrawString("" + txtSL.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(300, 230));
                e.Graphics.DrawString("" + txtKM.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(540, 230));
                e.Graphics.DrawString("_________________________________________________________", new Font("Arial", 40, FontStyle.Regular), Brushes.Black, new Point(0, 200));
                e.Graphics.DrawString("Thành tiền: " + txtTongtien.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(650, 270));
            }
            else
            {
                e.Graphics.DrawString("Hóa đơn", new Font("Arial", 40, FontStyle.Bold), Brushes.Red, new Point(300, 30));
                e.Graphics.DrawString("_________________________________________________________", new Font("Arial", 40, FontStyle.Bold), Brushes.Black, new Point(0, 40));
                e.Graphics.DrawString("Ngày in Hóa đơn: " + DateTime.Now.ToString("dd-MM-yyy hh:mm"), new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(600, 70));
                e.Graphics.DrawString("Số Hóa đơn: " + txtID_HD.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 120));
                e.Graphics.DrawString("Họ tên Khách hàng: " + txtKH.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 150));
                e.Graphics.DrawString("Nhân viên lập hóa đơn: " + txtNV.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 180));
                e.Graphics.DrawString("Ngày lập Hóa đơn: " + txtDate.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(500, 120));
                e.Graphics.DrawString("Tên món ăn ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 210));
                e.Graphics.DrawString("Giá món ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(750, 210));
                e.Graphics.DrawString("Số lượng ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(270, 210));
                e.Graphics.DrawString("Khuyến mãi ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(500, 210));
                e.Graphics.DrawString("" + txtTenMon.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(0, 230));
                e.Graphics.DrawString("" + txtGia.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(755, 230));
                e.Graphics.DrawString("" + txtSL.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(300, 230));
                e.Graphics.DrawString("" + txtKM.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(540, 230));
                e.Graphics.DrawString("_________________________________________________________", new Font("Arial", 40, FontStyle.Regular), Brushes.Black, new Point(0, 200));
                e.Graphics.DrawString("Thành tiền: " + txtTongtien.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(650, 270));
                e.Graphics.DrawString("Momo ", new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(700, 300));
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                e.Graphics.DrawImage(bmp, 630, 320);
                bmp.Dispose();
            }
            
        }
        //
        //Quét QR
        //
        private void btnQR_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            //Zen.Barcode.CodeQrBarcodeDraw codeQr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            //var qrText = txtID_HD.Text + "|" +
            //txtKH.Text + "|" +
            //txtNV.Text + "|" +
            //txtDate.Text + "|" +
            //txtTenMon.Text + "|" +
            ////txtGia.Text /*+ "|" +*/
            //txtSL.Text; /*+ "|" +*/
            ////txtKM.Text; /*+ "|" +*/
            ////Convert.ToString(txtTongtien.Text);
            //pictureBox1.Image = codeQr.Draw(qrText, 60);
            ////pictureBox1.Image = codeQr.Draw("{" + '"' + "Số Hóa đơn" + '"' + ":" + '"' + txtID_HD.Text + '"' + "," + '"' + "Họ tên Khách hàng" + '"' + ":" + '"' + txtKH.Text + '"' + "," + '"' + "Nhân viên lập hóa đơn" + '"' + ":" + '"' + txtNV.Text + '"' + '"' + "Ngày lập Hóa đơn" + '"' + ":" + '"' + txtDate.Text + "," + '"' + "Tên Món Ăn" + '"' + ":" + '"' + txtTenMon.Text + "," + '"' + "Giá món" + '"' + ":" + '"' + txtGia.Text + "," + '"' + "Số lượng" + '"' + ":" + '"' + txtSL.Text + "," + '"' + "Khuyến mãi" + '"' + ":" + '"' + txtKM.Text + "," + '"' + "Thành tiền" + '"' + ":" + '"' + txtTongtien.Text + '"' + "}", 900);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void PrintPic(object sender, PrintPageEventArgs e)
        {

        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
