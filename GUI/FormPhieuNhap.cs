using BUS;
using DTO;
using ExcelDataReader;
using OfficeOpenXml;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Pqc.Crypto.Lms;
using Org.BouncyCastle.Utilities;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.UniversalAccessibility.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class FormPhieuNhap : Form
    {

        List<ChiTietSanPhamDTO> tempCTSP = new List<ChiTietSanPhamDTO>();
        List<ChiTietPhieuNhapDTO> tempCTPN = new List<ChiTietPhieuNhapDTO>();
        List<ChiTietPhieuNhapDTO> chiTietPhieuNhapList = ChiTietPhieuNhapBUS.Instance.GetAllCTPN();
        List<ChiTietSanPhamDTO> chiTietSanPhamList = ChiTietSanPhamBUS.Instance.GetAllCTSP();
        List<string> itemCbb_sp = new List<string>();
        string numDel_Edit = "";
        string madsDangNhap = "";
        decimal tongTien = 0;
        int ttPdf = 0;

        public FormPhieuNhap(string madsDN)
        {
            madsDangNhap = madsDN;
            InitializeComponent();
            loadPhieuNhapData();
            loadData();
            ShowPanel(pn_maPN);
        }

        private void loadData()
        {
            pntb_ngayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
            pntb_nguoiLap.Text = madsDangNhap;

            List<NhaCungCapDTO> listNCC = NhaCungCapBUS.Instance.GetNhaCungCapByTrangThai();
            List<SanPhamDTO> listSP = SanPhamBUS.Instance.GetProductsByTrangThai();
            List<NhaCungCapDTO> listAllNCC = NhaCungCapBUS.Instance.GetAllNhaCungCap();
            List<DuocSiDTO> listAllDuocSi = DuocSiBUS.Instance.GetAllDuocSi();

            List<string> itemCbb_ncc = new List<string>();
            foreach (NhaCungCapDTO ncc in listNCC)
            {
                string item = $"{ncc.MaNCC} - {ncc.TenNCC}";
                itemCbb_ncc.Add(item);
            }
            pncbb_ncc.Items.AddRange(itemCbb_ncc.ToArray());
            pncbb_ncc.DropDownHeight = 200;
            pncbb_ncc.SelectedIndex = 0;

            foreach (SanPhamDTO sp in listSP)
            {
                string item = $"{sp.MaSP} - {sp.TenSP}";
                itemCbb_sp.Add(item);
            }
            pncbb_masp.Items.AddRange(itemCbb_sp.ToArray());
            pncbb_masp.DropDownHeight = 200;
            pncbb_masp.SelectedIndex = 0;

            List<string> itemCbb_AllNcc = new List<string>();
            string item1 = "Tất cả";
            itemCbb_AllNcc.Add(item1);
            foreach (NhaCungCapDTO ncc in listAllNCC)
            {
                string item = $"{ncc.MaNCC} - {ncc.TenNCC}";
                itemCbb_AllNcc.Add(item);
            }
            cbb_ncc.Items.AddRange(itemCbb_AllNcc.ToArray());
            cbb_ncc.DropDownHeight = 200;
            cbb_ncc.SelectedIndex = 0;

            List<string> itemCbb_AllDS = new List<string>();
            itemCbb_AllDS.Add(item1);
            foreach (DuocSiDTO ds in listAllDuocSi)
            {
                string item = $"{ds.MaDS} - {ds.HoTen}";
                itemCbb_AllDS.Add(item);
            }
            cbb_nguoinhap.Items.AddRange(itemCbb_AllDS.ToArray());
            cbb_nguoinhap.DropDownHeight = 200;
            cbb_nguoinhap.SelectedIndex = 0;
        }

        private void loadPhieuNhapData()
        {
            List<PhieuNhapDTO> listPN = PhieuNhapBUS.Instance.GetAllPhieuNhap();
            handleDataViewDSPN(listPN);
        }

        private void handleDataViewDSPN(List<PhieuNhapDTO> arr)
        {
            lv_DSPN.Items.Clear();

            int stt = 1;

            foreach (PhieuNhapDTO phieuNhap in arr)
            {
                ListViewItem item = new ListViewItem(stt.ToString());
                item.SubItems.Add(phieuNhap.MaPN);
                item.SubItems.Add(phieuNhap.NgayLap.ToString("dd/MM/yyyy"));
                item.SubItems.Add(phieuNhap.NguoiLap);
                item.SubItems.Add(phieuNhap.NhaCungCap);
                item.SubItems.Add(phieuNhap.TongTien.ToString());

                lv_DSPN.Items.Add(item);

                stt++;
            }
        }

        private void loadDataChiTietPN(string mapn)
        {
            lv_CTPN.Items.Clear();

            int stt = 1;

            foreach (ChiTietPhieuNhapDTO chiTietPN in chiTietPhieuNhapList)
            {

                foreach (ChiTietSanPhamDTO chiTietSP in chiTietSanPhamList)
                {
                    if (chiTietPN.MaPN == mapn)
                    {
                        if (chiTietPN.MaCT == chiTietSP.MaCT)
                        {
                            ListViewItem item = new ListViewItem(stt.ToString());
                            item.SubItems.Add(chiTietSP.MaSP);
                            item.SubItems.Add(chiTietSP.LoSX);
                            item.SubItems.Add(chiTietSP.NgaySX.ToString("dd/MM/yyyy"));
                            item.SubItems.Add(chiTietSP.HanSD.ToString("dd/MM/yyyy"));
                            item.SubItems.Add(chiTietPN.GiaNhap.ToString());
                            item.SubItems.Add(chiTietSP.GiaBan.ToString());
                            item.SubItems.Add(chiTietPN.SoLuong.ToString());

                            lv_CTPN.Items.Add(item);

                            stt++;
                        }
                    }
                }
            }
        }

        private void lv_DSPN_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string maPN = e.Item.SubItems[1].Text;
                string ngayLap = e.Item.SubItems[2].Text;
                string nguoiLap = e.Item.SubItems[3].Text;
                string nhaCungCap = e.Item.SubItems[4].Text;
                int tongTien = int.Parse(e.Item.SubItems[5].Text);
                ttPdf = tongTien;

                string mads_hoten = nguoiLap + " - " + DuocSiBUS.Instance.getHoTenDuocSi(nguoiLap);
                string mancc_ten = nhaCungCap + " - " + NhaCungCapBUS.Instance.getTenNcc(nhaCungCap);

                tb_maPhieu.Text = maPN;
                tb_ngayLap.Text = ngayLap;
                tb_nguoiLap.Text = mads_hoten;
                tb_ncc.Text = mancc_ten;
                lb_tongTien.Text = "Tổng tiền : " + tongTien.ToString("N0");

                loadDataChiTietPN(maPN);

                //reser ttsp
                tb_maSp.Text = "";
                tb_LoSx.Text = "";
                tb_Nsx.Text = "";
                tb_Hsd.Text = "";
                tb_giaNhap.Text = "";
                tb_giaBan.Text = "";
                tb_sl.Text = "";
            }
        }

        private void lv_CTPN_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string maSP = e.Item.SubItems[1].Text;
                string loSX = e.Item.SubItems[2].Text;
                string ngaySX = e.Item.SubItems[3].Text;
                string hanSD = e.Item.SubItems[4].Text;
                string giaNhap = e.Item.SubItems[5].Text;
                string giaBan = e.Item.SubItems[6].Text;
                string soLuong = e.Item.SubItems[7].Text;

                tb_maSp.Text = maSP;
                tb_LoSx.Text = loSX;
                tb_Nsx.Text = ngaySX;
                tb_Hsd.Text = hanSD;
                tb_giaNhap.Text = giaNhap;
                tb_giaBan.Text = giaBan;
                tb_sl.Text = soLuong;
            }
        }

        private void loadDataThongTinPN(List<ChiTietSanPhamDTO> arr, List<ChiTietPhieuNhapDTO> arr1)
        {
            lv_LapPhieu.Items.Clear();

            int stt = 1;
            tongTien = 0;
            foreach (ChiTietSanPhamDTO ctsp in arr)
            {
                foreach (ChiTietPhieuNhapDTO ctpn in arr1)
                {
                    if (ctsp.MaCT == ctpn.MaCT)
                    {
                        ListViewItem item = new ListViewItem(stt.ToString());
                        item.SubItems.Add(ctsp.MaSP);
                        item.SubItems.Add(ctsp.LoSX);
                        item.SubItems.Add(ctsp.NgaySX.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(ctsp.HanSD.ToString("dd/MM/yyyy"));
                        item.SubItems.Add(ctpn.GiaNhap.ToString());
                        item.SubItems.Add(ctsp.GiaBan.ToString());
                        item.SubItems.Add(ctpn.SoLuong.ToString());

                        lv_LapPhieu.Items.Add(item);
                        stt++;

                        tongTien += ctpn.GiaNhap * ctpn.SoLuong;
                    }
                }
            }
            lbpn_tongTien.Text = "Tổng tiền : " + tongTien.ToString("N0");
        }

        private void pnbtn_save_Click(object sender, EventArgs e)
        {
            string itemCbbMasp = pncbb_masp.Text;
            string[] stringMasp = itemCbbMasp.Split('-');
            string masp = stringMasp[0].Trim();

            string losx = pntb_loSx.Text;
            string ngaysx = pnDate_nsx.Value.ToString("dd/MM/yyyy");
            string hansd = pnDate_hsd.Value.ToString("dd/MM/yyyy");
            string giaNhap = pntb_giaNhap.Text; ;
            string giaBan = pntb_giaBan.Text;
            string soLuong = pntb_sl.Text;

            // lấy date của nsx & hsd
            DateTime dateNSX = pnDate_nsx.Value;
            DateTime dateHSD = pnDate_hsd.Value;

            bool ktra = ValidateInputs(losx, dateNSX, dateHSD, giaNhap, giaBan, soLuong);
            if (ktra)
            {
                if (decimal.TryParse(giaBan, out decimal giaBanThem) && decimal.TryParse(giaNhap, out decimal giaNhapThem) && int.TryParse(soLuong, out int soLuongThem))
                {
                    Random random = new Random();
                    int mactRandom = random.Next(1, 99999);
                    tempCTSP.Add(new ChiTietSanPhamDTO(mactRandom, masp, losx, dateNSX, dateHSD, giaBanThem, 0));
                    tempCTPN.Add(new ChiTietPhieuNhapDTO("0", mactRandom, giaNhapThem, soLuongThem));
                    loadDataThongTinPN(tempCTSP, tempCTPN);
                    reset();
                }
            }
        }

        public bool ValidateInputs(string loSx, DateTime nsx, DateTime hsd, string giaNhap, string giaBan, string soLuong)
        {
            bool ktra = true;
            if (string.IsNullOrWhiteSpace(loSx) || string.IsNullOrWhiteSpace(giaNhap) || string.IsNullOrWhiteSpace(giaBan) || string.IsNullOrWhiteSpace(soLuong))
            {
                MessageBox.Show("Không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ktra = false;
            }
            else
            {
                // tra giá nhập
                if (decimal.TryParse(giaNhap, out decimal giaNhapValue))
                {
                    if (giaNhapValue % 100 == 0)
                    {
                        erorr_giaNhap.Text = "";
                    }
                    else
                    {
                        erorr_giaNhap.Text = "Giá nhập phải chia hết cho 100";
                        ktra = false;
                    }
                }
                else
                {
                    erorr_giaNhap.Text = "Giá nhập phải là số dương";
                    ktra = false;
                }
                // tra giá bán
                if (decimal.TryParse(giaBan, out decimal giaBanValue))
                {
                    if (giaBanValue > giaNhapValue)
                    {
                        if (giaBanValue % 100 == 0)
                        {
                            erorr_giaBan.Text = "";
                        }
                        else
                        {
                            erorr_giaBan.Text = "Giá bán phải chia hết cho 100";
                            ktra = false;
                        }
                    }
                    else
                    {
                        erorr_giaBan.Text = "Giá bán phải lớn hơn giá nhập";
                        ktra = false;
                    }
                }
                else
                {
                    erorr_giaBan.Text = "Giá bán phải là số dương";
                    ktra = false;
                }
                // tra số lượng
                if (decimal.TryParse(soLuong, out decimal soLuongValue))
                {
                    if (soLuongValue > 0)
                    {
                        erorr_soLuong.Text = "";
                    }
                    else
                    {
                        erorr_soLuong.Text = "Số lượng phải lớn hơn 0";
                        ktra = false;
                    }
                }
                else
                {
                    erorr_soLuong.Text = "Số lượng phải là số dương";
                    ktra = false;
                }
                // tra  hạn sử dụng
                if (hsd > DateTime.Now && hsd > nsx)
                {
                    erorr_hsd.Text = "";
                }
                else
                {
                    if (hsd <= DateTime.Now)
                    {
                        erorr_hsd.Text = "HSD phải lớn hơn ngày hiện tại.";
                    }
                    else if (hsd <= nsx)
                    {
                        erorr_hsd.Text = "HSD phải lớn hơn NSX";
                    }
                    ktra = false;
                }
                // tra ngày sản xuất
                if (nsx < hsd || hsd == DateTime.Now)
                {
                    erorr_nsx.Text = "";
                }
                else
                {
                    erorr_nsx.Text = "NSX phải bé hơn HSD";
                    ktra = false;
                }
            }
            return ktra;
        }

        private void lv_LapPhieu_SelectedIndexChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                numDel_Edit = e.Item.SubItems[0].Text;
                string masp = e.Item.SubItems[1].Text;
                string losx = e.Item.SubItems[2].Text;
                string nsx = e.Item.SubItems[3].Text;
                string hanhsdSD = e.Item.SubItems[4].Text;
                string giaNhap = e.Item.SubItems[5].Text;
                string giaBan = e.Item.SubItems[6].Text;
                string soLuong = e.Item.SubItems[7].Text;

                pntb_loSx.Text = losx;
                pntb_giaNhap.Text = giaNhap;
                pntb_giaBan.Text = giaBan;
                pntb_sl.Text = soLuong;
                if (DateTime.TryParse(nsx, out DateTime nsxDate))
                {
                    pnDate_nsx.Value = nsxDate;
                }

                if (DateTime.TryParse(hanhsdSD, out DateTime hsdDate))
                {
                    pnDate_hsd.Value = hsdDate;
                }
                int index = 0;
                foreach (string chuoi in itemCbb_sp)
                {
                    string[] stringMasp = chuoi.Split('-');
                    string maspcbb = stringMasp[0].Trim();

                    if (maspcbb == masp)
                    {
                        break;
                    }
                    index++;
                }
                pncbb_masp.SelectedIndex = index;

                pnbtn_save.Enabled = false;
                pnbtn_edit.Enabled = true;
                pnbtn_del.Enabled = true;
            }
        }

        private void reset()
        {
            pntb_loSx.Text = "";
            pntb_giaNhap.Text = "";
            pntb_giaBan.Text = "";
            pntb_sl.Text = "";
            pncbb_masp.SelectedIndex = 0;
            pnDate_nsx.Value = DateTime.Now;
            pnDate_hsd.Value = DateTime.Now;
            pnbtn_edit.Enabled = false;
            pnbtn_del.Enabled = false;
            pnbtn_save.Enabled = true;
        }

        private void pnbtn_clear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string itemCbbNcc = pncbb_ncc.Text;
            string[] stringNcc = itemCbbNcc.Split('-');
            string mancc = stringNcc[0].Trim();

            string itemCbbMasp = pncbb_masp.Text;
            string[] stringMasp = itemCbbMasp.Split('-');
            string masp = stringMasp[0].Trim();

            string losx = pntb_loSx.Text;
            string ngaysx = pnDate_nsx.Value.ToString("dd/MM/yyyy");
            string hansd = pnDate_hsd.Value.ToString("dd/MM/yyyy");
            string giaNhap = pntb_giaNhap.Text; ;
            string giaBan = pntb_giaBan.Text;
            string soLuong = pntb_sl.Text;

            // lấy date của nsx & hsd
            DateTime dateNSX = pnDate_nsx.Value;
            DateTime dateHSD = pnDate_hsd.Value;

            if (int.TryParse(numDel_Edit, out int indexDel))
            {
                bool ktra = ValidateInputs(losx, dateNSX, dateHSD, giaNhap, giaBan, soLuong);
                if (ktra)
                {
                    if (decimal.TryParse(giaBan, out decimal giaBanThem) && decimal.TryParse(giaNhap, out decimal giaNhapThem) && int.TryParse(soLuong, out int soLuongThem))
                    {
                        tempCTSP[indexDel - 1] = new ChiTietSanPhamDTO(tempCTSP[indexDel - 1].MaCT, masp, losx, dateNSX, dateHSD, giaBanThem, 0);
                        tempCTPN[indexDel - 1] = new ChiTietPhieuNhapDTO("0", tempCTPN[indexDel - 1].MaCT, giaNhapThem, soLuongThem);
                        loadDataThongTinPN(tempCTSP, tempCTPN);
                        reset();
                    }
                }


            }
        }

        private void pnbtn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn huỷ bỏ phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                reset();
                pncbb_ncc.SelectedIndex = 0;
                tempCTSP.Clear();
                tempCTPN.Clear();
                loadDataThongTinPN(tempCTSP, tempCTPN);
            }
        }

        private void pnbtn_del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xoá sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (int.TryParse(numDel_Edit, out int indexDel))
                {
                    tempCTSP.RemoveAt(indexDel - 1);
                    tempCTPN.RemoveAt(indexDel - 1);
                    reset();
                    loadDataThongTinPN(tempCTSP, tempCTPN);
                }
            }
        }

        private void pnbtn_LapPhieu_Click(object sender, EventArgs e)
        {
            string lastMaPn = PhieuNhapBUS.Instance.GetLastMaPN();
            string prefix = lastMaPn.Substring(0, 2);
            string numberPart = lastMaPn.Substring(2);

            int nextNumber = int.Parse(numberPart) + 1;

            string newMaPn = prefix + nextNumber.ToString("D4");
            DateTime ngayLap = DateTime.Now;
            string nguoiLap = madsDangNhap;
            decimal tongTienAdd = tongTien;

            // lấy ncc
            string itemCbbNcc = pncbb_ncc.Text;
            string[] stringNcc = itemCbbNcc.Split('-');
            string nhaCungCap = stringNcc[0].Trim();

            if (tempCTSP.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn muốn lập phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    bool checkAddPhieuNhap = PhieuNhapBUS.Instance.AddPhieuNhap(newMaPn, ngayLap, nguoiLap, nhaCungCap, tongTienAdd);
                    if (checkAddPhieuNhap)
                    {
                        bool checkAll = false;
                        foreach (ChiTietSanPhamDTO ctsp in tempCTSP)
                        {
                            foreach (ChiTietPhieuNhapDTO ctpn in tempCTPN)
                            {
                                if (ctsp.MaCT == ctpn.MaCT)
                                {
                                    int mact = ChiTietSanPhamBUS.Instance.GetLastMaCT() + 1;
                                    bool checkAddCtsp = ChiTietSanPhamBUS.Instance.AddChiTietSanPham(mact, ctsp.MaSP, ctsp.LoSX, ctsp.NgaySX, ctsp.HanSD, ctsp.GiaBan, ctpn.SoLuong);
                                    if (checkAddCtsp)
                                    {
                                        bool checkAddCtpn = ChiTietPhieuNhapBUS.Instance.AddChiTietPhieuNhap(newMaPn, mact, ctpn.GiaNhap, ctpn.SoLuong);
                                        if (checkAddCtpn)
                                        {
                                            checkAll = true;
                                        }
                                    }

                                }
                            }
                        }
                        if (checkAll)
                        {
                            MessageBox.Show("Thêm phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            reset();
                            pncbb_ncc.SelectedIndex = 0;
                            tempCTSP.Clear();
                            tempCTPN.Clear();
                            loadDataThongTinPN(tempCTSP, tempCTPN);
                            lbpn_tongTien.Text = "Tổng tiền : 0";
                            loadPhieuNhapData();
                            loadData();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void cb_mapn_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mapn.Checked)
            {
                cb_ngaylap.Checked = false;
                cb_nguoinhap.Checked = false;
                cb_ncc.Checked = false;
                tb_maPN.Text = "";
                ShowPanel(pn_maPN);
            }
        }

        private void cb_ngaylap_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ngaylap.Checked)
            {
                cb_mapn.Checked = false;
                cb_nguoinhap.Checked = false;
                cb_ncc.Checked = false;
                date1_nl.Value = DateTime.Now;
                date2_nl.Value = DateTime.Now;
                ShowPanel(pn_ngaylap);
            }
        }

        private void cb_nguoinhap_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nguoinhap.Checked)
            {
                cb_mapn.Checked = false;
                cb_ngaylap.Checked = false;
                cb_ncc.Checked = false;
                cbb_nguoinhap.SelectedIndex = 0;
                ShowPanel(pn_nguoinhap);
            }
        }

        private void cb_ncc_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ncc.Checked)
            {
                cb_mapn.Checked = false;
                cb_ngaylap.Checked = false;
                cb_nguoinhap.Checked = false;
                cbb_ncc.SelectedIndex = 0;
                ShowPanel(pn_ncc);
            }
        }

        private void ShowPanel(Panel panelToShow)
        {
            pn_maPN.Visible = false;
            pn_ngaylap.Visible = false;
            pn_nguoinhap.Visible = false;
            pn_ncc.Visible = false;

            panelToShow.Visible = true;
            loadPhieuNhapData();
        }

        private void tb_maPN_TextChanged(object sender, EventArgs e)
        {
            string mapn = tb_maPN.Text;
            List<PhieuNhapDTO> arrMapn = PhieuNhapBUS.Instance.SearchPhieuNhap("mapn", mapn, DateTime.Now, DateTime.Now);
            handleDataViewDSPN(arrMapn);
        }

        private void resetFind()
        {
            tb_maPN.Text = "";
            date1_nl.Value = DateTime.Now;
            date2_nl.Value = DateTime.Now;
            cbb_nguoinhap.SelectedIndex = 0;
            cbb_ncc.SelectedIndex = 0;

            // reset thông tin phiếu nhập
            tb_maPhieu.Text = "";
            tb_ngayLap.Text = "";
            tb_nguoiLap.Text = "";
            tb_ncc.Text = "";
            tb_maSp.Text = "";
            tb_Nsx.Text = "";
            tb_giaNhap.Text = "";
            tb_sl.Text = "";
            tb_LoSx.Text = "";
            tb_Hsd.Text = "";
            tb_giaBan.Text = "";
            loadDataChiTietPN("-1");

            loadPhieuNhapData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            resetFind();
        }

        private void cbb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_ncc.SelectedItem != null)
            {
                string selected = cbb_ncc.SelectedItem.ToString();
                if (selected == "Tất cả")
                {
                    loadPhieuNhapData();
                }
                else
                {
                    string[] stringMasp = selected.Split('-');
                    string mancc = stringMasp[0].Trim();

                    List<PhieuNhapDTO> arrNcc = PhieuNhapBUS.Instance.SearchPhieuNhap("nhacungcap", mancc, DateTime.Now, DateTime.Now);
                    handleDataViewDSPN(arrNcc);
                }
            }
        }

        private void cbb_nguoinhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_nguoinhap.SelectedItem != null)
            {
                string selected = cbb_nguoinhap.SelectedItem.ToString();
                if (selected == "Tất cả")
                {
                    loadPhieuNhapData();
                }
                else
                {
                    string[] stringNguoiNhap = selected.Split('-');
                    string nguoiNhap = stringNguoiNhap[0].Trim();

                    List<PhieuNhapDTO> arrNguoiNhap = PhieuNhapBUS.Instance.SearchPhieuNhap("nguoinhap", nguoiNhap, DateTime.Now, DateTime.Now);
                    handleDataViewDSPN(arrNguoiNhap);
                }
            }
        }

        private void loadDataPhieuNhapFindByNgayLap()
        {
            DateTime selectedDate1 = date1_nl.Value;
            DateTime selectedDate2 = date2_nl.Value;

            selectedDate1 = selectedDate1.Date;
            selectedDate2 = selectedDate2.Date;

            if (selectedDate1 == DateTime.Now && selectedDate2 == DateTime.Now)
            {
                loadPhieuNhapData();
            }
            else
            {
                List<PhieuNhapDTO> arrNcc = PhieuNhapBUS.Instance.SearchPhieuNhap("ngaylap", "", selectedDate1, selectedDate2);
                handleDataViewDSPN(arrNcc);
            }
        }

        private void date1_nl_CloseUp(object sender, EventArgs e)
        {
            loadDataPhieuNhapFindByNgayLap();
        }

        private void date2_nl_CloseUp(object sender, EventArgs e)
        {
            loadDataPhieuNhapFindByNgayLap();
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


        private void btn_xuatDS_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xuất File PDF", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                // Đường dẫn cơ bản cho file PDF
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Lưu file PDF";
                    saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveFileDialog.FileName = "XuatPhieuNhapPdf.pdf";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        // Tạo tài liệu PDF
                        PdfDocument document = new PdfDocument();
                        document.Info.Title = "Created with PDFsharp";

                        // Tạo trang đầu tiên
                        PdfPage page = document.AddPage();
                        page.Width = XUnit.FromMillimeter(264); // Chiều rộng tùy chỉnh (Ví dụ: 420 mm tương đương với A3)
                        page.Height = XUnit.FromMillimeter(297); // Chiều cao tùy chỉnh (297 mm)
                        XGraphics gfx = XGraphics.FromPdfPage(page);

                        int rowHeight = 30;      // Chiều cao mỗi dòng
                        double pageHeight = page.Height.Point;  // Chiều cao tối đa của trang PDF

                        int rongStt = 35;
                        int rongMakh = 65;
                        int rongHoTen = 90;
                        int rongNgaySinh = 170;
                        int rongGt = 300;
                        int rongSdt = 87;

                        int vtSTT = 0;
                        int vtMakh = vtSTT + rongStt;
                        int vtHoTen = vtMakh + rongMakh;
                        int vtNgaySinh = vtHoTen + rongHoTen;
                        int vtGioiTinh = vtNgaySinh + rongNgaySinh;
                        int vtSDT = vtGioiTinh + rongGt;

                        // Vẽ tiêu đề trang và tiêu đề bảng trên trang đầu tiên
                        XFont titleFont = new XFont("Verdana", 22);
                        gfx.DrawString("Danh sách phiếu nhập", titleFont, XBrushes.Black, new XPoint(250, 30));

                        XFont headerFont = new XFont("Verdana", 12);
                        gfx.DrawString("STT", headerFont, XBrushes.Black, new XPoint(5, 65));
                        gfx.DrawRectangle(XPens.Black, vtSTT, 44, rongStt, rowHeight);
                        gfx.DrawString("MaPN", headerFont, XBrushes.Black, new XPoint(48, 65));
                        gfx.DrawRectangle(XPens.Black, vtMakh, 44, rongMakh, rowHeight);
                        gfx.DrawString("Ngày lập", headerFont, XBrushes.Black, new XPoint(117, 65));
                        gfx.DrawRectangle(XPens.Black, vtHoTen, 44, rongHoTen, rowHeight);
                        gfx.DrawString("Người lập", headerFont, XBrushes.Black, new XPoint(200, 65));
                        gfx.DrawRectangle(XPens.Black, vtNgaySinh, 44, rongNgaySinh, rowHeight);
                        gfx.DrawString("Nhà cung cấp", headerFont, XBrushes.Black, new XPoint(370, 65));
                        gfx.DrawRectangle(XPens.Black, vtGioiTinh, 44, rongGt, rowHeight);
                        gfx.DrawString("Tổng tiền", headerFont, XBrushes.Black, new XPoint(670, 65));
                        gfx.DrawRectangle(XPens.Black, vtSDT, 44, rongSdt, rowHeight);


                        // Vị trí bắt đầu vẽ các dòng dữ liệu
                        double yPosition = 92;
                        int khoangCachDOng = 18;
                        List<PhieuNhapDTO> listPNXuatFile = PhieuNhapBUS.Instance.GetAllPhieuNhap();
                        int stt = 1;

                        foreach (var item in listPNXuatFile)
                        {
                            // Nếu vị trí y vượt quá chiều cao trang, thêm trang mới mà không vẽ lại tiêu đề
                            if (yPosition > pageHeight - rowHeight)
                            {
                                page = document.AddPage();
                                page.Width = XUnit.FromMillimeter(264);
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

                            cellHeight = DrawStringMultiline(gfx, item.MaPN, new XFont("Verdana", 12), XBrushes.Black, new XPoint(45, yPosition), rongMakh);
                            maxCellHeight = Math.Max(maxCellHeight, cellHeight);

                            cellHeight = DrawStringMultiline(gfx, item.NgayLap.ToString("dd/MM/yyyy"), new XFont("Verdana", 12), XBrushes.Black, new XPoint(107, yPosition), rongHoTen);
                            maxCellHeight = Math.Max(maxCellHeight, cellHeight) + 10;

                            string nguoiLap = DuocSiBUS.Instance.getHoTenDuocSi(item.NguoiLap);
                            cellHeight = DrawStringMultiline(gfx, nguoiLap, new XFont("Verdana", 12), XBrushes.Black, new XPoint(200, yPosition), rongNgaySinh);
                            maxCellHeight = Math.Max(maxCellHeight, cellHeight);

                            string nhaCungCap = NhaCungCapBUS.Instance.getTenNcc(item.NhaCungCap);
                            cellHeight = DrawStringMultiline(gfx, nhaCungCap, new XFont("Verdana", 12), XBrushes.Black, new XPoint(370, yPosition), rongGt);
                            maxCellHeight = Math.Max(maxCellHeight, cellHeight);

                            cellHeight = DrawStringMultiline(gfx, item.TongTien.ToString("N0"), new XFont("Verdana", 12), XBrushes.Black, new XPoint(670, yPosition), rongSdt);
                            maxCellHeight = Math.Max(maxCellHeight, cellHeight);


                            // Vẽ các đường viền ô với `maxCellHeight` đồng nhất cho tất cả các ô trong dòng
                            gfx.DrawRectangle(XPens.Black, vtSTT, yPosition - khoangCachDOng, rongStt, maxCellHeight);
                            gfx.DrawRectangle(XPens.Black, vtMakh, yPosition - khoangCachDOng, rongMakh, maxCellHeight);
                            gfx.DrawRectangle(XPens.Black, vtHoTen, yPosition - khoangCachDOng, rongHoTen, maxCellHeight);
                            gfx.DrawRectangle(XPens.Black, vtNgaySinh, yPosition - khoangCachDOng, rongNgaySinh, maxCellHeight);
                            gfx.DrawRectangle(XPens.Black, vtGioiTinh, yPosition - khoangCachDOng, rongGt, maxCellHeight);
                            gfx.DrawRectangle(XPens.Black, vtSDT, yPosition - khoangCachDOng, rongSdt, maxCellHeight);

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
            }
        }

        private void btn_xuatPN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_maPhieu.Text))
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xuất File PDF", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    // Đường dẫn cơ bản cho file PDF
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Title = "Lưu file PDF";
                        saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                        saveFileDialog.FileName = "XuatCTPhieuNhapPdf.pdf";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;

                            // Tạo tài liệu PDF
                            PdfDocument document = new PdfDocument();
                            document.Info.Title = "Created with PDFsharp";

                            // Tạo trang đầu tiên
                            PdfPage page = document.AddPage();
                            page.Width = XUnit.FromMillimeter(200); // Chiều rộng tùy chỉnh (Ví dụ: 420 mm tương đương với A3)
                            page.Height = XUnit.FromMillimeter(297); // Chiều cao tùy chỉnh (297 mm)
                            XGraphics gfx = XGraphics.FromPdfPage(page);

                            // Vẽ tiêu đề trang và tiêu đề bảng trên trang đầu tiên
                            XFont titleFont = new XFont("Verdana", 22);
                            XFont titleFont1 = new XFont("Verdana", 10);
                            gfx.DrawString("CHI TIẾT PHIẾU NHẬP", titleFont, XBrushes.Black, new XPoint(165, 30));
                            string formattedDate = "Ngày " + DateTime.ParseExact(tb_ngayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("dd 'tháng' MM 'năm' yyyy");
                            gfx.DrawString(formattedDate, titleFont1, XBrushes.Black, new XPoint(215, 50));
                            gfx.DrawString(tb_maPhieu.Text, new XFont("Verdana", 8), XBrushes.Black, new XPoint(275, 65));

                            XFont headerFont = new XFont("Verdana", 12);
                            gfx.DrawString("Người lập : ", headerFont, XBrushes.Black, new XPoint(20, 110));
                            gfx.DrawString("Nhà cung cấp : ", headerFont, XBrushes.Black, new XPoint(20, 130));

                            string itemNguoiLap = tb_nguoiLap.Text;
                            string[] stringNL = itemNguoiLap.Split('-');
                            string nguoiLap = stringNL[1].Trim();
                            gfx.DrawString(nguoiLap, titleFont1, XBrushes.Black, new XPoint(88, 110));

                            string itemNhaCC = tb_ncc.Text;
                            string[] stringNcc = itemNhaCC.Split('-');
                            string tenNcc = stringNcc[1].Trim();
                            gfx.DrawString(tenNcc, titleFont1, XBrushes.Black, new XPoint(115, 130));

                            gfx.DrawString("STT", headerFont, XBrushes.Black, new XPoint(20, 170));
                            gfx.DrawString("MaSP", headerFont, XBrushes.Black, new XPoint(55, 170));
                            gfx.DrawString("Lô SX", headerFont, XBrushes.Black, new XPoint(115, 170));
                            gfx.DrawString("Ngày SX", headerFont, XBrushes.Black, new XPoint(215, 170));
                            gfx.DrawString("Hạn SD", headerFont, XBrushes.Black, new XPoint(300, 170));
                            gfx.DrawString("Giá nhập", headerFont, XBrushes.Black, new XPoint(390, 170));
                            gfx.DrawString("Giá bán", headerFont, XBrushes.Black, new XPoint(460, 170));
                            gfx.DrawString("SL", headerFont, XBrushes.Black, new XPoint(530, 170));


                            //Vị trí bắt đầu vẽ các dòng dữ liệu
                            int yPosition = 200;
                            int khoangCachDOng = 20;
                            List<KhachHangDTO> listKHXuatFile = KhachHangBUS.Instance.GetAllKhachHang();
                            int stt = 1;

                            foreach (ChiTietPhieuNhapDTO chiTietPN in chiTietPhieuNhapList)
                            {
                                foreach (ChiTietSanPhamDTO chiTietSP in chiTietSanPhamList)
                                {
                                    if (chiTietPN.MaPN == tb_maPhieu.Text)
                                    {
                                        if (chiTietPN.MaCT == chiTietSP.MaCT)
                                        {

                                            gfx.DrawString(stt.ToString(), headerFont, XBrushes.Black, new XPoint(25, yPosition));
                                            gfx.DrawString(chiTietSP.MaSP, headerFont, XBrushes.Black, new XPoint(55, yPosition));
                                            gfx.DrawString(chiTietSP.LoSX, headerFont, XBrushes.Black, new XPoint(115, yPosition));
                                            gfx.DrawString(chiTietSP.NgaySX.ToString("dd/MM/yyyy"), headerFont, XBrushes.Black, new XPoint(215, yPosition));
                                            gfx.DrawString(chiTietSP.HanSD.ToString("dd/MM/yyyy"), headerFont, XBrushes.Black, new XPoint(300, yPosition));
                                            gfx.DrawString(chiTietPN.GiaNhap.ToString("N0"), headerFont, XBrushes.Black, new XPoint(390, yPosition));
                                            gfx.DrawString(chiTietSP.GiaBan.ToString("N0"), headerFont, XBrushes.Black, new XPoint(460, yPosition));
                                            gfx.DrawString(chiTietPN.SoLuong.ToString(), headerFont, XBrushes.Black, new XPoint(530, yPosition));

                                            yPosition += 35;
                                            stt++;
                                        }
                                    }
                                }
                            }
                            gfx.DrawRectangle(XPens.Black, 20, yPosition - 10, 525, 0.5);
                            if (ttPdf < 1000000)
                            {
                                gfx.DrawString($"Thanh toán : {ttPdf.ToString("N0")}", headerFont, XBrushes.Black, new XPoint(410, yPosition + 10));
                            }
                            else if (ttPdf > 10000000)
                            {
                                gfx.DrawString($"Thanh toán : {ttPdf.ToString("N0")}", headerFont, XBrushes.Black, new XPoint(395, yPosition + 10));
                            }
                            else
                            {
                                gfx.DrawString($"Thanh toán : {ttPdf.ToString("N0")}", headerFont, XBrushes.Black, new XPoint(400, yPosition + 10));
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
        }

        private void pnbtn_import_Click(object sender, EventArgs e)
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
                            int soDongUp = 0;

                            foreach (DataRow row in dataTable.Rows)
                            {
                                string masp = row[0].ToString();
                                string losx = row[1].ToString();
                                string ngaysx = row[2].ToString();
                                string hansd = row[3].ToString();
                                string gianhap = row[4].ToString();
                                string giaban = row[5].ToString();
                                string soluong = row[6].ToString();

                                if (row == dataTable.Rows[0])
                                {
                                    if (masp != "Mã SP" || losx != "Lô sản xuất" || ngaysx != "Ngày sản xuất" || hansd != "Hạn sử dụng"
                                        || gianhap != "Giá nhập" || giaban != "Giá bán" || soluong != "Số lượng")
                                    {
                                        isHeaderValid = false;
                                        break;
                                    }
                                }
                                else
                                {
                                    if (isHeaderValid)
                                    {
                                        DateTime ngaysx1 = DateTime.Parse(row[2].ToString());
                                        DateTime hansd1 = DateTime.Parse(row[3].ToString());
                                        decimal gianhap1 = decimal.Parse(row[4].ToString());
                                        decimal giaban1 = decimal.Parse(row[5].ToString());
                                        int soluong1 = int.Parse(row[6].ToString());
                                        bool checksp = SanPhamBUS.Instance.IsProductExists(masp);
                                        if (checksp)
                                        {
                                            if (hansd1 > DateTime.Now && hansd1 > ngaysx1)
                                            {
                                                Random random = new Random();
                                                int mactRandom = random.Next(1, 99999);
                                                tempCTSP.Add(new ChiTietSanPhamDTO(mactRandom, masp, losx, ngaysx1, hansd1, giaban1, 0));
                                                tempCTPN.Add(new ChiTietPhieuNhapDTO("0", mactRandom, gianhap1, soluong1));
                                                soDongUp++;
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
                                MessageBox.Show($"Nhập Excel thành công {soDongUp} dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadDataThongTinPN(tempCTSP, tempCTPN);
                                reset();
                            }
                        }
                    }
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

        private void btn_xuatExcel_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Bạn chắc chắn muốn xuất File Excel?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {

                    saveFileDialog.Title = "Lưu File Excel";
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = "XuatHdExcel.xlsx"; // Tên file mặc định
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string initialFilePath = saveFileDialog.FileName;
                        List<PhieuNhapDTO> listPN = PhieuNhapBUS.Instance.GetAllPhieuNhap();

                        // Tạo file Excel
                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            // Tạo worksheet
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                            // Thêm dữ liệu mẫu vào sheet
                            worksheet.Cells[1, 1].Value = "STT";
                            worksheet.Cells[1, 2].Value = "Mã PN";
                            worksheet.Cells[1, 3].Value = "Ngày nhập";
                            worksheet.Cells[1, 4].Value = "Người nhập";
                            worksheet.Cells[1, 5].Value = "Nhà cung cấp";
                            worksheet.Cells[1, 6].Value = "Tổng tiền";

                            // Duyệt danh sách khách hàng và thêm vào Excel
                            int stt = 1;
                            int rowIndex = 2;
                            foreach (var pn in listPN)
                            {
                                worksheet.Cells[rowIndex, 1].Value = stt;
                                worksheet.Cells[rowIndex, 2].Value = pn.MaPN;
                                worksheet.Cells[rowIndex, 3].Value = pn.NgayLap;
                                string nguoiLap = DuocSiBUS.Instance.getHoTenDuocSi(pn.NguoiLap);
                                worksheet.Cells[rowIndex, 4].Value = nguoiLap;
                                string nhaCungCap = NhaCungCapBUS.Instance.getTenNcc(pn.NhaCungCap);
                                worksheet.Cells[rowIndex, 5].Value = nhaCungCap;
                                worksheet.Cells[rowIndex, 6].Value = pn.TongTien;

                                rowIndex++; ;
                                stt++; ;
                            }

                            // Tự động điều chỉnh độ rộng cột
                            worksheet.Cells.AutoFitColumns();

                            // Lưu file
                            FileInfo fileInfo = new FileInfo(initialFilePath);
                            excelPackage.SaveAs(fileInfo);

                            // Hiển thị thông báo
                            MessageBox.Show($"Xuất file Excel thành công!\nĐường dẫn: {initialFilePath}", "Thông báo");
                        }
                    }
                }
            }
        }
    }
}
