using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To1_Nhom3_Chude16
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            Xe f1 = new Xe();
            f1.Show();
            this.Close();        
        }

        private void btnLaiXe_Click(object sender, EventArgs e)
        {
            LaiXe f2 = new LaiXe();
            f2.Show();
            this.Close();


        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            HopDong f3 = new HopDong();
            f3.Show();
            this.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang f4 = new KhachHang();
            f4.Show();
            this.Close();
        }

        private void btnPhieuThanhToan_Click(object sender, EventArgs e)
        {
            PhieuThanhToan f5 = new PhieuThanhToan();
            f5.Show();
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

             DialogResult traloi;
             traloi = MessageBox.Show("Bạn có muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
             if (traloi == DialogResult.OK)
              Application.Exit();
            frmMenu c1 = new frmMenu();
            c1.Show();
            this.Hide();
        }
    }
}
