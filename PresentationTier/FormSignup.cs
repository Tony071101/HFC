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
        MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001");
        MySqlCommandBuilder cmd = new MySqlCommandBuilder();
        MySqlDataAdapter adap = new MySqlDataAdapter();
        

        public FormSignup()
        {
            InitializeComponent();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" && txtUserSignup.Text == "" && txtPass.Text == "" && txtDiaChi.Text == "" && txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập các dòng trên.", "Đăng ký không thành công.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text == txtConfirmPass.Text)
            {
                conn.Open();
                string dangky = "INSERT INTO hfc.nhanvien (TenNV,DiaChiNV,SDT_NV,Username,Password) VALUES ('" + txtName.Text + "','" + txtDiaChi.Text + "','" + txtSDT.Text + "','" + txtUserSignup.Text + "','" + txtPass.Text + "')";
                MySqlCommand command = new MySqlCommand(dangky, conn);
                command.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Tài khoản nhân viên đã đăng ký thành công","Đăng ký thành công.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xác nhận mật khẩu không thành công", "Đăng ký không thành công.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Text = "";
                txtConfirmPass.Text = "";
                txtPass.Focus();
            }
        }
    }
}
