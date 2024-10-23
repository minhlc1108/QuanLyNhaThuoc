namespace GUI
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            label17 = new Label();
            label1 = new Label();
            tb_user = new TextBox();
            tb_pass = new TextBox();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            btn_dangNhap = new Button();
            btn_exit = new Button();
            pic_show = new PictureBox();
            pic_unShow = new PictureBox();
            erorr_user = new Label();
            erorr_pass = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_show).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_unShow).BeginInit();
            SuspendLayout();
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(12, 200);
            label17.Name = "label17";
            label17.Size = new Size(102, 28);
            label17.TabIndex = 54;
            label17.Text = "Password :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 133);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 55;
            label1.Text = "Username :";
            // 
            // tb_user
            // 
            tb_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_user.Location = new Point(140, 130);
            tb_user.Margin = new Padding(3, 4, 3, 4);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(288, 34);
            tb_user.TabIndex = 63;
            tb_user.Text = "Admin";
            // 
            // tb_pass
            // 
            tb_pass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_pass.Location = new Point(140, 194);
            tb_pass.Margin = new Padding(3, 4, 3, 4);
            tb_pass.Name = "tb_pass";
            tb_pass.Size = new Size(288, 34);
            tb_pass.TabIndex = 64;
            tb_pass.Text = "123456";
            tb_pass.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(166, 89);
            label11.Name = "label11";
            label11.Size = new Size(161, 32);
            label11.TabIndex = 65;
            label11.Text = "ĐĂNG NHẬP";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(209, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // btn_dangNhap
            // 
            btn_dangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dangNhap.Location = new Point(83, 273);
            btn_dangNhap.Name = "btn_dangNhap";
            btn_dangNhap.Size = new Size(142, 40);
            btn_dangNhap.TabIndex = 67;
            btn_dangNhap.Text = "Đăng nhập";
            btn_dangNhap.UseVisualStyleBackColor = true;
            btn_dangNhap.Click += btn_dangNhap_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_exit.Location = new Point(262, 273);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(142, 40);
            btn_exit.TabIndex = 68;
            btn_exit.Text = "Thoát";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // pic_show
            // 
            pic_show.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic_show.Image = (Image)resources.GetObject("pic_show.Image");
            pic_show.Location = new Point(390, 200);
            pic_show.Name = "pic_show";
            pic_show.Size = new Size(33, 37);
            pic_show.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_show.TabIndex = 69;
            pic_show.TabStop = false;
            pic_show.MouseDown += pic_show_MouseDown;
            pic_show.MouseUp += pic_show_MouseUp;
            // 
            // pic_unShow
            // 
            pic_unShow.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic_unShow.Image = (Image)resources.GetObject("pic_unShow.Image");
            pic_unShow.Location = new Point(390, 200);
            pic_unShow.Name = "pic_unShow";
            pic_unShow.Size = new Size(33, 37);
            pic_unShow.SizeMode = PictureBoxSizeMode.CenterImage;
            pic_unShow.TabIndex = 70;
            pic_unShow.TabStop = false;
            pic_unShow.Visible = false;
            // 
            // erorr_user
            // 
            erorr_user.AutoSize = true;
            erorr_user.ForeColor = Color.Red;
            erorr_user.Location = new Point(140, 168);
            erorr_user.Name = "erorr_user";
            erorr_user.Size = new Size(0, 20);
            erorr_user.TabIndex = 71;
            // 
            // erorr_pass
            // 
            erorr_pass.AutoSize = true;
            erorr_pass.ForeColor = Color.Red;
            erorr_pass.Location = new Point(140, 232);
            erorr_pass.Name = "erorr_pass";
            erorr_pass.Size = new Size(0, 20);
            erorr_pass.TabIndex = 72;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 334);
            Controls.Add(erorr_pass);
            Controls.Add(erorr_user);
            Controls.Add(pic_unShow);
            Controls.Add(pic_show);
            Controls.Add(btn_exit);
            Controls.Add(btn_dangNhap);
            Controls.Add(pictureBox1);
            Controls.Add(label11);
            Controls.Add(tb_pass);
            Controls.Add(tb_user);
            Controls.Add(label1);
            Controls.Add(label17);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_show).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_unShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label17;
        private Label label1;
        private TextBox tb_user;
        private TextBox tb_pass;
        private Label label11;
        private PictureBox pictureBox1;
        private Button btn_dangNhap;
        private Button btn_exit;
        private PictureBox pic_show;
        private PictureBox pic_unShow;
        private Label erorr_user;
        private Label erorr_pass;
    }
}