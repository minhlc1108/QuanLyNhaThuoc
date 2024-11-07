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
    public partial class FormChiTietHoaDon : Form
    {
        string maHoaDon = "";
        List<ChiTietHoaDonDTO> listCTHD = ChiTietHoaDonBUS.Instance.GetAllChiTietHoaDon();
        List<ChiTietSanPhamDTO> listCTSP = ChiTietSanPhamBUS.Instance.GetAllCTSP();
        List<SanPhamDTO> listSP = SanPhamBUS.Instance.GetAllProducts();
        public FormChiTietHoaDon(string mahd)
        {
            InitializeComponent();
            maHoaDon = mahd;
            loadData();
        }

        private void loadData()
        {
            List<HoaDonDTO> listHoaDon = HoaDonBUS.Instance.GetAllHoaDon();
            foreach (HoaDonDTO hoaDon in listHoaDon)
            {
                if (hoaDon.MaHD == maHoaDon)
                {
                    tb_mahd.Text = hoaDon.MaHD;
                    tb_ngayLap.Text = hoaDon.NgayLap.ToString("dd/MM/yyyy");
                    tb_nguoiLap.Text = hoaDon.NguoiLap;
                    tb_toaThuoc.Text = hoaDon.ToaThuoc;
                    tb_tongTien.Text = string.Format("{0:0,0}", hoaDon.TongTien);
                    tb_diemTichLuy.Text = hoaDon.DiemTichLuy.ToString();

                    KhachHangDTO kh = KhachHangBUS.Instance.GetKhachHangByMaKH(hoaDon.KhachHangID);
                    if (kh != null)
                    {
                        tb_makh.Text = kh.MaKH.ToString();
                        tb_hoTen.Text = kh.HoTen;
                        tb_ngaySinh.Text = kh.NgaySinh.ToString("dd/MM/yyyy");
                        tb_gioiTinh.Text = kh.GioiTinh.ToString();
                        tb_sdt.Text = kh.SoDT.ToString();
                        tb_dtlKH.Text = kh.Diem.ToString();
                    }

                    lv_CTHD.Items.Clear();
                    int stt = 1;

                    foreach (ChiTietHoaDonDTO cthd in listCTHD)
                    {
                        if (cthd.MaHD == maHoaDon)
                        {
                            foreach (ChiTietSanPhamDTO ctsp in listCTSP)
                            {
                                if (cthd.MaCT == ctsp.MaCT)
                                {
                                    foreach (SanPhamDTO sp in listSP)
                                    {
                                        if (sp.MaSP == ctsp.MaSP)
                                        {
                                            ListViewItem item = new ListViewItem(stt.ToString());
                                            item.SubItems.Add(sp.MaSP);
                                            item.SubItems.Add(sp.TenSP);
                                            item.SubItems.Add(cthd.GiaBan.ToString());
                                            item.SubItems.Add(cthd.SoLuong.ToString());
                                            lv_CTHD.Items.Add(item);
                                            stt++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        // Hàm hỗ trợ để vẽ chuỗi với khả năng xuống dòng và trả về chiều cao thực tế của nội dung
        private double DrawStringMultiline(XGraphics gfx, string text, XFont font, XBrush brush, XPoint point, double maxWidth)
        {
            double lineHeight = font.Size + 5; // Chiều cao mỗi dòng
            string[] words = text.Split(' ');
            string line = "";
            double yPosition = point.Y;
            int lineCount = 0;

            foreach (var word in words)
            {
                // Thử thêm từ vào dòng hiện tại
                string testLine = string.IsNullOrEmpty(line) ? word : line + " " + word;
                XSize size = gfx.MeasureString(testLine, font);

                // Nếu chiều rộng dòng vượt quá maxWidth, xuống dòng
                if (size.Width > maxWidth)
                {
                    gfx.DrawString(line, font, brush, new XPoint(point.X, yPosition));
                    yPosition += lineHeight;
                    lineCount++;
                    line = word;
                }
                else
                {
                    line = testLine;
                }
            }
            // Vẽ dòng cuối cùng
            gfx.DrawString(line, font, brush, new XPoint(point.X, yPosition));
            lineCount++;

            // Trả về chiều cao thực tế của ô dựa trên số dòng
            return lineHeight * lineCount;
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xuất File PDF", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                // Đường dẫn cơ bản cho file PDF
                string baseFilePath = @$"D:\dataCSharp\FliePdfChiTietHoaDon\XuatCthdPdf_{tb_mahd.Text}.pdf";
                string filePath = baseFilePath;

                // Kiểm tra và tạo tên file mới nếu đã tồn tại
                int counter = 1;
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(
                        Path.GetDirectoryName(baseFilePath),
                        $"{Path.GetFileNameWithoutExtension(baseFilePath)}_{counter}.pdf"
                    );
                    counter++;
                }

                    // Tạo tài liệu PDF
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Created with PDFsharp";

                // Tạo trang đầu tiên
                PdfPage page = document.AddPage();
                page.Width = XUnit.FromMillimeter(200); // Chiều rộng tùy chỉnh (Ví dụ: 420 mm tương đương với A3)
                page.Height = XUnit.FromMillimeter(297); // Chiều cao tùy chỉnh (297 mm)
                XGraphics gfx = XGraphics.FromPdfPage(page);

                double rowHeight = 30;      // Chiều cao mỗi dòng
                double pageHeight = page.Height.Point;  // Chiều cao tối đa của trang PDF

                int rongStt = 40;
                int rongMakh = 54;
                int rongHoTen = 250;
                int rongNgaySinh = 80;
                int rongGt = 50;

                int vtSTT = 0;
                int vtMakh = vtSTT + rongStt;
                int vtHoTen = vtMakh + rongMakh;
                int vtNgaySinh = vtHoTen + rongHoTen;
                int vtGioiTinh = vtNgaySinh + rongNgaySinh;

                // Vẽ tiêu đề trang và tiêu đề bảng trên trang đầu tiên
                XFont titleFont = new XFont("Verdana", 22);
                XFont titleFont1 = new XFont("Verdana", 10);
                gfx.DrawString("CHI TIẾT HOÁ ĐƠN", titleFont, XBrushes.Black, new XPoint(180, 30));
                string formattedDate = "Ngày " + DateTime.Parse(tb_ngayLap.Text).ToString("dd 'tháng' MM 'năm' yyyy");
                gfx.DrawString(formattedDate, titleFont1, XBrushes.Black, new XPoint(215, 50));
                gfx.DrawString(tb_mahd.Text, new XFont("Verdana", 8), XBrushes.Black, new XPoint(275, 65));

                XFont headerFont = new XFont("Verdana", 12);
                gfx.DrawString("Người lập : ", headerFont, XBrushes.Black, new XPoint(20, 110));
                gfx.DrawString("Toa thuốc : ", headerFont, XBrushes.Black, new XPoint(20, 130));
                gfx.DrawString("Điểm tích luỹ : ", headerFont, XBrushes.Black, new XPoint(20, 150));
                string hotenDS = DuocSiBUS.Instance.getHoTenDuocSi(tb_nguoiLap.Text);
                gfx.DrawString(hotenDS, titleFont1, XBrushes.Black, new XPoint(88, 110));
                gfx.DrawString(tb_toaThuoc.Text, titleFont1, XBrushes.Black, new XPoint(90, 130));
                gfx.DrawString(tb_diemTichLuy.Text, titleFont1, XBrushes.Black, new XPoint(112, 150));
                gfx.DrawRectangle(XPens.Black, 20, 160, 525, 0.5);
                gfx.DrawString("Khách hàng : ", headerFont, XBrushes.Black, new XPoint(20, 180));
                gfx.DrawString("Số điện thoại : ", headerFont, XBrushes.Black, new XPoint(20, 200));
                gfx.DrawString("Ngày sinh : ", headerFont, XBrushes.Black, new XPoint(20, 220));
                gfx.DrawString("Giới tính : ", headerFont, XBrushes.Black, new XPoint(430, 200));
                gfx.DrawString("Điểm tích luỹ : ", headerFont, XBrushes.Black, new XPoint(430, 220));
                KhachHangDTO kh = KhachHangBUS.Instance.GetKhachHangByMaKH(int.Parse(tb_makh.Text));
                gfx.DrawString(kh.HoTen, titleFont1, XBrushes.Black, new XPoint(103, 180));
                gfx.DrawString(tb_sdt.Text, titleFont1, XBrushes.Black, new XPoint(110, 200));
                gfx.DrawString(tb_ngaySinh.Text, titleFont1, XBrushes.Black, new XPoint(93, 220));
                gfx.DrawString(tb_gioiTinh.Text, titleFont1, XBrushes.Black, new XPoint(494, 200));
                gfx.DrawString(tb_dtlKH.Text, titleFont1, XBrushes.Black, new XPoint(521, 220));
                gfx.DrawRectangle(XPens.Black, 20, 230, 525, 0.5);


                gfx.DrawString("STT", headerFont, XBrushes.Black, new XPoint(20, 250));
                gfx.DrawString("MaSP", headerFont, XBrushes.Black, new XPoint(60, 250));
                gfx.DrawString("Tên sản phẩm", headerFont, XBrushes.Black, new XPoint(120, 250));
                gfx.DrawString("Giá bán", headerFont, XBrushes.Black, new XPoint(470, 250));
                gfx.DrawString("SL", headerFont, XBrushes.Black, new XPoint(530, 250));


                //Vị trí bắt đầu vẽ các dòng dữ liệu
                int yPosition = 270;
                int khoangCachDOng = 20;
                List<KhachHangDTO> listKHXuatFile = KhachHangBUS.Instance.GetAllKhachHang();
                int stt = 1;

                foreach (ChiTietHoaDonDTO cthd in listCTHD)
                {
                    if (cthd.MaHD == maHoaDon)
                    {
                        foreach (ChiTietSanPhamDTO ctsp in listCTSP)
                        {
                            if (cthd.MaCT == ctsp.MaCT)
                            {
                                foreach (SanPhamDTO sp in listSP)
                                {
                                    if (sp.MaSP == ctsp.MaSP)
                                    {
                                    // Xử lý từng ô dữ liệu với hàm `DrawStringMultiline`
                                        DrawStringMultiline(gfx, stt.ToString(), new XFont("Verdana", 11), XBrushes.Black, new XPoint(25, yPosition), rongStt);
                                        DrawStringMultiline(gfx, sp.MaSP, new XFont("Verdana", 11), XBrushes.Black, new XPoint(55, yPosition), rongMakh);
                                        DrawStringMultiline(gfx, sp.TenSP, new XFont("Verdana", 11), XBrushes.Black, new XPoint(120, yPosition), 340);
                                        DrawStringMultiline(gfx, cthd.GiaBan.ToString(), new XFont("Verdana", 11), XBrushes.Black, new XPoint(470, yPosition), rongNgaySinh);
                                        DrawStringMultiline(gfx, cthd.SoLuong.ToString(), new XFont("Verdana", 11), XBrushes.Black, new XPoint(530, yPosition), rongGt);

                                        yPosition += 35;
                                        stt++;
                                    }
                                }
                            }
                        }
                    }
                }

                gfx.DrawRectangle(XPens.Black, 20, yPosition - 10, 525, 0.5);
                gfx.DrawString($"Thanh toán : {tb_tongTien.Text}", headerFont, XBrushes.Black, new XPoint(400, yPosition + 10));

                // Lưu tài liệu
                document.Save(filePath);
                if (File.Exists(filePath))
                {
                    MessageBox.Show($"Xuất File {filePath} thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xuất file thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
