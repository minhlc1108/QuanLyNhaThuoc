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
        private IconButton currentButton;
        private Form currentForm;
        private Form accountForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void activateButton(object sender)
        {
            if (sender != null)
            {
                disableButton();
                currentButton = (IconButton)sender;
                currentButton.BackColor = Color.FromArgb(0, 168, 222);
            }
        }

        private void disableButton()
        {
            if (currentButton != null)
            {
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
            openForm(new FormHoaDon());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormSanPham());
        }

        private void iconUser_Click(object sender, EventArgs e)
        {
            if(accountForm != null)
            {
                accountForm.Close();
            }

            accountForm = new FormThongTinTK();
            accountForm.StartPosition = FormStartPosition.CenterScreen;
            accountForm.Show();
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            activateButton(sender);
            openForm(new FormPhieuNhap());
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (panelMenu.Controls.Count > 0)
            {
                int count = panelMenu.Controls.Count;
                for (int i = count - 1; i >= 0; i--)
                {
                    if(panelMenu.Controls[i] is IconButton button && button.Visible)
                    {
                        button.PerformClick();
                        break;
                    }
                }
            }
        }
    }
}
