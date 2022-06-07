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
    public partial class FormMenu : Form
    {
        //Khai báo phân quyền
        string ID_NV = "", TenNV = "", DiaChiNV = "", SDT_NV = "", Username = "", Password = "";
        
        public FormMenu()
        {
            InitializeComponent();

        }
        //Constructor
        public FormMenu(String ID_NV, String TenNV, String DiaChiNV, String SDT_NV, String Username, String Password)
        {
            InitializeComponent();
            this.ID_NV = ID_NV;
            this.TenNV = TenNV;
            this.DiaChiNV = DiaChiNV;
            this.SDT_NV = SDT_NV;
            this.Username = Username;
            this.Password = Password;
        }
        private void hÓAĐƠNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHoaDon f = new FormHoaDon();
            f.MdiParent = this;
            f.Show();
        }
        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            toolStripStatusLabel1.Text =  "Welcome to Hutech Fried Chicken";
            toolStripStatusLabel2.Text = Username;
            //Phân quyền
            if (Username != "admin")
            {
                nHÂNVIÊNToolStripMenuItem.Enabled = false;
                tHỰCĐƠNToolStripMenuItem.Enabled = false;
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
