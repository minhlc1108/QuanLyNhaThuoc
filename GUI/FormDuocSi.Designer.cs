namespace GUI
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "1", "", "", "", "" }, -1);
            ListViewItem listViewItem2 = new ListViewItem("2");
            ListViewItem listViewItem3 = new ListViewItem("3");
            ListViewItem listViewItem4 = new ListViewItem("4");
            ListViewItem listViewItem5 = new ListViewItem("5");
            ListViewItem listViewItem6 = new ListViewItem("6");
            label1 = new Label();
            groupBox1 = new GroupBox();
            tb_email = new TextBox();
            tb_ma = new TextBox();
            label2 = new Label();
            tb_sdt = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tb_hoten = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btn_xuat = new Button();
            btn_nhapExcel = new Button();
            btn_del = new Button();
            btn_opLock = new Button();
            btn_lock = new Button();
            btn_clear = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            lv_qlduocsi = new ListView();
            stt = new ColumnHeader();
            mads = new ColumnHeader();
            hoten = new ColumnHeader();
            sdt = new ColumnHeader();
            email = new ColumnHeader();
            taikhoan = new ColumnHeader();
            trangthai = new ColumnHeader();
            cbb_find = new ComboBox();
            tb_find = new TextBox();
            btn_find = new Button();
            label6 = new Label();
            cbb_findTT = new ComboBox();
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
            groupBox1.Controls.Add(tb_email);
            groupBox1.Controls.Add(tb_ma);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_sdt);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_hoten);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 327);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin dược sĩ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(96, 263);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(237, 34);
            tb_email.TabIndex = 11;
            // 
            // tb_ma
            // 
            tb_ma.Location = new Point(96, 39);
            tb_ma.Name = "tb_ma";
            tb_ma.Size = new Size(237, 34);
            tb_ma.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 271);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 5;
            label2.Text = "Email :";
            // 
            // tb_sdt
            // 
            tb_sdt.Location = new Point(96, 189);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(237, 34);
            tb_sdt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 197);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 6;
            label4.Text = "SĐT :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 47);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 4;
            label3.Text = "Mã DS :";
            // 
            // tb_hoten
            // 
            tb_hoten.Location = new Point(96, 115);
            tb_hoten.Name = "tb_hoten";
            tb_hoten.Size = new Size(237, 34);
            tb_hoten.TabIndex = 9;
            tb_hoten.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 123);
            label5.Name = "label5";
            label5.Size = new Size(75, 23);
            label5.TabIndex = 7;
            label5.Text = "Họ Tên :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_xuat);
            groupBox2.Controls.Add(btn_nhapExcel);
            groupBox2.Controls.Add(btn_del);
            groupBox2.Controls.Add(btn_opLock);
            groupBox2.Controls.Add(btn_lock);
            groupBox2.Controls.Add(btn_clear);
            groupBox2.Controls.Add(btn_edit);
            groupBox2.Controls.Add(btn_add);
            groupBox2.Font = new Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 409);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 267);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            // 
            // btn_xuat
            // 
            btn_xuat.Location = new Point(198, 196);
            btn_xuat.Name = "btn_xuat";
            btn_xuat.Size = new Size(135, 40);
            btn_xuat.TabIndex = 7;
            btn_xuat.Text = "Xuất";
            btn_xuat.UseVisualStyleBackColor = true;
            // 
            // btn_nhapExcel
            // 
            btn_nhapExcel.Location = new Point(20, 196);
            btn_nhapExcel.Name = "btn_nhapExcel";
            btn_nhapExcel.Size = new Size(142, 40);
            btn_nhapExcel.TabIndex = 6;
            btn_nhapExcel.Text = "Nhập Excel";
            btn_nhapExcel.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(249, 127);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(84, 40);
            btn_del.TabIndex = 5;
            btn_del.Text = "Xoá";
            btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_opLock
            // 
            btn_opLock.Location = new Point(126, 127);
            btn_opLock.Name = "btn_opLock";
            btn_opLock.Size = new Size(94, 40);
            btn_opLock.TabIndex = 4;
            btn_opLock.Text = "Mở khoá";
            btn_opLock.UseVisualStyleBackColor = true;
            // 
            // btn_lock
            // 
            btn_lock.Location = new Point(20, 127);
            btn_lock.Name = "btn_lock";
            btn_lock.Size = new Size(79, 40);
            btn_lock.TabIndex = 3;
            btn_lock.Text = "Khoá";
            btn_lock.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(239, 53);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 40);
            btn_clear.TabIndex = 2;
            btn_clear.Text = "Làm mới";
            btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(126, 53);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(79, 40);
            btn_edit.TabIndex = 1;
            btn_edit.Text = "Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(20, 53);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(79, 40);
            btn_add.TabIndex = 0;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // lv_qlduocsi
            // 
            lv_qlduocsi.Activation = ItemActivation.TwoClick;
            lv_qlduocsi.Columns.AddRange(new ColumnHeader[] { stt, mads, hoten, sdt, email, taikhoan, trangthai });
            lv_qlduocsi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_qlduocsi.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6 });
            lv_qlduocsi.Location = new Point(387, 123);
            lv_qlduocsi.Name = "lv_qlduocsi";
            lv_qlduocsi.Size = new Size(735, 633);
            lv_qlduocsi.TabIndex = 14;
            lv_qlduocsi.UseCompatibleStateImageBehavior = false;
            lv_qlduocsi.View = View.Details;
            // 
            // stt
            // 
            stt.Text = "STT";
            // 
            // mads
            // 
            mads.Text = "Mã DS";
            mads.Width = 80;
            // 
            // hoten
            // 
            hoten.Text = "Họ tên";
            hoten.Width = 160;
            // 
            // sdt
            // 
            sdt.Text = "SĐT";
            sdt.Width = 80;
            // 
            // email
            // 
            email.Text = "Email";
            email.Width = 130;
            // 
            // taikhoan
            // 
            taikhoan.Text = "Tài khoản";
            taikhoan.Width = 120;
            // 
            // trangthai
            // 
            trangthai.Text = "Trạng thái";
            trangthai.Width = 100;
            // 
            // cbb_find
            // 
            cbb_find.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_find.FormattingEnabled = true;
            cbb_find.Items.AddRange(new object[] { "Mã DS", "Họ tên", "SĐT", "Email" });
            cbb_find.Location = new Point(625, 73);
            cbb_find.Name = "cbb_find";
            cbb_find.Size = new Size(111, 33);
            cbb_find.TabIndex = 15;
            // 
            // tb_find
            // 
            tb_find.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_find.Location = new Point(742, 73);
            tb_find.Name = "tb_find";
            tb_find.Size = new Size(280, 34);
            tb_find.TabIndex = 12;
            // 
            // btn_find
            // 
            btn_find.Font = new Font("Segoe UI Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_find.Location = new Point(1028, 71);
            btn_find.Name = "btn_find";
            btn_find.Size = new Size(94, 36);
            btn_find.TabIndex = 8;
            btn_find.Text = "Tìm";
            btn_find.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(385, 79);
            label6.Name = "label6";
            label6.Size = new Size(96, 23);
            label6.TabIndex = 36;
            label6.Text = "Trạng thái :";
            // 
            // cbb_findTT
            // 
            cbb_findTT.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_findTT.FormattingEnabled = true;
            cbb_findTT.Items.AddRange(new object[] { "Còn làm", "Nghỉ làm" });
            cbb_findTT.Location = new Point(487, 73);
            cbb_findTT.Name = "cbb_findTT";
            cbb_findTT.Size = new Size(91, 33);
            cbb_findTT.TabIndex = 37;
            // 
            // FormDuocSi
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1144, 762);
            Controls.Add(cbb_findTT);
            Controls.Add(label6);
            Controls.Add(btn_find);
            Controls.Add(tb_find);
            Controls.Add(cbb_find);
            Controls.Add(lv_qlduocsi);
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
        private Label label2;
        private TextBox tb_sdt;
        private Label label4;
        private Label label3;
        private TextBox tb_hoten;
        private Label label5;
        private GroupBox groupBox2;
        private Button btn_del;
        private Button btn_opLock;
        private Button btn_lock;
        private Button btn_clear;
        private Button btn_edit;
        private Button btn_add;
        private Button btn_xuat;
        private Button btn_nhapExcel;
        private ListView lv_qlduocsi;
        private ComboBox cbb_find;
        private TextBox tb_find;
        private Button btn_find;
        private ColumnHeader stt;
        private ColumnHeader mads;
        private ColumnHeader hoten;
        private ColumnHeader sdt;
        private ColumnHeader email;
        private ColumnHeader taikhoan;
        private ColumnHeader trangthai;
        private Label label6;
        private ComboBox cbb_findTT;
    }
}