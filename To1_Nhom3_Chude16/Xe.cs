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
    public partial class Xe : Form
    {
        SqlConnection con;//Tạo 1 đối tượng thuộc lớp Connection để kết nối
        SqlCommand command;//Gọi phương thức truy vấn tương tác dữ liệu khi đang kết nối
       string str = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=QLXevaLaiXe;Integrated Security=True";//Tạo String chứa chuỗi kết nối
        SqlDataAdapter da = new SqlDataAdapter();//Tạo đối tượng thuộc lớp DataAdapter để trao đổi dữ liệu(lưu dữ liệu lấy được vào đây)
        DataTable table = new DataTable();//Tạo bảng dữ liệu để chứa dữ liệu từ Daset đẩy xuống table theo cơ chế ADO.NET
        void loaddata()//Hàm load dữ liệu lên DataGirdview
        {
            command = con.CreateCommand();//Khởi tạo 1 cái xử lý kết nối
            command.CommandText = "select * from Xe";// Câu lệnh truy vấn 
            da.SelectCommand = command;//Thực thi câu lệnh truy vấn
            table.Clear();//Làm sạch bảng
            da.Fill(table);//Lấy dữ liệu từ DataAdapter đổ xuống table
            dgvXe.DataSource = table;//Lấy dữ liệu từ table đổ xuống DataGirdview

        }
        public Xe()
        {
            InitializeComponent();
        }

        private void btnKhoitao_Click(object sender, EventArgs e)
        {
            txtMaxe.ReadOnly = false;
            txtMaxe.Text = "";
            txtTenxe.Text = "";
            txtNamsx.Text = "";
            txtHangsx.Text = "";
            txtBienso.Text = "";
            txtLoaixe.Text = "";
            txtTinhtrang.Text = "";
            txtSoluong.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();//Tạo lệnh connection 
            // Thực hiện câu lệnh insert được tham số hóa theo đúng thứ tự sql
            command.CommandText = "insert into Xe values(N'" + txtMaxe.Text + "',N'" + txtTenxe.Text + "',N'" + txtNamsx.Text + "',N'" + txtHangsx.Text + "',N'" + txtBienso.Text + "',N'" + txtLoaixe.Text + "',N'" + txtTinhtrang.Text + "',N'" + txtSoluong.Text + "')";
            //Thực hiện các lệnh ở trên và cật nhật dữ liệu trong sql lun ko thông qua DataSet(Giá trị trả về là số hàng bị thay đổi)
            command.ExecuteNonQuery();
            loaddata();//thực thi hàm loaddata 
            txtMaxe.ResetText();
            txtTenxe.ResetText();
            txtNamsx.ResetText();
            txtHangsx.ResetText();
            txtBienso.ResetText();
            txtLoaixe.ResetText();
            txtTinhtrang.ResetText();
            txtSoluong.ResetText();
            MessageBox.Show("Bạn đã thêm thông tin xe thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "update Xe set MaXe =N'" + txtMaxe.Text + "', Tenxe=N'" + txtTenxe.Text + "', Namsx=N'" + txtNamsx.Text + "', Hangsx=N'" + txtHangsx.Text + "'" +
      ", BienSoXe=N'" + txtBienso.Text + "', LoaiXe=N'" + txtLoaixe.Text + "', TinhTrangXe=N'" + txtTinhtrang.Text + "', Soluong=" + txtSoluong.Text + "where MaXe = '" + txtMaxe.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtMaxe.ResetText();
            txtTenxe.ResetText();
            txtNamsx.ResetText();
            txtHangsx.ResetText();
            txtBienso.ResetText();
            txtLoaixe.ResetText();
            txtTinhtrang.ResetText();
            txtSoluong.ResetText();
            MessageBox.Show("Bạn đã sửa thông tin xe thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = con.CreateCommand();
            command.CommandText = "delete from Xe where MaXe = '" + txtMaxe.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
            txtMaxe.ResetText();
            txtTenxe.ResetText();
            txtNamsx.ResetText();
            txtHangsx.ResetText();
            txtBienso.ResetText();
            txtLoaixe.ResetText();
            txtTinhtrang.ResetText();
            txtSoluong.ResetText();
            MessageBox.Show("Bạn đã xóa thông tin xe thành công!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
             traloi = MessageBox.Show("Bạn có muốn thoát không?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            this.Close();       
            frmMenu b1 = new frmMenu();
            b1.Show();
           
        }

        private void dgvXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaxe.ReadOnly = true;//Sao khi chọn 1 ô thì Maxe sẽ khóa
            int i;
            i = dgvXe.CurrentRow.Index;
            txtMaxe.Text = dgvXe.Rows[i].Cells[0].Value.ToString();//Lấy dữ liệu ở các dòng thứ i trong hàng ngang đang chọn trên view hiển thị lên textbox Maxe
            txtTenxe.Text = dgvXe.Rows[i].Cells[1].Value.ToString();
            txtNamsx.Text = dgvXe.Rows[i].Cells[2].Value.ToString();
            txtHangsx.Text = dgvXe.Rows[i].Cells[3].Value.ToString();
            txtBienso.Text = dgvXe.Rows[i].Cells[4].Value.ToString();
            txtLoaixe.Text = dgvXe.Rows[i].Cells[5].Value.ToString();
            txtTinhtrang.Text = dgvXe.Rows[i].Cells[6].Value.ToString();
            txtSoluong.Text = dgvXe.Rows[i].Cells[7].Value.ToString();


        }

        private void Xe_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(str);//Truyền vào cho nó 1 chuỗi kết nối
            con.Open();//Thiết lập kết nối 
            loaddata();//load dữ liệu vào

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {

            if (rdt_maxe.Checked == true)//Nếu check vào mã xe là đúng
            {
                //Tạo đối tượng thuộc lớp DataAdapter với câu lệnh truy vấn lấy dữ liệu trong bảng Xe
                SqlDataAdapter da = new SqlDataAdapter("select * from Xe where Maxe like '%" + txttttim.Text + "%'", con);
                DataSet ds = new DataSet();//Tạo 1 đối tượng thuộc dataSet
                da.Fill(ds, "Xe");//Lấy dữ liệu bảng xe từ database đổ vào dataset thông qua DataAdapter
                dgvXe.DataSource = ds.Tables["Xe"].DefaultView;//Lấy dữ liệu xe hiện lên DataGirdview thông qua DataSource
                con.Close();//Đóng két nối

            }
            if (rdt_tenxe.Checked == true)
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from Xe where Tenxe like N'%" + txttttim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Xe");
                dgvXe.DataSource = ds.Tables["Xe"].DefaultView;
                con.Close();
            }
        }

        private void txttttim_KeyUp(object sender, KeyEventArgs e)
        {
            if (rdt_maxe.Checked == true)
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Xe where Maxe like '%" + txttttim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Xe");
                dgvXe.DataSource = ds.Tables["Xe"].DefaultView;
                con.Close();

            }
            if (rdt_tenxe.Checked == true)
            {

                SqlDataAdapter da = new SqlDataAdapter("select * from Xe where Tenxe like N'%" + txttttim.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds, "Xe");
                dgvXe.DataSource = ds.Tables["Xe"].DefaultView;
                con.Close();
            }
        }


    }
}
