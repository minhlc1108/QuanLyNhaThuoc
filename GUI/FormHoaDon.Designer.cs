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
            ListViewItem listViewItem7 = new ListViewItem("2");
            ListViewItem listViewItem8 = new ListViewItem("3");
            ListViewItem listViewItem9 = new ListViewItem("1");
            ListViewItem listViewItem10 = new ListViewItem("2");
            ListViewItem listViewItem11 = new ListViewItem("3");
            ListViewItem listViewItem12 = new ListViewItem("1");
            lv_HoaDon = new ListView();
            clMaSP = new ColumnHeader();
            clTenSP = new ColumnHeader();
            clGiaTien = new ColumnHeader();
            clSoLuong = new ColumnHeader();
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
            btn_find = new Button();
            label14 = new Label();
            label17 = new Label();
            label19 = new Label();
            lv_DSHoaDon = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            btn_addKH = new Button();
            groupBox1 = new GroupBox();
            btn_del = new Button();
            cbb_sp = new ComboBox();
            btn_import = new Button();
            btn_cancel = new Button();
            btn_addHD = new Button();
            lb_tong = new Label();
            btn_export = new Button();
            btn_show = new Button();
            cb_SDdiem = new CheckBox();
            lb_diemTichLuy = new Label();
            cbb_find = new ComboBox();
            date_find1 = new DateTimePicker();
            date_find2 = new DateTimePicker();
            label2 = new Label();
            tb_ngayLap = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lv_HoaDon
            // 
            lv_HoaDon.Columns.AddRange(new ColumnHeader[] { clMaSP, clTenSP, clGiaTien, clSoLuong });
            lv_HoaDon.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_HoaDon.FullRowSelect = true;
            lv_HoaDon.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8, listViewItem9 });
            lv_HoaDon.Location = new Point(14, 200);
            lv_HoaDon.Margin = new Padding(3, 4, 3, 4);
            lv_HoaDon.Name = "lv_HoaDon";
            lv_HoaDon.Size = new Size(563, 267);
            lv_HoaDon.TabIndex = 21;
            lv_HoaDon.UseCompatibleStateImageBehavior = false;
            lv_HoaDon.View = View.Details;
            // 
            // clMaSP
            // 
            clMaSP.Text = "Mã SP";
            clMaSP.Width = 80;
            // 
            // clTenSP
            // 
            clTenSP.Text = "Tên SP";
            clTenSP.Width = 278;
            // 
            // clGiaTien
            // 
            clGiaTien.Text = "Giá Tiền";
            clGiaTien.Width = 100;
            // 
            // clSoLuong
            // 
            clSoLuong.Text = "Số Lương";
            clSoLuong.Width = 100;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(235, 138);
            btn_edit.Margin = new Padding(3, 4, 3, 4);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(83, 40);
            btn_edit.TabIndex = 18;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(119, 136);
            btn_add.Margin = new Padding(3, 4, 3, 4);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(90, 42);
            btn_add.TabIndex = 17;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // tb_sl
            // 
            tb_sl.Location = new Point(509, 81);
            tb_sl.Margin = new Padding(3, 4, 3, 4);
            tb_sl.Name = "tb_sl";
            tb_sl.Size = new Size(68, 34);
            tb_sl.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(415, 90);
            label10.Name = "label10";
            label10.Size = new Size(88, 23);
            label10.TabIndex = 15;
            label10.Text = "Số lượng :";
            // 
            // tb_donGia
            // 
            tb_donGia.Location = new Point(320, 82);
            tb_donGia.Margin = new Padding(3, 4, 3, 4);
            tb_donGia.Name = "tb_donGia";
            tb_donGia.Size = new Size(89, 34);
            tb_donGia.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(235, 90);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 14;
            label9.Text = "Đơn giá :";
            // 
            // cbb_lsx
            // 
            cbb_lsx.FormattingEnabled = true;
            cbb_lsx.Location = new Point(119, 82);
            cbb_lsx.Margin = new Padding(3, 4, 3, 4);
            cbb_lsx.Name = "cbb_lsx";
            cbb_lsx.Size = new Size(110, 36);
            cbb_lsx.TabIndex = 13;
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
            tb_find.Location = new Point(736, 59);
            tb_find.Margin = new Padding(3, 4, 3, 4);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(292, 30);
            tb_find.TabIndex = 7;
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
            cbb_khach.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cbb_khach.Location = new Point(128, 170);
            cbb_khach.Margin = new Padding(3, 4, 3, 4);
            cbb_khach.Name = "cbb_khach";
            cbb_khach.Size = new Size(353, 31);
            cbb_khach.TabIndex = 6;
            // 
            // tb_nguoi
            // 
            tb_nguoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_nguoi.Location = new Point(128, 59);
            tb_nguoi.Margin = new Padding(3, 4, 3, 4);
            tb_nguoi.Name = "tb_nguoi";
            tb_nguoi.Size = new Size(458, 30);
            tb_nguoi.TabIndex = 8;
            // 
            // btn_find
            // 
            btn_find.Location = new Point(1045, 55);
            btn_find.Margin = new Padding(3, 4, 3, 4);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(87, 34);
            btn_find.TabIndex = 24;
            btn_find.Text = "Tìm";
            btn_find.UseVisualStyleBackColor = true;
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
            label17.Location = new Point(12, 174);
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
            lv_DSHoaDon.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lv_DSHoaDon.FullRowSelect = true;
            lv_DSHoaDon.Items.AddRange(new ListViewItem[] { listViewItem10, listViewItem11, listViewItem12 });
            lv_DSHoaDon.Location = new Point(620, 156);
            lv_DSHoaDon.Margin = new Padding(3, 4, 3, 4);
            lv_DSHoaDon.Name = "lv_DSHoaDon";
            lv_DSHoaDon.Size = new Size(512, 588);
            lv_DSHoaDon.TabIndex = 34;
            lv_DSHoaDon.UseCompatibleStateImageBehavior = false;
            lv_DSHoaDon.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã Hóa Đơn";
            columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Người Lập";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày Lập";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Khách Hàng";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tổng Tiền";
            columnHeader5.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 116);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 35;
            label1.Text = "Ngày lập :";
            label1.Click += label1_Click;
            // 
            // btn_addKH
            // 
            btn_addKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addKH.Location = new Point(497, 167);
            btn_addKH.Margin = new Padding(3, 4, 3, 4);
            btn_addKH.Name = "btn_addKH";
            btn_addKH.Size = new Size(89, 34);
            btn_addKH.TabIndex = 36;
            btn_addKH.Text = "Mới";
            btn_addKH.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_del);
            groupBox1.Controls.Add(cbb_sp);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btn_edit);
            groupBox1.Controls.Add(cbb_lsx);
            groupBox1.Controls.Add(btn_import);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btn_add);
            groupBox1.Controls.Add(tb_donGia);
            groupBox1.Controls.Add(tb_sl);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(lv_HoaDon);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(9, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 474);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm";
            // 
            // btn_del
            // 
            btn_del.Location = new Point(343, 136);
            btn_del.Margin = new Padding(3, 4, 3, 4);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(83, 40);
            btn_del.TabIndex = 39;
            btn_del.Text = "Xóa";
            btn_del.UseVisualStyleBackColor = true;
            // 
            // cbb_sp
            // 
            cbb_sp.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_sp.FormattingEnabled = true;
            cbb_sp.Items.AddRange(new object[] { "A", "B", "C", "D" });
            cbb_sp.Location = new Point(119, 35);
            cbb_sp.Margin = new Padding(3, 4, 3, 4);
            cbb_sp.Name = "cbb_sp";
            cbb_sp.Size = new Size(458, 31);
            cbb_sp.TabIndex = 38;
            // 
            // btn_import
            // 
            btn_import.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_import.Location = new Point(450, 134);
            btn_import.Margin = new Padding(3, 4, 3, 4);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(127, 42);
            btn_import.TabIndex = 43;
            btn_import.Text = "Nhập Excel";
            btn_import.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_cancel.Location = new Point(128, 752);
            btn_cancel.Margin = new Padding(3, 4, 3, 4);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(100, 40);
            btn_cancel.TabIndex = 40;
            btn_cancel.Text = "Huỷ bỏ";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_addHD
            // 
            btn_addHD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_addHD.Location = new Point(12, 752);
            btn_addHD.Margin = new Padding(3, 4, 3, 4);
            btn_addHD.Name = "btn_addHD";
            btn_addHD.Size = new Size(89, 42);
            btn_addHD.TabIndex = 41;
            btn_addHD.Text = "Lập";
            btn_addHD.UseVisualStyleBackColor = true;
            // 
            // lb_tong
            // 
            lb_tong.AutoSize = true;
            lb_tong.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_tong.Location = new Point(495, 702);
            lb_tong.Name = "lb_tong";
            lb_tong.Size = new Size(89, 28);
            lb_tong.TabIndex = 42;
            lb_tong.Text = "Tổng : 0";
            lb_tong.Click += label2_Click;
            // 
            // btn_export
            // 
            btn_export.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_export.Location = new Point(1045, 752);
            btn_export.Margin = new Padding(3, 4, 3, 4);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(87, 42);
            btn_export.TabIndex = 44;
            btn_export.Text = "Xuất ";
            btn_export.UseVisualStyleBackColor = true;
            // 
            // btn_show
            // 
            btn_show.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_show.Location = new Point(832, 752);
            btn_show.Margin = new Padding(3, 4, 3, 4);
            btn_show.Name = "btn_show";
            btn_show.Size = new Size(88, 42);
            btn_show.TabIndex = 45;
            btn_show.Text = "Xem";
            btn_show.UseVisualStyleBackColor = true;
            btn_show.Click += btn_show_Click;
            // 
            // cb_SDdiem
            // 
            cb_SDdiem.AutoSize = true;
            cb_SDdiem.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_SDdiem.Location = new Point(9, 701);
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
            lb_diemTichLuy.Location = new Point(424, 736);
            lb_diemTichLuy.Name = "lb_diemTichLuy";
            lb_diemTichLuy.Size = new Size(160, 28);
            lb_diemTichLuy.TabIndex = 57;
            lb_diemTichLuy.Text = "Điểm tích luỹ : 0";
            // 
            // cbb_find
            // 
            cbb_find.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_find.FormattingEnabled = true;
            cbb_find.Items.AddRange(new object[] { "Mã HĐ", "Người lập", "Ngày lập", "Khách hàng", "Tổng tiền" });
            cbb_find.Location = new Point(620, 59);
            cbb_find.Margin = new Padding(3, 4, 3, 4);
            cbb_find.Name = "cbb_find";
            cbb_find.Size = new Size(100, 31);
            cbb_find.TabIndex = 58;
            // 
            // date_find1
            // 
            date_find1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_find1.Location = new Point(620, 108);
            date_find1.Name = "date_find1";
            date_find1.Size = new Size(234, 31);
            date_find1.TabIndex = 60;
            // 
            // date_find2
            // 
            date_find2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_find2.Location = new Point(886, 108);
            date_find2.Name = "date_find2";
            date_find2.Size = new Size(246, 31);
            date_find2.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(860, 108);
            label2.Name = "label2";
            label2.Size = new Size(20, 28);
            label2.TabIndex = 62;
            label2.Text = "-";
            // 
            // tb_ngayLap
            // 
            tb_ngayLap.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ngayLap.Location = new Point(128, 112);
            tb_ngayLap.Margin = new Padding(3, 4, 3, 4);
            tb_ngayLap.Name = "tb_ngayLap";
            tb_ngayLap.Size = new Size(458, 30);
            tb_ngayLap.TabIndex = 63;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 807);
            Controls.Add(tb_ngayLap);
            Controls.Add(label2);
            Controls.Add(date_find2);
            Controls.Add(date_find1);
            Controls.Add(cbb_find);
            Controls.Add(btn_cancel);
            Controls.Add(lb_diemTichLuy);
            Controls.Add(cb_SDdiem);
            Controls.Add(btn_show);
            Controls.Add(btn_export);
            Controls.Add(lb_tong);
            Controls.Add(btn_addHD);
            Controls.Add(groupBox1);
            Controls.Add(btn_addKH);
            Controls.Add(label1);
            Controls.Add(label19);
            Controls.Add(label14);
            Controls.Add(lv_DSHoaDon);
            Controls.Add(btn_find);
            Controls.Add(tb_find);
            Controls.Add(label17);
            Controls.Add(cbb_khach);
            Controls.Add(label6);
            Controls.Add(tb_nguoi);
            Name = "FormHoaDon";
            Text = "FormHoaDon";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btn_find;
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
        private Button btn_import;
        private Button btn_export;
        private Button btn_show;
        private CheckBox cb_SDdiem;
        private Label lb_diemTichLuy;
        private ComboBox cbb_find;
        private DateTimePicker date_find1;
        private DateTimePicker date_find2;
        private Label label2;
        private TextBox tb_ngayLap;
    }
}