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

namespace QLHFC
{
    public partial class FormSignup : Form
    {
        //Khai báo và kết nối MySQL
        MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001");
        MySqlCommandBuilder cmd = new MySqlCommandBuilder();
        MySqlDataAdapter adap = new MySqlDataAdapter();
        

        public FormSignup()
        {
            InitializeComponent();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            //Đăng ký
            
            if (txtName.Text == "" && txtUserSignup.Text == "" && txtPass.Text == "" && txtDiaChi.Text == "" && txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các dòng trên.", "Đăng ký không thành công.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text == txtConfirmPass.Text)
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] pt = ms.ToArray();
                conn.Open();
                string dangky = "INSERT INTO hfc.nhanvien (TenNV,DiaChiNV,SDT_NV,Username,Password,AnhNV) VALUES ('" + txtName.Text + "','" + txtDiaChi.Text + "','" + txtSDT.Text + "','" + txtUserSignup.Text + "','" + txtPass.Text + "', @AnhNV)";
                MySqlCommand command = new MySqlCommand(dangky, conn);
                command.Parameters.Add("@AnhNV", MySqlDbType.LongBlob);
                command.Parameters["@AnhNV"].Value = pt;
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Tài khoản nhân viên đã đăng ký thành công", "Đăng ký thành công.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không thành công", "Đăng ký không thành công.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtConfirmPass.Text = "";
                txtPass.Focus();
            }
            
        }
        //Chọn hình ảnh
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
        //Khi chèn hình vào database, code sẽ hiện khung lỗi không cho thao tác tiếp, code này để tắt lỗi đó
        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Nhân viên đăng ký tài khoản phải có hình ảnh", "Quy định", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();
            f.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
