using BUS;
using DTO;
using ExcelDataReader;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using Org.BouncyCastle.Asn1.Pkcs;
using PdfSharp;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class FormNhaCungCap : Form
    {
        private string paramCbbFind;
        public FormNhaCungCap()
        {
            InitializeComponent();
            LoadNCCData();
            LoadDuLieu();
            // xử lý dataFind từ cbb_find
            if (cbb_find.Items.Count > 0)
            {
                paramCbbFind = cbb_find.Items[0].ToString();
            }
        }
        private void lv_qlncc_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string maDS = e.Item.SubItems[1].Text;
                string hoTen = e.Item.SubItems[2].Text;
                string diachi = e.Item.SubItems[3].Text;
                string sdt = e.Item.SubItems[4].Text;
                string email = e.Item.SubItems[5].Text;
                string trangThai = e.Item.SubItems[6].Text;

                tb_maNcc.Text = maDS;
                tb_tenNcc.Text = hoTen;
                tb_diaChi.Text = diachi;
                tb_email.Text = email;
                tb_sdt.Text = sdt;

                if (trangThai.Equals("Còn hợp tác"))
                {
                    btn_lock.Enabled = true;
                    btn_opLock.Enabled = false;
                }
                else
                {
                    btn_lock.Enabled = false;
                    btn_opLock.Enabled = true;
                }
                // xử lý label & button
                btn_add.Enabled = false;
                btn_del.Enabled = true;
                btn_edit.Enabled = true;
            }
        }

        private void LoadNCCData()
        {
            List<NhaCungCapDTO> nhaCungCapList = NhaCungCapBUS.Instance.GetAllNhaCungCap();
            handleDataView(nhaCungCapList);

        }
        private void LoadDuLieu()
        {
            string lastMaNCC = NhaCungCapBUS.Instance.GetLastMaNCC();
            string prefix = lastMaNCC.Substring(0, 3);
            string numberPart = lastMaNCC.Substring(3);

            int nextNumber = int.Parse(numberPart) + 1;

            string newMaNCC = prefix + nextNumber.ToString("D4");
            tb_maNcc.Text = newMaNCC;

        }

        private void upTrangThai(bool trangthai)
        {
            string mancc = tb_maNcc.Text;

            DialogResult result = MessageBox.Show("Bạn muốn thay đổi trạng thái NCC này", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool successUpTT = NhaCungCapBUS.Instance.UpdateTrangThaiNhaCungCap(mancc, trangthai);
                if (successUpTT)
                {
                    MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
        }

        private void reset()
        {
            tb_tenNcc.Text = "";
            tb_diaChi.Text = "";
            tb_email.Text = "";
            tb_sdt.Text = "";
            tb_find.Text = "";
            cbb_find.SelectedIndex = 0;
            cbb_ttFind.SelectedIndex = 0;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
            btn_lock.Enabled = false;
            btn_opLock.Enabled = false;
            btn_add.Enabled = true;
            LoadDuLieu();
            LoadNCCData();
        }

        public bool ValidateInputs(string hoTen, string diaChi, string sodt, string email)
        {
            bool ktra = true;
            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(sodt) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (!email.EndsWith("@gmail.com"))
                {
                    erorr_email.Text = "Email không hợp lệ!";
                    ktra = false;
                }
                else
                {
                    erorr_email.Text = "";
                }
            }
            return ktra;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {
            upTrangThai(false);
        }

        private void btn_opLock_Click(object sender, EventArgs e)
        {
            upTrangThai(true);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string mads = tb_maNcc.Text;
            string hoTen = tb_tenNcc.Text;
            string diaChi = tb_diaChi.Text;
            string sodt = tb_sdt.Text;
            string email = tb_email.Text;

            if (ValidateInputs(hoTen, diaChi, sodt, email))
            {
                DialogResult result = MessageBox.Show("Bạn muốn thêm NCC này?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool successAddNCC = NhaCungCapBUS.Instance.InsertNhaCungCap(mads, hoTen, diaChi, sodt, email, true);
                    if (successAddNCC)
                    {
                        MessageBox.Show("Thêm NCC thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Thêm NCC thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string mads = tb_maNcc.Text;
            string hoTen = tb_tenNcc.Text;
            string diaChi = tb_diaChi.Text;
            string sodt = tb_sdt.Text;
            string email = tb_email.Text;

            if (ValidateInputs(hoTen, diaChi, sodt, email))
            {
                DialogResult result = MessageBox.Show("Bạn muốn cập nhật NCC này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool successUpNCC = NhaCungCapBUS.Instance.UpdateNhaCungCap(mads, hoTen, diaChi, sodt, email);
                    if (successUpNCC)
                    {
                        MessageBox.Show("Cập nhật NCC thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật NCC thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            string mancc = tb_maNcc.Text;

            DialogResult result = MessageBox.Show($"Bạn muốn xóa NCC có MaNCC = {mancc}?", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool successDelNCC = NhaCungCapBUS.Instance.DeleteNhaCungCap(mancc);
                if (successDelNCC)
                {
                    MessageBox.Show("Xoá NCC thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
        }

        private void LoadNCCData_Find(string theLoaiFind, string dataFind, bool trangThai)
        {
            List<NhaCungCapDTO> nhaCungCapListFind = new List<NhaCungCapDTO>();
            if (theLoaiFind == "FindTrangThai")
            {
                nhaCungCapListFind = NhaCungCapBUS.Instance.GetNhaCungCapByTrangThai(trangThai);
            }
            else
            {
                string param = "";
                if (paramCbbFind == "Mã NCC")
                {
                    param = "mancc";
                }
                else if (paramCbbFind == "Tên NCC")
                {
                    param = "tenncc";
                }
                else if (paramCbbFind == "Địa chỉ")
                {
                    param = "diachi";
                }
                else if (paramCbbFind == "SĐT")
                {
                    param = "sodt";
                }
                else if (paramCbbFind == "Email")
                {
                    param = "email";
                }

                bool? trangthai = null;

                if (cbb_ttFind.Text == "Còn hợp tác")
                {
                    trangthai = true;
                }
                else if (cbb_ttFind.Text == "Hết hợp tác")
                {
                    trangthai = false;
                }
                else if (cbb_ttFind.Text == "Tất cả")
                {
                    trangthai = null;
                }
                nhaCungCapListFind = NhaCungCapBUS.Instance.FindNhaCungCap(param, dataFind, trangthai);
            }
            handleDataView(nhaCungCapListFind);
        }

        private void handleDataView(List<NhaCungCapDTO> arr)
        {
            lv_qlncc.Items.Clear();

            int stt = 1;

            foreach (NhaCungCapDTO nhaCungCap in arr)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(nhaCungCap.MaNCC);
                item.SubItems.Add(nhaCungCap.TenNCC);
                item.SubItems.Add(nhaCungCap.DiaChi);
                item.SubItems.Add(nhaCungCap.SoDT);
                item.SubItems.Add(nhaCungCap.Email);

                if (nhaCungCap.TrangThai == true)
                {
                    item.SubItems.Add("Còn hợp tác");
                }
                else
                {
                    item.SubItems.Add("Hết hợp tác");
                }
                lv_qlncc.Items.Add(item);

                stt++;
            }
        }

        private void cbb_ttFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbb_ttFind.SelectedItem.ToString();
            if (selectedItem == "Còn hợp tác")
            {
                LoadNCCData_Find("FindTrangThai", "", true);

            }
            else if (selectedItem == "Hết hợp tác")
            {
                LoadNCCData_Find("FindTrangThai", "", false);
            }
            else
            {
                LoadNCCData();
            }
        }

        private void cbb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            paramCbbFind = cbb_find.SelectedItem.ToString();
        }

        private void tb_find_TextChanged(object sender, EventArgs e)
        {
            string dataFind = tb_find.Text;
            LoadNCCData_Find("FindByParam", dataFind, true);
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                DialogResult result1 = MessageBox.Show($"Bạn chắc chắn muốn nhập File: '{Path.GetFileName(filePath)}'?", "Xác nhận",
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

                            bool isHeaderValid = true;

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string tenNcc = row[0].ToString();
                                string diaChi = row[1].ToString();
                                string soDT = row[2].ToString();
                                string email = row[3].ToString();

                                if (row == dataTable.Rows[0])
                                {
                                    if (tenNcc != "Tên nhà cung cấp" || diaChi != "Địa chỉ" || soDT != "Số điện thoại" || email != "Email")
                                    {
                                        isHeaderValid = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (isHeaderValid)
                                    {
                                        string lastMaNCC = NhaCungCapBUS.Instance.GetLastMaNCC();
                                        string prefix = lastMaNCC.Substring(0, 3);
                                        string numberPart = lastMaNCC.Substring(3);

                                        int nextNumber = int.Parse(numberPart) + 1;

                                        string newMaNCC = prefix + nextNumber.ToString("D4");

                                        NhaCungCapBUS.Instance.InsertNhaCungCap(newMaNCC, tenNcc, diaChi, soDT, email, true);
                                    }
                                }
                            }
                            if (isHeaderValid == false)
                            {
                                MessageBox.Show("File excel không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Nhập Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadNCCData();
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
                string baseFilePath = @"D:\dataCSharp\FilePdfNCC\XuatNCCPdf.pdf";
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
                page.Width = XUnit.FromMillimeter(377); // Chiều rộng tùy chỉnh (Ví dụ: 420 mm tương đương với A3)
                page.Height = XUnit.FromMillimeter(297); // Chiều cao tùy chỉnh (297 mm)
                XGraphics gfx = XGraphics.FromPdfPage(page);

                int rowHeight = 30;      // Chiều cao mỗi dòng
                double pageHeight = page.Height.Point;  // Chiều cao tối đa của trang PDF

                int rongStt = 35;
                int rongMakh = 65;
                int rongHoTen = 300;
                int rongNgaySinh = 280;
                int rongGt = 210;
                int rongSdt = 90;
                int rongDiem = 86;

                int vtSTT = 0;
                int vtMakh = vtSTT + rongStt;
                int vtHoTen = vtMakh + rongMakh;
                int vtNgaySinh = vtHoTen + rongHoTen;
                int vtGioiTinh = vtNgaySinh + rongNgaySinh;
                int vtSDT = vtGioiTinh + rongGt;
                int vtDiem = vtSDT + rongSdt;

                // Vẽ tiêu đề trang và tiêu đề bảng trên trang đầu tiên
                XFont titleFont = new XFont("Verdana", 22);
                gfx.DrawString("Danh sách nhà cung cấp", titleFont, XBrushes.Black, new XPoint(400, 30));

                XFont headerFont = new XFont("Verdana", 12);
                gfx.DrawString("STT", headerFont, XBrushes.Black, new XPoint(5, 65));
                gfx.DrawRectangle(XPens.Black, vtSTT, 44, rongStt, rowHeight);
                gfx.DrawString("MaNCC", headerFont, XBrushes.Black, new XPoint(48, 65));
                gfx.DrawRectangle(XPens.Black, vtMakh, 44, rongMakh, rowHeight);
                gfx.DrawString("Tên nhà cung cấp", headerFont, XBrushes.Black, new XPoint(107, 65));
                gfx.DrawRectangle(XPens.Black, vtHoTen, 44, rongHoTen, rowHeight);
                gfx.DrawString("Địa chỉ", headerFont, XBrushes.Black, new XPoint(405, 65));
                gfx.DrawRectangle(XPens.Black, vtNgaySinh, 44, rongNgaySinh, rowHeight);
                gfx.DrawString("Email", headerFont, XBrushes.Black, new XPoint(690, 65));
                gfx.DrawRectangle(XPens.Black, vtGioiTinh, 44, rongGt, rowHeight);
                gfx.DrawString("SĐT", headerFont, XBrushes.Black, new XPoint(895, 65));
                gfx.DrawRectangle(XPens.Black, vtSDT, 44, rongSdt, rowHeight);
                gfx.DrawString("TT", headerFont, XBrushes.Black, new XPoint(1010, 65));
                gfx.DrawRectangle(XPens.Black, vtDiem, 44, rongDiem, rowHeight);

                // Vị trí bắt đầu vẽ các dòng dữ liệu
                double yPosition = 92;
                int khoangCachDOng = 18;
                List<NhaCungCapDTO> listKNCCXuatFile = NhaCungCapBUS.Instance.GetAllNhaCungCap();
                int stt = 1;

                foreach (var item in listKNCCXuatFile)
                {
                    // Nếu vị trí y vượt quá chiều cao trang, thêm trang mới mà không vẽ lại tiêu đề
                    if (yPosition > pageHeight - rowHeight)
                    {
                        page = document.AddPage();
                        page.Width = XUnit.FromMillimeter(377);
                        page.Height = XUnit.FromMillimeter(297); // Chiều cao tùy chỉnh (297 mm)
                        gfx = XGraphics.FromPdfPage(page);
                        yPosition = 30;  // Đặt lại vị trí y trên trang mới
                    }

                    double maxCellHeight = rowHeight;
                    // Vẽ các ô dữ liệu và tính toán chiều cao của chúng dựa trên nội dung
                    double cellHeight;

                    // Xử lý từng ô dữ liệu với hàm `DrawStringMultiline`
                    cellHeight = DrawStringMultiline(gfx, stt.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(10, yPosition), rongStt);
                    maxCellHeight = Math.Max(maxCellHeight, cellHeight);

                    cellHeight = DrawStringMultiline(gfx, item.MaNCC, new XFont("Verdana", 12), XBrushes.Black, new XPoint(40, yPosition), rongMakh);
                    maxCellHeight = Math.Max(maxCellHeight, cellHeight);

                    cellHeight = DrawStringMultiline(gfx, item.TenNCC, new XFont("Verdana", 12), XBrushes.Black, new XPoint(107, yPosition), rongHoTen);
                    maxCellHeight = Math.Max(maxCellHeight, cellHeight) + 10;

                    cellHeight = DrawStringMultiline(gfx, item.DiaChi, new XFont("Verdana", 12), XBrushes.Black, new XPoint(405, yPosition), rongNgaySinh);
                    maxCellHeight = Math.Max(maxCellHeight, cellHeight);

                    cellHeight = DrawStringMultiline(gfx, item.Email, new XFont("Verdana", 12), XBrushes.Black, new XPoint(690, yPosition), rongGt);
                    maxCellHeight = Math.Max(maxCellHeight, cellHeight);

                    cellHeight = DrawStringMultiline(gfx, item.SoDT, new XFont("Verdana", 12), XBrushes.Black, new XPoint(895, yPosition), rongSdt);
                    maxCellHeight = Math.Max(maxCellHeight, cellHeight);

                    string tt = "";
                    if (item.TrangThai)
                    {
                        tt = "Còn hợp tác";
                    }
                    else
                    {
                        tt = "Hết hợp tác";
                    }
                    cellHeight = DrawStringMultiline(gfx, tt, new XFont("Verdana", 12), XBrushes.Black, new XPoint(985, yPosition), rongDiem);
                    maxCellHeight = Math.Max(maxCellHeight, cellHeight);

                    // Vẽ các đường viền ô với `maxCellHeight` đồng nhất cho tất cả các ô trong dòng
                    gfx.DrawRectangle(XPens.Black, vtSTT, yPosition - khoangCachDOng, rongStt, maxCellHeight);
                    gfx.DrawRectangle(XPens.Black, vtMakh, yPosition - khoangCachDOng, rongMakh, maxCellHeight);
                    gfx.DrawRectangle(XPens.Black, vtHoTen, yPosition - khoangCachDOng, rongHoTen, maxCellHeight);
                    gfx.DrawRectangle(XPens.Black, vtNgaySinh, yPosition - khoangCachDOng, rongNgaySinh, maxCellHeight);
                    gfx.DrawRectangle(XPens.Black, vtGioiTinh, yPosition - khoangCachDOng, rongGt, maxCellHeight);
                    gfx.DrawRectangle(XPens.Black, vtSDT, yPosition - khoangCachDOng, rongSdt, maxCellHeight);
                    gfx.DrawRectangle(XPens.Black, vtDiem, yPosition - khoangCachDOng, rongDiem, maxCellHeight);

                    // Cập nhật vị trí `yPosition` sau khi vẽ xong toàn bộ dòng
                    yPosition += maxCellHeight; // Di chuyển `yPosition` xuống để chuẩn bị cho dòng kế tiếp
                    stt++;
                }
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

        string GetUniqueFilePath(string filePath)
        {
            int counter = 1;
            string directory = Path.GetDirectoryName(filePath);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);

            while (File.Exists(filePath))
            {
                // Thêm số thứ tự vào tên file
                filePath = Path.Combine(directory, $"{fileNameWithoutExtension}{counter}{extension}");
                counter++;
            }

            return filePath;
        }

        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xuất File Excel?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                string initialFilePath = @"D:\dataCSharp\Xuat_Excel_NCC\XuatNccExcel.xlsx";

                // Gọi hàm để lấy đường dẫn file không trùng
                string uniqueFilePath = GetUniqueFilePath(initialFilePath);

                List<NhaCungCapDTO> nhaCungCapList = NhaCungCapBUS.Instance.GetAllNhaCungCap();

                // Tạo file Excel
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    // Tạo worksheet
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    // Thêm dữ liệu mẫu vào sheet
                    worksheet.Cells[1, 1].Value = "STT";
                    worksheet.Cells[1, 2].Value = "Mã NCC";
                    worksheet.Cells[1, 3].Value = "Tên nhà cung cấp";
                    worksheet.Cells[1, 4].Value = "Địa chỉ";
                    worksheet.Cells[1, 5].Value = "Số điện thoại";
                    worksheet.Cells[1, 6].Value = "Email";
                    worksheet.Cells[1, 7].Value = "Trạng thái";

                    // Duyệt danh sách khách hàng và thêm vào Excel
                    int stt = 1;
                    int rowIndex = 2;
                    foreach (var ncc in nhaCungCapList)
                    {
                        worksheet.Cells[rowIndex, 1].Value = stt;
                        worksheet.Cells[rowIndex, 2].Value = ncc.MaNCC;
                        worksheet.Cells[rowIndex, 3].Value = ncc.TenNCC;
                        worksheet.Cells[rowIndex, 4].Value = ncc.DiaChi;
                        worksheet.Cells[rowIndex, 5].Value = ncc.SoDT;
                        worksheet.Cells[rowIndex, 6].Value = ncc.Email;

                        string trangthai = "";
                        if(ncc.TrangThai == true)
                        {
                            trangthai = "Còn hợp tác";
                        }
                        else
                        {
                            trangthai = "Hết hợp tác";
                        }
                        worksheet.Cells[rowIndex, 7].Value = trangthai;

                        rowIndex++;
                        stt++;
                    }

                    // Tự động điều chỉnh độ rộng cột
                    worksheet.Cells.AutoFitColumns();

                    // Lưu file
                    FileInfo fileInfo = new FileInfo(uniqueFilePath);
                    excelPackage.SaveAs(fileInfo);

                    // Hiển thị thông báo
                    MessageBox.Show($"Xuất file Excel thành công!\nĐường dẫn: {uniqueFilePath}", "Thông báo");
                }
            }

        }
    }
}
