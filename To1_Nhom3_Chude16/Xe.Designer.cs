
namespace To1_Nhom3_Chude16
{
    partial class Xe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnKhoitao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtthongtintim = new System.Windows.Forms.TextBox();
            this.txtNamsx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gr_chọn = new System.Windows.Forms.GroupBox();
            this.rdt_malaixe = new System.Windows.Forms.RadioButton();
            this.rdt_tenlaixe = new System.Windows.Forms.RadioButton();
            this.txtMaxe = new System.Windows.Forms.TextBox();
            this.txtTenxe = new System.Windows.Forms.TextBox();
            this.txtHangsx = new System.Windows.Forms.TextBox();
            this.txtBienso = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.txtLoaixe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttttim = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdt_maxe = new System.Windows.Forms.RadioButton();
            this.rdt_tenxe = new System.Windows.Forms.RadioButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gr_chọn.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvXe);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(32, 313);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1191, 219);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin xe";
            // 
            // dgvXe
            // 
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Location = new System.Drawing.Point(0, 21);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.Size = new System.Drawing.Size(1185, 219);
            this.dgvXe.TabIndex = 4;
            this.dgvXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_tim);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnKhoitao);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(821, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(396, 234);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btn_tim
            // 
            this.btn_tim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim.Location = new System.Drawing.Point(229, 162);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(108, 46);
            this.btn_tim.TabIndex = 11;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(47, 162);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(108, 46);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnKhoitao
            // 
            this.btnKhoitao.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoitao.Location = new System.Drawing.Point(47, 21);
            this.btnKhoitao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhoitao.Name = "btnKhoitao";
            this.btnKhoitao.Size = new System.Drawing.Size(108, 46);
            this.btnKhoitao.TabIndex = 9;
            this.btnKhoitao.Text = "Khởi tạo";
            this.btnKhoitao.UseVisualStyleBackColor = true;
            this.btnKhoitao.Click += new System.EventHandler(this.btnKhoitao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(229, 89);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 46);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(229, 21);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(108, 46);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(47, 89);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(108, 46);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtthongtintim);
            this.groupBox1.Controls.Add(this.txtNamsx);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gr_chọn);
            this.groupBox1.Controls.Add(this.txtMaxe);
            this.groupBox1.Controls.Add(this.txtTenxe);
            this.groupBox1.Controls.Add(this.txtHangsx);
            this.groupBox1.Controls.Add(this.txtBienso);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.txtTinhtrang);
            this.groupBox1.Controls.Add(this.txtLoaixe);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(664, 214);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Xe";
            // 
            // txtthongtintim
            // 
            this.txtthongtintim.Location = new System.Drawing.Point(600, 234);
            this.txtthongtintim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtthongtintim.Name = "txtthongtintim";
            this.txtthongtintim.Size = new System.Drawing.Size(208, 22);
            this.txtthongtintim.TabIndex = 18;
            // 
            // txtNamsx
            // 
            this.txtNamsx.Location = new System.Drawing.Point(133, 128);
            this.txtNamsx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNamsx.Name = "txtNamsx";
            this.txtNamsx.Size = new System.Drawing.Size(167, 22);
            this.txtNamsx.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(501, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Nhập TT Tìm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Năm sản xuất";
            // 
            // gr_chọn
            // 
            this.gr_chọn.Controls.Add(this.rdt_malaixe);
            this.gr_chọn.Controls.Add(this.rdt_tenlaixe);
            this.gr_chọn.Location = new System.Drawing.Point(169, 210);
            this.gr_chọn.Margin = new System.Windows.Forms.Padding(4);
            this.gr_chọn.Name = "gr_chọn";
            this.gr_chọn.Padding = new System.Windows.Forms.Padding(4);
            this.gr_chọn.Size = new System.Drawing.Size(325, 65);
            this.gr_chọn.TabIndex = 16;
            this.gr_chọn.TabStop = false;
            this.gr_chọn.Text = "Chọn";
            // 
            // rdt_malaixe
            // 
            this.rdt_malaixe.AutoSize = true;
            this.rdt_malaixe.Location = new System.Drawing.Point(169, 23);
            this.rdt_malaixe.Margin = new System.Windows.Forms.Padding(4);
            this.rdt_malaixe.Name = "rdt_malaixe";
            this.rdt_malaixe.Size = new System.Drawing.Size(119, 21);
            this.rdt_malaixe.TabIndex = 9;
            this.rdt_malaixe.TabStop = true;
            this.rdt_malaixe.Text = "Tìm Mã Lái Xe";
            this.rdt_malaixe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdt_malaixe.UseVisualStyleBackColor = true;
            // 
            // rdt_tenlaixe
            // 
            this.rdt_tenlaixe.AutoSize = true;
            this.rdt_tenlaixe.Location = new System.Drawing.Point(8, 23);
            this.rdt_tenlaixe.Margin = new System.Windows.Forms.Padding(4);
            this.rdt_tenlaixe.Name = "rdt_tenlaixe";
            this.rdt_tenlaixe.Size = new System.Drawing.Size(125, 21);
            this.rdt_tenlaixe.TabIndex = 8;
            this.rdt_tenlaixe.TabStop = true;
            this.rdt_tenlaixe.Text = "Tìm Tên Lái Xe";
            this.rdt_tenlaixe.UseVisualStyleBackColor = true;
            // 
            // txtMaxe
            // 
            this.txtMaxe.Location = new System.Drawing.Point(133, 21);
            this.txtMaxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxe.Name = "txtMaxe";
            this.txtMaxe.Size = new System.Drawing.Size(167, 22);
            this.txtMaxe.TabIndex = 2;
            // 
            // txtTenxe
            // 
            this.txtTenxe.Location = new System.Drawing.Point(133, 71);
            this.txtTenxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenxe.Name = "txtTenxe";
            this.txtTenxe.Size = new System.Drawing.Size(167, 22);
            this.txtTenxe.TabIndex = 2;
            // 
            // txtHangsx
            // 
            this.txtHangsx.Location = new System.Drawing.Point(133, 180);
            this.txtHangsx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHangsx.Name = "txtHangsx";
            this.txtHangsx.Size = new System.Drawing.Size(167, 22);
            this.txtHangsx.TabIndex = 2;
            // 
            // txtBienso
            // 
            this.txtBienso.Location = new System.Drawing.Point(457, 26);
            this.txtBienso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBienso.Name = "txtBienso";
            this.txtBienso.Size = new System.Drawing.Size(169, 22);
            this.txtBienso.TabIndex = 2;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(457, 175);
            this.txtSoluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(169, 22);
            this.txtSoluong.TabIndex = 2;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Location = new System.Drawing.Point(457, 119);
            this.txtTinhtrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.Size = new System.Drawing.Size(169, 22);
            this.txtTinhtrang.TabIndex = 2;
            // 
            // txtLoaixe
            // 
            this.txtLoaixe.Location = new System.Drawing.Point(457, 73);
            this.txtLoaixe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoaixe.Name = "txtLoaixe";
            this.txtLoaixe.Size = new System.Drawing.Size(169, 22);
            this.txtLoaixe.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Biển Số Xe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tình Trạng Xe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hãng Sản Xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại Xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Xe";
            // 
            // txttttim
            // 
            this.txttttim.Location = new System.Drawing.Point(489, 257);
            this.txttttim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttttim.Name = "txttttim";
            this.txttttim.Size = new System.Drawing.Size(169, 22);
            this.txttttim.TabIndex = 18;
            this.txttttim.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txttttim_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(380, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nhập TT Tìm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdt_maxe);
            this.groupBox4.Controls.Add(this.rdt_tenxe);
            this.groupBox4.Location = new System.Drawing.Point(37, 234);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(325, 65);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn";
            // 
            // rdt_maxe
            // 
            this.rdt_maxe.AutoSize = true;
            this.rdt_maxe.Location = new System.Drawing.Point(169, 23);
            this.rdt_maxe.Margin = new System.Windows.Forms.Padding(4);
            this.rdt_maxe.Name = "rdt_maxe";
            this.rdt_maxe.Size = new System.Drawing.Size(96, 21);
            this.rdt_maxe.TabIndex = 9;
            this.rdt_maxe.TabStop = true;
            this.rdt_maxe.Text = "Tìm Mã Xe";
            this.rdt_maxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdt_maxe.UseVisualStyleBackColor = true;
            this.rdt_maxe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_tim_Click);
            // 
            // rdt_tenxe
            // 
            this.rdt_tenxe.AutoSize = true;
            this.rdt_tenxe.Location = new System.Drawing.Point(8, 23);
            this.rdt_tenxe.Margin = new System.Windows.Forms.Padding(4);
            this.rdt_tenxe.Name = "rdt_tenxe";
            this.rdt_tenxe.Size = new System.Drawing.Size(102, 21);
            this.rdt_tenxe.TabIndex = 8;
            this.rdt_tenxe.TabStop = true;
            this.rdt_tenxe.Text = "Tìm Tên Xe";
            this.rdt_tenxe.UseVisualStyleBackColor = true;
            this.rdt_tenxe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_tim_Click);
            // 
            // Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 543);
            this.Controls.Add(this.txttttim);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Xe";
            this.Text = "Xe";
            this.Load += new System.EventHandler(this.Xe_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gr_chọn.ResumeLayout(false);
            this.gr_chọn.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnKhoitao;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNamsx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxe;
        private System.Windows.Forms.TextBox txtTenxe;
        private System.Windows.Forms.TextBox txtHangsx;
        private System.Windows.Forms.TextBox txtBienso;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.TextBox txtLoaixe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtthongtintim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gr_chọn;
        private System.Windows.Forms.RadioButton rdt_malaixe;
        private System.Windows.Forms.RadioButton rdt_tenlaixe;
        private System.Windows.Forms.TextBox txttttim;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdt_maxe;
        private System.Windows.Forms.RadioButton rdt_tenxe;
        private System.Windows.Forms.Button btn_tim;
    }
}