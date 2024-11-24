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
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.UniversalAccessibility.Drawing;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;

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
            thanhPhanValue = txtThanhPhan.Text;
            dieutriValue = txtDieuTriBenh.Text;
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
            if (ValidateInputs(txtMaSanPham.Text, txtTenSanPham.Text, txtQuyCach.Text, txtXuatXu.Text, txtThanhPhan.Text, txtDieuTriBenh.Text) && checkMaSP())
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
        private bool checkMaSP()
        {
            List<SanPhamDTO> list = SanPhamBUS.Instance.GetAllProducts();
            foreach (SanPhamDTO sanpham in list)
            {
                if (sanpham.MaSP.Trim() == txtMaSanPham.Text.Trim())
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
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

        private List<ListViewItem> listTimKiem = new List<ListViewItem>();

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                btnResetSanPham_Click(sender, e);
            }
            string searchText = txtTimKiem.Text.Trim().ToLower();

            // Xác định loại tìm kiếm dựa trên ký tự phân tách
            bool isOrSearch = searchText.Contains(",");
            bool isAndSearch = searchText.Contains("+");

            if (isOrSearch && isAndSearch)
            {
                MessageBox.Show("Cú pháp tìm kiếm không hợp lệ. Vui lòng chỉ sử dụng ',' hoặc '+'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                LoadSPData();
                // Tách từ khóa dựa trên loại tìm kiếm
                if (isOrSearch)
                {
                    string[] keywords = txtTimKiem.Text.Trim().ToLower().Split(',');
                    PerformOrSearch(keywords);
                }
                else if (isAndSearch)
                {
                    string[] keywords = txtTimKiem.Text.Trim().ToLower().Split('+');
                    PerformAndSearch(keywords);
                }
                else
                {
                    searchBinhThuong();
                }
            }


        }
        private void searchBinhThuong()
        {
            foreach (ListViewItem item in lsvSanPham.Items)
            {
                bool isMatch = false;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (subItem.Text.ToLower().Contains(txtTimKiem.Text.Trim().ToLower()))
                    {
                        isMatch = true;
                        break;
                    }
                }

                if (isMatch)
                    listTimKiem.Add((ListViewItem)item.Clone()); // Lưu item khớp vào danh sách tạm
            }

            lsvSanPham.Items.Clear();
            lsvSanPham.Items.AddRange(listTimKiem.ToArray());
            listTimKiem.Clear();


        }
        private void PerformOrSearch(string[] keywords)
        {
            foreach (ListViewItem item in lsvSanPham.Items)
            {
                bool anyKeywordMatch = false;

                foreach (string keyword in keywords)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        if (subItem.Text.ToLower().Contains(keyword.Trim()))
                        {
                            anyKeywordMatch = true;
                            break;
                        }
                    }

                    if (anyKeywordMatch) break;
                }

                if (anyKeywordMatch)
                {
                    listTimKiem.Add((ListViewItem)item.Clone());
                }
            }

            // Hiển thị kết quả
            lsvSanPham.Items.Clear();
            lsvSanPham.Items.AddRange(listTimKiem.ToArray());
            listTimKiem.Clear();
        }

        private void PerformAndSearch(string[] keywords)
        {
            foreach (ListViewItem item in lsvSanPham.Items)
            {
                bool allKeywordsMatch = true;

                foreach (string keyword in keywords)
                {
                    bool keywordFound = false;

                    foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                    {
                        if (subItem.Text.ToLower().Contains(keyword.Trim()))
                        {
                            keywordFound = true;
                            break;
                        }
                    }

                    if (!keywordFound)
                    {
                        allKeywordsMatch = false;
                        break;
                    }
                }

                if (allKeywordsMatch)
                {
                    listTimKiem.Add((ListViewItem)item.Clone());
                }
            }

            // Hiển thị kết quả
            lsvSanPham.Items.Clear();
            lsvSanPham.Items.AddRange(listTimKiem.ToArray());
            listTimKiem.Clear();
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnXuatDanhSach_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xuất File Excel?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Lưu file Excel";
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "DanhSachSanPham.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Hoặc LicenseContext.Commercial nếu bạn có giấy phép

                        string filePath = saveFileDialog.FileName;

                        using (var package = new OfficeOpenXml.ExcelPackage())
                        {
                            var worksheet = package.Workbook.Worksheets.Add("Danh sách sản phẩm");

                            // Tiêu đề cột
                            worksheet.Cells[1, 1].Value = "Mã SP";
                            worksheet.Cells[1, 2].Value = "Tên SP";
                            worksheet.Cells[1, 3].Value = "Loại SP";
                            worksheet.Cells[1, 4].Value = "Nhà SX";
                            worksheet.Cells[1, 5].Value = "Quy Cách";
                            worksheet.Cells[1, 6].Value = "Xuất Xứ";
                            worksheet.Cells[1, 7].Value = "Kê Toa";
                            worksheet.Cells[1, 8].Value = "Số Lượng";
                            worksheet.Cells[1, 9].Value = "Trạng Thái";

                            var headerRange = worksheet.Cells[1, 1, 1, 9];
                            headerRange.Style.Font.Bold = true;
                            headerRange.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                            headerRange.Style.VerticalAlignment = OfficeOpenXml.Style.ExcelVerticalAlignment.Center;

                            int row = 2; // Bắt đầu từ dòng 2 vì dòng 1 là header
                            List<SanPhamDTO> listSanPham = SanPhamBUS.Instance.GetAllProducts();

                            foreach (var item in listSanPham)
                            {
                                int soLuongSanPham = SanPhamBUS.Instance.getSoLuongByMaSP(item.MaSP);

                                // Dữ liệu sản phẩm
                                worksheet.Cells[row, 1].Value = item.MaSP;
                                worksheet.Cells[row, 2].Value = item.TenSP;
                                worksheet.Cells[row, 3].Value = item.LoaiSP;
                                worksheet.Cells[row, 4].Value = item.NhaSanXuat;
                                worksheet.Cells[row, 5].Value = item.QuyCach;
                                worksheet.Cells[row, 6].Value = item.XuatXu;
                                worksheet.Cells[row, 7].Value = item.CanKeToa ? "Cần Kê Toa" : "Không Kê Toa";
                                worksheet.Cells[row, 8].Value = soLuongSanPham;
                                worksheet.Cells[row, 9].Value = item.TrangThai ? "Đang bán" : "Nghỉ bán";

                                row++;
                            }

                            // Kẻ đường dọc giữa các cột
                            worksheet.Cells[1, 1, row - 1, 9].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            worksheet.Cells[1, 1, row - 1, 9].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            worksheet.Cells[1, 1, row - 1, 9].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            worksheet.Cells[1, 1, row - 1, 9].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                            worksheet.Cells[1, 1, row - 1, 9].Style.Border.Top.Color.SetColor(System.Drawing.Color.Black);
                            worksheet.Cells[1, 1, row - 1, 9].Style.Border.Bottom.Color.SetColor(System.Drawing.Color.Black);
                            worksheet.Cells[1, 1, row - 1, 9].Style.Border.Left.Color.SetColor(System.Drawing.Color.Black);
                            worksheet.Cells[1, 1, row - 1, 9].Style.Border.Right.Color.SetColor(System.Drawing.Color.Black);

                            worksheet.Cells.AutoFitColumns();

                            // Lưu file Excel
                            package.SaveAs(new FileInfo(filePath));
                        }

                        MessageBox.Show($"Xuất file Excel thành công: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xuất File PDF?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Lưu file PDF";
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "XuatDanhSachSanPham.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        PdfDocument document = new PdfDocument();
                        document.Info.Title = "Danh sách Sản Phẩm";

                        PdfPage page = document.AddPage();
                        page.Orientation = PdfSharp.PageOrientation.Landscape;
                        page.Size = PdfSharp.PageSize.A3;
                        XGraphics gfx = XGraphics.FromPdfPage(page);

                        double rowHeight = 25; // Chiều cao cơ bản cho mỗi dòng
                        double startY = 100;   // Vị trí bắt đầu của bảng
                        double currentY = startY;

                        int rongMaSp = 100;
                        int rongTenSP = 150;
                        int rongLoaiSanPham = 150;
                        int rongNhaSanXuat = 150;
                        int rongQuyCach = 150;
                        int rongXuatXu = 100;
                        int rongKeToa = 100;
                        int rongSoLuong = 100;
                        int rongTrangThai = 120;

                        int totalWidth = rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat +
                                         rongQuyCach + rongXuatXu + rongKeToa + rongSoLuong + rongTrangThai;
                        double startX = (page.Width.Point - totalWidth) / 2;

                        XFont titleFont = new XFont("Verdana", 16);
                        XFont headerFont = new XFont("Verdana", 10);
                        XFont rowFont = new XFont("Verdana", 10);

                        gfx.DrawString("DANH SÁCH SẢN PHẨM", titleFont, XBrushes.Black, new XRect(0, 50, page.Width, 30), XStringFormats.TopCenter);

                        gfx.DrawRectangle(XPens.Black, startX, currentY, totalWidth, rowHeight);
                        gfx.DrawString("Mã SP", headerFont, XBrushes.Black, new XRect(startX, currentY, rongMaSp, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Tên SP", headerFont, XBrushes.Black, new XRect(startX + rongMaSp, currentY, rongTenSP, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Loại SP", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP, currentY, rongLoaiSanPham, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Nhà SX", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham, currentY, rongNhaSanXuat, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Quy Cách", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat, currentY, rongQuyCach, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Xuất Xứ", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach, currentY, rongXuatXu, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Kê Toa", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach + rongXuatXu, currentY, rongKeToa, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Số Lượng", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach + rongXuatXu + rongKeToa, currentY, rongSoLuong, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Trạng Thái", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach + rongXuatXu + rongKeToa + rongSoLuong, currentY, rongTrangThai, rowHeight), XStringFormats.Center);

                        currentY += rowHeight;

                        List<SanPhamDTO> listSanPham = SanPhamBUS.Instance.GetAllProducts();
                        foreach (var item in listSanPham)
                        {
                            int soLuongSanPham = SanPhamBUS.Instance.getSoLuongByMaSP(item.MaSP);

                            // Nếu vị trí vượt chiều cao trang, tạo trang mới
                            if (currentY + rowHeight > page.Height.Point - 50)
                            {
                                page = document.AddPage();
                                page.Orientation = PdfSharp.PageOrientation.Landscape;
                                page.Size = PdfSharp.PageSize.A3;
                                gfx = XGraphics.FromPdfPage(page);
                                currentY = startY;

                                // Vẽ lại tiêu đề bảng khi tạo trang mới
                                gfx.DrawRectangle(XPens.Black, startX, currentY, totalWidth, rowHeight);
                                gfx.DrawString("Mã SP", headerFont, XBrushes.Black, new XRect(startX, currentY, rongMaSp, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Tên SP", headerFont, XBrushes.Black, new XRect(startX + rongMaSp, currentY, rongTenSP, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Loại SP", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP, currentY, rongLoaiSanPham, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Nhà SX", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham, currentY, rongNhaSanXuat, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Quy Cách", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat, currentY, rongQuyCach, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Xuất Xứ", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach, currentY, rongXuatXu, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Kê Toa", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach + rongXuatXu, currentY, rongKeToa, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Số Lượng", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach + rongXuatXu + rongKeToa, currentY, rongSoLuong, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Trạng Thái", headerFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach + rongXuatXu + rongKeToa + rongSoLuong, currentY, rongTrangThai, rowHeight), XStringFormats.Center);

                                currentY += rowHeight;
                            }

                            // Tính chiều cao của dòng dựa trên nội dung (xuống dòng nếu cần)
                            double maxRowHeight = rowHeight;
                            string[] tenSPLines = WrapText(gfx, item.TenSP, rowFont, rongTenSP);
                            maxRowHeight = Math.Max(maxRowHeight, tenSPLines.Length * rowHeight);

                            // Vẽ các đường dọc giữa các cột
                            double currentX = startX;
                            DrawVerticalLine(gfx, currentY, currentY + maxRowHeight, currentX); // Mã SP
                            currentX += rongMaSp;
                            DrawVerticalLine(gfx, currentY, currentY + maxRowHeight, currentX); // Tên SP
                            currentX += rongTenSP;
                            DrawVerticalLine(gfx, currentY, currentY + maxRowHeight, currentX); // Loại SP
                            currentX += rongLoaiSanPham;
                            DrawVerticalLine(gfx, currentY, currentY + maxRowHeight, currentX); // Nhà SX
                            currentX += rongNhaSanXuat;
                            DrawVerticalLine(gfx, currentY, currentY + maxRowHeight, currentX); // Quy Cách
                            currentX += rongQuyCach;
                            DrawVerticalLine(gfx, currentY, currentY + maxRowHeight, currentX); // Xuất Xứ
                            currentX += rongXuatXu;
                            DrawVerticalLine(gfx, currentY, currentY + maxRowHeight, currentX); // Kê Toa
                            currentX += rongKeToa;
                            DrawVerticalLine(gfx, currentY, currentY + maxRowHeight, currentX); // Số Lượng
                            currentX += rongSoLuong;
                            DrawVerticalLine(gfx, currentY, currentY + maxRowHeight, currentX); // Trạng Thái

                            // Vẽ từng dòng dữ liệu
                            gfx.DrawRectangle(XPens.Black, startX, currentY, totalWidth, maxRowHeight);
                            gfx.DrawString(item.MaSP, rowFont, XBrushes.Black, new XRect(startX, currentY, rongMaSp, rowHeight), XStringFormats.Center);
                            DrawText(gfx, tenSPLines, rowFont, new XRect(startX + rongMaSp, currentY, rongTenSP, maxRowHeight));
                            gfx.DrawString(item.LoaiSP, rowFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP, currentY, rongLoaiSanPham, rowHeight), XStringFormats.Center);
                            gfx.DrawString(item.NhaSanXuat, rowFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham, currentY, rongNhaSanXuat, rowHeight), XStringFormats.Center);
                            gfx.DrawString(item.QuyCach, rowFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat, currentY, rongQuyCach, rowHeight), XStringFormats.Center);
                            gfx.DrawString(item.XuatXu, rowFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach, currentY, rongXuatXu, rowHeight), XStringFormats.Center);
                            gfx.DrawString(item.CanKeToa ? "Cần Kê Toa" : "Không Kê Toa", rowFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach + rongXuatXu, currentY, rongKeToa, rowHeight), XStringFormats.Center);
                            gfx.DrawString(soLuongSanPham.ToString(), rowFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach + rongXuatXu + rongKeToa, currentY, rongSoLuong, rowHeight), XStringFormats.Center);
                            gfx.DrawString(item.TrangThai ? "Đang bán" : "Nghỉ bán", rowFont, XBrushes.Black, new XRect(startX + rongMaSp + rongTenSP + rongLoaiSanPham + rongNhaSanXuat + rongQuyCach + rongXuatXu + rongKeToa + rongSoLuong, currentY, rongTrangThai, rowHeight), XStringFormats.Center);

                            // Vẽ đường ngang dưới dòng
                            DrawHorizontalLine(gfx, startX, startX + totalWidth, currentY + maxRowHeight);

                            currentY += maxRowHeight;
                        }
                        document.Save(filePath);
                        MessageBox.Show($"Xuất file PDF thành công: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private string[] WrapText(XGraphics gfx, string text, XFont font, double maxWidth)
        {
            List<string> lines = new List<string>();
            string[] words = text.Split(' ');

            string currentLine = "";
            foreach (var word in words)
            {
                string testLine = string.IsNullOrEmpty(currentLine) ? word : currentLine + " " + word;
                if (gfx.MeasureString(testLine, font).Width > maxWidth)
                {
                    lines.Add(currentLine);
                    currentLine = word;
                }
                else
                {
                    currentLine = testLine;
                }
            }
            if (!string.IsNullOrEmpty(currentLine))
            {
                lines.Add(currentLine);
            }
            return lines.ToArray();
        }

        private void DrawText(XGraphics gfx, string[] lines, XFont font, XRect rect)
        {
            double lineHeight = gfx.MeasureString("A", font).Height;
            double startY = rect.Y;

            foreach (var line in lines)
            {
                gfx.DrawString(line, font, XBrushes.Black, new XRect(rect.X, startY, rect.Width, lineHeight), XStringFormats.TopLeft);
                startY += lineHeight;
            }
        }
        private void DrawHorizontalLine(XGraphics gfx, double startX, double endX, double y)
        {
            gfx.DrawLine(XPens.Black, startX, y, endX, y);
        }
        private void DrawVerticalLine(XGraphics gfx, double yStart, double yEnd, double x)
        {
            gfx.DrawLine(XPens.Black, x, yStart, x, yEnd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                DialogResult result1 = MessageBox.Show($"Bạn chắc chắn muốn nhập File: '{Path.GetFileName(filePath)}'?",
                                                       "Xác nhận",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    // Đọc dữ liệu từ tệp Excel
                    using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
                    {
                        // Đặt cấu hình cho ExcelDataReader
                        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                        using (var reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            // Đọc dữ liệu thành DataSet
                            var result = reader.AsDataSet();

                            // Giả sử dữ liệu nằm trong bảng đầu tiên (Sheet1)
                            DataTable dataTable = result.Tables[0];

                            HashSet<string> existingProducts = new HashSet<string>();
                            // Lấy danh sách sản phẩm đã tồn tại trong cơ sở dữ liệu
                            List<SanPhamDTO> products = SanPhamBUS.Instance.GetAllProducts();

                            // Lưu tất cả mã sản phẩm đã có vào HashSet
                            foreach (var sp in products)
                            {
                                existingProducts.Add(sp.MaSP);
                            }

                            // Bỏ qua dòng đầu tiên (header)
                            foreach (DataRow row in dataTable.Rows.Cast<DataRow>().Skip(1))
                            {
                                string maSP = row[0].ToString();
                                string tenSP = row[1].ToString();
                                string loaiSP = row[2].ToString();
                                string nhaSX = row[3].ToString();
                                string QuyCach = row[4].ToString();
                                string XuatXu = row[5].ToString();
                                string KeToa = row[6].ToString();
                                string TrangThai = row[8].ToString();
                                bool checkKeToa = KeToa.Trim().ToLower() == "cần kê toa";
                                bool checkTrangThai = TrangThai.Trim().ToLower() == "đang bán";

                                // Kiểm tra mã sản phẩm có trùng không
                                if (!existingProducts.Contains(maSP))
                                {
                                    // Nếu không trùng, thực hiện thêm sản phẩm
                                    SanPhamBUS.Instance.InsertProduct(maSP, tenSP, loaiSP, nhaSX, QuyCach, XuatXu, checkKeToa, checkTrangThai);

                                    // Thêm mã sản phẩm mới vào danh sách kiểm tra
                                    existingProducts.Add(maSP);
                                    sum++;
                                }
                                btnResetSanPham_Click(sender, e);
                            }
                            if (sum == 0) {
                                MessageBox.Show($"Lỗi dữ liệu , không có sản phẩm nào được thêm");

                            }
                            else
                            {
                                MessageBox.Show($"Đã thêm thành công {sum} sản phẩm");
                            }

                        }
                    }
                }
            }
        }
    }
}
