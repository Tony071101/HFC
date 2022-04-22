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
    public partial class FormMenu : Form
    {
        
        public FormMenu()
        {
            InitializeComponent();
        }


        private void nHÂNVIÊNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNV f = new FormNV();
            f.MdiParent = this;
            f.Show();
        }

        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKH f = new FormKH();
            f.MdiParent = this;
            f.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
