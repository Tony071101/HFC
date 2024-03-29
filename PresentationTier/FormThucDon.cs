﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
//Test lưu lên Github
//test
namespace QLHFC.PresentationTier
{
    public partial class FormThucDon : Form
    {
        //Khai báo và kết nối MySQL
        MySqlConnection conn;
        MySqlCommandBuilder cmd;
        MySqlDataAdapter adap;
        DataTable mytable;
        string strconn = "Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001";
        string query_select = "SELECT * FROM hfc.thucdon";
        public FormThucDon()
        {
            InitializeComponent();
            this.dgvThucDon.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
        }

        private void FormThucDon_Load(object sender, EventArgs e)
        {
            //Show database
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
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvThucDon.Columns[3];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            //pic.Visible = false;
            MessageBox.Show("Vui lòng chọn hình khi thêm 1 món ăn", "Quy định", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            dgvThucDon.Columns[0].HeaderText = "ID món ăn";
            dgvThucDon.Columns[1].HeaderText = "Tên món ăn";
            dgvThucDon.Columns[2].HeaderText = "Giá món";
            dgvThucDon.Columns[3].HeaderText = "Hình minh họa";
        }
        //Hàm thêm
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] pt = ms.ToArray();
            conn.Open();
            string query_insert = "INSERT INTO hfc.thucdon (TenMonAn,Gia,HinhAnh) VALUES ('" + txtTenMon.Text + "','" + txtGia.Text + "', @HinhAnh)";
            MySqlCommand command = new MySqlCommand(query_insert, conn);
            command.Parameters.Add("@HinhAnh", MySqlDbType.LongBlob);
            command.Parameters["@HinhAnh"].Value = pt;
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data(); 
        }
        //Cập nhật dữ liệu tức thời
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
        //Hàm xóa
        private void btnDelFood_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_delete = "DELETE FROM hfc.thucdon WHERE ID_MonAn = '" + int.Parse(txtIDMon.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_delete, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        //Hàm sửa
        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] pt = ms.ToArray();
            conn.Open();
            string query_edit = "UPDATE hfc.thucdon SET TenMonAn ='" + txtTenMon.Text + "', Gia ='" + txtGia.Text + "', HinhAnh = @HinhAnh WHERE ID_MonAn = '" + int.Parse(txtIDMon.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_edit, conn);
            command.Parameters.Add("@HinhAnh", MySqlDbType.LongBlob);
            command.Parameters["@HinhAnh"].Value = pt;
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        //Đọc dữ liệu từ datagridview ra textbox/combobox/picturebox
        private void dgvThucDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvThucDon.Rows[e.RowIndex];
            txtIDMon.Text = Convert.ToString(row.Cells["ID_MonAn"].Value);
            txtTenMon.Text = Convert.ToString(row.Cells["TenMonAn"].Value);
            txtGia.Text = Convert.ToString(row.Cells["Gia"].Value);
            if (Convert.ToString(row.Cells["HinhAnh"].Value) != "")
            {
                MemoryStream pic = new MemoryStream((byte[])row.Cells["HinhAnh"].Value);
                pictureBox1.Image = Image.FromStream(pic);
            }
            else
            {
                pictureBox1.Image=null;
            }
        }
        //Hàm tìm kiếm
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
        //Chọn hình ảnh
        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            odf.Title = "Chọn ảnh";
            odf.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (odf.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.ImageLocation = odf.FileName;
            }
        }
        //Khi chèn hình vào database, code sẽ hiện khung lỗi không cho thao tác tiếp, code này để tắt lỗi đó
        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void cmbSearchMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
