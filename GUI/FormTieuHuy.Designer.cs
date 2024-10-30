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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            lv_DSHoaDon = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            label4 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(189, 38);
            label1.TabIndex = 0;
            label1.Text = "Đơn tiêu hủy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 37);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Sản phẩm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 76);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "Lô sản xuất";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 226);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "Lý do khác";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 195);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 5;
            label6.Text = "Lý do";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 158);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 6;
            label7.Text = "Người lập";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 121);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 7;
            label8.Text = "Ngày lập";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(521, 9);
            label9.Name = "label9";
            label9.Size = new Size(268, 38);
            label9.TabIndex = 8;
            label9.Text = "Danh sách tiêu hủy";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(635, 210);
            label10.Name = "label10";
            label10.Size = new Size(71, 20);
            label10.TabIndex = 9;
            label10.Text = "Thời gian";
            // 
            // button1
            // 
            button1.Location = new Point(833, 55);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(492, 57);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(153, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(664, 57);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(159, 27);
            dateTimePicker2.TabIndex = 12;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 259);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(359, 90);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lv_DSHoaDon
            // 
            lv_DSHoaDon.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lv_DSHoaDon.FullRowSelect = true;
            lv_DSHoaDon.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lv_DSHoaDon.Location = new Point(400, 111);
            lv_DSHoaDon.Margin = new Padding(3, 4, 3, 4);
            lv_DSHoaDon.Name = "lv_DSHoaDon";
            lv_DSHoaDon.Size = new Size(527, 411);
            lv_DSHoaDon.TabIndex = 35;
            lv_DSHoaDon.UseCompatibleStateImageBehavior = false;
            lv_DSHoaDon.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã SP";
            columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Lô SX";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày Lập";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Người lập";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Lý do";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Thiệt hại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 59);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 36;
            label4.Text = "Thời gian";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(180, 450);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 37;
            label11.Text = "Thiệt hại";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 450);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 38;
            // 
            // button2
            // 
            button2.Location = new Point(76, 493);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 39;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(202, 493);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 40;
            button3.Text = "Hủy";
            button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(12, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 392);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm tiêu hủy";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(142, 195);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(188, 28);
            comboBox1.TabIndex = 19;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(142, 116);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(188, 27);
            dateTimePicker3.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(142, 155);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(188, 27);
            textBox5.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(142, 76);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(142, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(188, 27);
            textBox2.TabIndex = 14;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(370, 11);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 42;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormTieuHuy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 535);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label4);
            Controls.Add(lv_DSHoaDon);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label1);
            Name = "FormTieuHuy";
            Text = "FormTieuHuy";
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private RichTextBox richTextBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private Label label11;
        private Label label4;
        private ListView lv_DSHoaDon;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button4;
    }
}