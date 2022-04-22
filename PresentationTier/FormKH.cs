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
    public partial class FormKH : Form
    {
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001";
        string query_select = "SELECT * FROM hfc.khachhang";
        public FormKH()
        {
            InitializeComponent();
        }

        private void FormKH_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(strconn);
                conn.Open();
                adap = new MySqlDataAdapter(query_select, conn);
                cmd = new MySqlCommandBuilder(adap);
                mytable = new DataTable();
                adap.Fill(mytable);
                conn.Close();
                dgvKH.DataSource = mytable;
            }
            catch (MySqlException)
            {

                MessageBox.Show("Lỗi kết nối MySQL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_insert = "INSERT INTO hfc.khachhang (TenKH,DiaChiKH,SDT_KH) VALUES ('" + txtNameKH.Text + "','" + txtDiaChiKH.Text + "','" + txtSDT_KH.Text + "')";
            MySqlCommand command = new MySqlCommand(query_insert, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }

        private void btnDelKH_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_delete = "DELETE FROM hfc.khachhang WHERE ID_KH = '" + int.Parse(txtID_KH.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_delete, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }

        private void btnEditKH_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_edit = "UPDATE hfc.khachhang SET TenKH ='" + txtNameKH.Text + "', DiaChiKH ='" + txtDiaChiKH.Text + "',SDT_KH ='" + txtSDT_KH.Text + "' WHERE ID_NV = '" + int.Parse(txtID_KH.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_edit, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        private void Read_Data()
        {
            conn.Open();
            adap = new MySqlDataAdapter(query_select, conn);
            cmd = new MySqlCommandBuilder(adap);
            mytable = new DataTable();
            adap.Fill(mytable);
            conn.Close();
            dgvKH.DataSource = mytable;
        }
        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKH.Rows[e.RowIndex];
            txtID_KH.Text = Convert.ToString(row.Cells["ID_KH"].Value);
            txtNameKH.Text = Convert.ToString(row.Cells["TenKH"].Value);
            txtDiaChiKH.Text = Convert.ToString(row.Cells["DiaChiKH"].Value);
            txtSDT_KH.Text = Convert.ToString(row.Cells["SDT_KH"].Value);
        }
    }
}
