namespace QLHFC
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenuManager f = new FormMenuManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormMain f = new FormMain();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn quay lại màn hình chính?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            FormMain f = new FormMain();
            this.Hide();
            f.ShowDialog();
            this.Show();
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