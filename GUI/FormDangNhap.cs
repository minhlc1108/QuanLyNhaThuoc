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

            string mads = "";
            bool check = false;
            bool checkTrangThai = false;
            foreach (TaiKhoanDTO taiKhoan in list)
            {
                if (username == taiKhoan.Username && password == taiKhoan.Password)
                {
                    mads = taiKhoan.MaTK;
                    if (DuocSiBUS.Instance.getTrangThaiDuocSi(mads) == true)
                    {
                        checkTrangThai = true;
                    }
                    check = true;
                    break;
                }
                
            }
            if(check)
            {
                if(checkTrangThai)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm(mads);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dược sĩ này đã nghỉ làm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
