namespace GUI
{
    partial class FormThongKeSPNhap
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
            label3 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(477, 11);
            label2.Name = "label2";
            label2.Size = new Size(349, 38);
            label2.TabIndex = 1;
            label2.Text = "Thống kê sản phẩm nhập";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(264, 58);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Sản phẩm:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(373, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(263, 28);
            comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(811, 58);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(263, 28);
            comboBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(673, 58);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 4;
            label1.Text = "Nhà cung cấp:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(673, 113);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 3, 0, 3);
            label4.Size = new Size(138, 34);
            label4.TabIndex = 9;
            label4.Text = "Ngày kết thúc:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 12F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(814, 113);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(149, 34);
            dateTimePicker2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(265, 113);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 3, 0, 3);
            label5.Size = new Size(135, 34);
            label5.TabIndex = 7;
            label5.Text = "Ngày bắt đầu:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(406, 113);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 34);
            dateTimePicker1.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(279, 182);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(125, 24);
            radioButton1.TabIndex = 10;
            radioButton1.TabStop = true;
            radioButton1.Text = "Theo số lượng";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(474, 182);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(125, 24);
            radioButton2.TabIndex = 11;
            radioButton2.Text = "Theo giá nhập";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(673, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(890, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 27);
            textBox2.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(869, 189);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 14;
            label6.Text = "-";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(638, 303);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(594, 500);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bảng thông tin";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(25, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(550, 456);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Thời gian";
            columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Chi tiết";
            columnHeader2.Width = 210;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 303);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(605, 500);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Biểu đồ";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(567, 225);
            button1.Name = "button1";
            button1.Size = new Size(129, 41);
            button1.TabIndex = 17;
            button1.Text = "Thống kê";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormThongKeSPNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 813);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormThongKeSPNhap";
            Text = "FormThongKeSPNhap";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label6;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox1;
        private Button button1;
    }
}