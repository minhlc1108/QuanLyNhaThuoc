using BUS;
using DAO;
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
    public partial class FormTieuHuy : Form
    {
        public FormTieuHuy()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // aa
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void FormTieuHuy_Load_1(object sender, EventArgs e)
        {
            DataTable chiTietSanPham = DataProvider.Instance.GetChiTietSanPham();
            DataTable danhSachDuocSi = DataProvider.Instance.GetDanhSachDuocSi();
            lv_DSHoaDon.SelectedIndexChanged += lv_DSHoaDon_SelectedIndexChanged;

            // Đẩy dữ liệu vào ComboBox cho lô sản xuất
            comboBoxLoSX.DataSource = chiTietSanPham;
            comboBoxLoSX.DisplayMember = "loSX";
            comboBoxLoSX.ValueMember = "mact"; // Sử dụng "mact" để lưu trữ

            // Đẩy dữ liệu vào ComboBox cho sản phẩm (hiển thị tên sản phẩm)
            comboBoxSanPham.DataSource = chiTietSanPham;
            comboBoxSanPham.DisplayMember = "tensp"; // Hiển thị tên sản phẩm
            comboBoxSanPham.ValueMember = "mact"; // Lưu giá trị là mã chi tiết

            // Đẩy dữ liệu vào ComboBox cho người lập
            comboBoxNguoiLap.DataSource = danhSachDuocSi;
            comboBoxNguoiLap.DisplayMember = "hoten";  // Hiển thị tên dược sĩ
            comboBoxNguoiLap.ValueMember = "mads";
            LoadTieuHuyData();
        }
        private void LoadTieuHuyData()
        {
            DataTable data = TieuHuyBUS.Instance.GetListTieuHuy();
            lv_DSHoaDon.Items.Clear();

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["mact"].ToString());
                //  item.SubItems.Add(row["loSX"].ToString());
                item.SubItems.Add(Convert.ToDateTime(row["ngaytieuhuy"]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(row["nguoilap"].ToString());
                item.SubItems.Add(row["lydo"].ToString());
                item.SubItems.Add(row["thiethai"].ToString());

                lv_DSHoaDon.Items.Add(item);
            }
        }

        private void comboBoxSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadListTieuHuy()
        {
            lv_DSHoaDon.Items.Clear();
            DataTable data = TieuHuyBUS.Instance.GetListTieuHuy();
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["mact"].ToString());
                item.SubItems.Add(row["ngaytieuhuy"].ToString());
                item.SubItems.Add(row["nguoilap"].ToString());
                item.SubItems.Add(row["lydo"].ToString());
                item.SubItems.Add(row["thiethai"].ToString());
                lv_DSHoaDon.Items.Add(item);
            }
        }
        private void buttonadd_Click(object sender, EventArgs e)
        {
            TieuHuyDTO tieuHuy = new TieuHuyDTO()
            {
                MaCT = int.Parse(comboBoxSanPham.SelectedValue.ToString()),
                NgayTieuHuy = dateTimePicker3.Value,
                NguoiLap = comboBoxNguoiLap.SelectedValue.ToString(),
                LyDo = richTextBox1.Text,
                ThietHai = string.IsNullOrEmpty(textBox1.Text) ? (decimal?)null : decimal.Parse(textBox1.Text)
            };

            if (TieuHuyBUS.Instance.AddTieuHuy(tieuHuy))
            {
                MessageBox.Show("Thêm thành công");
                LoadListTieuHuy();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            if (lv_DSHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_DSHoaDon.SelectedItems[0];
                TieuHuyDTO tieuHuy = new TieuHuyDTO()
                {
                    MaCT = int.Parse(selectedItem.Text),
                    NgayTieuHuy = dateTimePicker3.Value,
                    NguoiLap = comboBoxNguoiLap.SelectedValue.ToString(),
                    LyDo = richTextBox1.Text,
                    ThietHai = string.IsNullOrEmpty(textBox1.Text) ? (decimal?)null : decimal.Parse(textBox1.Text)
                };




                // Gọi phương thức cập nhật
                if (TieuHuyBUS.Instance.UpdateTieuHuy(tieuHuy))
                {
                    MessageBox.Show("Cập nhật thành công");
                    LoadListTieuHuy();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để cập nhật.");
            }
        }


        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (lv_DSHoaDon.SelectedItems.Count > 0)
            {
                int maCT = int.Parse(lv_DSHoaDon.SelectedItems[0].Text);
                if (TieuHuyBUS.Instance.DeleteTieuHuy(maCT))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadListTieuHuy();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void lv_DSHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_DSHoaDon.SelectedItems.Count > 0)
            {
                // Lấy mục được chọn đầu tiên
                ListViewItem selectedItem = lv_DSHoaDon.SelectedItems[0];

                // Gán giá trị từ các cột của ListView vào các điều khiển nhập liệu
                comboBoxSanPham.SelectedValue = int.Parse(selectedItem.SubItems[0].Text); // Mã chi tiết
                dateTimePicker3.Value = DateTime.Parse(selectedItem.SubItems[1].Text); // Ngày tiêu hủy
                comboBoxNguoiLap.SelectedValue = selectedItem.SubItems[2].Text; // Người lập
                richTextBox1.Text = selectedItem.SubItems[3].Text; // Lý do
                textBox1.Text = selectedItem.SubItems[4].Text; // Thiệt hại
            }
        }

    }
}
