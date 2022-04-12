using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QLHFC.FormMenuManager;

namespace QLHFC
{
    public partial class FormBill : Form
    {
        private int maHoaDon;

        public FormBill()
        {
            InitializeComponent();
            maHoaDon = 0;
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBill_Load(object sender, EventArgs e)
        {
            ThemHoaDon(FormMenuManager.XuatBill.tongTien);
            //var rowIndex = dgvBill.Rows.Add();
            //dgvBill.Rows[rowIndex].Cells[0].Value = "HD" + maHoaDon;
            //dgvBill.Rows[rowIndex].Cells[1].Value = ;
            //dgvBill.Rows[rowIndex].Cells[2].Value = FormMenuManager.XuatBill.tongTien;
            //dgvBill.Rows[rowIndex].Cells[3].Value = DateTime.Now.ToString("dd/mm/yyyy");
        }

        private void ThemHoaDon(string tongTien)
        {
            maHoaDon++;
            var rowIndex = dgvBill.Rows.Add();
            dgvBill.Rows[rowIndex].Cells[0].Value = "HD" + maHoaDon;
            //dgvBill.Rows[rowIndex].Cells[1].Value = ;
            dgvBill.Rows[rowIndex].Cells[2].Value = FormMenuManager.XuatBill.tongTien;
            dgvBill.Rows[rowIndex].Cells[3].Value = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
