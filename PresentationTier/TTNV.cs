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
    public partial class TTNV : Form
    {
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001";
        string query_select = "SELECT AnhNV FROM hfc.nhanvien where Username = '" +UserDetails.UserName+ "'";
        public TTNV()
        {
            InitializeComponent();
        }

        private void TTNV_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(strconn);
            conn.Open();
            adap = new MySqlDataAdapter(query_select, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            if(ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["AnhNV"]);
                pictureBox1.Image = new Bitmap(ms);
            }
            conn.Close();
            txtName_NV.Text = UserDetails.Tennv;
            txtAddress_NV.Text = UserDetails.Diachi;
            txtSDT_NV.Text = UserDetails.Sdt;
        }
    }
}
