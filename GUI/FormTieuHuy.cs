using BUS;
using DAO;
using DTO;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormTieuHuy : Form
    {
        private Dictionary<string, int> losxToMaCTMap = new Dictionary<string, int>();

        public FormTieuHuy()
        {
            InitializeComponent();
        }

        private void FormTieuHuy_Load_1(object sender, EventArgs e)
        {
            DataTable chiTietSanPham = DataProvider.Instance.GetChiTietSanPham();
            DataTable danhSachDuocSi = DataProvider.Instance.GetDanhSachDuocSi();
            lv_DSHoaDon.SelectedIndexChanged += lv_DSHoaDon_SelectedIndexChanged;

            // Populate product combobox with product data
            comboBoxSanPham.DataSource = chiTietSanPham;
            comboBoxSanPham.DisplayMember = "tensp";
            comboBoxSanPham.ValueMember = "mact"; // Store the MaCT value in the combo box

            // Populate batch combobox (LoSX)
            comboBoxLoSX.DataSource = chiTietSanPham;
            comboBoxLoSX.DisplayMember = "loSX";  // Show LoSX in the combobox
            comboBoxLoSX.ValueMember = "mact";  // Store MaCT for batch selection

            // Populate the pharmacist combobox (NguoiLap)
            comboBoxNguoiLap.DataSource = danhSachDuocSi;
            comboBoxNguoiLap.DisplayMember = "hoten";
            comboBoxNguoiLap.ValueMember = "mads";  // Use MaDS for the value

            // Load lô sản xuất into losxToMaCTMap
            losxToMaCTMap.Clear(); // Ensure to clear the previous data
            foreach (DataRow row in chiTietSanPham.Rows)
            {
                string loSX = row["loSX"].ToString();
                int maCT = Convert.ToInt32(row["mact"]);
                losxToMaCTMap[loSX] = maCT;  // Store loSX and MaCT in the map
            }

            LoadTieuHuyData();
        }

        private void LoadTieuHuyData()
        {
            DataTable data = TieuHuyBUS.Instance.GetListTieuHuy();
            lv_DSHoaDon.Items.Clear();

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["mact"].ToString());
                item.SubItems.Add(Convert.ToDateTime(row["ngaytieuhuy"]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(row["nguoilap"].ToString());
                item.SubItems.Add(row["lydo"].ToString());
                item.SubItems.Add(row["thiethai"].ToString());
                lv_DSHoaDon.Items.Add(item);
            }
        }

        private void comboBoxSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSanPham.SelectedItem is DataRowView selectedRow)
            {
                int maCT = Convert.ToInt32(selectedRow["mact"]);
                int currentQuantity = TieuHuyDAO.Instance.GetSoLuong(maCT);

                if (currentQuantity == 0)
                {
                    buttonadd.Enabled = false;
                    MessageBox.Show("Sản phẩm này đã hết số lượng và không thể tiêu hủy.");
                }
                else
                {
                    buttonadd.Enabled = true;
                }

                // Optionally, update the damage cost field based on purchase price and quantity
                decimal thietHai = DataProvider.Instance.CalculateThietHai(maCT); // This assumes a method that calculates damage
                textBox1.Text = thietHai.ToString("N2");
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            int maCT = int.Parse(comboBoxSanPham.SelectedValue.ToString());
            string loSX = comboBoxLoSX.Text;  // Get the selected batch (LoSX)

            // Ensure the batch exists in the dictionary
            if (losxToMaCTMap.ContainsKey(loSX))
            {
                int currentQuantity = TieuHuyDAO.Instance.GetSoLuong(maCT);

                if (currentQuantity == 0)
                {
                    MessageBox.Show("Sản phẩm này đã hết số lượng và không thể tiêu hủy.");
                    return; // Stop the save operation
                }

                // Create TieuHuyDTO object for storing information
                TieuHuyDTO tieuHuy = new TieuHuyDTO()
                {
                    MaCT = maCT,
                    NgayTieuHuy = dateTimePicker3.Value,
                    NguoiLap = comboBoxNguoiLap.SelectedValue.ToString(),
                    LyDo = richTextBox1.Text,
                    ThietHai = string.IsNullOrEmpty(textBox1.Text) ? (decimal?)null : decimal.Parse(textBox1.Text)
                };

                // Add TieuHuyDTO to database
                if (TieuHuyBUS.Instance.AddTieuHuy(tieuHuy))
                {
                    MessageBox.Show("Thêm và cập nhật số lượng thành công");
                    LoadListTieuHuy();
                }
                else
                {
                    MessageBox.Show("Thêm hoặc cập nhật số lượng thất bại");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy lô sản xuất này trong hệ thống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void LoadListTieuHuy()
        {
            DataTable data = TieuHuyBUS.Instance.GetListTieuHuy();
            lv_DSHoaDon.Items.Clear(); // Clear the existing list

            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["mact"].ToString());
                item.SubItems.Add(Convert.ToDateTime(row["ngaytieuhuy"]).ToString("dd/MM/yyyy"));
                item.SubItems.Add(row["nguoilap"].ToString());
                item.SubItems.Add(row["lydo"].ToString());
                item.SubItems.Add(row["thiethai"].ToString());
                lv_DSHoaDon.Items.Add(item);
            }
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStart.Value.Date;  // Lấy ngày bắt đầu (bỏ qua giờ phút giây)
            DateTime endDate = dateTimePickerEnd.Value.Date;      // Lấy ngày kết thúc (bỏ qua giờ phút giây)

            // Thêm 1 ngày vào endDate để bao gồm cả ngày cuối cùng
            endDate = endDate.AddDays(1).AddSeconds(-1);  // Thêm 1 ngày và trừ 1 giây

            // Lấy dữ liệu từ cơ sở dữ liệu
            DataTable result = DataProvider.GetTieuHuyInDateRange(startDate, endDate);


            // Hiển thị kết quả lên bảng (ListView hoặc DataGridView)
            lv_DSHoaDon.Items.Clear();  // Xóa các mục hiện tại

            foreach (DataRow row in result.Rows)
            {
                ListViewItem item = new ListViewItem(row["mact"].ToString());
                item.SubItems.Add(row["ngaytieuhuy"].ToString());
                item.SubItems.Add(row["nguoilap"].ToString());
                item.SubItems.Add(row["lydo"].ToString());
                item.SubItems.Add(row["thiethai"].ToString());

                lv_DSHoaDon.Items.Add(item);
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
                // Get the selected ListView item
                ListViewItem selectedItem = lv_DSHoaDon.SelectedItems[0];

                // Populate the fields with the selected data
                comboBoxSanPham.SelectedValue = int.Parse(selectedItem.SubItems[0].Text);
                dateTimePicker3.Value = DateTime.ParseExact(selectedItem.SubItems[1].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                comboBoxNguoiLap.SelectedValue = selectedItem.SubItems[2].Text;
                richTextBox1.Text = selectedItem.SubItems[3].Text;
                textBox1.Text = selectedItem.SubItems[4].Text;
            }

            //if (lv_DSHoaDon.SelectedItems.Count > 0)
            //{
            //    // Lấy thông tin của mục đã chọn
            //    ListViewItem selectedItem = lv_DSHoaDon.SelectedItems[0];

            //    // Lấy MaCT từ mục đã chọn (giả sử MaCT được lưu trong cột đầu tiên)
            //    int maCT = Convert.ToInt32(selectedItem.SubItems[0].Text);  // Cột 0 chứa MaCT

            //    // Lấy Lý Do từ mục đã chọn (giả sử Lý Do nằm ở cột 2)
            //    string lyDo = selectedItem.SubItems[2].Text;  // Cột 2 chứa Lý Do

            //    // Hiển thị Lý Do lên một textbox để người dùng có thể chỉnh sửa
            //    richTextBox1.Text = lyDo;  // txtLyDo là textbox hiển thị Lý Do
            //}
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn mục trong bảng
            if (lv_DSHoaDon.SelectedItems.Count > 0)
            {
                // Lấy MaCT từ mục đã chọn trong lv_DSHoaDon
                ListViewItem selectedItem = lv_DSHoaDon.SelectedItems[0];
                int maCT = Convert.ToInt32(selectedItem.SubItems[0].Text); // Cột 0 chứa MaCT

                // Lấy Lý Do từ TextBox (người dùng nhập vào)
                string lyDo = richTextBox1.Text;  // txtLyDo là TextBox hiển thị Lý Do

                // Cập nhật Lý Do vào cơ sở dữ liệu
                bool isUpdated = TieuHuyBUS.Instance.UpdateLyDo(maCT, lyDo);

                // Thông báo kết quả
                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật Lý Do thành công!");
                    // Cập nhật lại trong ListView
                    selectedItem.SubItems[3].Text = lyDo; // Cập nhật Lý Do trong ListView
                }
                else
                {
                    MessageBox.Show("Cập nhật Lý Do thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa!");
            }
        }

        private void comboBoxNguoiLap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
