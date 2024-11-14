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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtTenSanPham = new TextBox();
            txtDieuTriBenh = new TextBox();
            txtThanhPhan = new TextBox();
            txtXuatXu = new TextBox();
            txtQuyCach = new TextBox();
            cbbLoaiSanPham = new ComboBox();
            cbbNhaSX = new ComboBox();
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
            clKeToa = new ColumnHeader();
            clTrangThai = new ColumnHeader();
            btnKhoaSanPham = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnXuatDanhSach = new Button();
            label1 = new Label();
            label11 = new Label();
            cbbKeToa = new ComboBox();
            txtMaSanPham = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(452, 9);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ SẢN PHẨM";
            label2.Click += label2_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(984, 90);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(128, 26);
            btnTimKiem.TabIndex = 3;
            btnTimKiem.Text = "TÌM";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(472, 87);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(491, 23);
            txtTimKiem.TabIndex = 4;
            txtTimKiem.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(752, 39);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "TÌM KIẾM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 134);
            label4.Location = new Point(15, 134);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 6;
            label4.Text = "Tên sản phẩm :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 178);
            label5.Location = new Point(15, 178);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 7;
            label5.Text = "Loại sản phẩm :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 228);
            label6.Location = new Point(14, 228);
            label6.Name = "label6";
            label6.Size = new Size(110, 21);
            label6.TabIndex = 8;
            label6.Text = "Nhà sản xuất :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 277);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 9;
            label7.Text = "Xuất xứ :";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 328);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 10;
            label8.Text = "Quy cách :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 431);
            label9.Name = "label9";
            label9.Size = new Size(102, 21);
            label9.TabIndex = 11;
            label9.Text = "Thành phần :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 485);
            label10.Location = new Point(12, 485);
            label10.Name = "label10";
            label10.Size = new Size(112, 21);
            label10.TabIndex = 12;
            label10.Text = "Điều trị bệnh :";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(149, 132);
            txtTenSanPham.Location = new Point(149, 132);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(295, 23);
            txtTenSanPham.TabIndex = 13;
            // 
            // txtDieuTriBenh
            // 
            txtDieuTriBenh.Location = new Point(149, 487);
            txtDieuTriBenh.Location = new Point(149, 487);
            txtDieuTriBenh.Name = "txtDieuTriBenh";
            txtDieuTriBenh.Size = new Size(295, 23);
            txtDieuTriBenh.TabIndex = 14;
            // 
            // txtThanhPhan
            // 
            txtThanhPhan.Location = new Point(149, 433);
            txtThanhPhan.Name = "txtThanhPhan";
            txtThanhPhan.Size = new Size(295, 23);
            txtThanhPhan.TabIndex = 15;
            // 
            // txtXuatXu
            // 
            txtXuatXu.Location = new Point(149, 275);
            txtXuatXu.Name = "txtXuatXu";
            txtXuatXu.Size = new Size(295, 23);
            txtXuatXu.TabIndex = 16;
            // 
            // txtQuyCach
            // 
            txtQuyCach.Location = new Point(149, 330);
            txtQuyCach.Name = "txtQuyCach";
            txtQuyCach.Size = new Size(295, 23);
            txtQuyCach.TabIndex = 17;
            // 
            // cbbLoaiSanPham
            // 
            cbbLoaiSanPham.FormattingEnabled = true;
            cbbLoaiSanPham.Location = new Point(149, 180);
            cbbLoaiSanPham.Location = new Point(149, 180);
            cbbLoaiSanPham.Name = "cbbLoaiSanPham";
            cbbLoaiSanPham.Size = new Size(295, 23);
            cbbLoaiSanPham.TabIndex = 18;
            // 
            // cbbNhaSX
            // 
            cbbNhaSX.FormattingEnabled = true;
            cbbNhaSX.Location = new Point(148, 226);
            cbbNhaSX.Location = new Point(148, 226);
            cbbNhaSX.Name = "cbbNhaSX";
            cbbNhaSX.Size = new Size(296, 23);
            cbbNhaSX.TabIndex = 19;
            // 
            // btnThemSanPham
            // 
            btnThemSanPham.Location = new Point(52, 544);
            btnThemSanPham.Name = "btnThemSanPham";
            btnThemSanPham.Size = new Size(133, 26);
            btnThemSanPham.TabIndex = 20;
            btnThemSanPham.Text = "THÊM";
            btnThemSanPham.UseVisualStyleBackColor = true;
            btnThemSanPham.Click += button2_Click;
            // 
            // btnResetSanPham
            // 
            btnResetSanPham.Location = new Point(251, 544);
            btnResetSanPham.Name = "btnResetSanPham";
            btnResetSanPham.Size = new Size(121, 26);
            btnResetSanPham.TabIndex = 21;
            btnResetSanPham.Text = "LÀM MỚI";
            btnResetSanPham.UseVisualStyleBackColor = true;
            btnResetSanPham.Click += btnResetSanPham_Click;
            // 
            // btnUpdateSanPham
            // 
            btnUpdateSanPham.Location = new Point(52, 591);
            btnUpdateSanPham.Name = "btnUpdateSanPham";
            btnUpdateSanPham.Size = new Size(133, 26);
            btnUpdateSanPham.TabIndex = 22;
            btnUpdateSanPham.Text = "LƯU CHỈNH SỬA";
            btnUpdateSanPham.UseVisualStyleBackColor = true;
            btnUpdateSanPham.Click += btnUpdateSanPham_Click;
            // 
            // lsvSanPham
            // 
            lsvSanPham.Columns.AddRange(new ColumnHeader[] { clMaSP, clTenSP, clLoaiSP, clNhaSX, clQuyCach, clXuatXu, clKeToa, clTrangThai });
            lsvSanPham.FullRowSelect = true;
            lsvSanPham.Location = new Point(472, 137);
            lsvSanPham.Name = "lsvSanPham";
            lsvSanPham.Size = new Size(661, 433);
            lsvSanPham.TabIndex = 23;
            lsvSanPham.UseCompatibleStateImageBehavior = false;
            lsvSanPham.View = View.Details;
            lsvSanPham.ItemSelectionChanged += lsvSanPham_ItemSelectionChanged;
            lsvSanPham.SelectedIndexChanged += lsvSanPham_SelectedIndexChanged;
            lsvSanPham.ItemSelectionChanged += lsvSanPham_ItemSelectionChanged;
            lsvSanPham.SelectedIndexChanged += lsvSanPham_SelectedIndexChanged;
            // 
            // clMaSP
            // 
            clMaSP.Text = "Mã SP";
            clMaSP.Width = 80;
            // 
            // clTenSP
            // 
            clTenSP.Text = "Tên SP";
            clTenSP.Width = 80;
            clTenSP.Width = 80;
            // 
            // clLoaiSP
            // 
            clLoaiSP.Text = "Loại SP";
            clLoaiSP.Width = 70;
            // 
            // clNhaSX
            // 
            clNhaSX.Text = "Nhà SX";
            clNhaSX.Width = 70;
            // 
            // clQuyCach
            // 
            clQuyCach.Text = "Quy Cách";
            clQuyCach.Width = 120;
            // 
            // clXuatXu
            // 
            clXuatXu.Text = "Xuất xứ";
            clXuatXu.Width = 70;
            // 
            // clKeToa
            // 
            clKeToa.Text = "Kê Toa";
            clKeToa.Width = 80;
            // 
            // clKeToa
            // 
            clKeToa.Text = "Kê Toa";
            clKeToa.Width = 80;
            // 
            // clTrangThai
            // 
            clTrangThai.Text = "Trạng Thái";
            clTrangThai.Width = 90;
            // 
            // btnKhoaSanPham
            // 
            btnKhoaSanPham.Location = new Point(251, 591);
            btnKhoaSanPham.Name = "btnKhoaSanPham";
            btnKhoaSanPham.Size = new Size(121, 26);
            btnKhoaSanPham.TabIndex = 24;
            btnKhoaSanPham.Text = "KHÓA";
            btnKhoaSanPham.UseVisualStyleBackColor = true;
            btnKhoaSanPham.Click += btnKhoaSanPham_Click;
            // 
            // btnXuatDanhSach
            // 
            btnXuatDanhSach.Location = new Point(732, 591);
            btnXuatDanhSach.Name = "btnXuatDanhSach";
            btnXuatDanhSach.Size = new Size(151, 26);
            btnXuatDanhSach.Size = new Size(151, 26);
            btnXuatDanhSach.TabIndex = 25;
            btnXuatDanhSach.Text = "XUẤT DANH SÁCH";
            btnXuatDanhSach.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 36);
            label1.Location = new Point(218, 36);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "SẢN PHẨM";
            label1.Click += label1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 381);
            label11.Name = "label11";
            label11.Size = new Size(66, 21);
            label11.TabIndex = 28;
            label11.Text = "Kê Toa :";
            // 
            // cbbKeToa
            // 
            cbbKeToa.FormattingEnabled = true;
            cbbKeToa.Items.AddRange(new object[] { "Cần Kê Toa", "Không Cần Kê Toa" });
            cbbKeToa.Location = new Point(149, 383);
            cbbKeToa.Name = "cbbKeToa";
            cbbKeToa.Size = new Size(295, 23);
            cbbKeToa.TabIndex = 29;
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.Location = new Point(149, 87);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.Size = new Size(295, 23);
            txtMaSanPham.TabIndex = 31;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 85);
            label12.Name = "label12";
            label12.Size = new Size(115, 21);
            label12.TabIndex = 30;
            label12.Text = "Mã Sản Phẩm :";
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 694);
            Controls.Add(txtMaSanPham);
            Controls.Add(label12);
            Controls.Add(cbbKeToa);
            Controls.Add(label11);
            Controls.Add(btnXuatDanhSach);
            Controls.Add(btnKhoaSanPham);
            Controls.Add(lsvSanPham);
            Controls.Add(btnUpdateSanPham);
            Controls.Add(btnResetSanPham);
            Controls.Add(btnThemSanPham);
            Controls.Add(cbbNhaSX);
            Controls.Add(cbbLoaiSanPham);
            Controls.Add(txtQuyCach);
            Controls.Add(txtXuatXu);
            Controls.Add(txtThanhPhan);
            Controls.Add(txtDieuTriBenh);
            Controls.Add(txtTenSanPham);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSanPham";
            Text = "FormSanPham";
            Load += FormSanPham_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtTenSanPham;
        private TextBox txtDieuTriBenh;
        private TextBox txtThanhPhan;
        private TextBox txtXuatXu;
        private TextBox txtQuyCach;
        private ComboBox cbbLoaiSanPham;
        private ComboBox cbbNhaSX;
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
        private Button btnXuatDanhSach;
        private Label label1;
        private Label label11;
        private ComboBox cbbKeToa;
        private ColumnHeader clKeToa;
        private TextBox txtMaSanPham;
        private Label label12;
    }
}