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
    public partial class FormTaoHD : Form
    {
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001;";
        string query_select = "SELECT * FROM hfc.hoadon";
        string query_select_KH = "SELECT * FROM hfc.khachhang";
        string query_select_TD = "SELECT * FROM hfc.thucdon";
        public FormTaoHD()
        {
            InitializeComponent();
        }


        private void FormTaoHD_Load(object sender, EventArgs e)
        {
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
                MySqlCommand loadtd = new MySqlCommand(query_select_TD, conn);
                MySqlDataReader readtd = loadtd.ExecuteReader();

                while (readtd.Read())
                {
                    cmbTD.Items.Add(readtd[1]);
                }
                conn.Close();
                txtTenNV.Text = UserDetails.Tennv;
                txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy H:mm");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Lỗi kết nối MySQL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCreateHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query_insert = "INSERT INTO hfc.hoadon (TenKH,TenNV,Ngay,TenMonAn,SL,Gia,KhuyenMai,TongTien) VALUES ('" + cmbKH.Text + "','" + txtTenNV.Text + "','" + DateTime.Now.ToString(txtDate.Text) + "','" +cmbTD.Text+"','"+txtSL.Text+"','"+txtPrice.Text+"','"+txtGiamGia.Text+"%','"+ txtTotal.Text + "')";
                MySqlCommand command = new MySqlCommand(query_insert, conn);
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK);
            }
            catch(MySqlException)
            {
                MessageBox.Show("Không thêm được Hóa đơn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //conn.Open();
            //string query_insert_cthd = "INSERT INTO hfc.cthd (ID_HD,TenMonAn,SL,Gia,KhuyenMai,TongTien) VALUES ('" + cmbID_HD.Text + "','" + cmbTD.Text + "','" + txtSL.Text + "','" + cmbPrice.Text + "','" + txtGiamGia.Text + "%','" + txtTotal.Text + "')";
            //MySqlCommand cmd = new MySqlCommand(query_insert_cthd, conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCTHD f = new FormCTHD();
            f.Show();
        }

        private void cmbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbTD_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strconn);
            conn.Open();
            string query_select_price = "Select * from hfc.thucdon where TenMonAn = '" + cmbTD.Text + "'";
            MySqlCommand command = new MySqlCommand(query_select_price, conn);
            MySqlDataReader readprice = command.ExecuteReader();
            if(readprice.Read())
            {
                txtPrice.Text = readprice[2].ToString();
            }
            conn.Close();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            

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

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
