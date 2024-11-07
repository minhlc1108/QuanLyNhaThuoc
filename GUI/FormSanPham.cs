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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
            LoadSPData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void LoadSPData()
        {
            loadCbbNhaSanXuat();
            loadCbbLoaiSP();
            List<SanPhamDTO> sanPhamList = SanPhamBUS.Instance.GetAllProducts();
            List<TaiKhoanDTO> taiKhoanList = TaiKhoanBUS.Instance.GetAllTaiKhoan();

            lsvSanPham.Items.Clear();

            int stt = 1;

            foreach (SanPhamDTO SP in sanPhamList)
            {
                ListViewItem item = new ListViewItem(SP.MaSP.ToString());
                item.SubItems.Add(SP.TenSP);
                item.SubItems.Add(SP.LoaiSP);
                item.SubItems.Add(SP.NhaSanXuat);
                item.SubItems.Add(SP.QuyCach);
                item.SubItems.Add(SP.XuatXu);
                if (SP.CanKeToa)
                {
                    item.SubItems.Add("Cần Kê Toa");

                }
                else
                {
                    item.SubItems.Add("Không Kê Toa");

                }

                if (Convert.ToString(SP.TrangThai) == "True")
                {
                    item.SubItems.Add("Đang Bán");

                }
                else
                {
                    item.SubItems.Add("Nghỉ Bán");

                }

                lsvSanPham.Items.Add(item);
                stt++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void lsvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsvSanPham_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem item = e.Item; // Lấy dòng vừa được chọn
                txtMaSanPham.Text = item.SubItems[0].Text;
                txtTenSanPham.Text = item.SubItems[1].Text;
                for(int i = 0; i < cbbLoaiSanPham.Items.Count; i++)
                {
                    if (cbbLoaiSanPham.Items[i].ToString().Trim() == item.SubItems[2].Text.Trim())
                    {
                        cbbLoaiSanPham.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cbbNhaSX.Items.Count; i++)
                {
                    if (cbbNhaSX.Items[i].ToString().Trim() == item.SubItems[3].Text.Trim())
                    {
                        cbbNhaSX.SelectedIndex = i;
                        break;
                    }
                }

                // xử lý label & button

            }
        }
        public void loadCbbLoaiSP()
        {
            cbbLoaiSanPham.Items.Clear();

            List<LoaiSanPhamDTO> listLoaiSanPham = LoaiSanPhamBUS.Instance.GetAllLoaiSanPham();

            List<string> itemCbb_loaiSP = new List<string>();
            foreach (LoaiSanPhamDTO loaisp in listLoaiSanPham)
            {
                string item = $"{loaisp.MaLoai}";
                itemCbb_loaiSP.Add(item);
            }
            cbbLoaiSanPham.Items.AddRange(itemCbb_loaiSP.ToArray());
            cbbLoaiSanPham.DropDownHeight = 200;
            cbbLoaiSanPham.SelectedIndex = 0;

            
        }
        public void loadCbbNhaSanXuat()
        {
            cbbNhaSX.Items.Clear();

            List<NhaSanXuatDTO> nsxList = NhaSanXuatBUS.Instance.GetAllNhaSanXuat();

            List<string> itemCbb_nhaSX = new List<string>();
            foreach (NhaSanXuatDTO nsx in nsxList)
            {
                string item = $"{nsx.MaNSX}";
                itemCbb_nhaSX.Add(item);
            }
            cbbNhaSX.Items.AddRange(nsxList.ToArray());
            cbbNhaSX.DropDownHeight = 200;
            cbbNhaSX.SelectedIndex = 0;


        }
    }
}
