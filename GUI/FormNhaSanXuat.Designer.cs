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
            lv_qlncc = new ListView();
            clMaNSX = new ColumnHeader();
            clTenNSX = new ColumnHeader();
            nsxTrangThai = new ColumnHeader();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 19);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "NHÀ SẢN XUẤT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 58);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã nhà sản xuất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 148);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 99);
            label4.Name = "label4";
            label4.Size = new Size(118, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên nhà sản xuất";
            // 
            // lv_qlncc
            // 
            lv_qlncc.Columns.AddRange(new ColumnHeader[] { clMaNSX, clTenNSX, nsxTrangThai });
            lv_qlncc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_qlncc.FullRowSelect = true;
            lv_qlncc.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lv_qlncc.Location = new Point(59, 212);
            lv_qlncc.Margin = new Padding(3, 4, 3, 4);
            lv_qlncc.Name = "lv_qlncc";
            lv_qlncc.Size = new Size(693, 215);
            lv_qlncc.TabIndex = 44;
            lv_qlncc.UseCompatibleStateImageBehavior = false;
            lv_qlncc.View = View.Details;
            lv_qlncc.SelectedIndexChanged += lv_qlncc_SelectedIndexChanged;
            // 
            // clMaNSX
            // 
            clMaNSX.Text = "Mã NSX";
            clMaNSX.Width = 140;
            // 
            // clTenNSX
            // 
            clTenNSX.Text = "Tên NSX";
            clTenNSX.Width = 300;
            // 
            // nsxTrangThai
            // 
            nsxTrangThai.Text = "Trạng thái";
            nsxTrangThai.Width = 250;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(249, 148);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 45;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(460, 148);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 46;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(249, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 27);
            textBox1.TabIndex = 47;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(249, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 27);
            textBox2.TabIndex = 48;
            // 
            // FormNhaSanXuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(lv_qlncc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormNhaSanXuat";
            Text = "FormNhaSanXuat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListView lv_qlncc;
        private ColumnHeader clMaNSX;
        private ColumnHeader clTenNSX;
        private ColumnHeader nsxTrangThai;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}