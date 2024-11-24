
namespace GUI
{
    partial class FormLoaiSanPham
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
            label3 = new Label();
            txtLoaiSanPham = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            btnXoaLSP = new Button();
            btnUpdateLSP = new Button();
            btnResetLSP = new Button();
            btnThemLSP = new Button();
            btnXuatLSP = new Button();
            lsvLoaiSanPham = new ListView();
            clSTT = new ColumnHeader();
            clMaLoaiSP = new ColumnHeader();
            clTenLoaiSP = new ColumnHeader();
            clTrangThai = new ColumnHeader();
            label2 = new Label();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            txtMaLoaiSP = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(459, 34);
            label3.Name = "label3";
            label3.Size = new Size(249, 25);
            label3.TabIndex = 2;
            label3.Text = "QUẢN LÝ LOẠI SẢN PHẨM";
            // 
            // txtLoaiSanPham
            // 
            txtLoaiSanPham.Location = new Point(166, 239);
            txtLoaiSanPham.Name = "txtLoaiSanPham";
            txtLoaiSanPham.Size = new Size(258, 23);
            txtLoaiSanPham.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 237);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 21;
            label5.Text = "Loại sản phẩm :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 135);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 90);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 19;
            label1.Text = "LOẠI SẢN PHẨM";
            // 
            // btnXoaLSP
            // 
            btnXoaLSP.Location = new Point(54, 380);
            btnXoaLSP.Name = "btnXoaLSP";
            btnXoaLSP.Size = new Size(128, 26);
            btnXoaLSP.TabIndex = 28;
            btnXoaLSP.Text = "KHÓA / MỞ KHÓA";
            btnXoaLSP.UseVisualStyleBackColor = true;
            btnXoaLSP.Click += btnXoaLSP_Click;
            // 
            // btnUpdateLSP
            // 
            btnUpdateLSP.Location = new Point(240, 380);
            btnUpdateLSP.Name = "btnUpdateLSP";
            btnUpdateLSP.Size = new Size(133, 26);
            btnUpdateLSP.TabIndex = 27;
            btnUpdateLSP.Text = "LƯU CHỈNH SỬA";
            btnUpdateLSP.UseVisualStyleBackColor = true;
            btnUpdateLSP.Click += btnUpdateLSP_Click;
            // 
            // btnResetLSP
            // 
            btnResetLSP.Location = new Point(240, 321);
            btnResetLSP.Name = "btnResetLSP";
            btnResetLSP.Size = new Size(133, 26);
            btnResetLSP.TabIndex = 26;
            btnResetLSP.Text = "LÀM MỚI";
            btnResetLSP.UseVisualStyleBackColor = true;
            btnResetLSP.Click += btnResetLSP_Click;
            // 
            // btnThemLSP
            // 
            btnThemLSP.Location = new Point(54, 321);
            btnThemLSP.Name = "btnThemLSP";
            btnThemLSP.Size = new Size(128, 26);
            btnThemLSP.TabIndex = 25;
            btnThemLSP.Text = "THÊM";
            btnThemLSP.UseVisualStyleBackColor = true;
            btnThemLSP.Click += btnThemLSP_Click;
            // 
            // btnXuatLSP
            // 
            btnXuatLSP.Location = new Point(716, 612);
            btnXuatLSP.Name = "btnXuatLSP";
            btnXuatLSP.Size = new Size(180, 26);
            btnXuatLSP.TabIndex = 33;
            btnXuatLSP.Text = "XUẤT DANH SÁCH";
            btnXuatLSP.UseVisualStyleBackColor = true;
            btnXuatLSP.Click += btnXuatLSP_Click;
            // 
            // lsvLoaiSanPham
            // 
            lsvLoaiSanPham.Columns.AddRange(new ColumnHeader[] { clSTT, clMaLoaiSP, clTenLoaiSP, clTrangThai });
            lsvLoaiSanPham.FullRowSelect = true;
            lsvLoaiSanPham.Location = new Point(455, 173);
            lsvLoaiSanPham.Name = "lsvLoaiSanPham";
            lsvLoaiSanPham.Size = new Size(640, 405);
            lsvLoaiSanPham.TabIndex = 32;
            lsvLoaiSanPham.UseCompatibleStateImageBehavior = false;
            lsvLoaiSanPham.View = View.Details;
            lsvLoaiSanPham.ItemSelectionChanged += lsvLoaiSanPham_ItemSelectionChanged;
            lsvLoaiSanPham.SelectedIndexChanged += lsvLoaiSanPham_SelectedIndexChanged;
            // 
            // clSTT
            // 
            clSTT.Text = "STT";
            clSTT.Width = 50;
            // 
            // clMaLoaiSP
            // 
            clMaLoaiSP.Text = "Mã Loại Sản Phẩm";
            clMaLoaiSP.Width = 150;
            // 
            // clTenLoaiSP
            // 
            clTenLoaiSP.Text = "Tên Loại Sản Phẩm";
            clTenLoaiSP.Width = 300;
            // 
            // clTrangThai
            // 
            clTrangThai.Text = "Trạng Thái";
            clTrangThai.Width = 130;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(737, 77);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 31;
            label2.Text = "TÌM KIẾM";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(455, 124);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(491, 23);
            txtTimKiem.TabIndex = 30;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(967, 123);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(128, 26);
            btnTimKiem.TabIndex = 29;
            btnTimKiem.Text = "TÌM";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtMaLoaiSP
            // 
            txtMaLoaiSP.Location = new Point(166, 173);
            txtMaLoaiSP.Name = "txtMaLoaiSP";
            txtMaLoaiSP.Size = new Size(258, 23);
            txtMaLoaiSP.TabIndex = 36;
            txtMaLoaiSP.TextChanged += txtMaLoaiSP_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 173);
            label6.Name = "label6";
            label6.Size = new Size(144, 21);
            label6.TabIndex = 35;
            label6.Text = "Mã loại sản phẩm :";
            // 
            // FormLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 679);
            Controls.Add(txtMaLoaiSP);
            Controls.Add(label6);
            Controls.Add(btnXuatLSP);
            Controls.Add(lsvLoaiSanPham);
            Controls.Add(label2);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Controls.Add(btnXoaLSP);
            Controls.Add(btnUpdateLSP);
            Controls.Add(btnResetLSP);
            Controls.Add(btnThemLSP);
            Controls.Add(txtLoaiSanPham);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLoaiSanPham";
            Text = "FormLoaiSanPham";
            ResumeLayout(false);
            PerformLayout();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label label3;
        private TextBox txtLoaiSanPham;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button btnXoaLSP;
        private Button btnUpdateLSP;
        private Button btnResetLSP;
        private Button btnThemLSP;
        private Button btnXuatLSP;
        private ListView lsvLoaiSanPham;
        private ColumnHeader clMaLoaiSP;
        private ColumnHeader clMaSP;
        private ColumnHeader clTenSP;
        private ColumnHeader clTenLoai;
        private ColumnHeader clNhaSX;
        private ColumnHeader clQuyCach;
        private ColumnHeader clTenLoaiSP;
        private ColumnHeader clTrangThai;
        private Label label2;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private TextBox txtMaLoaiSP;
        private Label label6;
        private ColumnHeader clSTT;
    }
}