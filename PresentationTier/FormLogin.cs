using QLHFC.PresentationTier;
using MySql.Data.MySqlClient;
using System.Data;

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
            adap = new MySqlDataAdapter(dangnhap, conn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            MySqlDataReader dr = command.ExecuteReader();
            if (dr.Read() == true)
            {
                if(dt.Rows.Count > 0){
                    f = new FormMenu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString());
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ, vui lòng nhập lại.","Đăng nhập không thành công.",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            conn.Close();
            this.Hide();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            Application.Exit();
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