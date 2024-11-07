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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GUI
{
    public partial class FormHoaDon : Form
    {
        string madsDangNhap = "";
        int mact = 0;
        int sttDelEdit = 0;
        private Dictionary<string, int> losxToMaCTMap = new Dictionary<string, int>();
        List<ChiTietHoaDonDTO> tempCthd = new List<ChiTietHoaDonDTO>();
        List<ChiTietSanPhamDTO> tempCtsp = new List<ChiTietSanPhamDTO>();
        List<string> itemCbb_sp = new List<string>();
        decimal tongTien = 0;
        int dtl = 0;
        int soLuongCon = 0;
        string textCbb_find = "";

        public FormHoaDon(string mads)
        {
            InitializeComponent();
            madsDangNhap = mads;
            loadData();
            loadDSHoaDon();
            loadCbbKh();
        }

        private void loadData()
        {
            tb_nguoi.Text = madsDangNhap;
            lb_tong.Text = "Tổng tiền : " + tongTien;
            cbb_find.SelectedIndex = 0;

            List<SanPhamDTO> listSP = SanPhamBUS.Instance.GetProductsByTrangThai();

            itemCbb_sp.Clear();
            foreach (SanPhamDTO sp in listSP)
            {
                string item = $"{sp.MaSP} - {sp.TenSP}";
                itemCbb_sp.Add(item);
            }
            cbb_sp.Items.AddRange(itemCbb_sp.ToArray());
            cbb_sp.DropDownHeight = 200;
            cbb_sp.SelectedIndex = 0;

            string itemCbbMasp = cbb_sp.Text;
            string[] stringMasp = itemCbbMasp.Split('-');
            string masp = stringMasp[0].Trim();
            loadDataCbbLosx(masp);

            List<DuocSiDTO> listDuocSi = DuocSiBUS.Instance.GetAllDuocSi();
            List<string> itemCbb_FindDS = new List<string>();
            itemCbb_FindDS.Add("Tất cả dược sĩ");
            foreach (DuocSiDTO ds in listDuocSi)
            {
                string item = $"{ds.MaDS} - {ds.HoTen}";
                itemCbb_FindDS.Add(item);
            }
            cbb_findNguoiLap.Items.AddRange(itemCbb_FindDS.ToArray());
            cbb_findNguoiLap.DropDownHeight = 200;
            cbb_findNguoiLap.SelectedIndex = -1;
        }

        public void loadCbbKh()
        {
            cbb_khach.Items.Clear();

            List<KhachHangDTO> listAllKH = KhachHangBUS.Instance.GetAllKhachHang();

            List<string> itemCbb_kh = new List<string>();
            List<string> itemCbb_khFind = new List<string>();
            itemCbb_khFind.Add("Tất cả khách hàng");
            foreach (KhachHangDTO kh in listAllKH)
            {
                string item = $"{kh.MaKH} - {kh.HoTen}";
                itemCbb_kh.Add(item);
                itemCbb_khFind.Add(item);
            }
            cbb_khach.Items.AddRange(itemCbb_kh.ToArray());
            cbb_khach.DropDownHeight = 200;
            cbb_khach.SelectedIndex = 0;

            cbb_findKh.Items.AddRange(itemCbb_khFind.ToArray());
            cbb_findKh.DropDownHeight = 200;
            cbb_findKh.SelectedIndex = -1;
        }

        private void loadDataCbbLosx(string masp)
        {
            cbb_lsx.Items.Clear();
            List<ChiTietSanPhamDTO> listCTSPByLosx = ChiTietSanPhamBUS.Instance.GetLoSXAndCheckHSD(masp);
            List<string> itemCbb_lsx = new List<string>();
            foreach (ChiTietSanPhamDTO ctsp in listCTSPByLosx)
            {
                itemCbb_lsx.Add(ctsp.LoSX);
                losxToMaCTMap[ctsp.LoSX] = ctsp.MaCT;
            }
            cbb_lsx.Items.AddRange(itemCbb_lsx.ToArray());
            if (itemCbb_lsx.Count > 0)
            {
                cbb_lsx.SelectedIndex = 0;
                cbb_lsx.DropDownHeight = 150;
                erorr_sl.Text = "";
                tb_sl.Text = "";
            }
            else
            {
                cbb_lsx.Text = "";
                tb_donGia.Text = "";
                tb_sl.Enabled = false;
                btn_add.Enabled = false;
                cbb_lsx.Enabled = false;
                lb_slCon.Visible = false;
                MessageBox.Show("Sản phẩm này không có lô sản xuất!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void loadDSHoaDon()
        {
            List<HoaDonDTO> listHoaDon = HoaDonBUS.Instance.GetAllHoaDon();
            handleDataView(listHoaDon);
        }

        private void handleDataView(List<HoaDonDTO> arr)
        {
            lv_DSHoaDon.Items.Clear();

            int stt = 1;

            foreach (HoaDonDTO hoaDon in arr)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(hoaDon.MaHD);
                item.SubItems.Add(hoaDon.NguoiLap);
                item.SubItems.Add(hoaDon.NgayLap.ToString("dd/MM/yyyy"));
                item.SubItems.Add(hoaDon.KhachHangID.ToString());
                item.SubItems.Add(hoaDon.ToaThuoc);
                item.SubItems.Add(hoaDon.DiemTichLuy.ToString());
                item.SubItems.Add(hoaDon.TongTien.ToString());

                lv_DSHoaDon.Items.Add(item);
                stt++;
            }
        }

        private void cbb_sp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemCbbMasp = cbb_sp.Text;
            string[] stringMasp = itemCbbMasp.Split('-');
            string masp = stringMasp[0].Trim();

            tb_sl.Enabled = true;
            btn_add.Enabled = true;
            cbb_lsx.Enabled = true;
            lb_slCon.Visible = true;

            loadDataCbbLosx(masp);
        }

        private void cbb_lsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLoSX = cbb_lsx.SelectedItem.ToString();

            if (losxToMaCTMap.TryGetValue(selectedLoSX, out int maCT))
            {
                mact = maCT;
                decimal giaBan = ChiTietSanPhamBUS.Instance.GetGiaBanByMaCT(maCT);
                tb_donGia.Text = string.Format("{0:0,0}", giaBan);
                int soLuong = ChiTietSanPhamBUS.Instance.GetSoLuongByMaCT(maCT);
                soLuongCon = soLuong;
                lb_slCon.Text = "Còn : " + soLuong;
            }
        }

        public bool ValidateInputs(string soluong)
        {
            bool ktra = true;
            if (string.IsNullOrWhiteSpace(soluong))
            {
                erorr_sl.Text = "Không được để trống";
                ktra = false;
            }
            else
            {
                if (int.TryParse(soluong, out int sl))
                {
                    if (sl > 0 && sl <= soLuongCon)
                    {
                        erorr_sl.Text = "";
                    }
                    else if (sl > soLuongCon)
                    {
                        erorr_sl.Text = "Không đủ số lượng";
                        ktra = false;
                    }
                    else
                    {
                        erorr_sl.Text = "Số lượng lớn hơn 0";
                        ktra = false;
                    }
                }
                else
                {
                    erorr_sl.Text = "Số lượng là số dương";
                    ktra = false;
                }
            }
            return ktra;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string mads = madsDangNhap;
            DateTime ngayLap = DateTime.Now;
            string soLuong = tb_sl.Text;
            string loSX = cbb_lsx.Text;

            string strNumber = tb_donGia.Text;
            strNumber = strNumber.Replace(",", "");
            int donGia = int.Parse(strNumber);

            string itemCbbMaKH = cbb_khach.Text;
            string[] stringMaKH = itemCbbMaKH.Split('-');
            string makh = stringMaKH[0].Trim();

            string itemCbbMasp = cbb_sp.Text;
            string[] stringMasp = itemCbbMasp.Split('-');
            string masp = stringMasp[0].Trim();
            string tensp = stringMasp[1].Trim();

            bool checkValue = ValidateInputs(soLuong);
            if (checkValue)
            {
                int numSl = int.Parse(soLuong);
                ChiTietSanPhamDTO ctspAdd = null;
                ChiTietHoaDonDTO cthdAdd = null;
                bool exists = false;

                foreach (ChiTietSanPhamDTO ctsp in tempCtsp)
                {
                    if (ctsp.MaCT == mact)
                    {
                        foreach (ChiTietHoaDonDTO cthd in tempCthd)
                        {
                            if (ctsp.MaCT == cthd.MaCT)
                            {
                                int soluongThem = cthd.SoLuong + numSl;
                                if (soluongThem > soLuongCon)
                                {
                                    erorr_sl.Text = "Không đủ số lượng";
                                    break;
                                }
                                else
                                {
                                    cthd.SoLuong += numSl;

                                }
                            }
                        }
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    ctspAdd = new ChiTietSanPhamDTO(mact, masp, loSX, DateTime.Now, DateTime.Now, 0, 0);
                    cthdAdd = new ChiTietHoaDonDTO("", mact, donGia, numSl);

                    tempCtsp.Add(ctspAdd);
                    tempCthd.Add(cthdAdd);
                    tb_sl.Text = "";
                }
                loadDataHoaDon(tempCthd, tempCtsp);
            }

        }

        private void loadDataHoaDon(List<ChiTietHoaDonDTO> arr1, List<ChiTietSanPhamDTO> arr2)
        {
            lv_HoaDon.Items.Clear();

            int stt = 1;
            tongTien = 0;
            foreach (ChiTietSanPhamDTO ctsp in arr2)
            {
                foreach (ChiTietHoaDonDTO cthd in arr1)
                {
                    if (ctsp.MaCT == cthd.MaCT)
                    {
                        ListViewItem item = new ListViewItem(stt.ToString());
                        item.SubItems.Add(ctsp.MaSP);
                        string tensp = SanPhamBUS.Instance.GetTenSPByMaSP(ctsp.MaSP);
                        item.SubItems.Add(tensp);
                        item.SubItems.Add(cthd.GiaBan.ToString());
                        item.SubItems.Add(cthd.SoLuong.ToString());

                        lv_HoaDon.Items.Add(item);
                        stt++;

                        tongTien += cthd.GiaBan * cthd.SoLuong;
                    }
                }
            }
            lb_tong.Text = "Tổng tiền : " + tongTien;
            int diemTichLuy = (int)(tongTien / 100000);
            dtl = diemTichLuy;
            lb_diemTichLuy.Text = "Điểm tích luỹ : " + diemTichLuy;
        }

        private void lv_HoaDon_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string stt = e.Item.SubItems[0].Text;
                sttDelEdit = int.Parse(stt);
                string masp = e.Item.SubItems[1].Text;
                string tensp = e.Item.SubItems[2].Text;
                string giaBan = e.Item.SubItems[3].Text;
                string soLuong = e.Item.SubItems[4].Text;

                ChiTietSanPhamDTO ctsp = tempCtsp[int.Parse(stt) - 1];

                tb_sl.Text = soLuong;
                tb_donGia.Text = giaBan;

                int index = 0;
                foreach (string chuoi in itemCbb_sp)
                {
                    string itemCbbMasp = chuoi;
                    string[] stringMasp = itemCbbMasp.Split('-');
                    string masp1 = stringMasp[0].Trim();
                    if (masp == masp1)
                    {
                        break;
                    }
                    index++;
                }
                cbb_sp.SelectedIndex = index;

                cbb_lsx.Items.Clear();
                List<ChiTietSanPhamDTO> listCTSPByLosx = ChiTietSanPhamBUS.Instance.GetLoSXAndCheckHSD(masp);
                List<string> itemCbb_lsx = new List<string>();
                foreach (ChiTietSanPhamDTO ctsp1 in listCTSPByLosx)
                {
                    itemCbb_lsx.Add(ctsp1.LoSX);
                }
                cbb_lsx.Items.AddRange(itemCbb_lsx.ToArray());

                int index1 = 0;
                foreach (string chuoi in itemCbb_lsx)
                {
                    string itemCbbLosx = chuoi;
                    string[] stringLosx = itemCbbLosx.Split('-');
                    string losx = stringLosx[0].Trim();
                    if (ctsp.LoSX == losx)
                    {
                        break;
                    }
                    index1++;
                }
                cbb_lsx.SelectedIndex = index1;

                // xử lý label & button
                btn_add.Enabled = false;
                btn_edit.Enabled = true;
                btn_del.Enabled = true;
            }
        }

        private void reset()
        {
            tb_sl.Text = "";
            cbb_sp.SelectedIndex = 0;
            sttDelEdit = 0;

            btn_add.Enabled = true;
            btn_del.Enabled = false;
            btn_edit.Enabled = false;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (sttDelEdit != 0)
            {
                DialogResult result = MessageBox.Show("Bạn muốn xoá sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tempCtsp.RemoveAt(sttDelEdit - 1);
                    tempCthd.RemoveAt(sttDelEdit - 1);
                    reset();
                    loadDataHoaDon(tempCthd, tempCtsp);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu cần xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (sttDelEdit != 0)
            {
                string mads = madsDangNhap;
                DateTime ngayLap = DateTime.Now;
                string soLuong = tb_sl.Text;
                string loSX = cbb_lsx.Text;

                string strNumber = tb_donGia.Text;
                strNumber = strNumber.Replace(".", "");
                int donGia = int.Parse(strNumber);

                string itemCbbMaKH = cbb_khach.Text;
                string[] stringMaKH = itemCbbMaKH.Split('-');
                string makh = stringMaKH[0].Trim();

                string itemCbbMasp = cbb_sp.Text;
                string[] stringMasp = itemCbbMasp.Split('-');
                string masp = stringMasp[0].Trim();
                string tensp = stringMasp[1].Trim();

                bool checkValue = ValidateInputs(soLuong);
                if (checkValue)
                {
                    int numSl = int.Parse(soLuong);
                    tempCtsp[sttDelEdit - 1] = new ChiTietSanPhamDTO(tempCtsp[sttDelEdit - 1].MaCT, masp, loSX, DateTime.Now, DateTime.Now, 0, 0);
                    tempCthd[sttDelEdit - 1] = new ChiTietHoaDonDTO("", tempCthd[sttDelEdit - 1].MaCT, donGia, numSl);
                    reset();
                    loadDataHoaDon(tempCthd, tempCtsp);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn huỷ hoá đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                reset();
                tb_toathuoc.Text = "";
                cbb_khach.SelectedIndex = 0;
                cb_SDdiem.Checked = false;
                tempCthd.Clear();
                tempCtsp.Clear();
                loadDataHoaDon(tempCthd, tempCtsp);
            }
        }

        private void btn_addKH_Click(object sender, EventArgs e)
        {
            FormAddKhachHang formAddKH = new FormAddKhachHang(this);
            formAddKH.StartPosition = FormStartPosition.CenterParent;
            formAddKH.ShowDialog(this);
        }

        private void btn_addHD_Click(object sender, EventArgs e)
        {
            string nguoiLap = madsDangNhap;
            DateTime ngayLap = DateTime.Now;
            int khachHang = 0;
            string toaThuoc = tb_toathuoc.Text;
            int diemTichLuy1 = 0;
            decimal tongTienAdd = tongTien;

            string itemCbbMaKH = cbb_khach.Text;
            string[] stringMaKH = itemCbbMaKH.Split('-');
            int khachHangID = int.Parse(stringMaKH[0].Trim());


            if (tempCtsp.Count <= 0 && tempCthd.Count <= 0)
            {
                MessageBox.Show("Vui lòng thêm sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(toaThuoc))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu toa thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn lập hoá đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool checkThanhCong = false;
                    string lastMaHD = HoaDonBUS.Instance.GetLastMaHD();
                    string prefix = lastMaHD.Substring(0, 2);
                    string numberPart = lastMaHD.Substring(2);

                    int nextNumber = int.Parse(numberPart) + 1;

                    string newMaHD = prefix + nextNumber.ToString("D4");

                    if (cb_SDdiem.Checked)
                    {
                        diemTichLuy1 = dtl;
                    }

                    bool checkAddHoaDon = HoaDonBUS.Instance.AddHoaDon(newMaHD, ngayLap, nguoiLap, khachHangID, toaThuoc, diemTichLuy1, tongTienAdd);
                    if (checkAddHoaDon)
                    {
                        int diemtlBanDau = KhachHangBUS.Instance.GetDiemKhachHang(khachHangID);
                        bool checkKH = KhachHangBUS.Instance.UpdateDiemKhachHang(khachHangID, diemtlBanDau + diemTichLuy1);
                        if (checkKH)
                        {
                            foreach (ChiTietSanPhamDTO ctsp in tempCtsp)
                            {
                                foreach (ChiTietHoaDonDTO cthd in tempCthd)
                                {
                                    if (ctsp.MaCT == cthd.MaCT)
                                    {
                                        bool checkAddCTHD = ChiTietHoaDonBUS.Instance.AddChiTietHoaDon(newMaHD, ctsp.MaCT, cthd.GiaBan, cthd.SoLuong);
                                        if (checkAddCTHD)
                                        {
                                            int slBanDau = ChiTietSanPhamBUS.Instance.GetSoLuongByMaCT(ctsp.MaCT);
                                            bool checkUpCTSP = ChiTietSanPhamBUS.Instance.UpdateSoLuongChiTietSanPham(ctsp.MaCT, slBanDau - cthd.SoLuong);
                                            if (checkUpCTSP)
                                            {
                                                checkThanhCong = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (checkThanhCong)
                    {
                        tb_toathuoc.Text = "";
                        cbb_khach.SelectedIndex = 0;
                        cb_SDdiem.Checked = false;
                        tempCthd.Clear();
                        tempCtsp.Clear();
                        reset();
                        loadDataHoaDon(tempCthd, tempCtsp);
                        loadDSHoaDon();
                        MessageBox.Show("Lập hoá đơn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void Lv_DSHoaDon_MouseClick(object sender, MouseEventArgs e)
        {
            if (lv_DSHoaDon.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lv_DSHoaDon.SelectedItems[0];
                string maHD = selectedItem.SubItems[1].Text;
                FormChiTietHoaDon formCTHD = new FormChiTietHoaDon(maHD);
                formCTHD.StartPosition = FormStartPosition.CenterParent;
                formCTHD.ShowDialog(this);
            }
        }

        private void cbb_find_SelectedIndexChanged(object sender, EventArgs e)
        {
            textCbb_find = cbb_find.Text;
            int indexCbb = cbb_find.SelectedIndex;
            UnShowFind();
            if (indexCbb == 0)
            {
                tb_find.Visible = true;
                tb_find.Text = "";
            }
            else if (indexCbb == 1)
            {
                cbb_findNguoiLap.Visible = true;
                cbb_findNguoiLap.SelectedIndex = 0;
            }
            else if (indexCbb == 2)
            {
                panel_ngayLap.Visible = true;
                date_find1.Value = DateTime.Now;
                date_find2.Value = DateTime.Now;
            }
            else if (indexCbb == 3)
            {
                cbb_findKh.Visible = true;
                cbb_findKh.SelectedIndex = 0;
            }
            else if (indexCbb == 4 || indexCbb == 5 || indexCbb == 6)
            {
                tb_find.Visible = true;
                tb_find.Text = "";
            }
            loadDSHoaDon();
        }

        private void UnShowFind()
        {
            tb_find.Visible = false;
            panel_ngayLap.Visible = false;
            cbb_findKh.Visible = false;
            cbb_findNguoiLap.Visible = false;
        }

        private void Tb_find_TextChanged(object sender, EventArgs e)
        {
            string dataFind = tb_find.Text;
            string param = "";
            if (textCbb_find == "Mã HĐ")
            {
                param = "mahd";
            }
            if (textCbb_find == "Toa thuốc")
            {
                param = "toathuoc";
            }
            if (textCbb_find == "Điểm")
            {
                param = "diemtichluy";
            }
            if (textCbb_find == "Tổng tiền")
            {
                param = "tongtien";
            }
            List<HoaDonDTO> listHoaDonFind = HoaDonBUS.Instance.FindHoaDon(param, dataFind);
            handleDataView(listHoaDonFind);
        }

        private void Cbb_findNguoiLap_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemCbbMaDS = cbb_findNguoiLap.Text;

            if (itemCbbMaDS == "Tất cả dược sĩ")
            {
                List<HoaDonDTO> listHoaDonFind = HoaDonBUS.Instance.GetAllHoaDon();
                handleDataView(listHoaDonFind);
            }
            else
            {
                string[] stringMaDS = itemCbbMaDS.Split('-');
                string mads = stringMaDS[0].Trim();

                List<HoaDonDTO> listHoaDonFind = HoaDonBUS.Instance.FindHoaDon("nguoilap", mads);
                handleDataView(listHoaDonFind);
            }
        }

        private void Cbb_findKh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemCbbMaKH = cbb_findKh.Text;

            if (itemCbbMaKH == "Tất cả khách hàng")
            {
                List<HoaDonDTO> listHoaDonFind = HoaDonBUS.Instance.GetAllHoaDon();
                handleDataView(listHoaDonFind);
            }
            else
            {
                string[] stringMaKH = itemCbbMaKH.Split('-');
                string makh = stringMaKH[0].Trim();

                List<HoaDonDTO> listHoaDonFind = HoaDonBUS.Instance.FindHoaDon("khachhang", makh);
                handleDataView(listHoaDonFind);
            }
        }

        private void date_find1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1 = date_find1.Value.Date;
            DateTime date2 = date_find2.Value.Date;

            List<HoaDonDTO> listHoaDonFind = HoaDonBUS.Instance.FindHoaDonByNgayLap(date1, date2);
            handleDataView(listHoaDonFind);
        }

        private void date_find2_ValueChanged(object sender, EventArgs e)
        {
            DateTime date1 = date_find1.Value.Date;
            DateTime date2 = date_find2.Value.Date;

            List<HoaDonDTO> listHoaDonFind = HoaDonBUS.Instance.FindHoaDonByNgayLap(date1, date2);
            handleDataView(listHoaDonFind);
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xuất File PDF", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                // Đường dẫn cơ bản cho file PDF
                string baseFilePath = @"D:\dataCSharp\FliePdfHoaDon\XuatHoaDonPdf.pdf";
                string filePath = baseFilePath;

                //Kiểm tra và tạo tên file mới nếu đã tồn tại
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
                page.Width = XUnit.FromMillimeter(315); // Chiều rộng tùy chỉnh (Ví dụ: 420 mm tương đương với A3)
                page.Height = XUnit.FromMillimeter(297); // Chiều cao tùy chỉnh (297 mm)
                XGraphics gfx = XGraphics.FromPdfPage(page);

                double rowHeight = 30;      // Chiều cao mỗi dòng
                double pageHeight = page.Height.Point;  // Chiều cao tối đa của trang PDF

                int rongStt = 40;
                int rongMakh = 60;
                int rongHoTen = 90;
                int rongNgaySinh = 195;
                int rongGt = 190;
                int rongSdt = 180;
                int rongDiem = 45;
                int rongTongTien = 92;

                int vtSTT = 0;
                int vtMakh = vtSTT + rongStt;
                int vtHoTen = vtMakh + rongMakh;
                int vtNgaySinh = vtHoTen + rongHoTen;
                int vtGioiTinh = vtNgaySinh + rongNgaySinh;
                int vtSDT = vtGioiTinh + rongGt;
                int vtDiem = vtSDT + rongSdt;
                int vtTong = vtDiem + rongDiem;

                // Vẽ tiêu đề trang và tiêu đề bảng trên trang đầu tiên
                XFont titleFont = new XFont("Verdana", 22);
                gfx.DrawString("Danh sách Hoá Đơn", titleFont, XBrushes.Black, new XPoint(300, 30));

                XFont headerFont = new XFont("Verdana", 12);
                gfx.DrawString("STT", headerFont, XBrushes.Black, new XPoint(5, 65));
                gfx.DrawRectangle(XPens.Black, vtSTT, 44, rongStt, rowHeight);
                gfx.DrawString("MaHĐ", headerFont, XBrushes.Black, new XPoint(50, 65));
                gfx.DrawRectangle(XPens.Black, vtMakh, 44, rongMakh, rowHeight);
                gfx.DrawString("Ngày lập", headerFont, XBrushes.Black, new XPoint(117, 65));
                gfx.DrawRectangle(XPens.Black, vtHoTen, 44, rongHoTen, rowHeight);
                gfx.DrawString("Người lập", headerFont, XBrushes.Black, new XPoint(200, 65));
                gfx.DrawRectangle(XPens.Black, vtNgaySinh, 44, rongNgaySinh, rowHeight);
                gfx.DrawString("Khách hàng", headerFont, XBrushes.Black, new XPoint(395, 65));
                gfx.DrawRectangle(XPens.Black, vtGioiTinh, 44, rongGt, rowHeight);
                gfx.DrawString("Toa thuốc", headerFont, XBrushes.Black, new XPoint(585, 65));
                gfx.DrawRectangle(XPens.Black, vtSDT, 44, rongSdt, rowHeight);
                gfx.DrawString("ĐTL", headerFont, XBrushes.Black, new XPoint(765, 65));
                gfx.DrawRectangle(XPens.Black, vtDiem, 44, rongDiem, rowHeight);
                gfx.DrawString("Tổng tiền", headerFont, XBrushes.Black, new XPoint(810, 65));
                gfx.DrawRectangle(XPens.Black, vtTong, 44, rongTongTien, rowHeight);

                // Vị trí bắt đầu vẽ các dòng dữ liệu
                int yPosition = 92;
                int khoangCachDOng = 18;
                List<HoaDonDTO> listHDXuatFile = HoaDonBUS.Instance.GetAllHoaDon();
                int stt = 1;

                foreach (var item in listHDXuatFile)
                {
                    // Nếu vị trí y vượt quá chiều cao trang, thêm trang mới mà không vẽ lại tiêu đề
                    if (yPosition > pageHeight - rowHeight)
                    {
                        page = document.AddPage();
                        page.Width = XUnit.FromMillimeter(315);
                        page.Height = XUnit.FromMillimeter(297); // Chiều cao tùy chỉnh (297 mm)
                        gfx = XGraphics.FromPdfPage(page);
                        yPosition = 30;   // Đặt lại vị trí y trên trang mới
                    }
                    // Vẽ dữ liệu của mỗi dòng
                    gfx.DrawString(stt.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(10, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtSTT, yPosition - khoangCachDOng, rongStt, rowHeight);
                    gfx.DrawString(item.MaHD.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(45, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtMakh, yPosition - khoangCachDOng, rongMakh, rowHeight);
                    gfx.DrawString(item.NgayLap.ToString("dd/MM/yyyy"), new XFont("Verdana", 12), XBrushes.Black, new XPoint(109, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtHoTen, yPosition - khoangCachDOng, rongHoTen, rowHeight);
                    string hoTenNguoiLap = DuocSiBUS.Instance.getHoTenDuocSi(item.NguoiLap);
                    gfx.DrawString(hoTenNguoiLap, new XFont("Verdana", 12), XBrushes.Black, new XPoint(200, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtNgaySinh, yPosition - khoangCachDOng, rongNgaySinh, rowHeight);
                    KhachHangDTO khachHang = KhachHangBUS.Instance.GetKhachHangByMaKH(item.KhachHangID);
                    gfx.DrawString(khachHang.HoTen, new XFont("Verdana", 12), XBrushes.Black, new XPoint(395, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtGioiTinh, yPosition - khoangCachDOng, rongGt, rowHeight);
                    gfx.DrawString(item.ToaThuoc, new XFont("Verdana", 12), XBrushes.Black, new XPoint(585, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtSDT, yPosition - khoangCachDOng, rongSdt, rowHeight);
                    if(item.DiemTichLuy < 10)
                    {
                        gfx.DrawString(item.DiemTichLuy.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(772, yPosition));
                    }
                    else
                    {
                        gfx.DrawString(item.DiemTichLuy.ToString(), new XFont("Verdana", 12), XBrushes.Black, new XPoint(769, yPosition));
                    }
                    gfx.DrawRectangle(XPens.Black, vtDiem, yPosition - khoangCachDOng, rongDiem, rowHeight);
                    gfx.DrawString(item.TongTien.ToString("N0"), new XFont("Verdana", 12), XBrushes.Black, new XPoint(810, yPosition));
                    gfx.DrawRectangle(XPens.Black, vtTong, yPosition - khoangCachDOng, rongTongTien, rowHeight);

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
