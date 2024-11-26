using BUS;
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
    public partial class FormThongTinTK : Form
    {
        private string madsDangNhap;
        public FormThongTinTK(string mads)
        {
            madsDangNhap = mads;
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            bool kiemtra = ValidateInputs(tb_oldpw.Text, tb_newpw.Text, tb_cfpw.Text);
            if(kiemtra)
            {
                if (TaiKhoanBUS.Instance.UpdatePassword(madsDangNhap, tb_newpw.Text))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
            }
        }

        public bool ValidateInputs(string matkhau , string matkhaumoi, string xacnhan) 
        {
            bool ktra = true;
            if (string.IsNullOrWhiteSpace(matkhau) || string.IsNullOrWhiteSpace(matkhaumoi) || string.IsNullOrWhiteSpace(xacnhan))
            {
                MessageBox.Show("Không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            else
            {
                string password = TaiKhoanBUS.Instance.GetPassword(madsDangNhap);
                if (string.IsNullOrWhiteSpace(password)) {
                    MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
                }
                if (password != matkhau)
                {
                    err_oldpw.Text = "Mật khẩu cũ không đúng";
                    ktra = false;
                }
                else
                {
                    err_oldpw.Text = "";
                }

                if (matkhaumoi != xacnhan)
                {
                    err_cfpw.Text = "Mật khẩu xác nhận không khớp";
                    ktra = false;
                }
                else
                {
                    err_cfpw.Text = "";
                }

            }
            return ktra;
        }
    }
}
