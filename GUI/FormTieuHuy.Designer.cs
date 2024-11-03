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
            buttonadd = new Button();
            buttondelete = new Button();
            groupBox1 = new GroupBox();
            comboBoxNguoiLap = new ComboBox();
            comboBoxLoSX = new ComboBox();
            comboBoxSanPham = new ComboBox();
            dateTimePicker3 = new DateTimePicker();
            buttonedit = new Button();
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
            label5.Location = new Point(11, 227);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "Lý do khác";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 157);
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
            label10.Location = new Point(635, 211);
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
            dateTimePicker1.Location = new Point(491, 57);
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
            richTextBox1.Size = new Size(359, 89);
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
            lv_DSHoaDon.SelectedIndexChanged += lv_DSHoaDon_SelectedIndexChanged;
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
            label11.Location = new Point(14, 359);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 37;
            label11.Text = "Thiệt hại";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 355);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(188, 27);
            textBox1.TabIndex = 38;
            // 
            // buttonadd
            // 
            buttonadd.Location = new Point(17, 491);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(94, 29);
            buttonadd.TabIndex = 39;
            buttonadd.Text = "Lưu";
            buttonadd.UseVisualStyleBackColor = true;
            buttonadd.Click += buttonadd_Click;
            // 
            // buttondelete
            // 
            buttondelete.Location = new Point(248, 493);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(94, 29);
            buttondelete.TabIndex = 40;
            buttondelete.Text = "Xóa";
            buttondelete.UseVisualStyleBackColor = true;
            buttondelete.Click += buttondelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxNguoiLap);
            groupBox1.Controls.Add(comboBoxLoSX);
            groupBox1.Controls.Add(comboBoxSanPham);
            groupBox1.Controls.Add(dateTimePicker3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(11, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 415);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sản phẩm tiêu hủy";
            // 
            // comboBoxNguoiLap
            // 
            comboBoxNguoiLap.FormattingEnabled = true;
            comboBoxNguoiLap.Location = new Point(142, 155);
            comboBoxNguoiLap.Name = "comboBoxNguoiLap";
            comboBoxNguoiLap.Size = new Size(188, 28);
            comboBoxNguoiLap.TabIndex = 22;
            // 
            // comboBoxLoSX
            // 
            comboBoxLoSX.FormattingEnabled = true;
            comboBoxLoSX.Location = new Point(142, 72);
            comboBoxLoSX.Name = "comboBoxLoSX";
            comboBoxLoSX.Size = new Size(188, 28);
            comboBoxLoSX.TabIndex = 21;
            // 
            // comboBoxSanPham
            // 
            comboBoxSanPham.FormattingEnabled = true;
            comboBoxSanPham.Location = new Point(142, 27);
            comboBoxSanPham.Name = "comboBoxSanPham";
            comboBoxSanPham.Size = new Size(188, 28);
            comboBoxSanPham.TabIndex = 20;
            comboBoxSanPham.SelectedIndexChanged += comboBoxSanPham_SelectedIndexChanged;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(142, 116);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(188, 27);
            dateTimePicker3.TabIndex = 18;
            // 
            // buttonedit
            // 
            buttonedit.Location = new Point(134, 493);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(94, 29);
            buttonedit.TabIndex = 42;
            buttonedit.Text = "Sửa";
            buttonedit.UseVisualStyleBackColor = true;
            buttonedit.Click += buttonedit_Click;
            // 
            // FormTieuHuy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 535);
            Controls.Add(buttonedit);
            Controls.Add(groupBox1);
            Controls.Add(buttondelete);
            Controls.Add(buttonadd);
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
            Load += FormTieuHuy_Load_1;
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private RichTextBox richTextBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private Button buttondelete;
        private Button buttonadd;
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
        private Button buttonedit;
        private ComboBox comboBoxLoSX;
        private ComboBox comboBoxSanPham;
        private ComboBox comboBoxNguoiLap;
    }
}