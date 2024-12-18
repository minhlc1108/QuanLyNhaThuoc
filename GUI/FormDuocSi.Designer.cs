﻿namespace GUI
{
    partial class FormDuocSi
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            erorr_email = new Label();
            erorr_sdt = new Label();
            erorr_hoTen = new Label();
            label8 = new Label();
            label7 = new Label();
            label9 = new Label();
            label14 = new Label();
            tb_email = new TextBox();
            tb_ma = new TextBox();
            tb_sdt = new TextBox();
            tb_hoten = new TextBox();
            groupBox2 = new GroupBox();
            btn_xuatExcel = new Button();
            btn_xuatPDF = new Button();
            btn_nhapExcel = new Button();
            btn_opLock = new Button();
            btn_lock = new Button();
            btn_clear = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            cbb_find = new ComboBox();
            tb_find = new TextBox();
            label6 = new Label();
            cbb_findTT = new ComboBox();
            lv_qlduocsi = new ListView();
            clMaSP = new ColumnHeader();
            clTenSP = new ColumnHeader();
            clGiaTien = new ColumnHeader();
            clSoLuong = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label2 = new Label();
            btnPhanQuyen = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 31);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ DƯỢC SĨ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(erorr_email);
            groupBox1.Controls.Add(erorr_sdt);
            groupBox1.Controls.Add(erorr_hoTen);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(tb_ma);
            groupBox1.Controls.Add(tb_sdt);
            groupBox1.Controls.Add(tb_hoten);
            groupBox1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 112);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 337);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dược sĩ";
            // 
            // erorr_email
            // 
            erorr_email.AutoSize = true;
            erorr_email.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_email.ForeColor = Color.Red;
            erorr_email.Location = new Point(96, 300);
            erorr_email.Name = "erorr_email";
            erorr_email.Size = new Size(0, 20);
            erorr_email.TabIndex = 34;
            // 
            // erorr_sdt
            // 
            erorr_sdt.AutoSize = true;
            erorr_sdt.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_sdt.ForeColor = Color.Red;
            erorr_sdt.Location = new Point(96, 226);
            erorr_sdt.Name = "erorr_sdt";
            erorr_sdt.Size = new Size(0, 20);
            erorr_sdt.TabIndex = 33;
            // 
            // erorr_hoTen
            // 
            erorr_hoTen.AutoSize = true;
            erorr_hoTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_hoTen.ForeColor = Color.Red;
            erorr_hoTen.Location = new Point(96, 152);
            erorr_hoTen.Name = "erorr_hoTen";
            erorr_hoTen.Size = new Size(0, 20);
            erorr_hoTen.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 198);
            label8.Name = "label8";
            label8.Size = new Size(49, 23);
            label8.TabIndex = 30;
            label8.Text = "SĐT :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 124);
            label7.Name = "label7";
            label7.Size = new Size(72, 23);
            label7.TabIndex = 29;
            label7.Text = "Họ tên :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 272);
            label9.Name = "label9";
            label9.Size = new Size(60, 23);
            label9.TabIndex = 31;
            label9.Text = "Email :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(6, 48);
            label14.Name = "label14";
            label14.Size = new Size(70, 23);
            label14.TabIndex = 28;
            label14.Text = "Mã DS :";
            // 
            // tb_email
            // 
            tb_email.Location = new Point(96, 263);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(275, 34);
            tb_email.TabIndex = 11;
            // 
            // tb_ma
            // 
            tb_ma.Enabled = false;
            tb_ma.Location = new Point(96, 39);
            tb_ma.Name = "tb_ma";
            tb_ma.Size = new Size(275, 34);
            tb_ma.TabIndex = 8;
            // 
            // tb_sdt
            // 
            tb_sdt.Location = new Point(96, 189);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(275, 34);
            tb_sdt.TabIndex = 10;
            // 
            // tb_hoten
            // 
            tb_hoten.Location = new Point(96, 115);
            tb_hoten.Name = "tb_hoten";
            tb_hoten.Size = new Size(275, 34);
            tb_hoten.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnPhanQuyen);
            groupBox2.Controls.Add(btn_xuatExcel);
            groupBox2.Controls.Add(btn_xuatPDF);
            groupBox2.Controls.Add(btn_nhapExcel);
            groupBox2.Controls.Add(btn_opLock);
            groupBox2.Controls.Add(btn_lock);
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(btn_edit);
            groupBox2.Controls.Add(btn_add);
            groupBox2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 467);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(386, 311);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_xuatExcel
            // 
            btn_xuatExcel.Location = new Point(20, 197);
            btn_xuatExcel.Name = "btn_xuatExcel";
            btn_xuatExcel.Size = new Size(155, 40);
            btn_xuatExcel.TabIndex = 8;
            btn_xuatExcel.Text = "Xuất Excel";
            btn_xuatExcel.UseVisualStyleBackColor = true;
            btn_xuatExcel.Click += btn_xuatExcel_Click;
            // 
            // btn_xuatPDF
            // 
            btn_xuatPDF.Location = new Point(228, 197);
            btn_xuatPDF.Name = "btn_xuatPDF";
            btn_xuatPDF.Size = new Size(143, 40);
            btn_xuatPDF.TabIndex = 7;
            btn_xuatPDF.Text = "Xuất PDF";
            btn_xuatPDF.UseVisualStyleBackColor = true;
            btn_xuatPDF.Click += btn_xuat_Click;
            // 
            // btn_nhapExcel
            // 
            btn_nhapExcel.Location = new Point(20, 127);
            btn_nhapExcel.Name = "btn_nhapExcel";
            btn_nhapExcel.Size = new Size(123, 40);
            btn_nhapExcel.TabIndex = 6;
            btn_nhapExcel.Text = "Nhập Excel";
            btn_nhapExcel.UseVisualStyleBackColor = true;
            btn_nhapExcel.Click += btn_nhapExcel_Click;
            // 
            // btn_opLock
            // 
            btn_opLock.Enabled = false;
            btn_opLock.Location = new Point(270, 127);
            btn_opLock.Name = "btn_opLock";
            btn_opLock.Size = new Size(101, 40);
            btn_opLock.TabIndex = 4;
            btn_opLock.Text = "Mở khoá";
            btn_opLock.UseVisualStyleBackColor = true;
            btn_opLock.Click += btn_opLock_Click;
            // 
            // btn_lock
            // 
            btn_lock.Enabled = false;
            btn_lock.Location = new Point(167, 127);
            btn_lock.Name = "btn_lock";
            btn_lock.Size = new Size(76, 40);
            btn_lock.TabIndex = 3;
            btn_lock.Text = "Khoá";
            btn_lock.UseVisualStyleBackColor = true;
            btn_lock.Click += btn_lock_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(270, 53);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(101, 40);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "Làm mới";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_edit
            // 
            btn_edit.Enabled = false;
            btn_edit.Location = new Point(149, 53);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 40);
            btn_edit.TabIndex = 1;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(20, 53);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(100, 40);
            btn_add.TabIndex = 0;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cbb_find
            // 
            cbb_find.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_find.FormattingEnabled = true;
            cbb_find.Items.AddRange(new object[] { "Mã DS", "Họ tên", "SĐT", "Email" });
            cbb_find.Location = new Point(784, 73);
            cbb_find.Name = "cbb_find";
            cbb_find.Size = new Size(126, 33);
            cbb_find.TabIndex = 15;
            cbb_find.SelectedIndexChanged += cbb_find_SelectedIndexChanged;
            // 
            // tb_find
            // 
            tb_find.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_find.Location = new Point(916, 73);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(316, 34);
            tb_find.TabIndex = 12;
            tb_find.TextChanged += tb_find_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(415, 79);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 36;
            label6.Text = "Trạng thái :";
            // 
            // cbb_findTT
            // 
            cbb_findTT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_findTT.FormattingEnabled = true;
            cbb_findTT.Items.AddRange(new object[] { "Tất cả", "Còn làm", "Nghỉ làm" });
            cbb_findTT.Location = new Point(517, 73);
            cbb_findTT.Name = "cbb_findTT";
            cbb_findTT.Size = new Size(125, 33);
            cbb_findTT.TabIndex = 37;
            cbb_findTT.SelectedIndexChanged += cbb_findTT_SelectedIndexChanged;
            // 
            // lv_qlduocsi
            // 
            lv_qlduocsi.Columns.AddRange(new ColumnHeader[] { clMaSP, clTenSP, clGiaTien, clSoLuong, columnHeader1, columnHeader2, columnHeader3 });
            lv_qlduocsi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_qlduocsi.FullRowSelect = true;
            lv_qlduocsi.Location = new Point(415, 124);
            lv_qlduocsi.Margin = new Padding(3, 4, 3, 4);
            lv_qlduocsi.Name = "lv_qlduocsi";
            lv_qlduocsi.Size = new Size(817, 719);
            lv_qlduocsi.TabIndex = 48;
            lv_qlduocsi.UseCompatibleStateImageBehavior = false;
            lv_qlduocsi.View = View.Details;
            lv_qlduocsi.ItemSelectionChanged += lv_qlduocsi_ItemSelectionChanged;
            // 
            // clMaSP
            // 
            clMaSP.Text = "STT";
            clMaSP.Width = 40;
            // 
            // clTenSP
            // 
            clTenSP.Text = "Mã DS";
            clTenSP.Width = 80;
            // 
            // clGiaTien
            // 
            clGiaTien.Text = "Họ tên";
            clGiaTien.Width = 190;
            // 
            // clSoLuong
            // 
            clSoLuong.Text = "SĐT";
            clSoLuong.Width = 110;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Email";
            columnHeader1.Width = 203;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tài khoản";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Trạng thái";
            columnHeader3.Width = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(689, 79);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 49;
            label2.Text = "Tìm kiếm :";
            // 
            // btnPhanQuyen
            // 
            btnPhanQuyen.Enabled = false;
            btnPhanQuyen.Location = new Point(128, 253);
            btnPhanQuyen.Name = "btnPhanQuyen";
            btnPhanQuyen.Size = new Size(128, 40);
            btnPhanQuyen.TabIndex = 9;
            btnPhanQuyen.Text = "Phân quyền";
            btnPhanQuyen.UseVisualStyleBackColor = true;
            btnPhanQuyen.Click += btnPhanQuyen_Click;
            // 
            // FormDuocSi
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1244, 864);
            Controls.Add(label2);
            Controls.Add(lv_qlduocsi);
            Controls.Add(cbb_findTT);
            Controls.Add(label6);
            Controls.Add(tb_find);
            Controls.Add(cbb_find);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(5);
            Name = "FormDuocSi";
            Text = "FormDuocSi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private TextBox tb_email;
        private TextBox tb_ma;
        private TextBox tb_sdt;
        private TextBox tb_hoten;
        private GroupBox groupBox2;
        private Button btn_opLock;
        private Button btn_lock;
        private Button btn_clear;
        private Button btn_edit;
        private Button btn_add;
        private Button btn_xuatPDF;
        private Button btn_nhapExcel;
        private ComboBox cbb_find;
        private TextBox tb_find;
        private Label label6;
        private ComboBox cbb_findTT;
        private Label label8;
        private Label label7;
        private Label label14;
        private Label label9;
        private ListView lv_qlduocsi;
        private ColumnHeader clMaSP;
        private ColumnHeader clTenSP;
        private ColumnHeader clGiaTien;
        private ColumnHeader clSoLuong;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label erorr_email;
        private Label erorr_sdt;
        private Label erorr_hoTen;
        private Label label2;
        private Button btn_xuatExcel;
        private Label label3;
        private Button btnPhanQuyen;
    }
}