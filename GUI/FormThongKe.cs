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
    public partial class FormThongKe : Form
    {
        private Button currentButton;
        private Form currentForm;
        private Panel bottomPanel;
        public FormThongKe()
        {
            InitializeComponent();
        }


        private void activateButton(object sender)
        {
            if (sender != null)
            {
                disableButton();
                currentButton = (Button) sender;
                bottomPanel = new Panel();
                bottomPanel.Size = new Size(currentButton.Width, 6);
                bottomPanel.Location = new Point(0, currentButton.Bottom - 6);
                bottomPanel.BackColor = Color.LightSeaGreen;
                currentButton.Controls.Add(bottomPanel);
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
            panelThongKe.Controls.Add(form);
            panelThongKe.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void disableButton()
        {
            if (currentButton != null)
            {
                currentButton.Controls.Remove(bottomPanel);
            }
        }
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnSanPhamNhap_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnSanPhamBan_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            activateButton(sender);
        }
    }
}
