    namespace GUI
{
    partial class FormSanPham
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
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listView1 = new ListView();
            clMaSP = new ColumnHeader();
            clTenSP = new ColumnHeader();
            clLoaiSP = new ColumnHeader();
            clNhaSX = new ColumnHeader();
            clQuyCach = new ColumnHeader();
            clXuatXu = new ColumnHeader();
            clTrangThai = new ColumnHeader();
            button5 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(452, 9);
            label2.Name = "label2";
            label2.Size = new Size(201, 25);
            label2.TabIndex = 1;
            label2.Text = "QUẢN LÝ SẢN PHẨM";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1078, 100);
            button1.Name = "button1";
            button1.Size = new Size(128, 26);
            button1.TabIndex = 3;
            button1.Text = "TÌM";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(566, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(491, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(846, 56);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 5;
            label3.Text = "TÌM KIẾM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 101);
            label4.Name = "label4";
            label4.Size = new Size(116, 21);
            label4.TabIndex = 6;
            label4.Text = "Tên sản phẩm :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 158);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 7;
            label5.Text = "Loại sản phẩm :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 216);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 8;
            label6.Text = "Nhà sản phẩm :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 277);
            label7.Name = "label7";
            label7.Size = new Size(73, 21);
            label7.TabIndex = 9;
            label7.Text = "Xuất xứ :";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 328);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 10;
            label8.Text = "Quy cách :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 383);
            label9.Name = "label9";
            label9.Size = new Size(102, 21);
            label9.TabIndex = 11;
            label9.Text = "Thành phần :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 441);
            label10.Name = "label10";
            label10.Size = new Size(112, 21);
            label10.TabIndex = 12;
            label10.Text = "Điều trị bệnh :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(149, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(373, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(149, 443);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(373, 23);
            textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(149, 385);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(373, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(149, 275);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(373, 23);
            textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(149, 330);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(373, 23);
            textBox6.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(149, 158);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(373, 23);
            comboBox1.TabIndex = 18;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(149, 214);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(373, 23);
            comboBox2.TabIndex = 19;
            // 
            // button2
            // 
            button2.Location = new Point(4, 529);
            button2.Name = "button2";
            button2.Size = new Size(110, 26);
            button2.TabIndex = 20;
            button2.Text = "THÊM";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(132, 529);
            button3.Name = "button3";
            button3.Size = new Size(121, 26);
            button3.TabIndex = 21;
            button3.Text = "LÀM MỚI";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(273, 529);
            button4.Name = "button4";
            button4.Size = new Size(133, 26);
            button4.TabIndex = 22;
            button4.Text = "LƯU CHỈNH SỬA";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clMaSP, clTenSP, clLoaiSP, clNhaSX, clQuyCach, clXuatXu, clTrangThai });
            listView1.Location = new Point(566, 150);
            listView1.Name = "listView1";
            listView1.Size = new Size(640, 405);
            listView1.TabIndex = 23;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // clMaSP
            // 
            clMaSP.Text = "Mã SP";
            clMaSP.Width = 80;
            // 
            // clTenSP
            // 
            clTenSP.Text = "Tên SP";
            clTenSP.Width = 150;
            // 
            // clLoaiSP
            // 
            clLoaiSP.Text = "Loại SP";
            clLoaiSP.Width = 70;
            // 
            // clNhaSX
            // 
            clNhaSX.Text = "Nhà SX";
            clNhaSX.Width = 70;
            // 
            // clQuyCach
            // 
            clQuyCach.Text = "Quy Cách";
            clQuyCach.Width = 100;
            // 
            // clXuatXu
            // 
            clXuatXu.Text = "Xuất xứ";
            clXuatXu.Width = 70;
            // 
            // clTrangThai
            // 
            clTrangThai.Text = "Trạng Thái";
            clTrangThai.Width = 90;
            // 
            // button5
            // 
            button5.Location = new Point(429, 529);
            button5.Name = "button5";
            button5.Size = new Size(93, 26);
            button5.TabIndex = 24;
            button5.Text = "KHÓA";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(683, 591);
            button6.Name = "button6";
            button6.Size = new Size(180, 26);
            button6.TabIndex = 25;
            button6.Text = "XUẤT DANH SÁCH";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(953, 591);
            button7.Name = "button7";
            button7.Size = new Size(121, 26);
            button7.TabIndex = 26;
            button7.Text = "LÀM MỚI";
            button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 56);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "SẢN PHẨM";
            label1.Click += label1_Click;
            // 
            // FormSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 694);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSanPham";
            Text = "FormSanPham";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListView listView1;
        private ColumnHeader clMaSP;
        private ColumnHeader clTenSP;
        private ColumnHeader clLoaiSP;
        private ColumnHeader clNhaSX;
        private ColumnHeader clQuyCach;
        private ColumnHeader clXuatXu;
        private ColumnHeader clTrangThai;
        private Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button6;
        private Button button7;
        private Label label1;
    }
}