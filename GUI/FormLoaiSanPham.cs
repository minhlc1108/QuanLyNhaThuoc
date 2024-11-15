using BUS;
using DTO;
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
    public partial class FormLoaiSanPham : Form
    {
        public bool True { get; private set; }

        public FormLoaiSanPham()
        {
            InitializeComponent();
            reset();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LoadLoaiSPData()
        {
            List<LoaiSanPhamDTO> loaiSanPhamList = LoaiSanPhamBUS.Instance.GetAllLoaiSanPham();
            List<TaiKhoanDTO> taiKhoanList = TaiKhoanBUS.Instance.GetAllTaiKhoan();

            lsvLoaiSanPham.Items.Clear();

            int stt = 1;

            foreach (LoaiSanPhamDTO loaiSP in loaiSanPhamList)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(loaiSP.MaLoai);
                item.SubItems.Add(loaiSP.TenLoai);
                if (Convert.ToString(loaiSP.TrangThai) == "True")
                {
                    item.SubItems.Add("Đang Bán");

                }
                else
                {
                    item.SubItems.Add("Nghỉ Bán");

                }


                lsvLoaiSanPham.Items.Add(item);
                Console.WriteLine(Convert.ToString(loaiSP.TrangThai), loaiSP.TrangThai);
                stt++;
            }
        }

        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoaiSP.Text;
            string tenLoai = txtLoaiSanPham.Text;

            if (ValidateInputs(maLoai, tenLoai))
            {
                DialogResult result = MessageBox.Show("Bạn muốn thêm dược sĩ này?", "Xác nhận thêm dược sĩ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool successAddLoaiSanPham = LoaiSanPhamBUS.Instance.InsertLoaiSanPham(maLoai, tenLoai, true);
                    if (successAddLoaiSanPham)
                    {

                        MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();

                    }
                    else
                    {
                        MessageBox.Show("Thêm loại sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public bool ValidateInputs(string tenloai, string maloai)
        {
            bool ktra = true;
            if (string.IsNullOrWhiteSpace(tenloai) || string.IsNullOrWhiteSpace(maloai))
            {
                MessageBox.Show("Không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            //else
            //{
            //    if (!System.Text.RegularExpressions.Regex.IsMatch(sodt, @"^0\d{9}$"))
            //    {
            //        erorr_sdt.Text = "Số điện thoại không hợp lệ!";
            //        ktra = false;
            //    }
            //    else
            //    {
            //        erorr_sdt.Text = "";
            //    }

            //    if (!email.EndsWith("@gmail.com"))
            //    {
            //        erorr_email.Text = "Email không hợp lệ!";
            //        ktra = false;
            //    }
            //    else
            //    {
            //        erorr_email.Text = "";
            //    }
            //}
            return ktra;
        }

        private void btnXoaLSP_Click(object sender, EventArgs e)
        {
            string maLoaiSP = txtMaLoaiSP.Text;
            string tenLoaiSP = txtLoaiSanPham.Text;
            DialogResult result = MessageBox.Show($"Bạn muốn khóa  loại sản phẩm sĩ có Tên Sản Phẩm = {tenLoaiSP}?", "Xác nhận khóa loại sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int checkSP = LoaiSanPhamBUS.Instance.checkSanPham(maLoaiSP);
                if (checkSP > 0)
                {
                    MessageBox.Show("Khóa loại sản phẩm thất bại,vui lòng khóa các sản phẩm lên quan trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
                else
                {
                    bool successDelDuocSi = LoaiSanPhamBUS.Instance.UpdateTrangThaiLoaiSanPham(maLoaiSP,false);
                    MessageBox.Show("Khóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }

            }
        }

        private void lsvLoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsvLoaiSanPham_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem item = e.Item; // Lấy dòng vừa được chọn
                txtMaLoaiSP.Text = item.SubItems[1].Text;
                txtLoaiSanPham.Text = item.SubItems[2].Text;
                // xử lý label & button
                btnThemLSP.Enabled = false;
                txtMaLoaiSP.Enabled = false;
                btnXoaLSP.Enabled = true;
                btnUpdateLSP.Enabled = true;
            }
        }

        private void btnResetLSP_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            txtMaLoaiSP.Text = null;
            txtLoaiSanPham.Text = null;
            txtLoaiSanPham.Enabled = true;
            txtMaLoaiSP.Enabled = true;
            btnThemLSP.Enabled = true;
            btnUpdateLSP.Enabled = false;
            btnXoaLSP.Enabled = false;
            LoadLoaiSPData();

        }

        private void btnUpdateLSP_Click(object sender, EventArgs e)
        {
            string maLoai = txtMaLoaiSP.Text;
            string tenLoai = txtLoaiSanPham.Text;

            if (ValidateInputs(maLoai, tenLoai))
            {
                DialogResult result = MessageBox.Show("Bạn muốn sửa loại sản phẩm này?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool successAddLoaiSanPham = LoaiSanPhamBUS.Instance.UpdateTenLoaiSanPham(maLoai, tenLoai);
                    if (successAddLoaiSanPham)
                    {
                        MessageBox.Show("Sửa loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();

                    }
                    else
                    {
                        MessageBox.Show("Thêm loại sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtMaLoaiSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
