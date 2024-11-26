namespace GUI
{
    partial class FormThongKeSPBan
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            cbbLoc = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            chartLSP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1 = new GroupBox();
            chartSP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnThongKe = new Button();
            groupBox3 = new GroupBox();
            tblThongtin = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartLSP).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartSP).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // cbbLoc
            // 
            cbbLoc.FormattingEnabled = true;
            cbbLoc.Items.AddRange(new object[] { "Tất cả", "Bán chạy top 1", "Bán chạy top 2", "Bán chạy top 3", "Bán chạy top 4", "Bán chạy top 5" });
            cbbLoc.Location = new Point(380, 62);
            cbbLoc.Name = "cbbLoc";
            cbbLoc.Size = new Size(611, 28);
            cbbLoc.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(313, 62);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 5;
            label3.Text = "Lọc:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(467, 9);
            label2.Name = "label2";
            label2.Size = new Size(332, 38);
            label2.TabIndex = 4;
            label2.Text = "Thống kê sản phẩm bán";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chartLSP);
            groupBox2.Location = new Point(584, 394);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(639, 407);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Biểu đồ tỉ lệ bán theo loại";
            // 
            // chartLSP
            // 
            chartArea1.Name = "ChartArea1";
            chartLSP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartLSP.Legends.Add(legend1);
            chartLSP.Location = new Point(25, 26);
            chartLSP.Name = "chartLSP";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "SoLuong";
            chartLSP.Series.Add(series1);
            chartLSP.Size = new Size(593, 375);
            chartLSP.TabIndex = 1;
            chartLSP.Text = "chartLSP";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chartSP);
            groupBox1.Location = new Point(12, 394);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(550, 407);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Biểu đồ tỉ lệ bán theo sản phẩm";
            // 
            // chartSP
            // 
            chartArea2.Name = "ChartArea1";
            chartSP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartSP.Legends.Add(legend2);
            chartSP.Location = new Point(6, 26);
            chartSP.Name = "chartSP";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "SoLuong";
            chartSP.Series.Add(series2);
            chartSP.Size = new Size(511, 375);
            chartSP.TabIndex = 0;
            chartSP.Text = "chartSP";
            // 
            // btnThongKe
            // 
            btnThongKe.Font = new Font("Segoe UI", 12F);
            btnThongKe.Location = new Point(1024, 56);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(129, 41);
            btnThongKe.TabIndex = 22;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tblThongtin);
            groupBox3.Location = new Point(18, 112);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1205, 276);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bảng thông tin";
            // 
            // tblThongtin
            // 
            tblThongtin.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader1, columnHeader2 });
            tblThongtin.Location = new Point(6, 26);
            tblThongtin.Name = "tblThongtin";
            tblThongtin.Size = new Size(1151, 244);
            tblThongtin.TabIndex = 0;
            tblThongtin.UseCompatibleStateImageBehavior = false;
            tblThongtin.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mã loại";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mã sản phẩm";
            columnHeader4.Width = 150;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên sản phẩm";
            columnHeader1.Width = 750;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số lượng";
            columnHeader2.Width = 120;
            // 
            // FormThongKeSPBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 813);
            Controls.Add(groupBox3);
            Controls.Add(btnThongKe);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(cbbLoc);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormThongKeSPBan";
            Text = "FormThongKeSPBan";
            Load += FormThongKeSPBan_Load;
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartLSP).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartSP).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbLoc;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button btnThongKe;
        private GroupBox groupBox3;
        private ListView tblThongtin;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLSP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSP;
    }
}