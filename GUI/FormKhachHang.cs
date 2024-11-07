using BUS;
using DTO;
using ExcelDataReader;
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
    public partial class FormKhachHang : Form
    {
        int maKhUp = 0;
        private string paramCbbFind;
        public FormKhachHang()
        {
            InitializeComponent();
            // xử lý dataFind từ cbb_find
            loadData();
            if (cbb_find.Items.Count > 0)
            {
                paramCbbFind = cbb_find.Items[0].ToString();
            }
            loadDataKH();
        }

        private void loadData()
        {
            cbb_find.SelectedIndex = 0;
        }

        private void loadDataKH()
        {
            List<KhachHangDTO> arrKH = KhachHangBUS.Instance.GetAllKhachHang();
            handleDataViewDSKH(arrKH);
        }

        private void handleDataViewDSKH(List<KhachHangDTO> arr)
        {
            lv_qlkhachhang.Items.Clear();

            int stt = 1;

            foreach (KhachHangDTO khachhang in arr)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(khachhang.MaKH.ToString());
                item.SubItems.Add(khachhang.HoTen);
                item.SubItems.Add(khachhang.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(khachhang.GioiTinh);
                item.SubItems.Add(khachhang.SoDT);
                item.SubItems.Add(khachhang.Diem.ToString());


                lv_qlkhachhang.Items.Add(item);

                stt++;
            }
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
                DialogResult result = MessageBox.Show("Bạn muốn thêm khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool checkAdd = KhachHangBUS.Instance.AddKhachHang(makh, hoTen, ngaySinh, gioiTinh, soDT, 0);
                    if (checkAdd)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
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
        private void cb_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nam.Checked)
            {
                cb_nu.Checked = false;
            }
        }

        private void cb_nu_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nu.Checked)
            {
                cb_nam.Checked = false;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            tb_hoten.Text = "";
            tb_diem.Text = "0";
            tb_sdt.Text = "";
            date_kh.Value = new DateTime(2000, 1, 1);
            cb_nam.Checked = false;
            cb_nu.Checked = false;

            loadDataKH();
        }

        private void lv_qlkhachhang_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                maKhUp = int.Parse(e.Item.SubItems[1].Text);
                string hoTen = e.Item.SubItems[2].Text;
                string ngaySinh = e.Item.SubItems[3].Text;
                string gioiTinh = e.Item.SubItems[4].Text;
                string soDT = e.Item.SubItems[5].Text;
                string diem = e.Item.SubItems[6].Text;

                tb_hoten.Text = hoTen;
                tb_sdt.Text = soDT;
                tb_diem.Text = diem;
                if (gioiTinh == "Nam")
                {
                    cb_nam.Checked = true;
                }
                else
                {
                    cb_nu.Checked = true;
                }
                if (DateTime.TryParse(ngaySinh, out DateTime ngaySinhDate))
                {
                    date_kh.Value = ngaySinhDate;
                }

                // xử lý label & button
                btn_add.Enabled = false;
                btn_edit.Enabled = true;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int makh = maKhUp;
            string hoTen = tb_hoten.Text;
            DateTime ngaySinh = date_kh.Value;
            string gioiTinh = "chua_check";
            if (cb_nam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
            {
                gioiTinh = "Nữ";
            }
            string soDT = tb_sdt.Text;
            int diem = int.Parse(tb_diem.Text);

            bool checkValue = ValidateInputs(hoTen, soDT, gioiTinh);
            if (checkValue)
            {
                DialogResult result = MessageBox.Show("Bạn muốn sửa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool checkUp = KhachHangBUS.Instance.UpdateKhachHang(makh, hoTen, ngaySinh, gioiTinh, soDT, diem);
                    if (checkUp)
                    {
                        MessageBox.Show("Sửa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                }
            }

            // xử lý label & button
            btn_add.Enabled = true;
            btn_edit.Enabled = false;
        }

        private void cbb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            paramCbbFind = cbb_find.SelectedItem.ToString();
            if (paramCbbFind == "Ngày sinh")
            {
                date_find1.Enabled = true;
                date_find2.Enabled = true;
                tb_find.Text = "";
                tb_find.ReadOnly = true;
            }
            else
            {
                date_find1.Value = new DateTime(2000, 1, 1);
                date_find2.Value = DateTime.Now;
                date_find1.Enabled = false;
                date_find2.Enabled = false;
                tb_find.ReadOnly = false;
            }
        }

        private void LoadKhachHangData_Find(string dataFind)
        {
            List<KhachHangDTO> khListFind = new List<KhachHangDTO>();
            string param = "";
            if (paramCbbFind == "Mã KH")
            {
                param = "makh";
            }
            else if (paramCbbFind == "Họ tên")
            {
                param = "hoten";
            }
            else if (paramCbbFind == "Giới tính")
            {
                param = "gioitinh";
            }
            else if (paramCbbFind == "SĐT")
            {
                param = "sodt";
            }
            else if (paramCbbFind == "Điểm")
            {
                param = "diem";
            }
            khListFind = KhachHangBUS.Instance.FindKhachHang(param, dataFind);
            handleDataViewDSKH(khListFind);
        }

        private void tb_find_TextChanged(object sender, EventArgs e)
        {
            string dataFind = tb_find.Text;
            LoadKhachHangData_Find(dataFind);
        }

        private void loadDataKhFind()
        {
            DateTime date1 = date_find1.Value;
            DateTime date2 = date_find2.Value;

            date1 = date1.Date;
            date2 = date2.Date;

            List<KhachHangDTO> khListFind = KhachHangBUS.Instance.FindKhachHangByNgaySinh(date1, date2);
            handleDataViewDSKH(khListFind);
        }

        private void date_find1_ValueChanged(object sender, EventArgs e)
        {
            loadDataKhFind();
        }

        private void date_find2_ValueChanged(object sender, EventArgs e)
        {
            loadDataKhFind();
        }

        private void btn_nhapExcel_Click(object sender, EventArgs e)
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
                            int num = 0;

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string hoTen = row[0].ToString();
                                string ngaySinh = row[1].ToString();
                                string gioiTinh = row[2].ToString();
                                string soDT = row[3].ToString();
                                string diem = row[4].ToString();

                                if (row == dataTable.Rows[0])
                                {
                                    if (hoTen != "Họ tên" || ngaySinh != "Ngày sinh" || gioiTinh != "Giới tính" || soDT != "Số điện thoại" || diem != "Điểm")
                                    {
                                        isHeaderValid = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (isHeaderValid)
                                    {
                                        DateTime ngaySinhDate = DateTime.Parse(ngaySinh);
                                        int diemInt = int.Parse(diem);
                                        KhachHangDTO kh = new KhachHangDTO(0, hoTen, ngaySinhDate, gioiTinh, soDT, diemInt);
                                        bool check = KhachHangBUS.Instance.KhachHangDaTonTai(kh);
                                        if (check)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            int makh = KhachHangBUS.Instance.GetLastMaKH() + 1;
                                            if (KhachHangBUS.Instance.AddKhachHang(makh, hoTen, ngaySinhDate, gioiTinh, soDT, diemInt))
                                            {
                                                num++;
                                            }
                                        }
                                    }
                                }
                            }
                            if (isHeaderValid == false)
                            {
                                MessageBox.Show("File excel không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                if(num == 0)
                                {
                                    MessageBox.Show($"Đã nhập File {Path.GetFileName(filePath)} này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    loadDataKH();
                                }else
                                {
                                    MessageBox.Show($"Thêm thành công {num} khác hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    loadDataKH();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xuất File PDF", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                // Đường dẫn cơ bản cho file PDF
                string baseFilePath = @"D:\dataCSharp\FilePdfKH\XuatKhPdf.pdf";
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
                XGraphics gfx = XGraphics.FromPdfPage(page);

                double rowHeight = 30;      // Chiều cao mỗi dòng
                double pageHeight = page.Height.Point;  // Chiều cao tối đa của trang PDF

                int rongStt = 40;   
                int rongMakh = 54;   
                int rongHoTen = 190;   
                int rongNgaySinh = 100;   
                int rongGt = 50;   
                int rongSdt = 110;
                int rongDiem = 50;

                int vtSTT = 0;
                int vtMakh = vtSTT + rongStt;
                int vtHoTen = vtMakh + rongMakh;
                int vtNgaySinh = vtHoTen + rongHoTen;
                int vtGioiTinh = vtNgaySinh + rongNgaySinh;
                int vtSDT = vtGioiTinh + rongGt;
                int vtDiem = vtSDT + rongSdt;

                // Vẽ tiêu đề trang và tiêu đề bảng trên trang đầu tiên
                XFont titleFont = new XFont("Verdana", 22);
                gfx.DrawString("CHI TIẾT SẢN PHẨM", titleFont, XBrushes.Black, new XPoint(200, 30));

                XFont headerFont = new XFont("Verdana", 12);
                gfx.DrawString("STT", headerFont, XBrushes.Black, new XPoint(5, 65));
                gfx.DrawRectangle(XPens.Black, vtSTT, 44, rongStt, rowHeight);
                gfx.DrawString("MaKH", headerFont, XBrushes.Black, new XPoint(50, 65));
                gfx.DrawRectangle(XPens.Black, vtMakh, 44, rongMakh, rowHeight);
                gfx.DrawString("Họ tên", headerFont, XBrushes.Black, new XPoint(102, 65));
                gfx.DrawRectangle(XPens.Black, vtHoTen, 44, rongHoTen, rowHeight);
                gfx.DrawString("Ngày sinh", headerFont, XBrushes.Black, new XPoint(305, 65));
                gfx.DrawRectangle(XPens.Black, vtNgaySinh, 44, rongNgaySinh, rowHeight);
                gfx.DrawString("GT", headerFont, XBrushes.Black, new XPoint(395, 65));
                gfx.DrawRectangle(XPens.Black, vtGioiTinh, 44, rongGt, rowHeight);
                gfx.DrawString("SĐT", headerFont, XBrushes.Black, new XPoint(475, 65));
                gfx.DrawRectangle(XPens.Black, vtSDT, 44, rongSdt, rowHeight);
                gfx.DrawString("Điểm", headerFont, XBrushes.Black, new XPoint(555, 65));
                gfx.DrawRectangle(XPens.Black, vtDiem, 44, rongDiem, rowHeight);

                // Vị trí bắt đầu vẽ các dòng dữ liệu
                int yPosition = 92;
                int khoangCachDOng = 18;
                List<KhachHangDTO> listKHXuatFile = KhachHangBUS.Instance.GetAllKhachHang();
                int stt = 1;

                foreach (var item in listKHXuatFile)
                {
                    // Nếu vị trí y vượt quá chiều cao trang, thêm trang mới mà không vẽ lại tiêu đề
                    if (yPosition > pageHeight - rowHeight)
                    {
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        yPosition = 30;  // Đặt lại vị trí y trên trang mới
                    }
                    // Vẽ dữ liệu của mỗi dòng
                    gfx.DrawString(stt.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(10, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtSTT, yPosition - khoangCachDOng, rongStt, rowHeight);
                    gfx.DrawString(item.MaKH.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(59, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtMakh, yPosition - khoangCachDOng, rongMakh, rowHeight);
                    gfx.DrawString(item.HoTen, new XFont("Verdana", 12), XBrushes.Black, new XPoint(102, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtHoTen, yPosition - khoangCachDOng, rongHoTen, rowHeight);
                    gfx.DrawString(item.NgaySinh.ToString("dd/MM/yyyy"), new XFont("Verdana", 12), XBrushes.Black, new XPoint(295, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtNgaySinh, yPosition - khoangCachDOng, rongNgaySinh, rowHeight);
                    gfx.DrawString(item.GioiTinh, new XFont("Verdana", 12), XBrushes.Black, new XPoint(395, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtGioiTinh, yPosition - khoangCachDOng, rongGt, rowHeight);
                    gfx.DrawString(item.SoDT, new XFont("Verdana", 12), XBrushes.Black, new XPoint(450, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtSDT, yPosition - khoangCachDOng, rongSdt, rowHeight);
                    if(item.Diem < 10)
                    { 
                        gfx.DrawString(item.Diem.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(568, yPosition)); 
                    } else if(item.Diem < 100 && item.Diem >= 10)
                    {
                        gfx.DrawString(item.Diem.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(564, yPosition));
                    }
                    else if (item.Diem >= 1000)
                    {
                    gfx.DrawString(item.Diem.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(556, yPosition));
                    }
                    else
                    {
                        gfx.DrawString(item.Diem.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(560, yPosition));
                    }
                    gfx.DrawRectangle(XPens.Black, vtDiem, yPosition - khoangCachDOng, rongDiem, rowHeight);

                    yPosition += 30;  // Di chuyển xuống dòng tiếp theo
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
    }
}
