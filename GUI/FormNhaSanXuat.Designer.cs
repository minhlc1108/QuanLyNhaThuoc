
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
            ListViewItem listViewItem1 = new ListViewItem("1");
            ListViewItem listViewItem2 = new ListViewItem("2");
            ListViewItem listViewItem3 = new ListViewItem("3");
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lv_qlncc = new ListView();
            clMaNSX = new ColumnHeader();
            clTenNSX = new ColumnHeader();
            nsxTrangThai = new ColumnHeader();
            Yesbtn = new RadioButton();
            Nobtn = new RadioButton();
            textBoxMANSX = new TextBox();
            textBoxtennsx = new TextBox();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(531, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 32);
            label1.TabIndex = 0;
            label1.Text = "NHÀ SẢN XUẤT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(188, 76);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã nhà sản xuất :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(188, 157);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 2;
            label3.Text = "Trạng thái :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(188, 119);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 3;
            label4.Text = "Tên nhà sản xuất :";
            // 
            // lv_qlncc
            // 
            lv_qlncc.Columns.AddRange(new ColumnHeader[] { clMaNSX, clTenNSX, nsxTrangThai });
            lv_qlncc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lv_qlncc.FullRowSelect = true;
            lv_qlncc.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            lv_qlncc.Location = new Point(157, 202);
            lv_qlncc.Name = "lv_qlncc";
            lv_qlncc.Size = new Size(824, 269);
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
            clTenNSX.Width = 330;
            // 
            // nsxTrangThai
            // 
            nsxTrangThai.Text = "Trạng thái";
            nsxTrangThai.Width = 340;
            // 
            // Yesbtn
            // 
            Yesbtn.AutoSize = true;
            Yesbtn.Location = new Point(469, 163);
            Yesbtn.Margin = new Padding(3, 2, 3, 2);
            Yesbtn.Name = "Yesbtn";
            Yesbtn.Size = new Size(82, 19);
            Yesbtn.TabIndex = 45;
            Yesbtn.TabStop = true;
            Yesbtn.Text = "Hoạt động";
            Yesbtn.UseVisualStyleBackColor = true;
            Yesbtn.CheckedChanged += Yes_CheckedChanged;
            // 
            // Nobtn
            // 
            Nobtn.AutoSize = true;
            Nobtn.Location = new Point(594, 163);
            Nobtn.Margin = new Padding(3, 2, 3, 2);
            Nobtn.Name = "Nobtn";
            Nobtn.Size = new Size(118, 19);
            Nobtn.TabIndex = 46;
            Nobtn.TabStop = true;
            Nobtn.Text = "Không hoạt động";
            Nobtn.UseVisualStyleBackColor = true;
            // 
            // textBoxMANSX
            // 
            textBoxMANSX.Location = new Point(469, 76);
            textBoxMANSX.Margin = new Padding(3, 2, 3, 2);
            textBoxMANSX.Name = "textBoxMANSX";
            textBoxMANSX.ReadOnly = true;
            textBoxMANSX.Size = new Size(248, 23);
            textBoxMANSX.TabIndex = 47;
            textBoxMANSX.TextChanged += textBox1_TextChanged;
            // 
            // textBoxtennsx
            // 
            textBoxtennsx.Location = new Point(469, 119);
            textBoxtennsx.Margin = new Padding(3, 2, 3, 2);
            textBoxtennsx.Name = "textBoxtennsx";
            textBoxtennsx.Size = new Size(248, 23);
            textBoxtennsx.TabIndex = 48;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(678, 495);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 49;
            buttonAdd.Text = "Thêm";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(790, 495);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 50;
            buttonEdit.Text = "Sửa";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(906, 495);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 51;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormNhaSanXuat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 648);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxtennsx);
            Controls.Add(textBoxMANSX);
            Controls.Add(Nobtn);
            Controls.Add(Yesbtn);
            Controls.Add(lv_qlncc);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormNhaSanXuat";
            Text = " n";
            Load += FormNhaSanXuat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Yes_CheckedChanged(object sender, EventArgs e)
            {
                // Kiểm tra nếu Yesbtn đang được chọn
                if (Yesbtn.Checked)
                {
                    // Nếu Yes được chọn, đặt No thành không được chọn
                    Nobtn.Checked = false;

                    // Bạn có thể thực hiện các thao tác khác nếu cần, ví dụ:
                    // MessageBox.Show("Trạng thái: Yes được chọn");

                    // Cập nhật biến TrangThai nếu cần
                    // bool trangThai = true; // nếu cần lưu trạng thái
                }
            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {
                // Kiểm tra nếu textBoxMANSX có giá trị hay không
                if (string.IsNullOrWhiteSpace(textBoxMANSX.Text))
                {
                    // Nếu trống, vô hiệu hóa các nút Sửa và Xóa
                    buttonEdit.Enabled = false;
                    buttonDelete.Enabled = false;
                }
                else
                {
                    // Nếu có giá trị, kích hoạt các nút Sửa và Xóa
                    buttonEdit.Enabled = true;
                    buttonDelete.Enabled = true;
                }
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
            private RadioButton Yesbtn;
            private RadioButton Nobtn;
            private TextBox textBoxMANSX;
            private TextBox textBoxtennsx;
            private Button buttonAdd;
            private Button buttonEdit;
            private Button buttonDelete;
        }
    }