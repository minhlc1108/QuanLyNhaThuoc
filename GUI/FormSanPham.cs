using BUS;
using DTO;
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
        private string thanhPhanValue; // Biến lưu giá trị ban đầu thành phần
        private string dieutriValue; // Biến lưu giá trị ban đầu thành phần

        public FormSanPham()
        {
            InitializeComponent();
            LoadSPData();
            LoadSPData();
            thanhPhanValue=txtThanhPhan.Text;
            dieutriValue=txtDieuTriBenh.Text;
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
            bool keToa;
            if (cbbKeToa.Text == "Cần Kê Toa")
            {
                keToa = true;
            }
            else
            {
                keToa = false;
            }
            if (ValidateInputs(txtMaSanPham.Text, txtTenSanPham.Text, txtQuyCach.Text, txtXuatXu.Text, txtThanhPhan.Text, txtDieuTriBenh.Text))
            {
                bool themSanPham = SanPhamBUS.Instance.InsertProduct(txtMaSanPham.Text, txtTenSanPham.Text, cbbLoaiSanPham.Text.Split(" - ")[0].Trim(), cbbNhaSX.Text.Split(" - ")[0].Trim(), txtQuyCach.Text, txtXuatXu.Text, keToa, true);
                string[] thanhPhanList = txtThanhPhan.Text.Split(',');
                foreach (string thanhPhan in thanhPhanList)
                {
                    bool themThanhPhan = ThanhPhanBUS.Instance.themThanhPhan(txtMaSanPham.Text.Trim(), thanhPhan.Trim());
                }
                string[] dieuTriList = txtDieuTriBenh.Text.Split(',');
                foreach (string dieutri in dieuTriList)
                {
                    bool themDieuTri = DieuTriBUS.Instance.themDieuTri(txtMaSanPham.Text.Trim(), dieutri.Trim());
                }
                LoadSPData();
                btnResetSanPham_Click(sender, e);
            }
        }
        private void LoadSPData()
        {
            cbbKeToa.SelectedIndex = 0;
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
                int soLuong = SanPhamBUS.Instance.getSoLuongByMaSP(SP.MaSP);
                item.SubItems.Add(soLuong.ToString());

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
                btnKhoaSanPham.Enabled = false;
                btnUpdateSanPham.Enabled = false;
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
                txtMaSanPham.Enabled = false;
                ListViewItem item = e.Item; // Lấy dòng vừa được chọn
                txtMaSanPham.Text = item.SubItems[0].Text;
                txtTenSanPham.Text = item.SubItems[1].Text;
                txtQuyCach.Text = item.SubItems[4].Text;
                txtXuatXu.Text = item.SubItems[5].Text;

                for (int i = 0; i < cbbLoaiSanPham.Items.Count; i++)
                {
                    if (cbbLoaiSanPham.Items[i].ToString().Split(" - ")[0].Trim() == item.SubItems[2].Text.Trim())
                    {
                        cbbLoaiSanPham.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cbbNhaSX.Items.Count; i++)
                {
                    if (cbbNhaSX.Items[i].ToString().Split(" - ")[0].Trim() == item.SubItems[3].Text.Trim())
                    {
                        cbbNhaSX.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < cbbKeToa.Items.Count; i++)
                {
                    if (cbbKeToa.Items[i].ToString().Split(" - ")[0].Trim() == item.SubItems[6].Text.Trim())
                    {
                        cbbKeToa.SelectedIndex = i;
                        break;
                    }
                }

                // get thành phần by mã
                List<ThanhPhanDTO> listThanhPhanByMa = ThanhPhanBUS.Instance.GetALLThanhPhanByMa(txtMaSanPham.Text.Trim());
                string thanhPhanString = string.Join(", ", listThanhPhanByMa.ConvertAll(tp => tp.TenThanhPhan));
                txtThanhPhan.Text = thanhPhanString;
                //get điều tri by mã
                List<DieuTriDTO> listDieuTriByMa = DieuTriBUS.Instance.GetALLDieuTriByMa(txtMaSanPham.Text.Trim());
                string dieuTriString = string.Join(", ", listDieuTriByMa.ConvertAll(tp => tp.BenhDieuTri));
                txtDieuTriBenh.Text = dieuTriString;
                btnThemSanPham.Enabled = false;
                btnUpdateSanPham.Enabled = true;
                if (item.SubItems[8].Text.Trim() == "Nghỉ Bán")
                {
                    btnKhoaSanPham.Enabled = false;
                }
                else
                {
                    btnKhoaSanPham.Enabled = true;
                }
                cbbLoaiSanPham.Enabled = false;
                cbbNhaSX.Enabled = false;
            }
        }
        public void loadCbbLoaiSP()
        {
            cbbLoaiSanPham.Items.Clear();

            List<LoaiSanPhamDTO> listLoaiSanPham = LoaiSanPhamBUS.Instance.GetAllLoaiSanPham();

            List<string> itemCbb_loaiSP = new List<string>();
            foreach (LoaiSanPhamDTO loaisp in listLoaiSanPham)
            {
                string item = $"{loaisp.MaLoai + " - " + loaisp.TenLoai}";
                itemCbb_loaiSP.Add(item);
            }
            cbbLoaiSanPham.Items.AddRange(itemCbb_loaiSP.ToArray());
            cbbLoaiSanPham.DropDownHeight = 200;
            cbbLoaiSanPham.SelectedIndex = 0;


        }
        public void loadCbbNhaSanXuat()
        {
            cbbKeToa.Items.Clear();
            cbbKeToa.Items.Add("Cần Kê Toa");
            cbbKeToa.Items.Add("Không Kê Toa");
            cbbNhaSX.Items.Clear();

            List<NhaSanXuatDTO> nsxList = NhaSanXuatBUS.Instance.GetAllNhaSanXuat();

            List<string> itemCbb_NhaSX = new List<string>();
            foreach (NhaSanXuatDTO nsx in nsxList)
            {
                string item = $"{nsx.MaNSX + " - " + nsx.TenNSX}";
                itemCbb_NhaSX.Add(item);
            }
            cbbNhaSX.Items.AddRange(itemCbb_NhaSX.ToArray());
            cbbNhaSX.DropDownHeight = 200;
            cbbNhaSX.SelectedIndex = 0;


        }

        private void btnKhoaSanPham_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSanPham.Text;
            bool keToa;
            if (cbbKeToa.Text == "Cần Kê Toa")
            {
                keToa = true;
            }
            else
            {
                keToa = false;
            }
            DialogResult result = MessageBox.Show("Bạn muốn thay đổi khóa sản phẩm này", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            SanPhamDTO sp = SanPhamBUS.Instance.GetSPByMaSP(txtMaSanPham.Text);
            // get thành phần by mã
            List<ThanhPhanDTO> listThanhPhanByMa = ThanhPhanBUS.Instance.GetALLThanhPhanByMa(txtMaSanPham.Text.Trim());
            string thanhPhanString = string.Join(", ", listThanhPhanByMa.ConvertAll(tp => tp.TenThanhPhan));
            txtThanhPhan.Text = thanhPhanString;
            string[] thanhPhanList = txtThanhPhan.Text.Split(',');
            //get điều tri by mã
            List<DieuTriDTO> listDieuTriByMa = DieuTriBUS.Instance.GetALLDieuTriByMa(txtMaSanPham.Text.Trim());
            string dieuTriString = string.Join(", ", listDieuTriByMa.ConvertAll(tp => tp.BenhDieuTri));
            txtDieuTriBenh.Text = dieuTriString;

            bool check = true;
            if (sp.TenSP.Trim() != txtTenSanPham.Text || sp.QuyCach.Trim() != txtQuyCach.Text || sp.XuatXu.Trim() != txtXuatXu.Text || sp.CanKeToa != keToa || txtThanhPhan.Text != thanhPhanString || txtDieuTriBenh.Text != dieuTriString)
            {

                MessageBox.Show("Không được chỉnh sửa sản phẩm khi khóa .", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;

            }
            if (result == DialogResult.Yes && check)
            {
                bool successUpTT = SanPhamBUS.Instance.UpdateTrangThaiSanPham(maSP, false);
                if (successUpTT)
                {
                    MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSPData();
                }
            }
            btnResetSanPham_Click(sender, e);
        }

        private void btnResetSanPham_Click(object sender, EventArgs e)
        {
            LoadSPData();
            txtDieuTriBenh.Text = "";
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtQuyCach.Text = "";
            txtXuatXu.Text = "";
            txtThanhPhan.Text = "";
            txtTimKiem.Text = "";
            cbbKeToa.SelectedIndex = 0;
            cbbLoaiSanPham.SelectedIndex = 0;
            cbbNhaSX.SelectedIndex = 0;
            btnThemSanPham.Enabled = true;
            btnKhoaSanPham.Enabled = false;
            btnUpdateSanPham.Enabled = false;
            txtMaSanPham.Enabled = true;
            cbbLoaiSanPham.Enabled = true;
            cbbNhaSX.Enabled = true;
        }

        private void btnUpdateSanPham_Click(object sender, EventArgs e)
        {

            bool keToa;
            if (cbbKeToa.Text == "Cần Kê Toa")
            {
                keToa = true;
            }
            else
            {
                keToa = false;
            }

            if (ValidateInputs(txtMaSanPham.Text, txtTenSanPham.Text, txtQuyCach.Text, txtXuatXu.Text, txtThanhPhan.Text, txtDieuTriBenh.Text))
            {
                bool updateSanPham = SanPhamBUS.Instance.UpdateSanPham(txtMaSanPham.Text, txtTenSanPham.Text, cbbLoaiSanPham.Text.Split(" - ")[0].Trim(), cbbNhaSX.Text.Split(" - ")[0].Trim(), txtQuyCach.Text, txtXuatXu.Text, keToa);
                bool xoaThanhPhanByMaSP = ThanhPhanBUS.Instance.deleteThanhPhan(txtMaSanPham.Text.Trim());
                bool xoaDieuTriByMaSP = DieuTriBUS.Instance.deleteDieuTri(txtMaSanPham.Text.Trim());
                string[] thanhPhanList = txtThanhPhan.Text.Split(',');
                foreach (string thanhPhan in thanhPhanList)
                {
                    bool themThanhPhan = ThanhPhanBUS.Instance.themThanhPhan(txtMaSanPham.Text.Trim(), thanhPhan.Trim());
                }
                string[] dieuTriList = txtDieuTriBenh.Text.Split(',');
                foreach (string dieutri in dieuTriList)
                {
                    bool themDieuTri = DieuTriBUS.Instance.themDieuTri(txtMaSanPham.Text.Trim(), dieutri.Trim());
                }
                LoadSPData();
                btnResetSanPham_Click(sender, e);
            }

        }
        public bool ValidateInputs(string maSP, string tenSP, string xuatxu, string quycach, string thanhphan, string dieutribenh)
        {
            bool ktra = true;
            if (string.IsNullOrWhiteSpace(maSP) || string.IsNullOrWhiteSpace(tenSP) || string.IsNullOrWhiteSpace(xuatxu) || string.IsNullOrWhiteSpace(quycach) || string.IsNullOrWhiteSpace(thanhphan) || string.IsNullOrWhiteSpace(dieutribenh))
            {
                MessageBox.Show("Không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            return ktra;
        }

        private void txtThanhPhan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
