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
            ListViewItem listViewItem1 = new ListViewItem("2");
            ListViewItem listViewItem2 = new ListViewItem("3");
            ListViewItem listViewItem3 = new ListViewItem("1");
            label1 = new Label();
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 20);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "form tiêu hủy";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 73);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 111);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Lô sản xuất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 148);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày lập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 189);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 4;
            label5.Text = "Người lập";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 235);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 5;
            label6.Text = "Lý do";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 281);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 6;
            label7.Text = "Lý do khác";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(422, 32);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // button1
            // 
            button1.Location = new Point(842, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(32, 333);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(351, 156);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // lsvThemHoaDon
            // 
            lsvThemHoaDon.Columns.AddRange(new ColumnHeader[] { clMaSP, clKhachHang, clTenSP, clGiaTien, clSoLuong });
            lsvThemHoaDon.FullRowSelect = true;
            lsvThemHoaDon.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lsvThemHoaDon.Location = new Point(399, 100);
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
            clSoLuong.Text = "Số Lương";
            clSoLuong.Width = 100;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(498, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(141, 27);
            dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(667, 32);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(162, 27);
            dateTimePicker2.TabIndex = 23;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(141, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 24;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(141, 65);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(187, 28);
            comboBox2.TabIndex = 25;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(141, 108);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(187, 28);
            comboBox3.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(141, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 28;
            // 
            // button2
            // 
            button2.Location = new Point(159, 533);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 29;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormTieuHuy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(935, 587);
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
            Controls.Add(label1);
            Name = "FormTieuHuy";
            Text = "FormTieuHuy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
    }
}