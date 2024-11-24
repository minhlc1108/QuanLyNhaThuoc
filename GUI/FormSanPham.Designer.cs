    namespace GUI
{
    partial class FormSanPham
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
            label2 = new Label();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnThemSanPham = new Button();
            btnResetSanPham = new Button();
            btnUpdateSanPham = new Button();
            lsvSanPham = new ListView();
            clMaSP = new ColumnHeader();
            clTenSP = new ColumnHeader();
            clLoaiSP = new ColumnHeader();
            clNhaSX = new ColumnHeader();
            clQuyCach = new ColumnHeader();
            clXuatXu = new ColumnHeader();
            clKeToa = new ColumnHeader();
            clSoLuong = new ColumnHeader();
            clTrangThai = new ColumnHeader();
            btnKhoaSanPham = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnXuatDanhSachExcel = new Button();
            button1 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            txtMaSanPham = new TextBox();
            label12 = new Label();
            cbbKeToa = new ComboBox();
            label11 = new Label();
            cbbNhaSX = new ComboBox();
            cbbLoaiSanPham = new ComboBox();
            txtQuyCach = new TextBox();
            txtXuatXu = new TextBox();
            txtThanhPhan = new TextBox();
            txtDieuTriBenh = new TextBox();
            txtTenSanPham = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            erorr_email = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(385, 9);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ SẢN PHẨM";
            label2.Click += label2_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(985, 48);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(128, 26);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "TÌM";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(452, 48);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(510, 23);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.TextChanged += textBox1_TextChanged;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Location = new Point(36, 28);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(146, 28);
            btnThemSanPham.TabIndex = 20;
            btnThemSanPham.Text = "THÊM";
            btnThemSanPham.UseVisualStyleBackColor = true;
            btnThemSanPham.Click += button2_Click;
            // 
            // btnResetSanPham
            // 
            btnResetSanPham.Location = new Point(230, 28);
            btnResetSanPham.Name = "btnResetSanPham";
            btnResetSanPham.Size = new Size(149, 28);
            btnResetSanPham.TabIndex = 21;
            btnResetSanPham.Text = "LÀM MỚI";
            btnResetSanPham.UseVisualStyleBackColor = true;
            btnResetSanPham.Click += btnResetSanPham_Click;
            // 
            // btnUpdateSanPham
            // 
            btnUpdateSanPham.Location = new Point(36, 73);
            btnUpdateSanPham.Name = "btnUpdateSanPham";
            btnUpdateSanPham.Size = new Size(146, 28);
            btnUpdateSanPham.TabIndex = 22;
            btnUpdateSanPham.Text = "LƯU CHỈNH SỬA";
            btnUpdateSanPham.UseVisualStyleBackColor = true;
            btnUpdateSanPham.Click += btnUpdateSanPham_Click;
            // 
            // lsvSanPham
            // 
            lsvSanPham.Columns.AddRange(new ColumnHeader[] { clMaSP, clTenSP, clLoaiSP, clNhaSX, clQuyCach, clXuatXu, clKeToa, clSoLuong, clTrangThai });
            lsvSanPham.FullRowSelect = true;
            lsvSanPham.Location = new Point(452, 87);
            lsvSanPham.Name = "lsvSanPham";
            lsvSanPham.Size = new Size(661, 399);
            lsvSanPham.TabIndex = 23;
            lsvSanPham.UseCompatibleStateImageBehavior = false;
            lsvSanPham.View = View.Details;
            lsvSanPham.ItemSelectionChanged += lsvSanPham_ItemSelectionChanged;
            lsvSanPham.SelectedIndexChanged += lsvSanPham_SelectedIndexChanged;
            // 
            // clMaSP
            // 
            clMaSP.Text = "Mã SP";
            // 
            // clTenSP
            // 
            clTenSP.Text = "Tên SP";
            clTenSP.TextAlign = HorizontalAlignment.Center;
            // 
            // clLoaiSP
            // 
            clLoaiSP.Text = "Loại SP";
            clLoaiSP.TextAlign = HorizontalAlignment.Center;
            // 
            // clNhaSX
            // 
            clNhaSX.Text = "Nhà SX";
            clNhaSX.TextAlign = HorizontalAlignment.Center;
            clNhaSX.Width = 65;
            // 
            // clQuyCach
            // 
            clQuyCach.Text = "Quy Cách";
            clQuyCach.TextAlign = HorizontalAlignment.Center;
            clQuyCach.Width = 100;
            // 
            // clXuatXu
            // 
            clXuatXu.Text = "Xuất xứ";
            clXuatXu.TextAlign = HorizontalAlignment.Center;
            clXuatXu.Width = 70;
            // 
            // clKeToa
            // 
            clKeToa.Text = "Kê Toa";
            clKeToa.TextAlign = HorizontalAlignment.Center;
            clKeToa.Width = 75;
            // 
            // clSoLuong
            // 
            clSoLuong.Text = "Số Lượng";
            clSoLuong.TextAlign = HorizontalAlignment.Center;
            clSoLuong.Width = 70;
            // 
            // clTrangThai
            // 
            clTrangThai.Text = "Trạng Thái";
            clTrangThai.TextAlign = HorizontalAlignment.Center;
            clTrangThai.Width = 90;
            // 
            // btnKhoaSanPham
            // 
            btnKhoaSanPham.Location = new Point(230, 74);
            btnKhoaSanPham.Name = "btnKhoaSanPham";
            btnKhoaSanPham.Size = new Size(149, 28);
            btnKhoaSanPham.TabIndex = 24;
            btnKhoaSanPham.Text = "KHÓA / MỞ KHÓA";
            btnKhoaSanPham.UseVisualStyleBackColor = true;
            btnKhoaSanPham.Click += btnKhoaSanPham_Click;
            // 
            // btnXuatDanhSachExcel
            // 
            btnXuatDanhSachExcel.Location = new Point(259, 49);
            btnXuatDanhSachExcel.Name = "btnXuatDanhSachExcel";
            btnXuatDanhSachExcel.Size = new Size(151, 38);
            btnXuatDanhSachExcel.TabIndex = 25;
            btnXuatDanhSachExcel.Text = "Xuất Excel";
            btnXuatDanhSachExcel.UseVisualStyleBackColor = true;
            btnXuatDanhSachExcel.Click += btnXuatDanhSach_Click;
            // 
            // button1
            // 
            button1.Location = new Point(44, 49);
            button1.Name = "button1";
            button1.Size = new Size(151, 38);
            button1.TabIndex = 32;
            button1.Text = "Xuất PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(472, 47);
            button3.Name = "button3";
            button3.Size = new Size(151, 38);
            button3.TabIndex = 34;
            button3.Text = "Nhập Excel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMaSanPham);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(cbbKeToa);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cbbNhaSX);
            groupBox1.Controls.Add(cbbLoaiSanPham);
            groupBox1.Controls.Add(txtQuyCach);
            groupBox1.Controls.Add(txtXuatXu);
            groupBox1.Controls.Add(txtThanhPhan);
            groupBox1.Controls.Add(txtDieuTriBenh);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(erorr_email);
            groupBox1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(421, 464);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(144, 38);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(267, 29);
            txtMaSanPham.TabIndex = 52;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(10, 41);
            label12.Name = "label12";
            label12.Size = new Size(115, 21);
            label12.TabIndex = 51;
            label12.Text = "Mã Sản Phẩm :";
            // 
            // cbbKeToa
            // 
            cbbKeToa.FormattingEnabled = true;
            cbbKeToa.Items.AddRange(new object[] { "Cần Kê Toa", "Không Cần Kê Toa" });
            cbbKeToa.Location = new Point(142, 332);
            cbbKeToa.Name = "cbbKeToa";
            cbbKeToa.Size = new Size(269, 29);
            cbbKeToa.TabIndex = 50;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(10, 332);
            label11.Name = "label11";
            label11.Size = new Size(66, 21);
            label11.TabIndex = 49;
            label11.Text = "Kê Toa :";
            // 
            // cbbNhaSX
            // 
            cbbNhaSX.FormattingEnabled = true;
            cbbNhaSX.Location = new Point(142, 188);
            cbbNhaSX.Name = "cbbNhaSX";
            cbbNhaSX.Size = new Size(269, 29);
            cbbNhaSX.TabIndex = 48;
            // 
            // cbbLoaiSanPham
            // 
            cbbLoaiSanPham.FormattingEnabled = true;
            cbbLoaiSanPham.Location = new Point(143, 134);
            cbbLoaiSanPham.Name = "cbbLoaiSanPham";
            cbbLoaiSanPham.Size = new Size(268, 29);
            cbbLoaiSanPham.TabIndex = 47;
            // 
            // txtQuyCach
            // 
            txtQuyCach.Location = new Point(142, 284);
            txtQuyCach.Name = "txtQuyCach";
            txtQuyCach.Size = new Size(269, 29);
            txtQuyCach.TabIndex = 46;
            // 
            // txtXuatXu
            // 
            txtXuatXu.Location = new Point(142, 238);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(269, 29);
            txtXuatXu.TabIndex = 45;
            // 
            // txtThanhPhan
            // 
            txtThanhPhan.Location = new Point(142, 378);
            txtThanhPhan.Name = "txtThanhPhan";
            txtThanhPhan.Size = new Size(269, 29);
            txtThanhPhan.TabIndex = 44;
            // 
            // txtDieuTriBenh
            // 
            txtDieuTriBenh.Location = new Point(142, 420);
            txtDieuTriBenh.Name = "txtDieuTriBenh";
            txtDieuTriBenh.Size = new Size(269, 29);
            txtDieuTriBenh.TabIndex = 43;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(144, 85);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(267, 29);
            txtTenSanPham.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 420);
            label10.Name = "label10";
            label10.Size = new Size(112, 21);
            label10.TabIndex = 41;
            label10.Text = "Điều trị bệnh :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(10, 378);
            label9.Name = "label9";
            label9.Size = new Size(102, 21);
            label9.TabIndex = 40;
            label9.Text = "Thành phần :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(10, 284);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 39;
            label8.Text = "Quy cách :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 238);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 38;
            label7.Text = "Xuất xứ :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 188);
            label6.Name = "label6";
            label6.Size = new Size(110, 21);
            label6.TabIndex = 37;
            label6.Text = "Nhà sản xuất :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 137);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 36;
            label5.Text = "Loại sản phẩm :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 88);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 35;
            label4.Text = "Tên sản phẩm :";
            // 
            // erorr_email
            // 
            erorr_email.AutoSize = true;
            erorr_email.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_email.ForeColor = Color.Red;
            erorr_email.Location = new Point(98, 314);
            erorr_email.Name = "erorr_email";
            erorr_email.Size = new Size(0, 15);
            erorr_email.TabIndex = 34;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnResetSanPham);
            groupBox2.Controls.Add(btnThemSanPham);
            groupBox2.Controls.Add(btnUpdateSanPham);
            groupBox2.Controls.Add(btnKhoaSanPham);
            groupBox2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 507);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(421, 121);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnXuatDanhSachExcel);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(button3);
            groupBox3.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(452, 507);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(662, 121);
            groupBox3.TabIndex = 37;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng khác";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 681);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lsvSanPham);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Button btnThemSanPham;
        private Button btnResetSanPham;
        private Button btnUpdateSanPham;
        private ListView lsvSanPham;
        private ColumnHeader clMaSP;
        private ColumnHeader clTenSP;
        private ColumnHeader clLoaiSP;
        private ColumnHeader clNhaSX;
        private ColumnHeader clQuyCach;
        private ColumnHeader clXuatXu;
        private ColumnHeader clTrangThai;
        private Button btnKhoaSanPham;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnXuatDanhSachExcel;
        private ColumnHeader clKeToa;
        private ColumnHeader clSoLuong;
        private Button button1;
        private Button button3;
        private GroupBox groupBox1;
        private Label erorr_email;
        private TextBox txtMaSanPham;
        private Label label12;
        private ComboBox cbbKeToa;
        private Label label11;
        private ComboBox cbbNhaSX;
        private ComboBox cbbLoaiSanPham;
        private TextBox txtQuyCach;
        private TextBox txtXuatXu;
        private TextBox txtThanhPhan;
        private TextBox txtDieuTriBenh;
        private TextBox txtTenSanPham;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}