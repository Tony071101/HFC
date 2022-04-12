using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHFC
{
    public partial class FormMenuManager : Form
    {
     
        public FormMenuManager()
        {
            InitializeComponent();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddfood_Click(object sender, EventArgs e)
        {

        }

        private void FormMenuManager_Load(object sender, EventArgs e)
        {
            KhoiTaoThucDon(3, 4); 
        }

        private void KhoiTaoThucDon(int dong, int cot)
        {
            int x, y = 50, khoangCachX = 110, khoangCachY = 100, dem = 1;
            Button btnFood;
            for (int i = 0; i < dong; i++) 
            {
                x = 70;
                for (int j = 0; j < cot; j++)
                {
                    btnFood = new Button();
                    btnFood.Location = new Point(x, y);
                    btnFood.Size = new Size(100, 80);
                    btnFood.Text = dem++.ToString();
                    btnFood.BackColor = Color.White;
                    btnFood.Click += btnFood_Click;
                    pnlMenu.Controls.Add(btnFood);
                    x += khoangCachX;
                }
                y += khoangCachY;
            }
        }

        

        private void btnFood_Click(object? sender, EventArgs e)
        {
            
            Button btnFood = (Button)sender;
            if(btnFood.BackColor == Color.Blue){
                return;
            }
            btnFood.BackColor = (btnFood.BackColor == Color.White) ? Color.Blue : Color.White;
            double tongTien = 0;
            foreach (Button food in pnlMenu.Controls)
            {
                if (food.BackColor == Color.Blue)
                {
                    tongTien += TinhTien(int.Parse(food.Text));
                    food.BackColor = Color.Blue;

                }
            }
            txtMoney.Text = tongTien.ToString();

            XuatBill.tongTien = tongTien.ToString();
        }

        

        private double TinhTien(int viTriFood)
        {
            if (viTriFood <= 4) return 30000;
            if (viTriFood <= 8) return 50000;
            return 5000;
        }
        public class XuatBill
        {
            static public string tongTien; 
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            foreach(Button food in pnlMenu.Controls)
            {
                if(food.BackColor == Color.Blue)
                {
                    food.BackColor = Color.White;
                }
            }
            
            FormBill f = new FormBill();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
