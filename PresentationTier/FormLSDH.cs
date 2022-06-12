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
    public partial class FormLSDH : Form
    {
        //Khai báo và kết nối MySQL
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001";
        
        public FormLSDH()
        {
            InitializeComponent();
        }

        private void FormLSDH_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(strconn);
                conn.Open();
                string query_select = "SELECT * FROM hfc.hoadon where TenKH = '" + LSDH.Tenkh + "'";
                adap = new MySqlDataAdapter(query_select, conn);
                cmd = new MySqlCommandBuilder(adap);
                mytable = new DataTable();
                adap.Fill(mytable);
                conn.Close();
                dgvLSDH.DataSource = mytable;
            }
            catch (MySqlException)
            {

                MessageBox.Show("Lỗi kết nối MySQL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.dgvLSDH.Columns["TenKH"].Visible = false;
        }
    }
}
