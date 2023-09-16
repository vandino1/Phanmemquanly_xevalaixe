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
    public partial class LaiXe : Form
    {
        SqlConnection con;
        SqlCommand command;
        string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLXevaLaiXe;Integrated Security=True";
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = con.CreateCommand();
            command.CommandText = "select * from LaiXe";
            da.SelectCommand = command;
            table.Clear();
            da.Fill(table);
            dgvLaixe.DataSource = table;
        }
        public LaiXe()
        {
            InitializeComponent();
        }

        private void LaiXe_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            loaddata();

        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
           
            command = con.CreateCommand();
            command.CommandText = "insert into LaiXe values(N'" + txtMalaixe.Text + "',N'" + txtTenlaixe.Text + "',N'" +DTNgaysinh.Text+ "',N'" + cmbGioiTinh.Text + "',N'" + txtDiachi.Text + "',N'" + txtDT.Text + "',N'" + txtEmail.Text + "',N'" + txtBangcap.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
            txtMalaixe.ResetText();
            txtTenlaixe.ResetText();
            DTNgaysinh.ResetText();
            cmbGioiTinh.ResetText();
            txtDiachi.ResetText();
            txtDT.ResetText();
            txtEmail.ResetText();
            txtBangcap.ResetText();
            MessageBox.Show("Bạn đã thêm thông tin lái xe thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "update LaiXe set Malaixe =N'" + txtMalaixe.Text + "', TenLaixe=N'" + txtTenlaixe.Text + "', Ngaysinh=N'" + DTNgaysinh.Text + "', Gioitinh=N'" + cmbGioiTinh.Text + "',Diachi=N'" + txtDiachi.Text + "', Dienthoai=N'" + txtDT.Text + "', Email=N'" + txtEmail.Text + "', Bangcap='" + txtBangcap.Text + "'where Malaixe = '" + txtMalaixe.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtMalaixe.ResetText();
            txtTenlaixe.ResetText();
            DTNgaysinh.ResetText();
            cmbGioiTinh.ResetText();
            txtDiachi.ResetText();
            txtDT.ResetText();
            txtEmail.ResetText();
            txtBangcap.ResetText();
            MessageBox.Show("Bạn đã sửa thông tin lái xe thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "delete from LaiXe where Malaixe ='" + txtMalaixe.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtMalaixe.ResetText();
            txtTenlaixe.ResetText();
            DTNgaysinh.ResetText();
            cmbGioiTinh.ResetText();
            txtDiachi.ResetText();
            txtDT.ResetText();
            txtEmail.ResetText();
            txtBangcap.ResetText();
            MessageBox.Show("Bạn đã xóa thông tin lái xe thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            txtMalaixe.ReadOnly = false;
            txtMalaixe.Text = "";
            txtTenlaixe.Text = "";
            DTNgaysinh.Text = "";
            cmbGioiTinh.Text = "";
            txtDiachi.Text = "";
            txtDT.Text = "";
            txtEmail.Text = "";
            txtBangcap.Text = "";

        }

        private void dgvLaixe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMalaixe.ReadOnly = true;
            int i;
            i = dgvLaixe.CurrentRow.Index;
            txtMalaixe.Text = dgvLaixe.Rows[i].Cells[0].Value.ToString();
            txtTenlaixe.Text = dgvLaixe.Rows[i].Cells[1].Value.ToString();
            DTNgaysinh.Text = dgvLaixe.Rows[i].Cells[2].Value.ToString();
            cmbGioiTinh.Text = dgvLaixe.Rows[i].Cells[3].Value.ToString();
            txtDiachi.Text = dgvLaixe.Rows[i].Cells[4].Value.ToString();
            txtDT.Text = dgvLaixe.Rows[i].Cells[5].Value.ToString();
            txtEmail.Text = dgvLaixe.Rows[i].Cells[6].Value.ToString();
            txtBangcap.Text = dgvLaixe.Rows[i].Cells[7].Value.ToString();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
              this.Close();
            frmMenu b2 = new frmMenu();
            b2.Show();

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {

            if (rdt_malaixe.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LaiXe where Malaixe like '%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "LaiXe");
                dgvLaixe.DataSource = ds.Tables["LaiXe"].DefaultView;
                con.Close();

            }
            if (rdt_tenlaixe.Checked == true)
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from LaiXe where TenLaixe like N'%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "LaiXe");
                dgvLaixe.DataSource = ds.Tables["LaiXe"].DefaultView;
                con.Close();
            }
        }

        private void txtthongtintim_KeyUp(object sender, KeyEventArgs e)
        {
            if (rdt_malaixe.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LaiXe where Malaixe like '%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "LaiXe");
                dgvLaixe.DataSource = ds.Tables["LaiXe"].DefaultView;
                con.Close();
            }
            if (rdt_tenlaixe.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from LaiXe where TenLaixe like N'%" + txtthongtintim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "LaiXe");
                dgvLaixe.DataSource = ds.Tables["LaiXe"].DefaultView;
                con.Close();
            }
        }

       
    }
}
