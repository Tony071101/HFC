using QLHFC.PresentationTier;
using MySql.Data.MySqlClient;
using System.Data;
using QLHFC.Classes;
using System.Diagnostics;

namespace QLHFC
{
    public partial class FormLogin : Form
    {
        //Khai báo MySQL
        MySqlConnection conn = new MySqlConnection("Server = localhost; Port = 3306; Database = hfc; UId = root; Pwd = bjergsen07112001");
        MySqlCommandBuilder cmd = new MySqlCommandBuilder();
        MySqlDataAdapter adap = new MySqlDataAdapter();

        public FormLogin()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Đăng nhập
            //MySQL connection to retrieve user details into a class on successful log in
            conn.Open();
            //Get count, username
            string dangnhap = "SELECT * FROM hfc.nhanvien WHERE Username= '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";
            MySqlCommand command = new MySqlCommand(dangnhap, conn);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(command);
            da.Fill(dt);
            MySqlDataReader dr = command.ExecuteReader();
            if (dr.Read() == true)
            {
                if (dt.Rows.Count > 0)
                {
                    //If the user exist - allow to log in
                    //Store the information from the query to UserDetails class to be used in other forms
                    UserDetails.UserName = dt.Rows[0][4].ToString();
                    UserDetails.Tennv = dt.Rows[0][1].ToString();
                    UserDetails.Diachi = dt.Rows[0][2].ToString();
                    UserDetails.Sdt = dt.Rows[0][3].ToString();
                    //Hide this form and open the main Dashboard Form
                    this.Hide();
                    FormMenu f = new FormMenu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString());
                    f.ShowDialog();
                }
                //If failed login - show message
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ, vui lòng nhập lại.", "Đăng nhập không thành công.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                this.Show();
            }
            conn.Close();
            this.Show();
            ////Check whether user exists
            //if (dt.Rows.Count > 0)
            //{
            //    //If the user exist - allow to log in
            //    //Store the information from the query to UserDetails class to be used in other forms
            //    UserDetails.UserName = dt.Rows[0][4].ToString();
            //    UserDetails.Tennv = dt.Rows[0][2].ToString();
            //    //Hide this form and open the main Dashboard Form
            //    this.Hide();
            //    FormMenu f = new FormMenu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString());
            //    f.ShowDialog();
            //}
            ////If failed login - show message
            //else
            //{
            //    MessageBox.Show("Login failed", "Technical - Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            //Đăng nhập 
            //FormMenu f;
            //conn.Open();
            //string dangnhap = "SELECT * FROM hfc.nhanvien WHERE Username= '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'";
            //MySqlCommand command = new MySqlCommand(dangnhap, conn);
            //adap = new MySqlDataAdapter(dangnhap, conn);
            //DataTable dt = new DataTable();
            //adap.Fill(dt);
            //MySqlDataReader dr = command.ExecuteReader();
            //if (dr.Read() == true)
            //{
            //    if(dt.Rows.Count > 0){
            //        f = new FormMenu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString());
            //        this.Hide();
            //        f.ShowDialog();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ, vui lòng nhập lại.","Đăng nhập không thành công.",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    txtUsername.Text = "";
            //    txtPassword.Text = "";
            //    txtUsername.Focus();
            //    this.Show();
            //}
            //conn.Close();
            //this.Show();
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