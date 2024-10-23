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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                    btn_del.Enabled = true;
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            string mads = tb_ma.Text;
            string hoTen = tb_hoten.Text;
            string sodt = tb_sdt.Text;
            string email = tb_email.Text;

            if (ValidateInputs(hoTen, sodt, email))
            {
                DialogResult result = MessageBox.Show("Bạn muốn thêm dược sĩ này?", "Xác nhận thêm dược sĩ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                DialogResult result = MessageBox.Show("Bạn muốn cập nhật dược sĩ này?", "Xác nhận cập nhật dược sĩ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                        MessageBox.Show("Thêm dược sĩ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btn_del_Click(object sender, EventArgs e)
        {
            string mads = tb_ma.Text;

            DialogResult result = MessageBox.Show($"Bạn muốn xóa dược sĩ có MaDS = {mads}?", "Xác nhận xoá dược sĩ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool successDelTaiKhoan = TaiKhoanBUS.Instance.DeleteTaiKhoan(mads);
                if (successDelTaiKhoan)
                {
                    bool successDelDuocSi = DuocSiBUS.Instance.DeleteDuocSi(mads);
                    if (successDelDuocSi)
                    {
                        MessageBox.Show("Xoá dược sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                }
            }
        }

        private void btn_nhapExcel_Click(object sender, EventArgs e)
        {

        }

        private void btn_xuat_Click(object sender, EventArgs e)
        {

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
            btn_add.Enabled = true;
            btn_opLock.Enabled = false;
            btn_lock.Enabled = false;
            btn_del.Enabled = false;
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

            lv_qlduocsi.Items.Clear();

            int stt = 1;

            foreach (DuocSiDTO duocSi in duocSiListFind)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(duocSi.MaDS);
                item.SubItems.Add(duocSi.HoTen);
                item.SubItems.Add(duocSi.SDT);
                item.SubItems.Add(duocSi.Email);

                var taiKhoan = taiKhoanList.FirstOrDefault(tk => tk.MaTK == duocSi.MaDS);

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

        private void LoadDuocSiData()
        {
            List<DuocSiDTO> duocSiList = DuocSiBUS.Instance.GetAllDuocSi();
            List<TaiKhoanDTO> taiKhoanList = TaiKhoanBUS.Instance.GetAllTaiKhoan();

            lv_qlduocsi.Items.Clear();

            int stt = 1;

            foreach (DuocSiDTO duocSi in duocSiList)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(duocSi.MaDS);
                item.SubItems.Add(duocSi.HoTen);
                item.SubItems.Add(duocSi.SDT);
                item.SubItems.Add(duocSi.Email);

                var taiKhoan = taiKhoanList.FirstOrDefault(tk => tk.MaTK == duocSi.MaDS);

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
