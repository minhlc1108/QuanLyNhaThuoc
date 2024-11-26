namespace GUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelMenu = new Panel();
            btnDangXuat = new FontAwesome.Sharp.IconButton();
            btnThongKe = new FontAwesome.Sharp.IconButton();
            btnNhaCungCap = new FontAwesome.Sharp.IconButton();
            btnNhaSanXuat = new FontAwesome.Sharp.IconButton();
            btnKhachHang = new FontAwesome.Sharp.IconButton();
            btnDuocSi = new FontAwesome.Sharp.IconButton();
            btnTieuHuy = new FontAwesome.Sharp.IconButton();
            btnPhieuNhap = new FontAwesome.Sharp.IconButton();
            btnHoaDon = new FontAwesome.Sharp.IconButton();
            btnLoaiSanPham = new FontAwesome.Sharp.IconButton();
            btnSanPham = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            iconUser = new FontAwesome.Sharp.IconPictureBox();
            labelTenDS = new Label();
            panelDesktop = new Panel();
            panelMenu.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 153, 207);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Controls.Add(btnThongKe);
            panelMenu.Controls.Add(btnNhaCungCap);
            panelMenu.Controls.Add(btnNhaSanXuat);
            panelMenu.Controls.Add(btnKhachHang);
            panelMenu.Controls.Add(btnDuocSi);
            panelMenu.Controls.Add(btnTieuHuy);
            panelMenu.Controls.Add(btnPhieuNhap);
            panelMenu.Controls.Add(btnHoaDon);
            panelMenu.Controls.Add(btnLoaiSanPham);
            panelMenu.Controls.Add(btnSanPham);
            panelMenu.Controls.Add(panel2);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(219, 903);
            panelMenu.TabIndex = 0;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI", 11F);
            btnDangXuat.ForeColor = Color.Gainsboro;
            btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.ArrowUpRightFromSquare;
            btnDangXuat.IconColor = Color.Gainsboro;
            btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.Location = new Point(0, 843);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Padding = new Padding(10, 0, 0, 0);
            btnDangXuat.Size = new Size(219, 60);
            btnDangXuat.TabIndex = 11;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnDangXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDangXuat.UseVisualStyleBackColor = true;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 11F);
            btnThongKe.ForeColor = Color.Gainsboro;
            btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            btnThongKe.IconColor = Color.Gainsboro;
            btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnThongKe.ImageAlign = ContentAlignment.MiddleLeft;
            btnThongKe.Location = new Point(0, 665);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(10, 0, 0, 0);
            btnThongKe.Size = new Size(219, 60);
            btnThongKe.TabIndex = 10;
            btnThongKe.Text = "Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.Dock = DockStyle.Top;
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Font = new Font("Segoe UI", 11F);
            btnNhaCungCap.ForeColor = Color.Gainsboro;
            btnNhaCungCap.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            btnNhaCungCap.IconColor = Color.Gainsboro;
            btnNhaCungCap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhaCungCap.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.Location = new Point(0, 605);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Padding = new Padding(10, 0, 0, 0);
            btnNhaCungCap.Size = new Size(219, 60);
            btnNhaCungCap.TabIndex = 9;
            btnNhaCungCap.Text = "Nhà cung cấp";
            btnNhaCungCap.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaCungCap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhaCungCap.UseVisualStyleBackColor = true;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnNhaSanXuat
            // 
            btnNhaSanXuat.Dock = DockStyle.Top;
            btnNhaSanXuat.FlatAppearance.BorderSize = 0;
            btnNhaSanXuat.FlatStyle = FlatStyle.Flat;
            btnNhaSanXuat.Font = new Font("Segoe UI", 11F);
            btnNhaSanXuat.ForeColor = Color.Gainsboro;
            btnNhaSanXuat.IconChar = FontAwesome.Sharp.IconChar.Industry;
            btnNhaSanXuat.IconColor = Color.Gainsboro;
            btnNhaSanXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNhaSanXuat.ImageAlign = ContentAlignment.MiddleLeft;
            btnNhaSanXuat.Location = new Point(0, 545);
            btnNhaSanXuat.Name = "btnNhaSanXuat";
            btnNhaSanXuat.Padding = new Padding(10, 0, 0, 0);
            btnNhaSanXuat.Size = new Size(219, 60);
            btnNhaSanXuat.TabIndex = 12;
            btnNhaSanXuat.Text = "Nhà sản xuất";
            btnNhaSanXuat.TextAlign = ContentAlignment.MiddleLeft;
            btnNhaSanXuat.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNhaSanXuat.UseVisualStyleBackColor = true;
            btnNhaSanXuat.Click += btnNhaSanXuat_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 11F);
            btnKhachHang.ForeColor = Color.Gainsboro;
            btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnKhachHang.IconColor = Color.Gainsboro;
            btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnKhachHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.Location = new Point(0, 485);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Padding = new Padding(10, 0, 0, 0);
            btnKhachHang.Size = new Size(219, 60);
            btnKhachHang.TabIndex = 7;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.TextAlign = ContentAlignment.MiddleLeft;
            btnKhachHang.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnKhachHang.UseVisualStyleBackColor = true;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnDuocSi
            // 
            btnDuocSi.Dock = DockStyle.Top;
            btnDuocSi.FlatAppearance.BorderSize = 0;
            btnDuocSi.FlatStyle = FlatStyle.Flat;
            btnDuocSi.Font = new Font("Segoe UI", 11F);
            btnDuocSi.ForeColor = Color.Gainsboro;
            btnDuocSi.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            btnDuocSi.IconColor = Color.Gainsboro;
            btnDuocSi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDuocSi.ImageAlign = ContentAlignment.MiddleLeft;
            btnDuocSi.Location = new Point(0, 425);
            btnDuocSi.Name = "btnDuocSi";
            btnDuocSi.Padding = new Padding(10, 0, 0, 0);
            btnDuocSi.Size = new Size(219, 60);
            btnDuocSi.TabIndex = 6;
            btnDuocSi.Text = "Dược sĩ";
            btnDuocSi.TextAlign = ContentAlignment.MiddleLeft;
            btnDuocSi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDuocSi.UseVisualStyleBackColor = true;
            btnDuocSi.Click += btnDuocSi_Click;
            // 
            // btnTieuHuy
            // 
            btnTieuHuy.Dock = DockStyle.Top;
            btnTieuHuy.FlatAppearance.BorderSize = 0;
            btnTieuHuy.FlatStyle = FlatStyle.Flat;
            btnTieuHuy.Font = new Font("Segoe UI", 11F);
            btnTieuHuy.ForeColor = Color.Gainsboro;
            btnTieuHuy.IconChar = FontAwesome.Sharp.IconChar.FileCircleXmark;
            btnTieuHuy.IconColor = Color.Gainsboro;
            btnTieuHuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTieuHuy.ImageAlign = ContentAlignment.MiddleLeft;
            btnTieuHuy.Location = new Point(0, 365);
            btnTieuHuy.Name = "btnTieuHuy";
            btnTieuHuy.Padding = new Padding(10, 0, 0, 0);
            btnTieuHuy.Size = new Size(219, 60);
            btnTieuHuy.TabIndex = 14;
            btnTieuHuy.Text = "Tiêu hủy";
            btnTieuHuy.TextAlign = ContentAlignment.MiddleLeft;
            btnTieuHuy.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTieuHuy.UseVisualStyleBackColor = true;
            btnTieuHuy.Click += btnTieuHuy_Click;
            // 
            // btnPhieuNhap
            // 
            btnPhieuNhap.Dock = DockStyle.Top;
            btnPhieuNhap.FlatAppearance.BorderSize = 0;
            btnPhieuNhap.FlatStyle = FlatStyle.Flat;
            btnPhieuNhap.Font = new Font("Segoe UI", 11F);
            btnPhieuNhap.ForeColor = Color.Gainsboro;
            btnPhieuNhap.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            btnPhieuNhap.IconColor = Color.Gainsboro;
            btnPhieuNhap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPhieuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhap.Location = new Point(0, 305);
            btnPhieuNhap.Name = "btnPhieuNhap";
            btnPhieuNhap.Padding = new Padding(10, 0, 0, 0);
            btnPhieuNhap.Size = new Size(219, 60);
            btnPhieuNhap.TabIndex = 5;
            btnPhieuNhap.Text = "Phiếu nhập";
            btnPhieuNhap.TextAlign = ContentAlignment.MiddleLeft;
            btnPhieuNhap.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPhieuNhap.UseVisualStyleBackColor = true;
            btnPhieuNhap.Click += btnPhieuNhap_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 11F);
            btnHoaDon.ForeColor = Color.Gainsboro;
            btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            btnHoaDon.IconColor = Color.Gainsboro;
            btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHoaDon.ImageAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.Location = new Point(0, 245);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(10, 0, 0, 0);
            btnHoaDon.Size = new Size(219, 60);
            btnHoaDon.TabIndex = 4;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHoaDon.UseVisualStyleBackColor = true;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnLoaiSanPham
            // 
            btnLoaiSanPham.Dock = DockStyle.Top;
            btnLoaiSanPham.FlatAppearance.BorderSize = 0;
            btnLoaiSanPham.FlatStyle = FlatStyle.Flat;
            btnLoaiSanPham.Font = new Font("Segoe UI", 11F);
            btnLoaiSanPham.ForeColor = Color.Gainsboro;
            btnLoaiSanPham.IconChar = FontAwesome.Sharp.IconChar.Capsules;
            btnLoaiSanPham.IconColor = Color.Gainsboro;
            btnLoaiSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLoaiSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.Location = new Point(0, 185);
            btnLoaiSanPham.Name = "btnLoaiSanPham";
            btnLoaiSanPham.Padding = new Padding(10, 0, 0, 0);
            btnLoaiSanPham.Size = new Size(219, 60);
            btnLoaiSanPham.TabIndex = 13;
            btnLoaiSanPham.Text = "Loại sản phẩm";
            btnLoaiSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnLoaiSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLoaiSanPham.UseVisualStyleBackColor = true;
            btnLoaiSanPham.Click += btnLoaiSanPham_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.FromArgb(0, 153, 207);
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 11F);
            btnSanPham.ForeColor = Color.Gainsboro;
            btnSanPham.IconChar = FontAwesome.Sharp.IconChar.Pills;
            btnSanPham.IconColor = Color.Gainsboro;
            btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSanPham.ImageAlign = ContentAlignment.MiddleLeft;
            btnSanPham.Location = new Point(0, 125);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(10, 0, 0, 0);
            btnSanPham.Size = new Size(219, 60);
            btnSanPham.TabIndex = 3;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 125);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(5, 79);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ NHÀ THUỐC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(74, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 120);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 153, 255);
            panel3.Controls.Add(iconUser);
            panel3.Controls.Add(labelTenDS);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(219, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1263, 44);
            panel3.TabIndex = 1;
            // 
            // iconUser
            // 
            iconUser.BackColor = Color.FromArgb(0, 153, 255);
            iconUser.Dock = DockStyle.Right;
            iconUser.ForeColor = Color.Gainsboro;
            iconUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            iconUser.IconColor = Color.Gainsboro;
            iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconUser.IconSize = 40;
            iconUser.Location = new Point(1103, 0);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(40, 44);
            iconUser.SizeMode = PictureBoxSizeMode.CenterImage;
            iconUser.TabIndex = 3;
            iconUser.TabStop = false;
            iconUser.Click += iconUser_Click;
            // 
            // labelTenDS
            // 
            labelTenDS.AutoSize = true;
            labelTenDS.Dock = DockStyle.Right;
            labelTenDS.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTenDS.ForeColor = Color.Gainsboro;
            labelTenDS.Location = new Point(1143, 0);
            labelTenDS.Name = "labelTenDS";
            labelTenDS.Padding = new Padding(0, 5, 0, 5);
            labelTenDS.Size = new Size(120, 38);
            labelTenDS.TabIndex = 2;
            labelTenDS.Text = "Tên dược sĩ";
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(219, 44);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1263, 859);
            panelDesktop.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 903);
            Controls.Add(panelDesktop);
            Controls.Add(panel3);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ImeMode = ImeMode.On;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panelMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnDuocSi;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnNhaCungCap;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnPhieuNhap;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private PictureBox pictureBox2;
        private Label label1;
        private Panel panel3;
        private Label labelTenDS;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnNhaSanXuat;
        private FontAwesome.Sharp.IconButton btnTieuHuy;
        private FontAwesome.Sharp.IconButton btnLoaiSanPham;
    }
}