namespace GUI
{
    partial class FormThongKe
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
            panel1 = new Panel();
            btnNhaCungCap = new Button();
            btnSanPhamBan = new Button();
            btnSanPhamNhap = new Button();
            btnDoanhThu = new Button();
            panelThongKe = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(btnNhaCungCap);
            panel1.Controls.Add(btnSanPhamBan);
            panel1.Controls.Add(btnSanPhamNhap);
            panel1.Controls.Add(btnDoanhThu);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 1;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.Dock = DockStyle.Left;
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Location = new Point(342, 0);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Size = new Size(130, 50);
            btnNhaCungCap.TabIndex = 3;
            btnNhaCungCap.Text = "Nhà cung cấp";
            btnNhaCungCap.UseVisualStyleBackColor = true;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnSanPhamBan
            // 
            btnSanPhamBan.Dock = DockStyle.Left;
            btnSanPhamBan.FlatAppearance.BorderSize = 0;
            btnSanPhamBan.FlatStyle = FlatStyle.Flat;
            btnSanPhamBan.Location = new Point(220, 0);
            btnSanPhamBan.Name = "btnSanPhamBan";
            btnSanPhamBan.Size = new Size(122, 50);
            btnSanPhamBan.TabIndex = 2;
            btnSanPhamBan.Text = "Sản phẩm bán";
            btnSanPhamBan.UseVisualStyleBackColor = true;
            btnSanPhamBan.Click += btnSanPhamBan_Click;
            // 
            // btnSanPhamNhap
            // 
            btnSanPhamNhap.Dock = DockStyle.Left;
            btnSanPhamNhap.FlatAppearance.BorderSize = 0;
            btnSanPhamNhap.FlatStyle = FlatStyle.Flat;
            btnSanPhamNhap.Location = new Point(94, 0);
            btnSanPhamNhap.Name = "btnSanPhamNhap";
            btnSanPhamNhap.Size = new Size(126, 50);
            btnSanPhamNhap.TabIndex = 1;
            btnSanPhamNhap.Text = "Sản phẩm nhập";
            btnSanPhamNhap.UseVisualStyleBackColor = true;
            btnSanPhamNhap.Click += btnSanPhamNhap_Click;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.Dock = DockStyle.Left;
            btnDoanhThu.FlatAppearance.BorderSize = 0;
            btnDoanhThu.FlatStyle = FlatStyle.Flat;
            btnDoanhThu.Location = new Point(0, 0);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(94, 50);
            btnDoanhThu.TabIndex = 0;
            btnDoanhThu.Text = "Doanh thu";
            btnDoanhThu.UseVisualStyleBackColor = true;
            btnDoanhThu.Click += btnDoanhThu_Click;
            // 
            // panelThongKe
            // 
            panelThongKe.Dock = DockStyle.Fill;
            panelThongKe.Location = new Point(0, 50);
            panelThongKe.Name = "panelThongKe";
            panelThongKe.Size = new Size(800, 400);
            panelThongKe.TabIndex = 2;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelThongKe);
            Controls.Add(panel1);
            Name = "FormThongKe";
            Text = "FormThongKe";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnDoanhThu;
        private Button btnNhaCungCap;
        private Button btnSanPhamBan;
        private Button btnSanPhamNhap;
        private Panel panelThongKe;
    }
}