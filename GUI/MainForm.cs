using BUS;
using DTO;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        string madsDangNhap = "";
        int quyends = 0;
        private IconButton currentButton;
        private Form currentForm;
        private Form accountForm;
        public MainForm(string mads, int quyen)
        {
            InitializeComponent();
            madsDangNhap = mads;
            quyends = quyen;
            loadDataDangNhap();
        }

        private void loadDataDangNhap()
        {
            string tenDS = DuocSiBUS.Instance.getHoTenDuocSi(madsDangNhap);
            labelTenDS.Text = tenDS;
        }

        private void activateButton(object sender)
        {
            if (sender != null)
            {
                disableButton();
                currentButton = (IconButton)sender;
                currentButton.Font = new Font("Segoe UI", 11F,FontStyle.Bold);
                currentButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                currentButton.BackColor = Color.FromArgb(0, 168, 222);
            }
        }

        private void disableButton()
        {
            if (currentButton != null)
            {
                currentButton.Font = new Font("Segoe UI", 11F);
                currentButton.BackColor = Color.FromArgb(0, 153, 207);
            }
        }

        private void openForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(form);
            panelDesktop.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormHoaDon(madsDangNhap));
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormSanPham());
        }


        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormLoaiSanPham());
        }
        private void iconUser_Click(object sender, EventArgs e)
        {
            if (accountForm != null)
            {
                accountForm.Close();
            }

            accountForm = new FormThongTinTK(madsDangNhap);
            accountForm.StartPosition = FormStartPosition.CenterScreen;
            accountForm.Show();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormPhieuNhap(madsDangNhap));
        }

        private void btnTieuHuy_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormTieuHuy());
        }
        private void btnDuocSi_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormDuocSi());
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormKhachHang());
        }

        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormNhaSanXuat());
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormNhaCungCap());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormThongKe());
        }

        private void SetChucNangTheoPhanQuyen(int quyen)
        {
            int index = 0;
            int count = panelMenu.Controls.Count;
            for (int i = count - 2; i > 0  ; i--)
            {
                //MessageBox.Show(panelMenu.Controls[i].ToString());
                bool isChecked = (quyen & (1 << index++)) != 0; // Kiểm tra bit
                panelMenu.Controls[i].Visible =isChecked; // Thiết lập trạng thái
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            SetChucNangTheoPhanQuyen(quyends);
            if (panelMenu.Controls.Count > 0)
            {
                int count = panelMenu.Controls.Count;
                for (int i = count - 2; i > 0; i--)
                {
                    if (panelMenu.Controls[i] is IconButton button && button.Visible)
                    {
                        button.PerformClick();
                        break;
                    }
                }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FormDangNhap formDN = new FormDangNhap();
                formDN.Show();
                this.Hide();
            }
        }
    }
}
