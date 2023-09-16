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
    public partial class KhachHang : Form
    {
        SqlConnection con;
        SqlCommand command;
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLXevaLaiXe;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = con.CreateCommand();
            command.CommandText = "select * from KhachHang";
            da.SelectCommand = command;
            table.Clear();
            da.Fill(table);
            dgvKH.DataSource = table;
        }
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loaddata();


        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            txtMaKH.ReadOnly = false;
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            cmbGioitinh.Text = "";
            DTNgaysinh.Text = "";
            txtDiachi.Text = "";
            txtDT.Text = "";
            txtEmail.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "insert into KhachHang values(N'" + txtMaKH.Text + "',N'" + txtTenKH.Text + "',N'" + cmbGioitinh.Text + "',N'" + DTNgaysinh.Text + "',N'" + txtDiachi.Text + "',N'" + txtDT.Text + "',N'" + txtEmail.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            cmbGioitinh.ResetText();
            DTNgaysinh.ResetText();
            txtDiachi.ResetText();
            txtDT.ResetText();
            txtEmail.ResetText();
            MessageBox.Show("Bạn đã thêm thông tin khách hàng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "update KhachHang set Makhachhang =N'" + txtMaKH.Text + "', Tenkhachhang=N'" + txtTenKH.Text + "', Gioitinh=N'" + cmbGioitinh.Text + "', Ngaysinh=N'" + DTNgaysinh.Text + "',Diachi=N'" + txtDiachi.Text + "', Dienthoai=N'" + txtDT.Text + "', Email=N'" + txtEmail.Text + "'where Makhachhang = '" + txtMaKH.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            cmbGioitinh.ResetText();
            DTNgaysinh.ResetText();
            txtDiachi.ResetText();
            txtDT.ResetText();
            txtEmail.ResetText();
            MessageBox.Show("Bạn đã sửa thông tin khách hàng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "delete from KhachHang where Makhachhang = '" + txtMaKH.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            cmbGioitinh.ResetText();
            DTNgaysinh.ResetText();
            txtDiachi.ResetText();
            txtDT.ResetText();
            txtEmail.ResetText();
            MessageBox.Show("Bạn đã xóa thông tin khách hàng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMaKH.ReadOnly = true;
            int i;
            i = dgvKH.CurrentRow.Index;
            txtMaKH.Text = dgvKH.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKH.Rows[i].Cells[1].Value.ToString();
            cmbGioitinh.Text = dgvKH.Rows[i].Cells[2].Value.ToString();
            DTNgaysinh.Text = dgvKH.Rows[i].Cells[3].Value.ToString();
            txtDiachi.Text = dgvKH.Rows[i].Cells[4].Value.ToString();
            txtDT.Text = dgvKH.Rows[i].Cells[5].Value.ToString();
            txtEmail.Text = dgvKH.Rows[i].Cells[6].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
              this.Close();
            frmMenu b4 = new frmMenu();
            b4.Show();

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {

            if (rdt_makhachhang.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang where Makhachhang like '%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "KhachHang");
                dgvKH.DataSource = ds.Tables["KhachHang"].DefaultView;
                con.Close();
            }
            if (rdt_tenkhachhang.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang where Tenkhachhang like N'%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "KhachHang");
                dgvKH.DataSource = ds.Tables["KhachHang"].DefaultView;
                con.Close();
            }
        }

        private void txtthongtintim_KeyUp(object sender, KeyEventArgs e)
        {
            if (rdt_makhachhang.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang where Makhachhang like '%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "KhachHang");
                dgvKH.DataSource = ds.Tables["KhachHang"].DefaultView;
                con.Close();
            }
            if (rdt_tenkhachhang.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from KhachHang where Tenkhachhang like N'%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "KhachHang");
                dgvKH.DataSource = ds.Tables["KhachHang"].DefaultView;
                con.Close();
            }
        }

        
    }
}
