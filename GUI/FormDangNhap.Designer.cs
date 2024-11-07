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
            pictureBox1 = new PictureBox();
            btn_dangNhap = new MaterialSkin.Controls.MaterialButton();
            btn_exit = new MaterialSkin.Controls.MaterialButton();
            tb_user = new MaterialSkin.Controls.MaterialTextBox();
            tb_pass = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            iconShowPassword = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconShowPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(235, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // btn_dangNhap
            // 
            btn_dangNhap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_dangNhap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_dangNhap.Depth = 0;
            btn_dangNhap.HighEmphasis = true;
            btn_dangNhap.Icon = null;
            btn_dangNhap.Location = new Point(163, 301);
            btn_dangNhap.Margin = new Padding(4, 6, 4, 6);
            btn_dangNhap.MouseState = MaterialSkin.MouseState.HOVER;
            btn_dangNhap.Name = "btn_dangNhap";
            btn_dangNhap.NoAccentTextColor = Color.Empty;
            btn_dangNhap.Size = new Size(105, 36);
            btn_dangNhap.TabIndex = 73;
            btn_dangNhap.Text = "Đăng nhập";
            btn_dangNhap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_dangNhap.UseAccentColor = false;
            btn_dangNhap.UseVisualStyleBackColor = true;
            btn_dangNhap.Click += btn_dangNhap_Click_1;
            // 
            // btn_exit
            // 
            btn_exit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_exit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_exit.Depth = 0;
            btn_exit.HighEmphasis = true;
            btn_exit.Icon = null;
            btn_exit.Location = new Point(326, 301);
            btn_exit.Margin = new Padding(4, 6, 4, 6);
            btn_exit.MouseState = MaterialSkin.MouseState.HOVER;
            btn_exit.Name = "btn_exit";
            btn_exit.NoAccentTextColor = Color.Empty;
            btn_exit.Size = new Size(69, 36);
            btn_exit.TabIndex = 74;
            btn_exit.Text = "Thoát";
            btn_exit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_exit.UseAccentColor = false;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // tb_user
            // 
            tb_user.AnimateReadOnly = false;
            tb_user.BorderStyle = BorderStyle.None;
            tb_user.Depth = 0;
            tb_user.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_user.LeadingIcon = null;
            tb_user.Location = new Point(129, 139);
            tb_user.MaxLength = 50;
            tb_user.MouseState = MaterialSkin.MouseState.OUT;
            tb_user.Multiline = false;
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(330, 50);
            tb_user.TabIndex = 75;
            tb_user.Text = "";
            tb_user.TrailingIcon = null;
            // 
            // tb_pass
            // 
            tb_pass.AnimateReadOnly = false;
            tb_pass.BorderStyle = BorderStyle.None;
            tb_pass.Depth = 0;
            tb_pass.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tb_pass.LeadingIcon = null;
            tb_pass.Location = new Point(129, 215);
            tb_pass.MaxLength = 50;
            tb_pass.MouseState = MaterialSkin.MouseState.OUT;
            tb_pass.Multiline = false;
            tb_pass.Name = "tb_pass";
            tb_pass.Password = true;
            tb_pass.Size = new Size(330, 50);
            tb_pass.TabIndex = 76;
            tb_pass.Text = "";
            tb_pass.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(15, 158);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(76, 19);
            materialLabel1.TabIndex = 77;
            materialLabel1.Text = "Username:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(15, 235);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(75, 19);
            materialLabel2.TabIndex = 78;
            materialLabel2.Text = "Password:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(223, 100);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(90, 19);
            materialLabel3.TabIndex = 79;
            materialLabel3.Text = "ĐĂNG NHẬP";
            // 
            // iconShowPassword
            // 
            iconShowPassword.BackColor = SystemColors.Control;
            iconShowPassword.ForeColor = SystemColors.ControlText;
            iconShowPassword.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            iconShowPassword.IconColor = SystemColors.ControlText;
            iconShowPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconShowPassword.IconSize = 46;
            iconShowPassword.Location = new Point(454, 215);
            iconShowPassword.Name = "iconShowPassword";
            iconShowPassword.Size = new Size(46, 50);
            iconShowPassword.TabIndex = 80;
            iconShowPassword.TabStop = false;
            iconShowPassword.Click += iconShowPassword_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 393);
            Controls.Add(iconShowPassword);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(tb_pass);
            Controls.Add(tb_user);
            Controls.Add(btn_exit);
            Controls.Add(btn_dangNhap);
            Controls.Add(pictureBox1);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDangNhap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconShowPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label17;
        private Label label1;
        private PictureBox pictureBox1;
        private Label erorr_user;
        private Label erorr_pass;
        private MaterialSkin.Controls.MaterialButton btn_dangNhap;
        private MaterialSkin.Controls.MaterialButton btn_exit;
        private MaterialSkin.Controls.MaterialTextBox tb_user;
        private MaterialSkin.Controls.MaterialTextBox tb_pass;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private FontAwesome.Sharp.IconPictureBox iconShowPassword;
    }
}