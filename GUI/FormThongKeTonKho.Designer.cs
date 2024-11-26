namespace GUI
{
    partial class FormThongKeTonKho
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            btnThongKe = new Button();
            groupBox2 = new GroupBox();
            tblThongTin = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox1 = new GroupBox();
            chartTonKho = new System.Windows.Forms.DataVisualization.Charting.Chart();
            cbbLoaiSP = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tblHetHang = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            tabPage2 = new TabPage();
            tblHetHSD = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            columnHeader17 = new ColumnHeader();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartTonKho).BeginInit();
            groupBox3.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnThongKe
            // 
            btnThongKe.Font = new Font("Segoe UI", 12F);
            btnThongKe.Location = new Point(1014, 57);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(137, 41);
            btnThongKe.TabIndex = 36;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tblThongTin);
            groupBox2.Location = new Point(18, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1199, 294);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bảng thông tin";
            // 
            // tblThongTin
            // 
            tblThongTin.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader7, columnHeader5, columnHeader6 });
            tblThongTin.Location = new Point(6, 26);
            tblThongTin.Name = "tblThongTin";
            tblThongTin.Size = new Size(1183, 256);
            tblThongTin.TabIndex = 0;
            tblThongTin.UseCompatibleStateImageBehavior = false;
            tblThongTin.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã chi tiết";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Mã sản phẩm";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Loại sản phẩm";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Lô sản xuất";
            columnHeader4.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tên sản phẩm";
            columnHeader7.Width = 420;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Hạn sử dụng";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Số lượng";
            columnHeader6.Width = 100;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chartTonKho);
            groupBox1.Location = new Point(18, 410);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(538, 391);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Biểu đồ";
            // 
            // chartTonKho
            // 
            chartArea2.Name = "ChartArea1";
            chartTonKho.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartTonKho.Legends.Add(legend2);
            chartTonKho.Location = new Point(6, 26);
            chartTonKho.Name = "chartTonKho";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "SoLuong";
            chartTonKho.Series.Add(series2);
            chartTonKho.Size = new Size(512, 359);
            chartTonKho.TabIndex = 0;
            chartTonKho.Text = "chart";
            // 
            // cbbLoaiSP
            // 
            cbbLoaiSP.FormattingEnabled = true;
            cbbLoaiSP.Location = new Point(420, 63);
            cbbLoaiSP.Name = "cbbLoaiSP";
            cbbLoaiSP.Size = new Size(577, 28);
            cbbLoaiSP.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(273, 63);
            label3.Name = "label3";
            label3.Size = new Size(141, 28);
            label3.TabIndex = 24;
            label3.Text = "Loại sản phẩm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(473, 10);
            label2.Name = "label2";
            label2.Size = new Size(251, 38);
            label2.TabIndex = 23;
            label2.Text = "Thống kê tồn kho";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tabControl1);
            groupBox3.Location = new Point(590, 410);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(627, 391);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cảnh báo";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(21, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(600, 359);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tblHetHang);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(592, 326);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sắp hết hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tblHetHang
            // 
            tblHetHang.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            tblHetHang.Location = new Point(16, 18);
            tblHetHang.Name = "tblHetHang";
            tblHetHang.Size = new Size(570, 284);
            tblHetHang.TabIndex = 0;
            tblHetHang.UseCompatibleStateImageBehavior = false;
            tblHetHang.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Mã sản phẩm";
            columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Tên sản phẩm";
            columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Số lượng";
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Trạng thái";
            columnHeader11.Width = 150;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tblHetHSD);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(592, 326);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sắp hết HSD";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblHetHSD
            // 
            tblHetHSD.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17 });
            tblHetHSD.Location = new Point(15, 18);
            tblHetHSD.Name = "tblHetHSD";
            tblHetHSD.Size = new Size(571, 302);
            tblHetHSD.TabIndex = 0;
            tblHetHSD.UseCompatibleStateImageBehavior = false;
            tblHetHSD.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Mã chi tiết";
            columnHeader12.Width = 120;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Mã sản phẩm";
            columnHeader13.Width = 120;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Lô sản xuất";
            columnHeader14.Width = 120;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Tên sản phẩm";
            columnHeader15.Width = 150;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Hạn sử dụng";
            columnHeader16.Width = 120;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Trạng thái";
            columnHeader17.Width = 120;
            // 
            // FormThongKeTonKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 813);
            Controls.Add(groupBox3);
            Controls.Add(btnThongKe);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cbbLoaiSP);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormThongKeTonKho";
            Load += FormThongKeTonKho_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartTonKho).EndInit();
            groupBox3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox2;
        private ListView tblThongTin;
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
        private ComboBox cbbLoaiSP;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private GroupBox groupBox3;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader4;
        private Button btnThongKe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTonKho;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListView tblHetHang;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ListView tblHetHSD;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader17;
    }
}