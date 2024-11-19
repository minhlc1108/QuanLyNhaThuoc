namespace GUI
{
    partial class FormChiTietHoaDon
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
            label19 = new Label();
            label14 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            tb_tongTien = new TextBox();
            tb_diemTichLuy = new TextBox();
            tb_toaThuoc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tb_ngayLap = new TextBox();
            label2 = new Label();
            tb_nguoiLap = new TextBox();
            tb_mahd = new TextBox();
            groupBox2 = new GroupBox();
            tb_ngaySinh = new TextBox();
            tb_dtlKH = new TextBox();
            tb_sdt = new TextBox();
            label6 = new Label();
            tb_gioiTinh = new TextBox();
            label11 = new Label();
            label7 = new Label();
            label8 = new Label();
            tb_hoTen = new TextBox();
            label9 = new Label();
            tb_makh = new TextBox();
            label10 = new Label();
            lv_CTHD = new ListView();
            clMaSP = new ColumnHeader();
            clTenSP = new ColumnHeader();
            clGiaTien = new ColumnHeader();
            clSoLuong = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            btn_export = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(199, 9);
            label19.Name = "label19";
            label19.Size = new Size(234, 32);
            label19.TabIndex = 5;
            label19.Text = "CHI TIẾT HOÁ ĐƠN\r\n";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(311, 39);
            label14.Name = "label14";
            label14.Size = new Size(95, 23);
            label14.TabIndex = 28;
            label14.Text = "Người lập :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 86);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 36;
            label1.Text = "Ngày lập :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_tongTien);
            groupBox1.Controls.Add(tb_diemTichLuy);
            groupBox1.Controls.Add(tb_toaThuoc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_ngayLap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_nguoiLap);
            groupBox1.Controls.Add(tb_mahd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label14);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 183);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hoá đơn";
            // 
            // tb_tongTien
            // 
            tb_tongTien.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_tongTien.Location = new Point(130, 131);
            tb_tongTien.Margin = new Padding(3, 4, 3, 4);
            tb_tongTien.Name = "tb_tongTien";
            tb_tongTien.ReadOnly = true;
            tb_tongTien.Size = new Size(152, 30);
            tb_tongTien.TabIndex = 46;
            // 
            // tb_diemTichLuy
            // 
            tb_diemTichLuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_diemTichLuy.Location = new Point(440, 131);
            tb_diemTichLuy.Margin = new Padding(3, 4, 3, 4);
            tb_diemTichLuy.Name = "tb_diemTichLuy";
            tb_diemTichLuy.ReadOnly = true;
            tb_diemTichLuy.Size = new Size(152, 30);
            tb_diemTichLuy.TabIndex = 45;
            // 
            // tb_toaThuoc
            // 
            tb_toaThuoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_toaThuoc.Location = new Point(440, 82);
            tb_toaThuoc.Margin = new Padding(3, 4, 3, 4);
            tb_toaThuoc.Name = "tb_toaThuoc";
            tb_toaThuoc.ReadOnly = true;
            tb_toaThuoc.Size = new Size(152, 30);
            tb_toaThuoc.TabIndex = 44;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 135);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 43;
            label5.Text = "Tổng tiền :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(312, 135);
            label4.Name = "label4";
            label4.Size = new Size(120, 23);
            label4.TabIndex = 42;
            label4.Text = "Điểm tích luỹ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(312, 86);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 41;
            label3.Text = "Toa thuốc :";
            // 
            // tb_ngayLap
            // 
            tb_ngayLap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ngayLap.Location = new Point(130, 82);
            tb_ngayLap.Margin = new Padding(3, 4, 3, 4);
            tb_ngayLap.Name = "tb_ngayLap";
            tb_ngayLap.ReadOnly = true;
            tb_ngayLap.Size = new Size(152, 30);
            tb_ngayLap.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 39;
            label2.Text = "Mã hoá đơn : ";
            // 
            // tb_nguoiLap
            // 
            tb_nguoiLap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_nguoiLap.Location = new Point(440, 35);
            tb_nguoiLap.Margin = new Padding(3, 4, 3, 4);
            tb_nguoiLap.Name = "tb_nguoiLap";
            tb_nguoiLap.ReadOnly = true;
            tb_nguoiLap.Size = new Size(152, 30);
            tb_nguoiLap.TabIndex = 38;
            // 
            // tb_mahd
            // 
            tb_mahd.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_mahd.Location = new Point(130, 35);
            tb_mahd.Margin = new Padding(3, 4, 3, 4);
            tb_mahd.Name = "tb_mahd";
            tb_mahd.ReadOnly = true;
            tb_mahd.Size = new Size(152, 30);
            tb_mahd.TabIndex = 37;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_ngaySinh);
            groupBox2.Controls.Add(tb_dtlKH);
            groupBox2.Controls.Add(tb_sdt);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tb_gioiTinh);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tb_hoTen);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(tb_makh);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(608, 183);
            groupBox2.TabIndex = 47;
            groupBox2.TabStop = false;
            groupBox2.Text = "Khách hàng";
            // 
            // tb_ngaySinh
            // 
            tb_ngaySinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ngaySinh.Location = new Point(130, 131);
            tb_ngaySinh.Margin = new Padding(3, 4, 3, 4);
            tb_ngaySinh.Name = "tb_ngaySinh";
            tb_ngaySinh.ReadOnly = true;
            tb_ngaySinh.Size = new Size(152, 30);
            tb_ngaySinh.TabIndex = 46;
            // 
            // tb_dtlKH
            // 
            tb_dtlKH.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_dtlKH.Location = new Point(440, 131);
            tb_dtlKH.Margin = new Padding(3, 4, 3, 4);
            tb_dtlKH.Name = "tb_dtlKH";
            tb_dtlKH.ReadOnly = true;
            tb_dtlKH.Size = new Size(152, 30);
            tb_dtlKH.TabIndex = 45;
            // 
            // tb_sdt
            // 
            tb_sdt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_sdt.Location = new Point(440, 82);
            tb_sdt.Margin = new Padding(3, 4, 3, 4);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.ReadOnly = true;
            tb_sdt.Size = new Size(152, 30);
            tb_sdt.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 135);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 43;
            label6.Text = "Ngày sinh :";
            // 
            // tb_gioiTinh
            // 
            tb_gioiTinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_gioiTinh.Location = new Point(130, 82);
            tb_gioiTinh.Margin = new Padding(3, 4, 3, 4);
            tb_gioiTinh.Name = "tb_gioiTinh";
            tb_gioiTinh.ReadOnly = true;
            tb_gioiTinh.Size = new Size(152, 30);
            tb_gioiTinh.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(6, 86);
            label11.Name = "label11";
            label11.Size = new Size(84, 23);
            label11.TabIndex = 28;
            label11.Text = "Giới tính :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(312, 135);
            label7.Name = "label7";
            label7.Size = new Size(120, 23);
            label7.TabIndex = 42;
            label7.Text = "Điểm tích luỹ :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(311, 86);
            label8.Name = "label8";
            label8.Size = new Size(120, 23);
            label8.TabIndex = 41;
            label8.Text = "Số điện thoại :";
            // 
            // tb_hoTen
            // 
            tb_hoTen.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_hoTen.Location = new Point(321, 35);
            tb_hoTen.Margin = new Padding(3, 4, 3, 4);
            tb_hoTen.Name = "tb_hoTen";
            tb_hoTen.ReadOnly = true;
            tb_hoTen.Size = new Size(271, 30);
            tb_hoTen.TabIndex = 40;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 39);
            label9.Name = "label9";
            label9.Size = new Size(77, 23);
            label9.TabIndex = 39;
            label9.Text = "Mã KH : ";
            // 
            // tb_makh
            // 
            tb_makh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_makh.Location = new Point(130, 35);
            tb_makh.Margin = new Padding(3, 4, 3, 4);
            tb_makh.Name = "tb_makh";
            tb_makh.ReadOnly = true;
            tb_makh.Size = new Size(68, 30);
            tb_makh.TabIndex = 37;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(234, 39);
            label10.Name = "label10";
            label10.Size = new Size(72, 23);
            label10.TabIndex = 36;
            label10.Text = "Họ tên :";
            // 
            // lv_CTHD
            // 
            lv_CTHD.Columns.AddRange(new ColumnHeader[] { clMaSP, clTenSP, clGiaTien, clSoLuong, columnHeader1 });
            lv_CTHD.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_CTHD.FullRowSelect = true;
            lv_CTHD.Location = new Point(12, 444);
            lv_CTHD.Margin = new Padding(3, 4, 3, 4);
            lv_CTHD.Name = "lv_CTHD";
            lv_CTHD.Size = new Size(608, 267);
            lv_CTHD.TabIndex = 47;
            lv_CTHD.UseCompatibleStateImageBehavior = false;
            lv_CTHD.View = View.Details;
            // 
            // clMaSP
            // 
            clMaSP.Text = "STT";
            clMaSP.Width = 40;
            // 
            // clTenSP
            // 
            clTenSP.Text = "Mã SP";
            clTenSP.Width = 70;
            // 
            // clGiaTien
            // 
            clGiaTien.Text = "Tên sản phẩm";
            clGiaTien.Width = 324;
            // 
            // clSoLuong
            // 
            clSoLuong.Text = "Giá bán";
            clSoLuong.Width = 90;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Số lượng";
            columnHeader1.Width = 80;
            // 
            // btn_export
            // 
            btn_export.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_export.Location = new Point(503, 718);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(117, 40);
            btn_export.TabIndex = 48;
            btn_export.Text = "Xuất PDF";
            btn_export.UseVisualStyleBackColor = true;
            btn_export.Click += btn_export_Click;
            // 
            // FormChiTietHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 769);
            Controls.Add(btn_export);
            Controls.Add(lv_CTHD);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label19);
            Name = "FormChiTietHoaDon";
            Text = "Chi tiết hoá đơn";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label19;
        private Label label14;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox tb_nguoiLap;
        private TextBox tb_mahd;
        private TextBox tb_ngayLap;
        private Label label2;
        private TextBox tb_tongTien;
        private TextBox tb_diemTichLuy;
        private TextBox tb_toaThuoc;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox tb_ngaySinh;
        private TextBox tb_dtlKH;
        private TextBox tb_sdt;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tb_hoTen;
        private Label label9;
        private TextBox tb_gioiTinh;
        private TextBox tb_makh;
        private Label label10;
        private Label label11;
        private ListView lv_CTHD;
        private ColumnHeader clMaSP;
        private ColumnHeader clTenSP;
        private ColumnHeader clGiaTien;
        private ColumnHeader clSoLuong;
        private ColumnHeader columnHeader1;
        private Button btn_export;
    }
}