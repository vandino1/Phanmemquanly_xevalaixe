using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace To1_Nhom3_Chude16
{
    public partial class PhieuThanhToan : Form
    {
        SqlConnection con;
        SqlCommand command;
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLXevaLaiXe;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = con.CreateCommand();
            command.CommandText = "select * from PhieuThanhToan";
            da.SelectCommand = command;
            table.Clear();
            da.Fill(table);
            dgvThanhtoan.DataSource = table;
        }
        public PhieuThanhToan()
        {
            InitializeComponent();
        }

        private void btnKhoiTao_Click(object sender, EventArgs e)
        {
            txtMaThanhtoan.ReadOnly = false;
            txtMaThanhtoan.Text = "";
            txtMaKH.Text = "";
            DTNgaymuon.Text = "";
            DTNgaytra.Text = "";
            txtTientheongay.Text = "";
            txtMaxe.Text = "";
            txtChiphiBT.Text = "";

        }

        private void PhieuThanhToan_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "insert into PhieuThanhToan values(N'" + txtMaThanhtoan.Text + "',N'" + txtMaKH.Text + "',N'" + DTNgaymuon.Text + "',N'" + DTNgaytra.Text + "',N'" + txtTientheongay.Text + "',N'" + txtMaxe.Text + "',N'" + txtChiphiBT.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
            txtMaThanhtoan.ResetText();
            txtMaKH.ResetText();
            DTNgaymuon.ResetText();
            DTNgaytra.ResetText();
            txtTientheongay.ResetText();
            txtMaxe.ResetText();
            txtChiphiBT.ResetText();
            MessageBox.Show("Bạn đã thêm thông tin phiếu thanh toán thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "update PhieuThanhToan set MaphieuThanhtoan =N'" + txtMaThanhtoan.Text + "', Makhachhang=N'" + txtMaKH.Text + "', NgayMuonXe=N'" + DTNgaymuon.Text + "', Ngaytraxethucte=N'" + DTNgaytra.Text + "',Tientraxetheongay=N'" + txtTientheongay.Text + "', Maxe=N'" + txtMaxe.Text + "', Chiphiboithuong=N'" + txtChiphiBT.Text + "'where MaphieuThanhtoan = '" + txtMaThanhtoan.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtMaThanhtoan.ResetText();
            txtMaKH.ResetText();
            DTNgaymuon.ResetText();
            DTNgaytra.ResetText();
            txtTientheongay.ResetText();
            txtMaxe.ResetText();
            txtChiphiBT.ResetText();
            MessageBox.Show("Bạn đã sửa thông tin phiếu thanh toán thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "delete from PhieuThanhToan where MaphieuThanhtoan = '" + txtMaThanhtoan.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtMaThanhtoan.ResetText();
            txtMaKH.ResetText();
            DTNgaymuon.ResetText();
            DTNgaytra.ResetText();
            txtTientheongay.ResetText();
            txtMaxe.ResetText();
            txtChiphiBT.ResetText();
            MessageBox.Show("Bạn đã xóa thông tin phiếu thanh toán thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void dvgThanhtoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaThanhtoan.ReadOnly = true;
            int i;
            i = dgvThanhtoan.CurrentRow.Index;
            txtMaThanhtoan.Text = dgvThanhtoan.Rows[i].Cells[0].Value.ToString();
            txtMaKH.Text = dgvThanhtoan.Rows[i].Cells[1].Value.ToString();
            DTNgaymuon.Text = dgvThanhtoan.Rows[i].Cells[2].Value.ToString();
            DTNgaytra.Text = dgvThanhtoan.Rows[i].Cells[3].Value.ToString();
            txtTientheongay.Text = dgvThanhtoan.Rows[i].Cells[4].Value.ToString();
            txtMaxe.Text = dgvThanhtoan.Rows[i].Cells[5].Value.ToString();
            txtChiphiBT.Text = dgvThanhtoan.Rows[i].Cells[6].Value.ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            this.Close();
            frmMenu b5 = new frmMenu();
            b5.Show();

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {

            if (rdt_maxe.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuThanhToan where Maxe like '%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "PhieuThanhToan");
                dgvThanhtoan.DataSource = ds.Tables["PhieuThanhToan"].DefaultView;
                con.Close();
            }
            if (rdt_makhachhang.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuThanhToan where Makhachhang like N'%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "PhieuThanhToan");
                dgvThanhtoan.DataSource = ds.Tables["PhieuThanhToan"].DefaultView;
                con.Close();
            }
            if (rdt_maphieuthanhtoan.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuThanhToan where MaphieuThanhToan like N'%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "PhieuThanhToan");
                dgvThanhtoan.DataSource = ds.Tables["PhieuThanhToan"].DefaultView;
                con.Close();
            }
        }

        private void txtthongtintim_KeyUp(object sender, KeyEventArgs e)
        {

            if (rdt_maxe.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuThanhToan where Maxe like '%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "PhieuThanhToan");
                dgvThanhtoan.DataSource = ds.Tables["PhieuThanhToan"].DefaultView;
                con.Close();
            }
            if (rdt_makhachhang.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuThanhToan where Makhachhang like N'%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "PhieuThanhToan");
                dgvThanhtoan.DataSource = ds.Tables["PhieuThanhToan"].DefaultView;
                con.Close();
            }
            if (rdt_maphieuthanhtoan.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from PhieuThanhToan where MaphieuThanhToan like N'%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "PhieuThanhToan");
                dgvThanhtoan.DataSource = ds.Tables["PhieuThanhToan"].DefaultView;
                con.Close();
            }
        }

        
    }
}
