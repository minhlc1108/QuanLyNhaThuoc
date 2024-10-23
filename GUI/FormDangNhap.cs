using DTO;
using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void pic_show_MouseUp(object sender, EventArgs e)
        {
            pic_unShow.Visible = false;
            pic_show.Visible = true;
            tb_pass.UseSystemPasswordChar = true;
        }

        private void pic_show_MouseDown(object sender, EventArgs e)
        {
            pic_unShow.Visible = true;
            pic_show.Visible = false;
            tb_pass.UseSystemPasswordChar = false;
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {

            List<TaiKhoanDTO> list = TaiKhoanBUS.Instance.GetAllTaiKhoan();

            string username = tb_user.Text;
            string password = tb_pass.Text;

            bool check = false;
            foreach (TaiKhoanDTO taiKhoan in list)
            {
                if (username == taiKhoan.Username && password == taiKhoan.Password)
                {
                    check = true;
                    break;
                }
            }
            if(check)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
