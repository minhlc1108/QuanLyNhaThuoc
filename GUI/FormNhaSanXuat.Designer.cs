namespace GUI
{
    partial class FormNhaSanXuat
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            lsvThemHoaDon = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 18);
            label1.Name = "label1";
            label1.Size = new Size(247, 50);
            label1.TabIndex = 0;
            label1.Text = "Nhà sản xuất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 26);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã nhà sản xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 80);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên sản xuất";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 141);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Trạng thái";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 77);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 27);
            textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(194, 138);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(46, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(821, 231);
            panel1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(624, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(107, 40);
            button1.TabIndex = 18;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(624, 141);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(107, 40);
            button2.TabIndex = 19;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(624, 80);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 20;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            // 
            // lsvThemHoaDon
            // 
            lsvThemHoaDon.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvThemHoaDon.FullRowSelect = true;
            lsvThemHoaDon.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lsvThemHoaDon.Location = new Point(46, 327);
            lsvThemHoaDon.Margin = new Padding(3, 4, 3, 4);
            lsvThemHoaDon.Name = "lsvThemHoaDon";
            lsvThemHoaDon.Size = new Size(821, 253);
            lsvThemHoaDon.TabIndex = 21;
            lsvThemHoaDon.UseCompatibleStateImageBehavior = false;
            lsvThemHoaDon.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã nhà sản xuất";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên nhà sản xuất";
            columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Trạng thái";
            columnHeader3.Width = 310;
            // 
            // FormNhaSanXuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 593);
            Controls.Add(lsvThemHoaDon);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormNhaSanXuat";
            Text = " n";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Panel panel1;
        private Button button1;
        private Button button3;
        private Button button2;
        private ListView lsvThemHoaDon;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}