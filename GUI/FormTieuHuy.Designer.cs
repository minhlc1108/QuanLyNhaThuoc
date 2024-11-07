namespace GUI
{
    partial class FormTieuHuy
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
            ListViewItem listViewItem4 = new ListViewItem("2");
            ListViewItem listViewItem5 = new ListViewItem("3");
            ListViewItem listViewItem6 = new ListViewItem("1");
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            lsvThemHoaDon = new ListView();
            clMaSP = new ColumnHeader();
            clKhachHang = new ColumnHeader();
            clTenSP = new ColumnHeader();
            clGiaTien = new ColumnHeader();
            clSoLuong = new ColumnHeader();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 137);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 175);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Lô sản xuất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 212);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày lập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 253);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Người lập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 299);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 5;
            label6.Text = "Lý do";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(74, 345);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 6;
            label7.Text = "Lý do khác";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(444, 100);
            label8.Name = "label8";
            label8.Size = new Size(71, 20);
            label8.TabIndex = 7;
            label8.Text = "Thời gian";
            // 
            // button1
            // 
            button1.Location = new Point(878, 96);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(80, 397);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(351, 156);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // lsvThemHoaDon
            // 
            lsvThemHoaDon.Columns.AddRange(new ColumnHeader[] { clMaSP, clKhachHang, clTenSP, clGiaTien, clSoLuong });
            lsvThemHoaDon.FullRowSelect = true;
            lsvThemHoaDon.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
            lsvThemHoaDon.Location = new Point(447, 164);
            lsvThemHoaDon.Margin = new Padding(3, 4, 3, 4);
            lsvThemHoaDon.Name = "lsvThemHoaDon";
            lsvThemHoaDon.Size = new Size(514, 474);
            lsvThemHoaDon.TabIndex = 21;
            lsvThemHoaDon.UseCompatibleStateImageBehavior = false;
            lsvThemHoaDon.View = View.Details;
            // 
            // clMaSP
            // 
            clMaSP.Text = "Mã SP";
            clMaSP.Width = 96;
            // 
            // clKhachHang
            // 
            clKhachHang.Text = "Khách Hàng";
            clKhachHang.Width = 100;
            // 
            // clTenSP
            // 
            clTenSP.Text = "Tên SP";
            clTenSP.Width = 100;
            // 
            // clGiaTien
            // 
            clGiaTien.Text = "Giá Tiền";
            clGiaTien.Width = 100;
            // 
            // clSoLuong
            // 
            clSoLuong.Text = "Số Lượng";
            clSoLuong.Width = 100;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(521, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(141, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(692, 96);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(162, 27);
            dateTimePicker2.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 299);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(189, 129);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(187, 28);
            comboBox2.TabIndex = 25;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(189, 172);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(187, 28);
            comboBox3.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 28;
            // 
            // button2
            // 
            button2.Location = new Point(123, 609);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 29;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(259, 609);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 30;
            button3.Text = "Hủy";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(676, 647);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 31;
            button4.Text = "Xuất excel";
            button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(146, 41);
            label9.Name = "label9";
            label9.Size = new Size(200, 41);
            label9.TabIndex = 33;
            label9.Text = "Đơn tiêu hủy";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(588, 32);
            label10.Name = "label10";
            label10.Size = new Size(284, 41);
            label10.TabIndex = 34;
            label10.Text = "Danh sách tiêu hủy";
            // 
            // FormTieuHuy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 688);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lsvThemHoaDon);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormTieuHuy";
            Text = "FormTieuHuy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private RichTextBox richTextBox1;
        private ListView lsvThemHoaDon;
        private ColumnHeader clMaSP;
        private ColumnHeader clKhachHang;
        private ColumnHeader clTenSP;
        private ColumnHeader clGiaTien;
        private ColumnHeader clSoLuong;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label9;
        private Label label10;
    }
}