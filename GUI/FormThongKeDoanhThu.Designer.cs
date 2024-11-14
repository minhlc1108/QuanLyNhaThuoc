namespace GUI
{
    partial class FormThongKeDoanhThu
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
            label1 = new Label();
            dateBatDau = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            dateKetThuc = new DateTimePicker();
            btnThongKe = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tblThongTin = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(444, 16);
            label1.Name = "label1";
            label1.Size = new Size(284, 38);
            label1.TabIndex = 0;
            label1.Text = "Thống kê doanh thu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // dateBatDau
            // 
            dateBatDau.Font = new Font("Segoe UI", 12F);
            dateBatDau.Format = DateTimePickerFormat.Short;
            dateBatDau.Location = new Point(355, 95);
            dateBatDau.Name = "dateBatDau";
            dateBatDau.Size = new Size(149, 34);
            dateBatDau.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(214, 95);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 3, 0, 3);
            label2.Size = new Size(135, 34);
            label2.TabIndex = 2;
            label2.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(642, 95);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 3, 0, 3);
            label3.Size = new Size(138, 34);
            label3.TabIndex = 4;
            label3.Text = "Ngày kết thúc:";
            // 
            // dateKetThuc
            // 
            dateKetThuc.Font = new Font("Segoe UI", 12F);
            dateKetThuc.Format = DateTimePickerFormat.Short;
            dateKetThuc.Location = new Point(783, 95);
            dateKetThuc.Name = "dateKetThuc";
            dateKetThuc.Size = new Size(149, 34);
            dateKetThuc.TabIndex = 3;
            // 
            // btnThongKe
            // 
            btnThongKe.Font = new Font("Segoe UI", 12F);
            btnThongKe.Location = new Point(512, 164);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(129, 55);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(31, 270);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 480);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Biểu đồ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tblThongTin);
            groupBox2.Location = new Point(586, 270);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 480);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bảng thông tin";
            // 
            // tblThongTin
            // 
            tblThongTin.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            tblThongTin.Location = new Point(25, 38);
            tblThongTin.Name = "tblThongTin";
            tblThongTin.Size = new Size(477, 420);
            tblThongTin.TabIndex = 0;
            tblThongTin.UseCompatibleStateImageBehavior = false;
            tblThongTin.View = View.Details;
            tblThongTin.SelectedIndexChanged += tblThongTin_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Thời gian";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Doanh thu";
            columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Chi phí";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Chênh lệch";
            columnHeader4.Width = 110;
            // 
            // FormThongKeDoanhThu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1145, 762);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnThongKe);
            Controls.Add(label3);
            Controls.Add(dateKetThuc);
            Controls.Add(label2);
            Controls.Add(dateBatDau);
            Controls.Add(label1);
            Name = "FormThongKeDoanhThu";
            Text = "FormThongKeDoanhThu";
            Load += FormThongKeDoanhThu_Load;
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private DateTimePicker dateBatDau;
        private DateTimePicker dateKetThuc;
        private Button btnThongKe;
        private ListView tblThongTin;
    }
}