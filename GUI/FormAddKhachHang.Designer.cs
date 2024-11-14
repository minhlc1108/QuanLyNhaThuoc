namespace GUI
{
    partial class FormAddKhachHang
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
            btn_add = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_sdt = new TextBox();
            tb_hoten = new TextBox();
            date_kh = new DateTimePicker();
            cb_nam = new CheckBox();
            cb_nu = new CheckBox();
            erorr_sdt = new Label();
            erorr_diem = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_add.Location = new Point(186, 323);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(119, 40);
            btn_add.TabIndex = 35;
            btn_add.Text = "Thêm";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 238);
            label2.Name = "label2";
            label2.Size = new Size(53, 23);
            label2.TabIndex = 12;
            label2.Text = "SĐT :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 176);
            label4.Name = "label4";
            label4.Size = new Size(90, 23);
            label4.TabIndex = 13;
            label4.Text = "Giới tính :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 119);
            label5.Name = "label5";
            label5.Size = new Size(99, 23);
            label5.TabIndex = 14;
            label5.Text = "Ngày sinh :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 56);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 15;
            label6.Text = "Họ tên :";
            // 
            // tb_sdt
            // 
            tb_sdt.Location = new Point(121, 230);
            tb_sdt.Name = "tb_sdt";
            tb_sdt.Size = new Size(317, 34);
            tb_sdt.TabIndex = 17;
            // 
            // tb_hoten
            // 
            tb_hoten.Location = new Point(121, 48);
            tb_hoten.Name = "tb_hoten";
            tb_hoten.Size = new Size(317, 34);
            tb_hoten.TabIndex = 19;
            // 
            // date_kh
            // 
            date_kh.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            date_kh.Location = new Point(121, 112);
            date_kh.Name = "date_kh";
            date_kh.Size = new Size(317, 31);
            date_kh.TabIndex = 21;
            date_kh.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cb_nam
            // 
            cb_nam.AutoSize = true;
            cb_nam.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_nam.Location = new Point(121, 173);
            cb_nam.Name = "cb_nam";
            cb_nam.Size = new Size(72, 29);
            cb_nam.TabIndex = 22;
            cb_nam.Text = "Nam";
            cb_nam.UseVisualStyleBackColor = true;
            // 
            // cb_nu
            // 
            cb_nu.AutoSize = true;
            cb_nu.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_nu.Location = new Point(221, 173);
            cb_nu.Name = "cb_nu";
            cb_nu.Size = new Size(58, 29);
            cb_nu.TabIndex = 23;
            cb_nu.Text = "Nữ";
            cb_nu.UseVisualStyleBackColor = true;
            // 
            // erorr_sdt
            // 
            erorr_sdt.AutoSize = true;
            erorr_sdt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_sdt.ForeColor = Color.Red;
            erorr_sdt.Location = new Point(121, 267);
            erorr_sdt.Name = "erorr_sdt";
            erorr_sdt.Size = new Size(0, 23);
            erorr_sdt.TabIndex = 24;
            // 
            // erorr_diem
            // 
            erorr_diem.AutoSize = true;
            erorr_diem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            erorr_diem.ForeColor = Color.Red;
            erorr_diem.Location = new Point(121, 337);
            erorr_diem.Name = "erorr_diem";
            erorr_diem.Size = new Size(0, 23);
            erorr_diem.TabIndex = 25;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(erorr_diem);
            groupBox1.Controls.Add(erorr_sdt);
            groupBox1.Controls.Add(cb_nu);
            groupBox1.Controls.Add(cb_nam);
            groupBox1.Controls.Add(date_kh);
            groupBox1.Controls.Add(tb_hoten);
            groupBox1.Controls.Add(tb_sdt);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 305);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm khách hàng";
            // 
            // FormAddKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 373);
            Controls.Add(btn_add);
            Controls.Add(groupBox1);
            Name = "FormAddKhachHang";
            Text = "FormAddKhachHang";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_add;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_sdt;
        private TextBox tb_hoten;
        private DateTimePicker date_kh;
        private CheckBox cb_nam;
        private CheckBox cb_nu;
        private Label erorr_sdt;
        private Label erorr_diem;
        private GroupBox groupBox1;
    }
}