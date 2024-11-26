namespace GUI
{
    partial class FormPhanQuyen
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
            label1 = new Label();
            listcheckquyen = new CheckedListBox();
            btnLuu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 46);
            label1.TabIndex = 0;
            label1.Text = "Phân quyền";
            // 
            // listcheckquyen
            // 
            listcheckquyen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listcheckquyen.FormattingEnabled = true;
            listcheckquyen.Items.AddRange(new object[] { "Chức năng sản phẩm", "Chức năng loại sản phẩm", "Chức năng hóa đơn", "Chức năng phiếu nhập", "Chức năng tiêu hủy", "Chức năng dược sĩ", "Chức năng khách hàng", "Chức năng nhà sản xuất", "Chức năng nhà cung cấp", "Chức năng thống kê" });
            listcheckquyen.Location = new Point(111, 99);
            listcheckquyen.Name = "listcheckquyen";
            listcheckquyen.Size = new Size(355, 294);
            listcheckquyen.TabIndex = 1;
            // 
            // btnLuu
            // 
            btnLuu.Font = new Font("Segoe UI", 16F);
            btnLuu.Location = new Point(186, 406);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(167, 51);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // FormPhanQuyen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 469);
            Controls.Add(btnLuu);
            Controls.Add(listcheckquyen);
            Controls.Add(label1);
            Name = "FormPhanQuyen";
            Text = "FormPhanQuyen";
            Load += FormPhanQuyen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox listcheckquyen;
        private Button btnLuu;
    }
}