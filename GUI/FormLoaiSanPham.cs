using BUS;
using DTO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
                DialogResult result = MessageBox.Show("Bạn muốn thêm loại sản phẩm  này?", "Xác nhận thêm loại sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes && checkMaSP())
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
            btnResetLSP_Click(sender, e);
        }
        private bool checkMaSP()
        {
            List<LoaiSanPhamDTO> list = LoaiSanPhamBUS.Instance.GetAllLoaiSanPham();
            foreach (LoaiSanPhamDTO loaiSP in list)
            {
                if (loaiSP.MaLoai.Trim() == txtMaLoaiSP.Text.Trim())
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
        public bool ValidateInputs(string tenloai, string maloai)
        {
            bool ktra = true;
            if (string.IsNullOrWhiteSpace(tenloai) || string.IsNullOrWhiteSpace(maloai))
            {
                MessageBox.Show("Không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
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
                    bool successDelDuocSi = LoaiSanPhamBUS.Instance.UpdateTrangThaiLoaiSanPham(maLoaiSP, false);
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
            btnResetLSP_Click(sender, e);
        }

        private void txtMaLoaiSP_TextChanged(object sender, EventArgs e)
        {

        }

        private List<ListViewItem> listTimKiem = new List<ListViewItem>();

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                btnResetLSP_Click(sender, e);
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
                LoadLoaiSPData();
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
            foreach (ListViewItem item in lsvLoaiSanPham.Items)
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

            lsvLoaiSanPham.Items.Clear();
            lsvLoaiSanPham.Items.AddRange(listTimKiem.ToArray());
            listTimKiem.Clear();


        }
        private void PerformOrSearch(string[] keywords)
        {
            foreach (ListViewItem item in lsvLoaiSanPham.Items)
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
            lsvLoaiSanPham.Items.Clear();
            lsvLoaiSanPham.Items.AddRange(listTimKiem.ToArray());
            listTimKiem.Clear();
        }

        private void PerformAndSearch(string[] keywords)
        {
            foreach (ListViewItem item in lsvLoaiSanPham.Items)
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
            lsvLoaiSanPham.Items.Clear();
            lsvLoaiSanPham.Items.AddRange(listTimKiem.ToArray());
            listTimKiem.Clear();
        }


        private void btnXuatLSP_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xuất File PDF?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Lưu file PDF";
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "DanhSachLoaiSanPham.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        PdfDocument document = new PdfDocument();
                        document.Info.Title = "Danh sách Loại Sản Phẩm";

                        PdfPage page = document.AddPage();
                        page.Orientation = PdfSharp.PageOrientation.Landscape;
                        page.Size = PdfSharp.PageSize.A4;
                        XGraphics gfx = XGraphics.FromPdfPage(page);

                        double rowHeight = 25; // Chiều cao cơ bản cho mỗi dòng
                        double startY = 100;   // Vị trí bắt đầu của bảng
                        double currentY = startY;

                        int colSTT = 50;
                        int colMaLoai = 100;
                        int colTen = 200;
                        int colTrangThai = 100;
                        int totalWidth = colSTT + colMaLoai + colTen + colTrangThai;

                        double startX = (page.Width.Point - totalWidth) / 2;

                        XFont titleFont = new XFont("Verdana", 16);
                        XFont headerFont = new XFont("Verdana", 10);
                        XFont rowFont = new XFont("Verdana", 10);

                        // Vẽ tiêu đề
                        gfx.DrawString("DANH SÁCH LOẠI SẢN PHẨM", titleFont, XBrushes.Black, new XRect(0, 50, page.Width, 30), XStringFormats.TopCenter);

                        // Vẽ tiêu đề cột
                        gfx.DrawRectangle(XPens.Black, startX, currentY, totalWidth, rowHeight);
                        gfx.DrawString("STT", headerFont, XBrushes.Black, new XRect(startX, currentY, colSTT, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Mã Loại", headerFont, XBrushes.Black, new XRect(startX + colSTT, currentY, colMaLoai, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Tên", headerFont, XBrushes.Black, new XRect(startX + colSTT + colMaLoai, currentY, colTen, rowHeight), XStringFormats.Center);
                        gfx.DrawString("Trạng Thái", headerFont, XBrushes.Black, new XRect(startX + colSTT + colMaLoai + colTen, currentY, colTrangThai, rowHeight), XStringFormats.Center);

                        currentY += rowHeight;

                        // Lấy danh sách loại sản phẩm
                        List<LoaiSanPhamDTO> listLoaiSanPham = LoaiSanPhamBUS.Instance.GetAllLoaiSanPham();
                        int stt = 1;

                        foreach (var item in listLoaiSanPham)
                        {
                            // Nếu vị trí vượt chiều cao trang, tạo trang mới
                            if (currentY + rowHeight > page.Height.Point - 50)
                            {
                                page = document.AddPage();
                                page.Orientation = PdfSharp.PageOrientation.Landscape;
                                page.Size = PdfSharp.PageSize.A4;
                                gfx = XGraphics.FromPdfPage(page);
                                currentY = startY;

                                // Vẽ lại tiêu đề bảng khi tạo trang mới
                                gfx.DrawRectangle(XPens.Black, startX, currentY, totalWidth, rowHeight);
                                gfx.DrawString("STT", headerFont, XBrushes.Black, new XRect(startX, currentY, colSTT, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Mã Loại", headerFont, XBrushes.Black, new XRect(startX + colSTT, currentY, colMaLoai, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Tên", headerFont, XBrushes.Black, new XRect(startX + colSTT + colMaLoai, currentY, colTen, rowHeight), XStringFormats.Center);
                                gfx.DrawString("Trạng Thái", headerFont, XBrushes.Black, new XRect(startX + colSTT + colMaLoai + colTen, currentY, colTrangThai, rowHeight), XStringFormats.Center);

                                currentY += rowHeight;
                            }

                            // Vẽ dòng dữ liệu
                            gfx.DrawRectangle(XPens.Black, startX, currentY, totalWidth, rowHeight);
                            gfx.DrawString(stt.ToString(), rowFont, XBrushes.Black, new XRect(startX, currentY, colSTT, rowHeight), XStringFormats.Center);
                            gfx.DrawString(item.MaLoai, rowFont, XBrushes.Black, new XRect(startX + colSTT, currentY, colMaLoai, rowHeight), XStringFormats.Center);
                            gfx.DrawString(item.TenLoai, rowFont, XBrushes.Black, new XRect(startX + colSTT + colMaLoai, currentY, colTen, rowHeight), XStringFormats.Center);
                            gfx.DrawString(item.TrangThai ? "Đang Bán" : "Nghỉ Bán", rowFont, XBrushes.Black, new XRect(startX + colSTT + colMaLoai + colTen, currentY, colTrangThai, rowHeight), XStringFormats.Center);

                            currentY += rowHeight;
                            stt++;
                        }

                        document.Save(filePath);
                        MessageBox.Show($"Xuất file PDF thành công: {filePath}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        
    }
}
