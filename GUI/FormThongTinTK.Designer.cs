namespace GUI
{
    partial class FormThongTinTK
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
            btn_Luu = new Button();
            groupBox1 = new GroupBox();
            tb_cfpw = new TextBox();
            label2 = new Label();
            tb_newpw = new TextBox();
            label1 = new Label();
            tb_oldpw = new TextBox();
            label6 = new Label();
            err_oldpw = new Label();
            err_cfpw = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Luu
            // 
            btn_Luu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Luu.Location = new Point(214, 373);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(123, 62);
            btn_Luu.TabIndex = 37;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(err_oldpw);
            groupBox1.Controls.Add(err_cfpw);
            groupBox1.Controls.Add(tb_cfpw);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_newpw);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_oldpw);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(29, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(551, 307);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đổi mật khẩu";
            // 
            // tb_cfpw
            // 
            tb_cfpw.Location = new Point(209, 226);
            tb_cfpw.Name = "tb_cfpw";
            tb_cfpw.PasswordChar = '*';
            tb_cfpw.Size = new Size(317, 34);
            tb_cfpw.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 234);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 28;
            label2.Text = "Xác nhận mật khẩu:";
            // 
            // tb_newpw
            // 
            tb_newpw.Location = new Point(209, 145);
            tb_newpw.Name = "tb_newpw";
            tb_newpw.PasswordChar = '*';
            tb_newpw.Size = new Size(317, 34);
            tb_newpw.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 153);
            label1.Name = "label1";
            label1.Size = new Size(128, 23);
            label1.TabIndex = 26;
            label1.Text = "Mật khẩu mới:";
            // 
            // tb_oldpw
            // 
            tb_oldpw.Location = new Point(209, 67);
            tb_oldpw.Name = "tb_oldpw";
            tb_oldpw.PasswordChar = '*';
            tb_oldpw.Size = new Size(317, 34);
            tb_oldpw.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(19, 67);
            label6.Name = "label6";
            label6.Size = new Size(119, 23);
            label6.TabIndex = 15;
            label6.Text = "Mật khẩu cũ: ";
            // 
            // err_oldpw
            // 
            err_oldpw.AutoSize = true;
            err_oldpw.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            err_oldpw.ForeColor = Color.Red;
            err_oldpw.Location = new Point(209, 104);
            err_oldpw.Name = "err_oldpw";
            err_oldpw.Size = new Size(0, 23);
            err_oldpw.TabIndex = 30;
            // 
            // err_cfpw
            // 
            err_cfpw.AutoSize = true;
            err_cfpw.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            err_cfpw.ForeColor = Color.Red;
            err_cfpw.Location = new Point(209, 263);
            err_cfpw.Name = "err_cfpw";
            err_cfpw.Size = new Size(0, 23);
            err_cfpw.TabIndex = 31;
            // 
            // FormThongTinTK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 472);
            Controls.Add(btn_Luu);
            Controls.Add(groupBox1);
            Name = "FormThongTinTK";
            Text = "FormThongTinTK";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Luu;
        private GroupBox groupBox1;
        private TextBox tb_oldpw;
        private Label label6;
        private TextBox tb_cfpw;
        private Label label2;
        private TextBox tb_newpw;
        private Label label1;
        private Label err_oldpw;
        private Label err_cfpw;
    }
}