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
            panelMenu = new Panel();
            btnNhaCungCap = new Button();
            btnSanPhamBan = new Button();
            btnDoanhThu = new Button();
            panelThongKe = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.PaleTurquoise;
            panelMenu.Controls.Add(btnNhaCungCap);
            panelMenu.Controls.Add(btnSanPhamBan);
            panelMenu.Controls.Add(btnDoanhThu);
            panelMenu.Dock = DockStyle.Top;
            panelMenu.ForeColor = Color.Black;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(800, 50);
            panelMenu.TabIndex = 1;
            // 
            // btnNhaCungCap
            // 
            btnNhaCungCap.Dock = DockStyle.Left;
            btnNhaCungCap.FlatAppearance.BorderSize = 0;
            btnNhaCungCap.FlatStyle = FlatStyle.Flat;
            btnNhaCungCap.Location = new Point(216, 0);
            btnNhaCungCap.Name = "btnNhaCungCap";
            btnNhaCungCap.Size = new Size(130, 50);
            btnNhaCungCap.TabIndex = 3;
            btnNhaCungCap.Text = "Tồn kho";
            btnNhaCungCap.UseVisualStyleBackColor = true;
            btnNhaCungCap.Click += btnNhaCungCap_Click;
            // 
            // btnSanPhamBan
            // 
            btnSanPhamBan.Dock = DockStyle.Left;
            btnSanPhamBan.FlatAppearance.BorderSize = 0;
            btnSanPhamBan.FlatStyle = FlatStyle.Flat;
            btnSanPhamBan.Location = new Point(94, 0);
            btnSanPhamBan.Name = "btnSanPhamBan";
            btnSanPhamBan.Size = new Size(122, 50);
            btnSanPhamBan.TabIndex = 2;
            btnSanPhamBan.Text = "Sản phẩm bán";
            btnSanPhamBan.UseVisualStyleBackColor = true;
            btnSanPhamBan.Click += btnSanPhamBan_Click;
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
            Controls.Add(panelMenu);
            Name = "FormThongKe";
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Button btnDoanhThu;
        private Button btnNhaCungCap;
        private Button btnSanPhamBan;
        private Panel panelThongKe;
    }
}