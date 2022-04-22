using QLHFC.PresentationTier;
using MySql.Data.MySqlClient;

namespace QLHFC
{
    public partial class FormLogin : Form
    {
        MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001");
        MySqlCommandBuilder cmd = new MySqlCommandBuilder();
        MySqlDataAdapter adap = new MySqlDataAdapter();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu f;
            conn.Open();
            string dangnhap = "SELECT * FROM hfc.nhanvien WHERE Username= '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";
            MySqlCommand command = new MySqlCommand(dangnhap, conn);
            MySqlDataReader dr = command.ExecuteReader();
            if (dr.Read() == true)
            {
                f = new FormMenu();
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ, vui lòng nhập lại.","Đăng nhập không thành công.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            conn.Close();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            FormSignup f = new FormSignup();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}