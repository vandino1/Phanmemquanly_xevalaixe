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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {

            if ((this.txtTendangnhap.Text == "") || (this.txtMatkhau.Text == ""))
                MessageBox.Show("Vui lòng nhập Tên hoặc mật khẩu người dùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if ((this.txtTendangnhap.Text == "1") && (this.txtMatkhau.Text == "1"))
            {              
                frmMenu f6 = new frmMenu();
                f6.Show();
               this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "THÔNG BÁO");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng hệ thống đăng nhập không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                this.Close();


        }

        
    }
}
