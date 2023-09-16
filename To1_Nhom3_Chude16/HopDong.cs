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
    public partial class HopDong : Form
    {
        SqlConnection con;
        SqlCommand command;
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLXevaLaiXe;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = con.CreateCommand();
            command.CommandText = "select * from HopDong";
            da.SelectCommand = command;
            table.Clear();
            da.Fill(table);
            dgvHopDong.DataSource = table;
        }
            public HopDong()
        {
            InitializeComponent();
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            txtMaHD.ReadOnly = false;
            txtMaHD.Text = "";
            txtTenHD.Text = "";
            DTNgaylapHD.Text = "";
            txtNgayluong.Text = "";
            txtMucluong.Text = "";
            txtMaxe.Text = "";
            txtMalaixe.Text = "";


        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            command = con.CreateCommand();
            command.CommandText = "insert into HopDong values(N'" + txtMaHD.Text + "',N'" + txtTenHD.Text + "',N'" + DTNgaylapHD.Text + "',N'" + txtNgayluong.Text + "',N'" + txtMucluong.Text + "',N'" + txtMaxe.Text + "',N'" + txtMalaixe.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
            txtMaHD.ResetText();
            txtTenHD.ResetText();
            DTNgaylapHD.ResetText();
            txtNgayluong.ResetText();
            txtMucluong.ResetText();
            txtMaxe.ResetText();
            txtMalaixe.ResetText();
            MessageBox.Show("Bạn đã thêm thông tin hợp đồng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

           

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "update HopDong set Mahopdong =N'" + txtMaHD.Text + "', Tenhopdong=N'" + txtTenHD.Text + "', Ngaylaphopdong=N'" + DTNgaylapHD.Text + "', NgayThanhToanLuong=N'" + txtNgayluong.Text + "', MucLuong=N'" + txtMucluong.Text + "', MaXe=N'" + txtMaxe.Text + "', Malaixe=N'" + txtMalaixe.Text + "'where Mahopdong = '" + txtMaHD.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtMaHD.ResetText();
            txtTenHD.ResetText();
            DTNgaylapHD.ResetText();
            txtNgayluong.ResetText();
            txtMucluong.ResetText();
            txtMaxe.ResetText();
            txtMalaixe.ResetText();
            MessageBox.Show("Bạn đã sửa thông tin hợp đồng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "delete from HopDong where Mahopdong = '" + txtMaHD.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtMaHD.ResetText();
            txtTenHD.ResetText();
            DTNgaylapHD.ResetText();
            txtNgayluong.ResetText();
            txtMucluong.ResetText();
            txtMaxe.ResetText();
            txtMalaixe.ResetText();
            MessageBox.Show("Bạn đã xóa thông tin hợp đồng thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
              this.Close();
            frmMenu b3 = new frmMenu();
            b3.Show();

        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loaddata();

        }

        private void dgvHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.ReadOnly = true;
            int i;
            i = dgvHopDong.CurrentRow.Index;
            txtMaHD.Text = dgvHopDong.Rows[i].Cells[0].Value.ToString();
            txtTenHD.Text = dgvHopDong.Rows[i].Cells[1].Value.ToString();
            DTNgaylapHD.Text = dgvHopDong.Rows[i].Cells[2].Value.ToString();
            txtNgayluong.Text = dgvHopDong.Rows[i].Cells[3].Value.ToString();
            txtMucluong.Text = dgvHopDong.Rows[i].Cells[4].Value.ToString();
            txtMaxe.Text = dgvHopDong.Rows[i].Cells[5].Value.ToString();
            txtMalaixe.Text = dgvHopDong.Rows[i].Cells[6].Value.ToString();
            
        }

        private void txtthongtintim_KeyUp(object sender, KeyEventArgs e)
        {
            if (rdt_mahopdong.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HopDong where Mahopdong like '%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "HopDong");
                dgvHopDong.DataSource = ds.Tables["HopDong"].DefaultView;
                con.Close();
            }
            if (rdt_tenhopdong.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HopDong where Tenhopdong like N'%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "HopDong");
                dgvHopDong.DataSource = ds.Tables["HopDong"].DefaultView;
                con.Close();
            }

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {

            if (rdt_mahopdong.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HopDong where Mahopdong like '%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "HopDong");
                dgvHopDong.DataSource = ds.Tables["HopDong"].DefaultView;
                con.Close();
            }
            if (rdt_tenhopdong.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from HopDong where Tenhopdong like N'%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "HopDong");
                dgvHopDong.DataSource = ds.Tables["HopDong"].DefaultView;
                con.Close();
            }
        }

        
    }
}
