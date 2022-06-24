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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace QLHFC.PresentationTier
{
    public partial class FormKH : Form
    {
        //Khai báo và kết nối MySQL
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
            //
            //Show database
            //
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
            if(UserDetails.UserName != "admin")
            {
                //btnAddKH.Enabled = false;
                btnDelKH.Enabled = false;
                btnEditKH.Enabled = false;
            }
            dgvKH.Columns[0].HeaderText = "ID Khách hàng";
            dgvKH.Columns[1].HeaderText = "Tên Khách hàng";
            dgvKH.Columns[2].HeaderText = "Địa chỉ Khách hàng";
            dgvKH.Columns[3].HeaderText = "SĐT cá nhân";
        }
        //
        //Hàm thêm
        //
        private void btnAddKH_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_insert = "INSERT INTO hfc.khachhang (TenKH,DiaChiKH,SDT_KH) VALUES ('" + txtNameKH.Text + "','" + txtDiaChiKH.Text + "','" + txtSDT_KH.Text + "')";
            MySqlCommand command = new MySqlCommand(query_insert, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        //
        //Hàm xóa
        //
        private void btnDelKH_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_delete = "DELETE FROM hfc.khachhang WHERE ID_KH = '" + int.Parse(txtID_KH.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_delete, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        //
        //Hàm sửa
        //
        private void btnEditKH_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query_edit = "UPDATE hfc.khachhang SET TenKH ='" + txtNameKH.Text + "', DiaChiKH ='" + txtDiaChiKH.Text + "',SDT_KH ='" + txtSDT_KH.Text + "' WHERE ID_KH = '" + int.Parse(txtID_KH.Text) + "'";
            MySqlCommand command = new MySqlCommand(query_edit, conn);
            command.ExecuteNonQuery();
            conn.Close();
            Read_Data();
        }
        //
        //Cập nhật dữ liệu tức thời
        //
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
        //
        //Đọc dữ liệu từ datagridview ra textbox/combobox/picturebox
        //
        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvKH.Rows[e.RowIndex];
            txtID_KH.Text = Convert.ToString(row.Cells["ID_KH"].Value);
            txtNameKH.Text = Convert.ToString(row.Cells["TenKH"].Value);
            txtDiaChiKH.Text = Convert.ToString(row.Cells["DiaChiKH"].Value);
            txtSDT_KH.Text = Convert.ToString(row.Cells["SDT_KH"].Value);
            LSDH.Tenkh = txtNameKH.Text;
        }
        //
        //Hàm tìm kiếm
        //
        private void txtSearchKH_TextChanged(object sender, EventArgs e)
        {
            conn.Open();
            string query_search = "SELECT * FROM hfc.khachhang WHERE " + cmbSearchKH.Text + " like '%" + txtSearchKH.Text + "%'";
            MySqlCommand command = new MySqlCommand(query_search, conn);
            command.ExecuteNonQuery();
            adap = new MySqlDataAdapter(command);
            mytable = new DataTable();
            adap.Fill(mytable);
            conn.Close();
            dgvKH.DataSource = mytable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLSDH f = new FormLSDH();
            f.Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Excel.Application application = new Excel.Application();
            //Excel.Workbook workbook;
            //Excel.Worksheet worksheet;
            //Excel.Range workrange;
            //workbook = application.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            //worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            //workrange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, 1];
            //workrange.Range["A1:A1"].Value = "ID Khách hàng";
            //workrange.Range["A1:B1"].Value = "Tên Khách hàng";
            //workrange.Range["A1:C1"].Value = "Địa chỉ Khách hàng";
            //workrange.Range["A1:D1"].Value = "SĐT cá nhân";
            //for(int i =0; i <= dgvKH.Rows.Count - 1; i++)
            //{
            //    worksheet.Cells[1][i + 2] = i + 1; 
            ////}
            //SaveFileDialog save = new SaveFileDialog();
            //save.Title = "Xuất file Excel";
            //save.FileName = "";
            //save.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            //if (save.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        ExportExcel(save.FileName);
            //        MessageBox.Show("Xuất file thành công.");
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Xuất file không thành công.");
            //    }
            //}
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }
        private void ExportExcel (string path)
        {
            if (dgvKH.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
                application.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dgvKH.Columns.Count + 1; i++)
                {
                    application.Cells[1, i] = dgvKH.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvKH.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvKH.Columns.Count; j++)
                    {
                        application.Cells[i + 2, j + 1] = dgvKH.Rows[i].Cells[j].Value.ToString();
                    }
                }
                application.Columns.AutoFit();
                application.Visible = true;
            }
        }
    }
}
