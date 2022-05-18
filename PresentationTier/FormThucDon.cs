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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace QLHFC.PresentationTier
{
    public partial class FormThucDon : Form
    {
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001";
        string query_select = "SELECT * FROM hfc.thucdon";
        public FormThucDon()
        {
            InitializeComponent();
        }

        private void FormThucDon_Load(object sender, EventArgs e)
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
                dgvThucDon.DataSource = mytable;
            }
            catch (MySqlException)
            {

                MessageBox.Show("Lỗi kết nối MySQL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_insert = "INSERT INTO hfc.thucdon (TenMonAn,Gia) VALUES ('" + txtTenMon.Text + "','" + txtGia.Text + "')";
            MySqlCommand command = new MySqlCommand(query_insert, conn);
            command.Parameters.Add("img", MySqlDbType.LongBlob);
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
            dgvThucDon.DataSource = mytable;
        }
        private void btnDelFood_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_delete = "DELETE FROM hfc.thucdon WHERE ID_MonAn = '" + int.Parse(txtIDMon.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_delete, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_edit = "UPDATE hfc.thucdon SET TenMonAn ='" + txtTenMon.Text + "', Gia ='" + txtGia.Text + "' WHERE ID_MonAn = '" + int.Parse(txtIDMon.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_edit, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        private void dgvThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvThucDon.Rows[e.RowIndex];
            txtIDMon.Text = Convert.ToString(row.Cells["ID_MonAn"].Value);
            txtTenMon.Text = Convert.ToString(row.Cells["TenMonAn"].Value);
            txtGia.Text = Convert.ToString(row.Cells["Gia"].Value);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query_search = "SELECT * FROM hfc.thucdon WHERE " + cmbSearchMonAn.Text + " like '%" + txtSearchMonAn.Text + "%'";
            MySqlCommand command = new MySqlCommand(query_search, conn);
            command.ExecuteNonQuery();
            adap = new MySqlDataAdapter(command);
            mytable = new DataTable();
            adap.Fill(mytable);
            conn.Close();
            dgvThucDon.DataSource = mytable;
        }
    }
}
