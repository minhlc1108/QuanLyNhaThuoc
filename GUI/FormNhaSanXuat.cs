using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormNhaSanXuat : Form
    {
        public FormNhaSanXuat()
        {
            InitializeComponent();
            LoadData();
            // Chỉ tạo mã khi form load lần đầu
            textBoxMANSX.Text = NhaSanXuatBUS.Instance.GenerateMaNhaSanXuat();
        }

        // Load dữ liệu lên ListView
        private void LoadData()
        {
            lv_qlncc.Items.Clear();
            List<NhaSanXuatDTO> nhaSanXuatList = NhaSanXuatBUS.Instance.GetAllNhaSanXuat();

            foreach (var nsx in nhaSanXuatList)
            {
                ListViewItem item = new ListViewItem(nsx.MaNSX);
                item.SubItems.Add(nsx.TenNSX);
                item.SubItems.Add(nsx.TrangThai ? "Yes" : "No");
                lv_qlncc.Items.Add(item);
            }
        }

        // Thêm nhà sản xuất mới
        private void AddNhaSanXuat()
        {
            string tenNSX = textBoxtennsx.Text;
            bool trangThai = Yesbtn.Checked;

            if (NhaSanXuatBUS.Instance.InsertNewNhaSanXuat(tenNSX, trangThai))
            {
                MessageBox.Show("Thêm nhà sản xuất thành công!");
                LoadData();
                // Sau khi thêm, tạo mã mới để chuẩn bị cho lần thêm kế tiếp
                textBoxMANSX.Text = NhaSanXuatBUS.Instance.GenerateMaNhaSanXuat();
            }
            else
            {
                MessageBox.Show("Thêm nhà sản xuất thất bại!");
            }
        }

        // Cập nhật tên nhà sản xuất
        private void UpdateNhaSanXuat()
        {
            string maNSX = textBoxMANSX.Text;
            string tenNSX = textBoxtennsx.Text;
            bool trangThai = Yesbtn.Checked;

            // Cập nhật tên nhà sản xuất
            if (NhaSanXuatBUS.Instance.UpdateTenNhaSanXuat(maNSX, tenNSX))
            {
                MessageBox.Show("Cập nhật tên nhà sản xuất thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật tên nhà sản xuất thất bại!");
            }

            // Cập nhật trạng thái nhà sản xuất
            if (NhaSanXuatBUS.Instance.UpdateTrangThaiNhaSanXuat(maNSX, trangThai))
            {
                MessageBox.Show("Cập nhật trạng thái nhà sản xuất thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật trạng thái nhà sản xuất thất bại!");
            }

            LoadData(); // Tải lại dữ liệu sau khi cập nhật
        }


        // Xóa nhà sản xuất
        private void DeleteNhaSanXuat()
        {
            string maNSX = textBoxMANSX.Text;

            if (NhaSanXuatBUS.Instance.DeleteNhaSanXuat(maNSX))
            {
                MessageBox.Show("Xóa nhà sản xuất thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        // Sự kiện chọn item trong ListView
        private void lv_qlncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_qlncc.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_qlncc.SelectedItems[0];
                textBoxMANSX.Text = item.SubItems[0].Text;
                textBoxtennsx.Text = item.SubItems[1].Text;
                Yesbtn.Checked = item.SubItems[2].Text == "Yes";
                Nobtn.Checked = item.SubItems[2].Text == "No";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Gọi trực tiếp hàm AddNhaSanXuat
            AddNhaSanXuat();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            UpdateNhaSanXuat();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteNhaSanXuat();
        }
    }
}
