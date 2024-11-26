using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
            //if (lv_DSHoaDon.SelectedItems.Count > 0)
            //{
            //    ListViewItem selectedItem = lv_DSHoaDon.SelectedItems[0];
            //    int maCT = int.Parse(selectedItem.Text); // Get the MaCT value

            //    // Fetch and populate the details of the selected TieuHuy
            //    TieuHuyDTO tieuHuy = TieuHuyBUS.Instance.GetTieuHuyByMaCT(maCT);

            //    richTextBox1.Text = tieuHuy.LyDo;
            //    textBox1.Text = tieuHuy.ThietHai.ToString();

            //    // Load batch details
            //    comboBoxLoSX.Enabled = true;
            //    comboBoxLoSX.SelectedItem = tieuHuy.MaCT.ToString(); // Select the batch (LoSX) by MaCT

            //    buttonadd.Enabled = false;
            //    buttonedit.Enabled = true;
            //    buttondelete.Enabled = true;
            //}
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Your logic here
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
                dateTimePicker3.Value = DateTime.Parse(selectedItem.SubItems[1].Text);
                comboBoxNguoiLap.SelectedValue = selectedItem.SubItems[2].Text;
                richTextBox1.Text = selectedItem.SubItems[3].Text;
                textBox1.Text = selectedItem.SubItems[4].Text;
            }
        }
    }
}
