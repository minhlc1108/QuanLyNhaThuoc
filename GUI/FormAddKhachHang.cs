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
    public partial class FormAddKhachHang : Form
    {

        private FormHoaDon _formHoaDon;
        public FormAddKhachHang(FormHoaDon formHoaDon)
        {
            InitializeComponent();
            _formHoaDon = formHoaDon;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int makh = KhachHangBUS.Instance.GetLastMaKH() + 1;
            string hoTen = tb_hoten.Text;
            DateTime ngaySinh = date_kh.Value;
            string gioiTinh = "chua_check";
            if (cb_nam.Checked)
            {
                gioiTinh = "Nam";
            }
            else if (cb_nu.Checked)
            {
                gioiTinh = "Nữ";
            }
            string soDT = tb_sdt.Text;

            bool checkValue = ValidateInputs(hoTen, soDT, gioiTinh);
            if (checkValue)
            {
                DialogResult result = MessageBox.Show(this, "Bạn muốn thêm khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool checkAdd = KhachHangBUS.Instance.AddKhachHang(makh, hoTen, ngaySinh, gioiTinh, soDT, 0);
                    if (checkAdd)
                    {
                        MessageBox.Show(this, "Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();

                        // Gọi loadCbbKh trên FormHoaDon để cập nhật ComboBox
                        _formHoaDon.loadCbbKh();
                    }
                }
            }
        }


        public bool ValidateInputs(string hoTen, string sodt, string gioitinh)
        {
            bool ktra = true;
            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(sodt) || gioitinh == "chua_check")
            {
                MessageBox.Show("Không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            else
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(sodt, @"^0\d{9}$"))
                {
                    erorr_sdt.Text = "Số điện thoại không hợp lệ!";
                    ktra = false;
                }
                else
                {
                    erorr_sdt.Text = "";
                }
            }
            return ktra;
        }

        private void reset()
        {
            tb_hoten.Text = "";
            tb_sdt.Text = "";
            date_kh.Value = new DateTime(2000, 1, 1);
            cb_nam.Checked = false;
            cb_nu.Checked = false;
        }
    }
}
