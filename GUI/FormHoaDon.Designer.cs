namespace GUI
{
    partial class FormHoaDon
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
            lv_HoaDon = new ListView();
            clMaSP = new ColumnHeader();
            clTenSP = new ColumnHeader();
            clGiaTien = new ColumnHeader();
            clSoLuong = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            btn_edit = new Button();
            btn_add = new Button();
            tb_sl = new TextBox();
            label10 = new Label();
            tb_donGia = new TextBox();
            label9 = new Label();
            cbb_lsx = new ComboBox();
            label8 = new Label();
            tb_find = new TextBox();
            label6 = new Label();
            label7 = new Label();
            cbb_khach = new ComboBox();
            tb_nguoi = new TextBox();
            label14 = new Label();
            label17 = new Label();
            label19 = new Label();
            lv_DSHoaDon = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label1 = new Label();
            btn_addKH = new Button();
            groupBox1 = new GroupBox();
            lb_slCon = new Label();
            erorr_sl = new Label();
            btn_clear = new Button();
            btn_del = new Button();
            cbb_sp = new ComboBox();
            tb_toathuoc = new TextBox();
            label3 = new Label();
            btn_cancel = new Button();
            btn_addHD = new Button();
            lb_tong = new Label();
            btn_export = new Button();
            cb_SDdiem = new CheckBox();
            lb_diemTichLuy = new Label();
            cbb_find = new ComboBox();
            date_find1 = new DateTimePicker();
            date_find2 = new DateTimePicker();
            label2 = new Label();
            tb_ngayLap = new TextBox();
            panel_ngayLap = new Panel();
            cbb_findNguoiLap = new ComboBox();
            cbb_findKh = new ComboBox();
            groupBox1.SuspendLayout();
            panel_ngayLap.SuspendLayout();
            SuspendLayout();
            // 
            // lv_HoaDon
            // 
            lv_HoaDon.Columns.AddRange(new ColumnHeader[] { clMaSP, clTenSP, clGiaTien, clSoLuong, columnHeader9 });
            lv_HoaDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_HoaDon.FullRowSelect = true;
            lv_HoaDon.Location = new Point(14, 252);
            lv_HoaDon.Margin = new Padding(3, 4, 3, 4);
            lv_HoaDon.Name = "lv_HoaDon";
            lv_HoaDon.Size = new Size(563, 202);
            lv_HoaDon.TabIndex = 21;
            lv_HoaDon.UseCompatibleStateImageBehavior = false;
            lv_HoaDon.View = View.Details;
            lv_HoaDon.ItemSelectionChanged += lv_HoaDon_SelectedIndexChanged;
            // 
            // clMaSP
            // 
            clMaSP.Text = "STT";
            clMaSP.Width = 40;
            // 
            // clTenSP
            // 
            clTenSP.Text = "Mã SP";
            clTenSP.Width = 80;
            // 
            // clGiaTien
            // 
            clGiaTien.Text = "Tên sản phẩm";
            clGiaTien.Width = 277;
            // 
            // clSoLuong
            // 
            clSoLuong.Text = "Giá tiền";
            clSoLuong.Width = 80;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Số lượng";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 80;
            // 
            // btn_edit
            // 
            btn_edit.Enabled = false;
            btn_edit.Location = new Point(392, 202);
            btn_edit.Margin = new Padding(3, 4, 3, 4);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(80, 40);
            btn_edit.TabIndex = 18;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(288, 200);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(77, 42);
            btn_add.TabIndex = 17;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // tb_sl
            // 
            tb_sl.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_sl.Location = new Point(119, 135);
            tb_sl.Margin = new Padding(3, 4, 3, 4);
            tb_sl.Name = "tb_sl";
            tb_sl.Size = new Size(154, 30);
            tb_sl.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(21, 139);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 15;
            label10.Text = "Số lượng :";
            // 
            // tb_donGia
            // 
            tb_donGia.Enabled = false;
            tb_donGia.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_donGia.Location = new Point(393, 87);
            tb_donGia.Margin = new Padding(3, 4, 3, 4);
            tb_donGia.Name = "tb_donGia";
            tb_donGia.Size = new Size(184, 30);
            tb_donGia.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(308, 91);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 14;
            label9.Text = "Đơn giá :";
            // 
            // cbb_lsx
            // 
            cbb_lsx.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_lsx.FormattingEnabled = true;
            cbb_lsx.Location = new Point(119, 87);
            cbb_lsx.Margin = new Padding(3, 4, 3, 4);
            cbb_lsx.Name = "cbb_lsx";
            cbb_lsx.Size = new Size(154, 31);
            cbb_lsx.TabIndex = 13;
            cbb_lsx.SelectedIndexChanged += cbb_lsx_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 91);
            label8.Name = "label8";
            label8.Size = new Size(107, 23);
            label8.TabIndex = 12;
            label8.Text = "Lô sản xuất :";
            // 
            // tb_find
            // 
            tb_find.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_find.Location = new Point(799, 60);
            tb_find.Margin = new Padding(3, 4, 3, 4);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(433, 30);
            tb_find.TabIndex = 7;
            tb_find.TextChanged += Tb_find_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(232, 8);
            label6.Name = "label6";
            label6.Size = new Size(151, 32);
            label6.TabIndex = 1;
            label6.Text = "HÓA ĐƠN   ";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 39);
            label7.Name = "label7";
            label7.Size = new Size(96, 23);
            label7.TabIndex = 11;
            label7.Text = "Sản phẩm :";
            // 
            // cbb_khach
            // 
            cbb_khach.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_khach.FormattingEnabled = true;
            cbb_khach.Location = new Point(128, 156);
            cbb_khach.Margin = new Padding(3, 4, 3, 4);
            cbb_khach.Name = "cbb_khach";
            cbb_khach.Size = new Size(353, 31);
            cbb_khach.TabIndex = 6;
            // 
            // tb_nguoi
            // 
            tb_nguoi.Enabled = false;
            tb_nguoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_nguoi.Location = new Point(128, 59);
            tb_nguoi.Margin = new Padding(3, 4, 3, 4);
            tb_nguoi.Name = "tb_nguoi";
            tb_nguoi.Size = new Size(458, 30);
            tb_nguoi.TabIndex = 8;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(23, 63);
            label14.Name = "label14";
            label14.Size = new Size(95, 23);
            label14.TabIndex = 27;
            label14.Text = "Người lập :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(12, 160);
            label17.Name = "label17";
            label17.Size = new Size(113, 23);
            label17.TabIndex = 29;
            label17.Text = "Khách Hàng :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(742, 8);
            label19.Name = "label19";
            label19.Size = new Size(300, 32);
            label19.TabIndex = 4;
            label19.Text = "DANH SÁCH HÓA ĐƠN   ";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lv_DSHoaDon
            // 
            lv_DSHoaDon.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lv_DSHoaDon.FullRowSelect = true;
            lv_DSHoaDon.HoverSelection = true;
            lv_DSHoaDon.Location = new Point(620, 110);
            lv_DSHoaDon.Margin = new Padding(3, 4, 3, 4);
            lv_DSHoaDon.Name = "lv_DSHoaDon";
            lv_DSHoaDon.Size = new Size(612, 665);
            lv_DSHoaDon.TabIndex = 34;
            lv_DSHoaDon.UseCompatibleStateImageBehavior = false;
            lv_DSHoaDon.View = View.Details;
            lv_DSHoaDon.MouseClick += Lv_DSHoaDon_MouseClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            columnHeader1.Width = 36;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã HĐ";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Người lập";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Ngày lập";
            columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mã KH";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Toa thuốc";
            columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Điểm";
            columnHeader7.Width = 50;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Tổng tiền";
            columnHeader8.Width = 75;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 110);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 35;
            label1.Text = "Ngày lập :";
            // 
            // btn_addKH
            // 
            btn_addKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addKH.Location = new Point(497, 156);
            btn_addKH.Margin = new Padding(3, 4, 3, 4);
            btn_addKH.Name = "btn_addKH";
            btn_addKH.Size = new Size(89, 34);
            btn_addKH.TabIndex = 36;
            btn_addKH.Text = "Mới";
            btn_addKH.UseVisualStyleBackColor = true;
            btn_addKH.Click += btn_addKH_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lb_slCon);
            groupBox1.Controls.Add(erorr_sl);
            groupBox1.Controls.Add(btn_clear);
            groupBox1.Controls.Add(btn_del);
            groupBox1.Controls.Add(cbb_sp);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btn_edit);
            groupBox1.Controls.Add(cbb_lsx);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(tb_donGia);
            groupBox1.Controls.Add(tb_sl);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lv_HoaDon);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(9, 246);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 461);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // lb_slCon
            // 
            lb_slCon.AutoSize = true;
            lb_slCon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_slCon.ForeColor = Color.Blue;
            lb_slCon.Location = new Point(279, 138);
            lb_slCon.Name = "lb_slCon";
            lb_slCon.Size = new Size(56, 23);
            lb_slCon.TabIndex = 64;
            lb_slCon.Text = "Còn : ";
            // 
            // erorr_sl
            // 
            erorr_sl.AutoSize = true;
            erorr_sl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_sl.ForeColor = Color.Red;
            erorr_sl.Location = new Point(119, 169);
            erorr_sl.Name = "erorr_sl";
            erorr_sl.Size = new Size(0, 20);
            erorr_sl.TabIndex = 47;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(471, 135);
            btn_clear.Margin = new Padding(3, 4, 3, 4);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(106, 39);
            btn_clear.TabIndex = 46;
            btn_clear.Text = "Làm mới";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_del
            // 
            btn_del.Enabled = false;
            btn_del.Location = new Point(494, 202);
            btn_del.Margin = new Padding(3, 4, 3, 4);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(83, 40);
            btn_del.TabIndex = 39;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // cbb_sp
            // 
            cbb_sp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_sp.FormattingEnabled = true;
            cbb_sp.Location = new Point(119, 35);
            cbb_sp.Margin = new Padding(3, 4, 3, 4);
            cbb_sp.Name = "cbb_sp";
            cbb_sp.Size = new Size(458, 31);
            cbb_sp.TabIndex = 38;
            cbb_sp.SelectedIndexChanged += cbb_sp_SelectedIndexChanged;
            // 
            // tb_toathuoc
            // 
            tb_toathuoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_toathuoc.Location = new Point(128, 209);
            tb_toathuoc.Margin = new Padding(3, 4, 3, 4);
            tb_toathuoc.Name = "tb_toathuoc";
            tb_toathuoc.Size = new Size(458, 30);
            tb_toathuoc.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 213);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 44;
            label3.Text = "Toa thuốc :";
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.Location = new Point(486, 791);
            btn_cancel.Margin = new Padding(3, 4, 3, 4);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(100, 40);
            btn_cancel.TabIndex = 40;
            btn_cancel.Text = "Huỷ bỏ";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_addHD
            // 
            btn_addHD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addHD.Location = new Point(12, 791);
            btn_addHD.Margin = new Padding(3, 4, 3, 4);
            btn_addHD.Name = "btn_addHD";
            btn_addHD.Size = new Size(89, 42);
            btn_addHD.TabIndex = 41;
            btn_addHD.Text = "Lập";
            btn_addHD.UseVisualStyleBackColor = true;
            btn_addHD.Click += btn_addHD_Click;
            // 
            // lb_tong
            // 
            lb_tong.AutoSize = true;
            lb_tong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_tong.Location = new Point(15, 710);
            lb_tong.Name = "lb_tong";
            lb_tong.Size = new Size(89, 28);
            lb_tong.TabIndex = 42;
            lb_tong.Text = "Tổng : 0";
            // 
            // btn_export
            // 
            btn_export.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_export.Location = new Point(1145, 793);
            btn_export.Margin = new Padding(3, 4, 3, 4);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(87, 42);
            btn_export.TabIndex = 44;
            btn_export.Text = "Xuất ";
            btn_export.UseVisualStyleBackColor = true;
            btn_export.Click += btn_export_Click;
            // 
            // cb_SDdiem
            // 
            cb_SDdiem.AutoSize = true;
            cb_SDdiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_SDdiem.Location = new Point(439, 712);
            cb_SDdiem.Name = "cb_SDdiem";
            cb_SDdiem.Size = new Size(147, 29);
            cb_SDdiem.TabIndex = 56;
            cb_SDdiem.Text = "Sử dụng điểm";
            cb_SDdiem.UseVisualStyleBackColor = true;
            // 
            // lb_diemTichLuy
            // 
            lb_diemTichLuy.AutoSize = true;
            lb_diemTichLuy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_diemTichLuy.Location = new Point(15, 747);
            lb_diemTichLuy.Name = "lb_diemTichLuy";
            lb_diemTichLuy.Size = new Size(160, 28);
            lb_diemTichLuy.TabIndex = 57;
            lb_diemTichLuy.Text = "Điểm tích luỹ : 0";
            // 
            // cbb_find
            // 
            cbb_find.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_find.FormattingEnabled = true;
            cbb_find.Items.AddRange(new object[] { "Mã HĐ", "Người lập", "Ngày lập", "Khách hàng", "Toa thuốc", "Điểm", "Tổng tiền" });
            cbb_find.Location = new Point(620, 59);
            cbb_find.Margin = new Padding(3, 4, 3, 4);
            cbb_find.Name = "cbb_find";
            cbb_find.Size = new Size(144, 31);
            cbb_find.TabIndex = 58;
            cbb_find.SelectedIndexChanged += cbb_find_SelectedIndexChanged;
            // 
            // date_find1
            // 
            date_find1.CustomFormat = "dd/MM/yyyy";
            date_find1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_find1.Format = DateTimePickerFormat.Custom;
            date_find1.Location = new Point(0, 14);
            date_find1.Name = "date_find1";
            date_find1.Size = new Size(188, 31);
            date_find1.TabIndex = 60;
            date_find1.ValueChanged += date_find1_ValueChanged;
            // 
            // date_find2
            // 
            date_find2.CustomFormat = "dd/MM/yyyy";
            date_find2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_find2.Format = DateTimePickerFormat.Custom;
            date_find2.Location = new Point(242, 15);
            date_find2.Name = "date_find2";
            date_find2.Size = new Size(188, 31);
            date_find2.TabIndex = 61;
            date_find2.ValueChanged += date_find2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 14);
            label2.Name = "label2";
            label2.Size = new Size(20, 28);
            label2.TabIndex = 62;
            label2.Text = "-";
            // 
            // tb_ngayLap
            // 
            tb_ngayLap.Enabled = false;
            tb_ngayLap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ngayLap.Location = new Point(128, 106);
            tb_ngayLap.Margin = new Padding(3, 4, 3, 4);
            tb_ngayLap.Name = "tb_ngayLap";
            tb_ngayLap.Size = new Size(458, 30);
            tb_ngayLap.TabIndex = 63;
            tb_ngayLap.Text = "27/10/2024";
            // 
            // panel_ngayLap
            // 
            panel_ngayLap.Controls.Add(date_find1);
            panel_ngayLap.Controls.Add(date_find2);
            panel_ngayLap.Controls.Add(label2);
            panel_ngayLap.Location = new Point(799, 43);
            panel_ngayLap.Name = "panel_ngayLap";
            panel_ngayLap.Size = new Size(433, 58);
            panel_ngayLap.TabIndex = 64;
            panel_ngayLap.Visible = false;
            // 
            // cbb_findNguoiLap
            // 
            cbb_findNguoiLap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_findNguoiLap.FormattingEnabled = true;
            cbb_findNguoiLap.Location = new Point(799, 60);
            cbb_findNguoiLap.Margin = new Padding(3, 4, 3, 4);
            cbb_findNguoiLap.Name = "cbb_findNguoiLap";
            cbb_findNguoiLap.Size = new Size(433, 31);
            cbb_findNguoiLap.TabIndex = 7;
            cbb_findNguoiLap.Visible = false;
            cbb_findNguoiLap.SelectedIndexChanged += Cbb_findNguoiLap_SelectedIndexChanged;
            // 
            // cbb_findKh
            // 
            cbb_findKh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_findKh.FormattingEnabled = true;
            cbb_findKh.Location = new Point(799, 60);
            cbb_findKh.Margin = new Padding(3, 4, 3, 4);
            cbb_findKh.Name = "cbb_findKh";
            cbb_findKh.Size = new Size(433, 31);
            cbb_findKh.TabIndex = 7;
            cbb_findKh.Visible = false;
            cbb_findKh.SelectedIndexChanged += Cbb_findKh_SelectedIndexChanged;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 864);
            Controls.Add(panel_ngayLap);
            Controls.Add(cbb_findNguoiLap);
            Controls.Add(cbb_findKh);
            Controls.Add(tb_ngayLap);
            Controls.Add(label3);
            Controls.Add(tb_toathuoc);
            Controls.Add(cbb_find);
            Controls.Add(btn_cancel);
            Controls.Add(lb_diemTichLuy);
            Controls.Add(cb_SDdiem);
            Controls.Add(btn_export);
            Controls.Add(lb_tong);
            Controls.Add(btn_addHD);
            Controls.Add(groupBox1);
            Controls.Add(btn_addKH);
            Controls.Add(label1);
            Controls.Add(label19);
            Controls.Add(label14);
            Controls.Add(lv_DSHoaDon);
            Controls.Add(tb_find);
            Controls.Add(label17);
            Controls.Add(cbb_khach);
            Controls.Add(label6);
            Controls.Add(tb_nguoi);
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel_ngayLap.ResumeLayout(false);
            panel_ngayLap.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lv_HoaDon;
        private ColumnHeader clMaSP;
        private ColumnHeader clTenSP;
        private ColumnHeader clGiaTien;
        private ColumnHeader clSoLuong;
        private Button btn_edit;
        private Button btn_add;
        private TextBox tb_sl;
        private Label label10;
        private TextBox tb_donGia;
        private Label label9;
        private ComboBox cbb_lsx;
        private Label label8;
        private TextBox tb_find;
        private Label label6;
        private Label label7;
        private ComboBox cbb_khach;
        private TextBox tb_nguoi;
        private Label label14;
        private Label label17;
        private Label label19;
        private ListView lv_DSHoaDon;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label1;
        private Button btn_addKH;
        private GroupBox groupBox1;
        private ComboBox cbb_sp;
        private Button btn_cancel;
        private Button btn_del;
        private Button btn_addHD;
        private Label lb_tong;
        private Button btn_export;
        private CheckBox cb_SDdiem;
        private Label lb_diemTichLuy;
        private ComboBox cbb_find;
        private DateTimePicker date_find1;
        private DateTimePicker date_find2;
        private Label label2;
        private TextBox tb_ngayLap;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label3;
        private TextBox tb_toathuoc;
        private Button btn_clear;
        private Label erorr_sl;
        private ColumnHeader columnHeader9;
        private Label lb_slCon;
        private Panel panel_ngayLap;
        private ComboBox cbb_findKh;
        private ComboBox cbb_findNguoiLap;
    }
}