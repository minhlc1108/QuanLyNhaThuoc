namespace GUI
{
    partial class FormNhaCungCap
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
            erorr_sdt = new Label();
            erorr_email = new Label();
            tb_email = new TextBox();
            tb_sdt = new TextBox();
            tb_diaChi = new TextBox();
            tb_tenNcc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tb_maNcc = new TextBox();
            label17 = new Label();
            label19 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            btn_del = new Button();
            btn_import = new Button();
            btn_opLock = new Button();
            btn_lock = new Button();
            btn_export = new Button();
            btn_clear = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            cbb_ttFind = new ComboBox();
            tb_find = new TextBox();
            cbb_find = new ComboBox();
            groupBox2 = new GroupBox();
            lv_qlncc = new ListView();
            clMaNCC = new ColumnHeader();
            clTenNCC = new ColumnHeader();
            clDiaChi = new ColumnHeader();
            clSDT = new ColumnHeader();
            clEmail = new ColumnHeader();
            clTrangThai = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(erorr_sdt);
            groupBox1.Controls.Add(erorr_email);
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(tb_sdt);
            groupBox1.Controls.Add(tb_diaChi);
            groupBox1.Controls.Add(tb_tenNcc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_maNcc);
            groupBox1.Controls.Add(label17);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(796, 297);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm";
            // 
            // erorr_sdt
            // 
            erorr_sdt.AutoSize = true;
            erorr_sdt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_sdt.ForeColor = Color.Red;
            erorr_sdt.Location = new Point(560, 261);
            erorr_sdt.Name = "erorr_sdt";
            erorr_sdt.Size = new Size(0, 23);
            erorr_sdt.TabIndex = 43;
            // 
            // erorr_email
            // 
            erorr_email.AutoSize = true;
            erorr_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_email.ForeColor = Color.Red;
            erorr_email.Location = new Point(119, 261);
            erorr_email.Name = "erorr_email";
            erorr_email.Size = new Size(0, 23);
            erorr_email.TabIndex = 41;
            // 
            // tb_email
            // 
            tb_email.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_email.Location = new Point(119, 227);
            tb_email.Margin = new Padding(3, 4, 3, 4);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(276, 31);
            tb_email.TabIndex = 40;
            // 
            // tb_sdt
            // 
            tb_sdt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_sdt.Location = new Point(560, 227);
            tb_sdt.Margin = new Padding(3, 4, 3, 4);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(220, 31);
            tb_sdt.TabIndex = 39;
            // 
            // tb_diaChi
            // 
            tb_diaChi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_diaChi.Location = new Point(119, 159);
            tb_diaChi.Margin = new Padding(3, 4, 3, 4);
            tb_diaChi.Name = "tb_diaChi";
            tb_diaChi.Size = new Size(661, 31);
            tb_diaChi.TabIndex = 38;
            // 
            // tb_tenNcc
            // 
            tb_tenNcc.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_tenNcc.Location = new Point(119, 94);
            tb_tenNcc.Margin = new Padding(3, 4, 3, 4);
            tb_tenNcc.Name = "tb_tenNcc";
            tb_tenNcc.Size = new Size(661, 31);
            tb_tenNcc.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 231);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 36;
            label5.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(18, 163);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 35;
            label4.Text = "Địa chỉ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 30);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 34;
            label3.Text = "Mã NCC :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(434, 231);
            label2.Name = "label2";
            label2.Size = new Size(120, 23);
            label2.TabIndex = 33;
            label2.Text = "Số điện thoại :";
            // 
            // tb_maNcc
            // 
            tb_maNcc.Enabled = false;
            tb_maNcc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_maNcc.Location = new Point(119, 26);
            tb_maNcc.Margin = new Padding(3, 4, 3, 4);
            tb_maNcc.Name = "tb_maNcc";
            tb_maNcc.Size = new Size(194, 34);
            tb_maNcc.TabIndex = 31;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(18, 98);
            label17.Name = "label17";
            label17.Size = new Size(85, 23);
            label17.TabIndex = 30;
            label17.Text = "Tên NCC :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(442, 9);
            label19.Name = "label19";
            label19.Size = new Size(308, 32);
            label19.TabIndex = 5;
            label19.Text = "QUẢN LÝ NHÀ CUNG CẤP";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 38);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 41;
            label6.Text = "Trạng thái :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_del);
            groupBox3.Controls.Add(btn_import);
            groupBox3.Controls.Add(btn_opLock);
            groupBox3.Controls.Add(btn_lock);
            groupBox3.Controls.Add(btn_export);
            groupBox3.Controls.Add(btn_clear);
            groupBox3.Controls.Add(btn_edit);
            groupBox3.Controls.Add(btn_add);
            groupBox3.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(848, 44);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(384, 297);
            groupBox3.TabIndex = 41;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btn_del
            // 
            btn_del.Enabled = false;
            btn_del.Location = new Point(262, 126);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(104, 40);
            btn_del.TabIndex = 8;
            btn_del.Text = "Xoá";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_import
            // 
            btn_import.Location = new Point(53, 195);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(133, 40);
            btn_import.TabIndex = 6;
            btn_import.Text = "Nhập Excel";
            btn_import.UseVisualStyleBackColor = true;
            btn_import.Click += btn_import_Click;
            // 
            // btn_opLock
            // 
            btn_opLock.Enabled = false;
            btn_opLock.Location = new Point(136, 126);
            btn_opLock.Name = "btn_opLock";
            btn_opLock.Size = new Size(100, 40);
            btn_opLock.TabIndex = 4;
            btn_opLock.Text = "Mở khoá";
            btn_opLock.UseVisualStyleBackColor = true;
            btn_opLock.Click += btn_opLock_Click;
            // 
            // btn_lock
            // 
            btn_lock.Enabled = false;
            btn_lock.Location = new Point(20, 127);
            btn_lock.Name = "btn_lock";
            btn_lock.Size = new Size(91, 40);
            btn_lock.TabIndex = 3;
            btn_lock.Text = "Khoá";
            btn_lock.UseVisualStyleBackColor = true;
            btn_lock.Click += btn_lock_Click;
            // 
            // btn_export
            // 
            btn_export.Location = new Point(208, 195);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(130, 40);
            btn_export.TabIndex = 7;
            btn_export.Text = "Xuất";
            btn_export.UseVisualStyleBackColor = true;
            btn_export.Click += btn_export_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(262, 53);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(104, 40);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "Làm mới";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_edit
            // 
            btn_edit.Enabled = false;
            btn_edit.Location = new Point(136, 53);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(100, 40);
            btn_edit.TabIndex = 1;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(20, 53);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(91, 40);
            btn_add.TabIndex = 0;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cbb_ttFind
            // 
            cbb_ttFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_ttFind.FormattingEnabled = true;
            cbb_ttFind.Items.AddRange(new object[] { "Tất cả", "Còn hợp tác", "Hết hợp tác" });
            cbb_ttFind.Location = new Point(108, 33);
            cbb_ttFind.Margin = new Padding(3, 4, 3, 4);
            cbb_ttFind.Name = "cbb_ttFind";
            cbb_ttFind.Size = new Size(151, 33);
            cbb_ttFind.TabIndex = 41;
            cbb_ttFind.SelectedIndexChanged += cbb_ttFind_SelectedIndexChanged;
            // 
            // tb_find
            // 
            tb_find.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_find.Location = new Point(820, 29);
            tb_find.Margin = new Padding(3, 4, 3, 4);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(363, 34);
            tb_find.TabIndex = 41;
            tb_find.TextChanged += tb_find_TextChanged;
            // 
            // cbb_find
            // 
            cbb_find.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_find.FormattingEnabled = true;
            cbb_find.Items.AddRange(new object[] { "Mã NCC", "Tên NCC", "Địa chỉ", "SĐT", "Email" });
            cbb_find.Location = new Point(666, 29);
            cbb_find.Margin = new Padding(3, 4, 3, 4);
            cbb_find.Name = "cbb_find";
            cbb_find.Size = new Size(130, 33);
            cbb_find.TabIndex = 41;
            cbb_find.SelectedIndexChanged += cbb_find_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lv_qlncc);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbb_ttFind);
            groupBox2.Controls.Add(cbb_find);
            groupBox2.Controls.Add(tb_find);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(28, 347);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1204, 505);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // lv_qlncc
            // 
            lv_qlncc.Columns.AddRange(new ColumnHeader[] { clMaNCC, clTenNCC, clDiaChi, clSDT, clEmail, clTrangThai, columnHeader1 });
            lv_qlncc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_qlncc.FullRowSelect = true;
            lv_qlncc.Location = new Point(6, 87);
            lv_qlncc.Margin = new Padding(3, 4, 3, 4);
            lv_qlncc.Name = "lv_qlncc";
            lv_qlncc.Size = new Size(1180, 411);
            lv_qlncc.TabIndex = 43;
            lv_qlncc.UseCompatibleStateImageBehavior = false;
            lv_qlncc.View = View.Details;
            lv_qlncc.ItemSelectionChanged += lv_qlncc_SelectedIndexChanged;
            // 
            // clMaNCC
            // 
            clMaNCC.Text = "STT";
            clMaNCC.Width = 40;
            // 
            // clTenNCC
            // 
            clTenNCC.Text = "Mã NCC";
            clTenNCC.Width = 90;
            // 
            // clDiaChi
            // 
            clDiaChi.Text = "Tên nhà cung cấp";
            clDiaChi.Width = 310;
            // 
            // clSDT
            // 
            clSDT.Text = "Địa chỉ";
            clSDT.Width = 310;
            // 
            // clEmail
            // 
            clEmail.Text = "SĐT";
            clEmail.Width = 120;
            // 
            // clTrangThai
            // 
            clTrangThai.Text = "Email";
            clTrangThai.Width = 190;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Trạng thái";
            columnHeader1.Width = 116;
            // 
            // FormNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 864);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(label19);
            Controls.Add(groupBox1);
            Name = "FormNhaCungCap";
            Text = "FormNhaCungCap";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label19;
        private Label label17;
        private TextBox tb_maNcc;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tb_tenNcc;
        private Label label5;
        private TextBox tb_email;
        private TextBox tb_sdt;
        private TextBox tb_diaChi;
        private Label label6;
        private GroupBox groupBox3;
        private Button btn_import;
        private Button btn_opLock;
        private Button btn_lock;
        private Button btn_clear;
        private Button btn_edit;
        private Button btn_add;
        private Button btn_export;
        private ComboBox cbb_ttFind;
        private TextBox tb_find;
        private ComboBox cbb_find;
        private GroupBox groupBox2;
        private ListView lv_qlncc;
        private ColumnHeader clMaNCC;
        private ColumnHeader clTenNCC;
        private ColumnHeader clDiaChi;
        private ColumnHeader clSDT;
        private ColumnHeader clEmail;
        private ColumnHeader clTrangThai;
        private ColumnHeader columnHeader1;
        private Label erorr_sdt;
        private Label erorr_email;
        private Button btn_del;
    }
}