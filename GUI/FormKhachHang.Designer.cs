namespace GUI
{
    partial class FormKhachHang
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
            groupBox1 = new GroupBox();
            erorr_diem = new Label();
            erorr_sdt = new Label();
            cb_nu = new CheckBox();
            cb_nam = new CheckBox();
            date_kh = new DateTimePicker();
            tb_diem = new TextBox();
            tb_hoten = new TextBox();
            tb_sdt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            groupBox2 = new GroupBox();
            btn_xuat = new Button();
            btn_nhapExcel = new Button();
            btn_clear = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            cbb_find = new ComboBox();
            tb_find = new TextBox();
            date_find1 = new DateTimePicker();
            date_find2 = new DateTimePicker();
            label7 = new Label();
            lv_qlkhachhang = new ListView();
            clMaSP = new ColumnHeader();
            clTenSP = new ColumnHeader();
            clGiaTien = new ColumnHeader();
            clSoLuong = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(erorr_diem);
            groupBox1.Controls.Add(erorr_sdt);
            groupBox1.Controls.Add(cb_nu);
            groupBox1.Controls.Add(cb_nam);
            groupBox1.Controls.Add(date_kh);
            groupBox1.Controls.Add(tb_diem);
            groupBox1.Controls.Add(tb_hoten);
            groupBox1.Controls.Add(tb_sdt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(14, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 378);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm khách hàng";
            // 
            // erorr_diem
            // 
            erorr_diem.AutoSize = true;
            erorr_diem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_diem.ForeColor = Color.Red;
            erorr_diem.Location = new Point(121, 337);
            erorr_diem.Name = "erorr_diem";
            erorr_diem.Size = new Size(0, 23);
            erorr_diem.TabIndex = 25;
            // 
            // erorr_sdt
            // 
            erorr_sdt.AutoSize = true;
            erorr_sdt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_sdt.ForeColor = Color.Red;
            erorr_sdt.Location = new Point(121, 267);
            erorr_sdt.Name = "erorr_sdt";
            erorr_sdt.Size = new Size(0, 23);
            erorr_sdt.TabIndex = 24;
            // 
            // cb_nu
            // 
            cb_nu.AutoSize = true;
            cb_nu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_nu.Location = new Point(221, 173);
            cb_nu.Name = "cb_nu";
            cb_nu.Size = new Size(58, 29);
            cb_nu.TabIndex = 23;
            cb_nu.Text = "Nữ";
            cb_nu.UseVisualStyleBackColor = true;
            cb_nu.CheckedChanged += cb_nu_CheckedChanged;
            // 
            // cb_nam
            // 
            cb_nam.AutoSize = true;
            cb_nam.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_nam.Location = new Point(121, 173);
            cb_nam.Name = "cb_nam";
            cb_nam.Size = new Size(72, 29);
            cb_nam.TabIndex = 22;
            cb_nam.Text = "Nam";
            cb_nam.UseVisualStyleBackColor = true;
            cb_nam.CheckedChanged += cb_nam_CheckedChanged;
            // 
            // date_kh
            // 
            date_kh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_kh.Location = new Point(121, 112);
            date_kh.Name = "date_kh";
            date_kh.Size = new Size(317, 31);
            date_kh.TabIndex = 21;
            date_kh.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // tb_diem
            // 
            tb_diem.Enabled = false;
            tb_diem.Location = new Point(121, 300);
            tb_diem.Name = "tb_diem";
            tb_diem.Size = new Size(317, 34);
            tb_diem.TabIndex = 20;
            tb_diem.Text = "0";
            // 
            // tb_hoten
            // 
            tb_hoten.Location = new Point(121, 48);
            tb_hoten.Name = "tb_hoten";
            tb_hoten.Size = new Size(317, 34);
            tb_hoten.TabIndex = 19;
            // 
            // tb_sdt
            // 
            tb_sdt.Location = new Point(121, 230);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(317, 34);
            tb_sdt.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 56);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 15;
            label6.Text = "Họ tên :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 119);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 14;
            label5.Text = "Ngày sinh :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 176);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 13;
            label4.Text = "Giới tính :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 238);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 12;
            label2.Text = "SĐT :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 308);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 11;
            label1.Text = "Điểm :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(440, 9);
            label11.Name = "label11";
            label11.Size = new Size(287, 32);
            label11.TabIndex = 32;
            label11.Text = "QUẢN LÝ KHÁCH HÀNG";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_xuat);
            groupBox2.Controls.Add(btn_nhapExcel);
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(btn_edit);
            groupBox2.Controls.Add(btn_add);
            groupBox2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(14, 503);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 177);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_xuat
            // 
            btn_xuat.Location = new Point(259, 118);
            btn_xuat.Name = "btn_xuat";
            btn_xuat.Size = new Size(149, 40);
            btn_xuat.TabIndex = 7;
            btn_xuat.Text = "Xuất";
            btn_xuat.UseVisualStyleBackColor = true;
            btn_xuat.Click += btn_xuat_Click;
            // 
            // btn_nhapExcel
            // 
            btn_nhapExcel.Location = new Point(63, 118);
            btn_nhapExcel.Name = "btn_nhapExcel";
            btn_nhapExcel.Size = new Size(149, 40);
            btn_nhapExcel.TabIndex = 6;
            btn_nhapExcel.Text = "Nhập Excel";
            btn_nhapExcel.UseVisualStyleBackColor = true;
            btn_nhapExcel.Click += btn_nhapExcel_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(332, 53);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(106, 40);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "Làm mới";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_edit
            // 
            btn_edit.Enabled = false;
            btn_edit.Location = new Point(175, 53);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(120, 40);
            btn_edit.TabIndex = 1;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(20, 53);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(119, 40);
            btn_add.TabIndex = 0;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cbb_find
            // 
            cbb_find.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_find.FormattingEnabled = true;
            cbb_find.Items.AddRange(new object[] { "Mã KH", "Họ tên", "Ngày sinh", "Giới tính", "SĐT", "Điểm" });
            cbb_find.Location = new Point(494, 71);
            cbb_find.Name = "cbb_find";
            cbb_find.Size = new Size(149, 33);
            cbb_find.TabIndex = 34;
            cbb_find.SelectedIndexChanged += cbb_find_SelectedIndexChanged;
            // 
            // tb_find
            // 
            tb_find.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_find.Location = new Point(670, 71);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(562, 34);
            tb_find.TabIndex = 35;
            tb_find.TextChanged += tb_find_TextChanged;
            // 
            // date_find1
            // 
            date_find1.CalendarFont = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_find1.Enabled = false;
            date_find1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_find1.Location = new Point(494, 124);
            date_find1.Name = "date_find1";
            date_find1.Size = new Size(338, 31);
            date_find1.TabIndex = 22;
            date_find1.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            date_find1.ValueChanged += date_find1_ValueChanged;
            // 
            // date_find2
            // 
            date_find2.Enabled = false;
            date_find2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_find2.Location = new Point(898, 124);
            date_find2.Name = "date_find2";
            date_find2.Size = new Size(334, 31);
            date_find2.TabIndex = 37;
            date_find2.Value = new DateTime(2024, 10, 29, 12, 51, 29, 258);
            date_find2.ValueChanged += date_find2_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(854, 131);
            label7.Name = "label7";
            label7.Size = new Size(17, 23);
            label7.TabIndex = 22;
            label7.Text = "-";
            // 
            // lv_qlkhachhang
            // 
            lv_qlkhachhang.Columns.AddRange(new ColumnHeader[] { clMaSP, clTenSP, clGiaTien, clSoLuong, columnHeader1, columnHeader2, columnHeader3 });
            lv_qlkhachhang.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_qlkhachhang.FullRowSelect = true;
            lv_qlkhachhang.Location = new Point(494, 180);
            lv_qlkhachhang.Margin = new Padding(3, 4, 3, 4);
            lv_qlkhachhang.Name = "lv_qlkhachhang";
            lv_qlkhachhang.Size = new Size(738, 671);
            lv_qlkhachhang.TabIndex = 49;
            lv_qlkhachhang.UseCompatibleStateImageBehavior = false;
            lv_qlkhachhang.View = View.Details;
            lv_qlkhachhang.ItemSelectionChanged += lv_qlkhachhang_SelectedIndexChanged;
            // 
            // clMaSP
            // 
            clMaSP.Text = "STT";
            clMaSP.Width = 40;
            // 
            // clTenSP
            // 
            clTenSP.Text = "Mã KH";
            clTenSP.Width = 70;
            // 
            // clGiaTien
            // 
            clGiaTien.Text = "Họ tên";
            clGiaTien.Width = 233;
            // 
            // clSoLuong
            // 
            clSoLuong.Text = "Ngày sinh";
            clSoLuong.Width = 120;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Giới tính";
            columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "SĐT";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Điểm";
            columnHeader3.Width = 70;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 864);
            Controls.Add(lv_qlkhachhang);
            Controls.Add(label7);
            Controls.Add(date_find2);
            Controls.Add(date_find1);
            Controls.Add(tb_find);
            Controls.Add(cbb_find);
            Controls.Add(groupBox2);
            Controls.Add(label11);
            Controls.Add(groupBox1);
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label11;
        private GroupBox groupBox2;
        private Button btn_xuat;
        private Button btn_nhapExcel;
        private Button btn_clear;
        private Button btn_edit;
        private Button btn_add;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox tb_diem;
        private TextBox tb_hoten;
        private TextBox tb_sdt;
        private ComboBox cbb_find;
        private TextBox tb_find;
        private DateTimePicker date_kh;
        private DateTimePicker date_find1;
        private DateTimePicker date_find2;
        private Label label7;
        private CheckBox cb_nu;
        private CheckBox cb_nam;
        private Label erorr_diem;
        private Label erorr_sdt;
        private ListView lv_qlkhachhang;
        private ColumnHeader clMaSP;
        private ColumnHeader clTenSP;
        private ColumnHeader clGiaTien;
        private ColumnHeader clSoLuong;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}