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
            ListViewItem listViewItem7 = new ListViewItem("2");
            ListViewItem listViewItem8 = new ListViewItem("3");
            ListViewItem listViewItem9 = new ListViewItem("1");
            groupBox1 = new GroupBox();
            tb_email = new TextBox();
            tb_sdt = new TextBox();
            tb_diaChi = new TextBox();
            tb_tenNcc = new TextBox();
            cbb_tt = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tb_ncc = new TextBox();
            label17 = new Label();
            label19 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            btn_import = new Button();
            btn_opLock = new Button();
            btn_lock = new Button();
            btn_clear = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            btn_export = new Button();
            cbb_ttFind = new ComboBox();
            tb_find = new TextBox();
            cbb_find = new ComboBox();
            btn_find = new Button();
            groupBox2 = new GroupBox();
            lv_qlncc = new ListView();
            clMaNCC = new ColumnHeader();
            clTenNCC = new ColumnHeader();
            clDiaChi = new ColumnHeader();
            clSDT = new ColumnHeader();
            clEmail = new ColumnHeader();
            clTrangThai = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(tb_sdt);
            groupBox1.Controls.Add(tb_diaChi);
            groupBox1.Controls.Add(tb_tenNcc);
            groupBox1.Controls.Add(cbb_tt);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_ncc);
            groupBox1.Controls.Add(label17);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(28, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(796, 204);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm";
            // 
            // tb_email
            // 
            tb_email.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_email.Location = new Point(119, 149);
            tb_email.Margin = new Padding(3, 4, 3, 4);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(355, 30);
            tb_email.TabIndex = 40;
            // 
            // tb_sdt
            // 
            tb_sdt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_sdt.Location = new Point(610, 96);
            tb_sdt.Margin = new Padding(3, 4, 3, 4);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(168, 30);
            tb_sdt.TabIndex = 39;
            // 
            // tb_diaChi
            // 
            tb_diaChi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_diaChi.Location = new Point(119, 96);
            tb_diaChi.Margin = new Padding(3, 4, 3, 4);
            tb_diaChi.Name = "tb_diaChi";
            tb_diaChi.Size = new Size(355, 30);
            tb_diaChi.TabIndex = 38;
            // 
            // tb_tenNcc
            // 
            tb_tenNcc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_tenNcc.Location = new Point(396, 39);
            tb_tenNcc.Margin = new Padding(3, 4, 3, 4);
            tb_tenNcc.Name = "tb_tenNcc";
            tb_tenNcc.Size = new Size(382, 30);
            tb_tenNcc.TabIndex = 37;
            // 
            // cbb_tt
            // 
            cbb_tt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_tt.FormattingEnabled = true;
            cbb_tt.Location = new Point(610, 143);
            cbb_tt.Margin = new Padding(3, 4, 3, 4);
            cbb_tt.Name = "cbb_tt";
            cbb_tt.Size = new Size(168, 33);
            cbb_tt.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(53, 153);
            label5.Name = "label5";
            label5.Size = new Size(60, 23);
            label5.TabIndex = 36;
            label5.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(42, 100);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 35;
            label4.Text = "Địa chỉ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 43);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 34;
            label3.Text = "Mã NCC :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(542, 100);
            label2.Name = "label2";
            label2.Size = new Size(49, 23);
            label2.TabIndex = 33;
            label2.Text = "SĐT :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(495, 153);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 32;
            label1.Text = "Trạng thái :";
            // 
            // tb_ncc
            // 
            tb_ncc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ncc.Location = new Point(119, 39);
            tb_ncc.Margin = new Padding(3, 4, 3, 4);
            tb_ncc.Name = "tb_ncc";
            tb_ncc.Size = new Size(135, 30);
            tb_ncc.TabIndex = 31;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(305, 43);
            label17.Name = "label17";
            label17.Size = new Size(85, 23);
            label17.TabIndex = 30;
            label17.Text = "Tên NCC :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(406, 18);
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
            label6.Click += label6_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_import);
            groupBox3.Controls.Add(btn_opLock);
            groupBox3.Controls.Add(btn_lock);
            groupBox3.Controls.Add(btn_clear);
            groupBox3.Controls.Add(btn_edit);
            groupBox3.Controls.Add(btn_add);
            groupBox3.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(848, 62);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(384, 204);
            groupBox3.TabIndex = 41;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btn_import
            // 
            btn_import.Location = new Point(250, 126);
            btn_import.Name = "btn_import";
            btn_import.Size = new Size(116, 40);
            btn_import.TabIndex = 6;
            btn_import.Text = "Nhập Excel";
            btn_import.UseVisualStyleBackColor = true;
            // 
            // btn_opLock
            // 
            btn_opLock.Location = new Point(125, 126);
            btn_opLock.Name = "btn_opLock";
            btn_opLock.Size = new Size(100, 40);
            btn_opLock.TabIndex = 4;
            btn_opLock.Text = "Mở khoá";
            btn_opLock.UseVisualStyleBackColor = true;
            // 
            // btn_lock
            // 
            btn_lock.Location = new Point(20, 127);
            btn_lock.Name = "btn_lock";
            btn_lock.Size = new Size(82, 40);
            btn_lock.TabIndex = 3;
            btn_lock.Text = "Khoá";
            btn_lock.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(272, 53);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 40);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "Làm mới";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(145, 53);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(94, 40);
            btn_edit.TabIndex = 1;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(20, 53);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(91, 40);
            btn_add.TabIndex = 0;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_export
            // 
            btn_export.Location = new Point(1092, 491);
            btn_export.Name = "btn_export";
            btn_export.Size = new Size(94, 40);
            btn_export.TabIndex = 7;
            btn_export.Text = "Xuất";
            btn_export.UseVisualStyleBackColor = true;
            // 
            // cbb_ttFind
            // 
            cbb_ttFind.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_ttFind.FormattingEnabled = true;
            cbb_ttFind.Items.AddRange(new object[] { "Còn hợp tác", "Hết hợp tác" });
            cbb_ttFind.Location = new Point(108, 33);
            cbb_ttFind.Margin = new Padding(3, 4, 3, 4);
            cbb_ttFind.Name = "cbb_ttFind";
            cbb_ttFind.Size = new Size(170, 33);
            cbb_ttFind.TabIndex = 41;
            // 
            // tb_find
            // 
            tb_find.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_find.Location = new Point(734, 33);
            tb_find.Margin = new Padding(3, 4, 3, 4);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(343, 34);
            tb_find.TabIndex = 41;
            // 
            // cbb_find
            // 
            cbb_find.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_find.FormattingEnabled = true;
            cbb_find.Items.AddRange(new object[] { "Mã NCC", "Tên NCC", "Địa chỉ", "SĐT" });
            cbb_find.Location = new Point(560, 32);
            cbb_find.Margin = new Padding(3, 4, 3, 4);
            cbb_find.Name = "cbb_find";
            cbb_find.Size = new Size(148, 33);
            cbb_find.TabIndex = 41;
            // 
            // btn_find
            // 
            btn_find.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_find.Location = new Point(1092, 32);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(94, 36);
            btn_find.TabIndex = 42;
            btn_find.Text = "Tìm";
            btn_find.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lv_qlncc);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbb_ttFind);
            groupBox2.Controls.Add(btn_find);
            groupBox2.Controls.Add(btn_export);
            groupBox2.Controls.Add(cbb_find);
            groupBox2.Controls.Add(tb_find);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(28, 290);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1204, 551);
            groupBox2.TabIndex = 43;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // lv_qlncc
            // 
            lv_qlncc.Columns.AddRange(new ColumnHeader[] { clMaNCC, clTenNCC, clDiaChi, clSDT, clEmail, clTrangThai });
            lv_qlncc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_qlncc.FullRowSelect = true;
            lv_qlncc.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8, listViewItem9 });
            lv_qlncc.Location = new Point(6, 79);
            lv_qlncc.Margin = new Padding(3, 4, 3, 4);
            lv_qlncc.Name = "lv_qlncc";
            lv_qlncc.Size = new Size(1180, 392);
            lv_qlncc.TabIndex = 43;
            lv_qlncc.UseCompatibleStateImageBehavior = false;
            lv_qlncc.View = View.Details;
            // 
            // clMaNCC
            // 
            clMaNCC.Text = "Mã NCC";
            clMaNCC.Width = 90;
            // 
            // clTenNCC
            // 
            clTenNCC.Text = "Tên nhà cung cấp";
            clTenNCC.Width = 250;
            // 
            // clDiaChi
            // 
            clDiaChi.Text = "Địa chỉ";
            clDiaChi.Width = 250;
            // 
            // clSDT
            // 
            clSDT.Text = "SĐT";
            clSDT.Width = 100;
            // 
            // clEmail
            // 
            clEmail.Text = "Email";
            clEmail.Width = 250;
            // 
            // clTrangThai
            // 
            clTrangThai.Text = "Trạng thái";
            clTrangThai.Width = 146;
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
        private TextBox tb_ncc;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbb_tt;
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
        private Button btn_find;
        private GroupBox groupBox2;
        private ListView lv_qlncc;
        private ColumnHeader clMaNCC;
        private ColumnHeader clTenNCC;
        private ColumnHeader clDiaChi;
        private ColumnHeader clSDT;
        private ColumnHeader clEmail;
        private ColumnHeader clTrangThai;
    }
}