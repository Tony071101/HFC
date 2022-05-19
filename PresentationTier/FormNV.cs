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
    public partial class FormNV : Form
    {
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001";
        string query_select = "SELECT * FROM hfc.nhanvien";
        public FormNV()
        {
            InitializeComponent();
        }
        private void FormNV_Load(object sender, EventArgs e)
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
                dgvNV.DataSource = mytable;
            }
            catch (MySqlException)
            {

                MessageBox.Show("Lỗi kết nối MySQL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvNV.Columns[6];
            pic.ImageLayout = DataGridViewImageCellLayout.Stretch;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] pt = ms.ToArray();
            conn.Open();
            string query_insert = "INSERT INTO hfc.nhanvien (TenNV,DiaChiNV,SDT_NV,Username,Password,AnhNV) VALUES ('" + txtName_NV.Text + "','" + txtAddress_NV.Text + "','" + txtSDT_NV.Text + "','" + txtUsername_NV.Text + "','" + txtPassword_NV.Text + "', @AnhNV)";
            MySqlCommand command = new MySqlCommand(query_insert, conn);
            command.Parameters.Add("@AnhNV", MySqlDbType.LongBlob);
            command.Parameters["@AnhNV"].Value = pt;
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
            dgvNV.DataSource = mytable;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] pt = ms.ToArray();
            conn.Open();
            string query_edit = "UPDATE hfc.nhanvien SET TenNV ='" + txtName_NV.Text + "', DiaChiNV ='" + txtAddress_NV.Text + "',SDT_NV ='" + txtSDT_NV.Text + "',Username ='" + txtUsername_NV.Text + "',Password ='" + txtPassword_NV.Text + "', AnhNV = @AnhNV WHERE ID_NV = '" + int.Parse(txtID_NV.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_edit, conn);
            command.Parameters.Add("@AnhNV", MySqlDbType.LongBlob);
            command.Parameters["@AnhNV"].Value = pt;
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_delete = "DELETE FROM hfc.nhanvien WHERE ID_NV = '" + int.Parse(txtID_NV.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_delete, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNV.Rows[e.RowIndex];
            txtID_NV.Text = Convert.ToString(row.Cells["ID_NV"].Value);
            txtName_NV.Text = Convert.ToString(row.Cells["TenNV"].Value);
            txtAddress_NV.Text = Convert.ToString(row.Cells["DiaChiNV"].Value);
            txtSDT_NV.Text = Convert.ToString(row.Cells["SDT_NV"].Value);
            txtUsername_NV.Text = Convert.ToString(row.Cells["Username"].Value);
            txtPassword_NV.Text = Convert.ToString(row.Cells["Password"].Value);
            if (Convert.ToString(row.Cells["AnhNV"].Value) != "")
            {
                MemoryStream ms = new MemoryStream((byte[])row.Cells["AnhNV"].Value);
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query_search = "SELECT * FROM hfc.nhanvien WHERE " + cmbSearch.Text + " like '%" + txtSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(query_search, conn);
            command.ExecuteNonQuery();
            adap = new MySqlDataAdapter(command);
            mytable = new DataTable();
            adap.Fill(mytable);
            conn.Close();
            dgvNV.DataSource = mytable;
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            odf.Title = "Chọn ảnh";
            odf.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (odf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = odf.FileName;
            }
        }
        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
