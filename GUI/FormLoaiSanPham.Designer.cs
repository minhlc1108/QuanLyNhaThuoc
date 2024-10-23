namespace GUI
{
    partial class FormLoaiSanPham
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
            label3 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button7 = new Button();
            button6 = new Button();
            listView1 = new ListView();
            clMaLoaiSP = new ColumnHeader();
            clTenLoaiSP = new ColumnHeader();
            clTrangThai = new ColumnHeader();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(459, 34);
            label3.Name = "label3";
            label3.Size = new Size(249, 25);
            label3.TabIndex = 2;
            label3.Text = "QUẢN LÝ LOẠI SẢN PHẨM";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 23);
            textBox2.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(26, 237);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 21;
            label5.Text = "Loại sản phẩm :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 135);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(201, 90);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 19;
            label1.Text = "LOẠI SẢN PHẨM";
            // 
            // button5
            // 
            button5.Location = new Point(54, 380);
            button5.Name = "button5";
            button5.Size = new Size(110, 26);
            button5.TabIndex = 28;
            button5.Text = "KHÓA";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(240, 380);
            button4.Name = "button4";
            button4.Size = new Size(133, 26);
            button4.TabIndex = 27;
            button4.Text = "LƯU CHỈNH SỬA";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(240, 321);
            button3.Name = "button3";
            button3.Size = new Size(133, 26);
            button3.TabIndex = 26;
            button3.Text = "LÀM MỚI";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(54, 321);
            button2.Name = "button2";
            button2.Size = new Size(110, 26);
            button2.TabIndex = 25;
            button2.Text = "THÊM";
            button2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(880, 631);
            button7.Name = "button7";
            button7.Size = new Size(121, 26);
            button7.TabIndex = 34;
            button7.Text = "LÀM MỚI";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(610, 631);
            button6.Name = "button6";
            button6.Size = new Size(180, 26);
            button6.TabIndex = 33;
            button6.Text = "XUẤT DANH SÁCH";
            button6.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clMaLoaiSP, clTenLoaiSP, clTrangThai });
            listView1.Location = new Point(493, 190);
            listView1.Name = "listView1";
            listView1.Size = new Size(640, 405);
            listView1.TabIndex = 32;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // clMaLoaiSP
            // 
            clMaLoaiSP.Text = "Mã Loại Sản Phẩm";
            clMaLoaiSP.Width = 200;
            // 
            // clTenLoaiSP
            // 
            clTenLoaiSP.Text = "Tên Loại Sản Phẩm";
            clTenLoaiSP.Width = 300;
            // 
            // clTrangThai
            // 
            clTrangThai.Text = "Trạng Thái";
            clTrangThai.Width = 130;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(775, 94);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 31;
            label2.Text = "TÌM KIẾM";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(493, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(491, 23);
            textBox1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Location = new Point(1005, 140);
            button1.Name = "button1";
            button1.Size = new Size(128, 26);
            button1.TabIndex = 29;
            button1.Text = "TÌM";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 23);
            textBox3.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 173);
            label6.Name = "label6";
            label6.Size = new Size(144, 21);
            label6.TabIndex = 35;
            label6.Text = "Mã loại sản phẩm :";
            // 
            // FormLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 679);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(listView1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormLoaiSanPham";
            Text = "FormLoaiSanPham";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button7;
        private Button button6;
        private ListView listView1;
        private ColumnHeader clMaLoaiSP;
        private ColumnHeader clMaSP;
        private ColumnHeader clTenSP;
        private ColumnHeader clTenLoai;
        private ColumnHeader clNhaSX;
        private ColumnHeader clQuyCach;
        private ColumnHeader clTenLoaiSP;
        private ColumnHeader clTrangThai;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox3;
        private Label label6;
    }
}