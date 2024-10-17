namespace GUI
{
    partial class FormThongKeNhaCC
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
            button1 = new Button();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox1 = new GroupBox();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(517, 225);
            button1.Name = "button1";
            button1.Size = new Size(129, 41);
            button1.TabIndex = 36;
            button1.Text = "Thống kê";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(589, 272);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 480);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bảng thông tin";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Location = new Point(25, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(477, 420);
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
            groupBox1.Location = new Point(34, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 480);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Biểu đồ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(747, 192);
            label6.Name = "label6";
            label6.Size = new Size(15, 20);
            label6.TabIndex = 33;
            label6.Text = "-";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(768, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 27);
            textBox2.TabIndex = 32;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(551, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 27);
            textBox1.TabIndex = 31;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(375, 189);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(125, 24);
            radioButton2.TabIndex = 30;
            radioButton2.TabStop = true;
            radioButton2.Text = "Theo giá nhập";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(232, 187);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(125, 24);
            radioButton1.TabIndex = 29;
            radioButton1.TabStop = true;
            radioButton1.Text = "Theo số lượng";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(662, 118);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 3, 0, 3);
            label4.Size = new Size(138, 34);
            label4.TabIndex = 28;
            label4.Text = "Ngày kết thúc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(234, 118);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 3, 0, 3);
            label5.Size = new Size(135, 34);
            label5.TabIndex = 27;
            label5.Text = "Ngày bắt đầu:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(375, 118);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 34);
            dateTimePicker1.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(375, 64);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(577, 28);
            comboBox1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(232, 64);
            label3.Name = "label3";
            label3.Size = new Size(136, 28);
            label3.TabIndex = 24;
            label3.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(428, 11);
            label2.Name = "label2";
            label2.Size = new Size(322, 38);
            label2.TabIndex = 23;
            label2.Text = "Thống kê nhà cung cấp";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 12F);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(803, 118);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(149, 34);
            dateTimePicker2.TabIndex = 37;
            // 
            // FormThongKeNhaCC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 762);
            Controls.Add(dateTimePicker2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormThongKeNhaCC";
            Text = "FormThongKeNhaCC";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker2;
    }
}