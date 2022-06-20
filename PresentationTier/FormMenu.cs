using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using QLHFC.Classes;

namespace QLHFC.PresentationTier
{
    public partial class FormMenu : Form
    {
        //Khai báo phân quyền
        string ID_NV = "", TenNV = "", DiaChiNV = "", SDT_NV = "", Username = "", Password = "", AnhNV = "";
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001";
        public FormMenu()
        {
            InitializeComponent();

        }
        //Constructor
        public FormMenu(String ID_NV, String TenNV, String DiaChiNV, String SDT_NV, String Username, String Password, String AnhNV)
        {
            InitializeComponent();
            this.ID_NV = ID_NV;
            this.TenNV = TenNV;
            this.DiaChiNV = DiaChiNV;
            this.SDT_NV = SDT_NV;
            this.Username = Username;
            this.Password = Password;
            this.AnhNV = AnhNV;
        }
        private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon f = new FormHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void tTNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTNV f = new TTNV();
            f.MdiParent = this;
            f.Show();
        }

        private void dSHOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHDNV f = new FormHDNV();
            f.MdiParent = this;
            f.Show();
        }

        private void hÓAĐƠNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTaoHD f = new FormTaoHD();
            f.MdiParent = this;
            f.Show();
        }


        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strconn);
            conn.Open();
            string updatetime = "insert into hfc.time(TenNV,TimeDangXuat) VALUES ('" + UserDetails.Tennv + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";
            MySqlCommand command = new MySqlCommand(updatetime, conn);
            command.ExecuteNonQuery();
            conn.Close();
            FormLogin f = new FormLogin();
            f.Show();
            this.Close();
        }
        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNV f = new FormNV();
            f.MdiParent = this;
            f.Show();
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKH f = new FormKH();
            f.MdiParent = this;
            f.Show();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            toolStripStatusLabel1.Text =  "Chào mừng đến với chương trình, Nhân viên:";
            toolStripStatusLabel2.Text = TenNV;
            conn = new MySqlConnection(strconn);
            conn.Open();
            string inserttime = "insert into hfc.time(TenNV,TimeDangNhap) VALUES ('" + UserDetails.Tennv + "','" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')";
            MySqlCommand command = new MySqlCommand(inserttime, conn);
            command.ExecuteNonQuery();
            conn.Close();
            //Phân quyền
            if (Username != "admin")
            {
                nHÂNVIÊNToolStripMenuItem.Visible = false;
                tHỰCĐƠNToolStripMenuItem.Visible = false;
                hÓAĐƠNToolStripMenuItem.Visible = false;
            }
            else
            {
                dSHOAToolStripMenuItem.Visible = false;
            }
        }
        private void tHỰCĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThucDon f = new FormThucDon();
            f.MdiParent = this;
            f.Show();
        }
    }
}
