using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Mysqlx.Session;
using System.IO;
using ExcelDataReader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Media;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace GUI
{
    public partial class FormDuocSi : Form
    {
        private string paramCbbFind;

        public FormDuocSi()
        {
            InitializeComponent();
            LoadDuocSiData();
            LoadDuLieu();
            // xử lý dataFind từ cbb_find
            if (cbb_find.Items.Count > 0)
            {
                paramCbbFind = cbb_find.Items[0].ToString();
            }
        }


        private void lv_qlduocsi_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string maDS = e.Item.SubItems[1].Text;
                string hoTen = e.Item.SubItems[2].Text;
                string sdt = e.Item.SubItems[3].Text;
                string email = e.Item.SubItems[4].Text;
                string username = e.Item.SubItems[5].Text;
                string trangThai = e.Item.SubItems[6].Text;

                tb_ma.Text = maDS;
                tb_hoten.Text = hoTen;
                tb_sdt.Text = sdt;
                tb_email.Text = email;

                if (trangThai.Equals("Còn làm"))
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
                btn_edit.Enabled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string mads = tb_ma.Text;
            string hoTen = tb_hoten.Text;
            string sodt = tb_sdt.Text;
            string email = tb_email.Text;

            if (ValidateInputs(hoTen, sodt, email))
            {
                DialogResult result = MessageBox.Show("Bạn muốn thêm dược sĩ này?", "Xác nhận thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool successAddDuocSi = DuocSiBUS.Instance.InsertDuocSi(mads, hoTen, sodt, email, true);
                    if (successAddDuocSi)
                    {
                        bool successAddTK = TaiKhoanBUS.Instance.InsertTaiKhoan(mads, mads, "123456", 0);
                        if (successAddTK)
                        {
                            MessageBox.Show("Thêm dược sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm dược sĩ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string mads = tb_ma.Text;
            string hoTen = tb_hoten.Text;
            string sodt = tb_sdt.Text;
            string email = tb_email.Text;

            if (ValidateInputs(hoTen, sodt, email))
            {
                DialogResult result = MessageBox.Show("Bạn muốn cập nhật dược sĩ này?", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool successUpDuocSi = DuocSiBUS.Instance.UpdateDuocSi(mads, hoTen, sodt, email);
                    if (successUpDuocSi)
                    {
                        MessageBox.Show("Cập nhật dược sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật dược sĩ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void upTrangThai(bool trangthai)
        {
            string mads = tb_ma.Text;

            DialogResult result = MessageBox.Show("Bạn muốn thay đổi trạng thái dược sĩ này", "Xác nhận thay đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool successUpTT = DuocSiBUS.Instance.UpdateTrangThaiDuocSi(mads, trangthai);
                if (successUpTT)
                {
                    MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reset();
                }
            }
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
                                string soDT = row[1].ToString();
                                string email = row[2].ToString();

                                if (row == dataTable.Rows[0])
                                {
                                    if (hoTen != "Họ tên" || soDT != "Số điện thoại" || email != "Email")
                                    {
                                        isHeaderValid = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (isHeaderValid)
                                    {
                                        DuocSiDTO ds = new DuocSiDTO("00", hoTen, soDT, email, "true");
                                        bool check = DuocSiBUS.Instance.DuocSiDaTonTai(ds);
                                        if (check)
                                        {
                                            continue;
                                        }else
                                        {
                                            string lastMaDS = DuocSiBUS.Instance.GetLastMaDS();
                                            string prefix = lastMaDS.Substring(0, 2);
                                            string numberPart = lastMaDS.Substring(2);

                                            int nextNumber = int.Parse(numberPart) + 1;

                                            string newMaDS = prefix + nextNumber.ToString("D4");

                                            if(DuocSiBUS.Instance.InsertDuocSi(newMaDS, hoTen, soDT, email, true))
                                            {
                                                if (TaiKhoanBUS.Instance.InsertTaiKhoan(newMaDS, newMaDS, "123456", 0))
                                                {
                                                    num++;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            if (isHeaderValid == false)
                            {
                                MessageBox.Show("File excel không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }else
                            {
                                if(num == 0)
                                {
                                    MessageBox.Show($"Đã nhập File {Path.GetFileName(filePath)} này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    LoadDuocSiData();
                                }
                                else
                                {
                                    MessageBox.Show($"Thêm thành công {num} dược sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadDuocSiData();
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
                string baseFilePath = @"D:\dataCSharp\FilePdfDS\XuatDsPdf.pdf";
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

                // Vẽ tiêu đề trang và tiêu đề bảng trên trang đầu tiên
                XFont titleFont = new XFont("Verdana", 22);
                gfx.DrawString("Danh sách Dược Sĩ", titleFont, XBrushes.Black, new XPoint(200, 30));

                XFont headerFont = new XFont("Verdana", 12);
                gfx.DrawString("STT", headerFont, XBrushes.Black, new XPoint(5, 65));
                gfx.DrawRectangle(XPens.Black, 0, 44, 40, rowHeight);
                gfx.DrawString("Mã DS", headerFont, XBrushes.Black, new XPoint(45, 65));
                gfx.DrawRectangle(XPens.Black, 40, 44, 60, rowHeight);
                gfx.DrawString("Họ tên", headerFont, XBrushes.Black, new XPoint(112, 65));
                gfx.DrawRectangle(XPens.Black, 100, 44, 175, rowHeight);
                gfx.DrawString("Số ĐT", headerFont, XBrushes.Black, new XPoint(295, 65));
                gfx.DrawRectangle(XPens.Black, 275, 44, 95, rowHeight);
                gfx.DrawString("Email", headerFont, XBrushes.Black, new XPoint(375, 65));
                gfx.DrawRectangle(XPens.Black, 370, 44, 155, rowHeight);
                gfx.DrawString("TT", headerFont, XBrushes.Black, new XPoint(545, 65));
                gfx.DrawRectangle(XPens.Black, 525, 44, 65, rowHeight);

                // Vị trí bắt đầu vẽ các dòng dữ liệu
                int yPosition = 92;
                int khoangCachDOng = 18;
                List<DuocSiDTO> listDSXuatFile = DuocSiBUS.Instance.GetAllDuocSi();
                int stt = 1;

                foreach (var item in listDSXuatFile)
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
                    gfx.DrawRectangle(XPens.Black, 0, yPosition - khoangCachDOng, 40, rowHeight);
                    gfx.DrawString(item.MaDS, new XFont("Verdana", 12), XBrushes.Black, new XPoint(45, yPosition));
                    gfx.DrawRectangle(XPens.Black, 40, yPosition - khoangCachDOng, 60, rowHeight);
                    gfx.DrawString(item.HoTen, new XFont("Verdana", 12), XBrushes.Black, new XPoint(112, yPosition));
                    gfx.DrawRectangle(XPens.Black, 100, yPosition - khoangCachDOng, 175, rowHeight);
                    gfx.DrawString(item.SDT, new XFont("Verdana", 12), XBrushes.Black, new XPoint(280, yPosition));
                    gfx.DrawRectangle(XPens.Black, 275, yPosition - khoangCachDOng, 95, rowHeight);
                    gfx.DrawString(item.Email, new XFont("Verdana", 12), XBrushes.Black, new XPoint(375, yPosition));
                    gfx.DrawRectangle(XPens.Black, 370, yPosition - khoangCachDOng, 155, rowHeight);

                    string trangThai = item.TrangThai == "True" ? "Còn làm" : "Nghỉ làm";
                    gfx.DrawString(trangThai, new XFont("Verdana", 12), XBrushes.Black, new XPoint(530, yPosition));
                    gfx.DrawRectangle(XPens.Black, 525, yPosition - khoangCachDOng, 65, rowHeight);

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




        private void tb_find_TextChanged(object sender, EventArgs e)
        {
            string dataFind = tb_find.Text;
            LoadDuocSiData_Find("FindByParam", dataFind, true);
        }

        private void cbb_findTT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = cbb_findTT.SelectedItem.ToString();
            if (selectedItem == "Còn làm")
            {
                LoadDuocSiData_Find("FindTrangThai", "", true);

            }
            else if (selectedItem == "Nghỉ làm")
            {
                LoadDuocSiData_Find("FindTrangThai", "", false);
            }
            else
            {
                LoadDuocSiData();
            }
        }


        private void cbb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            paramCbbFind = cbb_find.SelectedItem.ToString();
        }

        private void reset()
        {
            tb_ma.Text = "";
            tb_hoten.Text = "";
            tb_sdt.Text = "";
            tb_email.Text = "";
            tb_find.Text = "";
            cbb_find.SelectedIndex = 0;
            cbb_findTT.SelectedIndex = 0;
            btn_add.Enabled = true;
            btn_opLock.Enabled = false;
            btn_lock.Enabled = false;
            btn_edit.Enabled = false;
            LoadDuLieu();
            LoadDuocSiData();
        }

        private void LoadDuLieu()
        {
            string lastMaDS = DuocSiBUS.Instance.GetLastMaDS();
            string prefix = lastMaDS.Substring(0, 2);
            string numberPart = lastMaDS.Substring(2);

            int nextNumber = int.Parse(numberPart) + 1;

            string newMaDS = prefix + nextNumber.ToString("D4");
            tb_ma.Text = newMaDS;

            cbb_findTT.SelectedIndex = 0;
            cbb_find.SelectedIndex = 0;
        }

        public bool ValidateInputs(string hoTen, string sodt, string email)
        {
            bool ktra = true;
            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(sodt) || string.IsNullOrWhiteSpace(email))
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

        private void LoadDuocSiData_Find(string theLoaiFind, string dataFind, bool trangThai)
        {
            List<DuocSiDTO> duocSiListFind = new List<DuocSiDTO>();
            if (theLoaiFind == "FindTrangThai")
            {
                duocSiListFind = DuocSiBUS.Instance.GetDuocSiByTrangThai(trangThai);
            }
            else
            {
                string param = "";
                if (paramCbbFind == "Mã DS")
                {
                    param = "mads";
                }
                else if (paramCbbFind == "Họ tên")
                {
                    param = "hoten";
                }
                else if (paramCbbFind == "SĐT")
                {
                    param = "sodt";
                }
                else if (paramCbbFind == "Email")
                {
                    param = "hoten";
                }
                duocSiListFind = DuocSiBUS.Instance.FindDuocSi(param, dataFind);
            }


            List<TaiKhoanDTO> taiKhoanList = TaiKhoanBUS.Instance.GetAllTaiKhoan();

            handleDataView(duocSiListFind, taiKhoanList);
        }

        private void LoadDuocSiData()
        {
            List<DuocSiDTO> duocSiList = DuocSiBUS.Instance.GetAllDuocSi();
            List<TaiKhoanDTO> taiKhoanList = TaiKhoanBUS.Instance.GetAllTaiKhoan();

            handleDataView(duocSiList, taiKhoanList);
        }

        private void handleDataView(List<DuocSiDTO> arrDS, List<TaiKhoanDTO> arrTK)
        {
            lv_qlduocsi.Items.Clear();

            int stt = 1;

            foreach (DuocSiDTO duocSi in arrDS)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(duocSi.MaDS);
                item.SubItems.Add(duocSi.HoTen);
                item.SubItems.Add(duocSi.SDT);
                item.SubItems.Add(duocSi.Email);

                var taiKhoan = arrTK.FirstOrDefault(tk => tk.MaTK == duocSi.MaDS);

                if (taiKhoan != null)
                {
                    item.SubItems.Add(taiKhoan.Username);
                }
                else
                {
                    item.SubItems.Add("N/A");
                }
                if (duocSi.TrangThai == "True")
                {
                    item.SubItems.Add("Còn làm");
                }
                else
                {
                    item.SubItems.Add("Nghỉ làm");
                }
                lv_qlduocsi.Items.Add(item);

                stt++;
            }
        }
    }
}
