using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class FormThongKeTonKho : Form
    {
        public FormThongKeTonKho()
        {
            InitializeComponent();
        }

        public void loadCbbLoaiSP()
        {
            cbbLoaiSP.Items.Clear();

            List<LoaiSanPhamDTO> listLoaiSanPham = LoaiSanPhamBUS.Instance.GetLoaiSanPhamByTrangThai(true);

            List<string> itemCbb_loaiSP = new List<string>();
            itemCbb_loaiSP.Add("Tất cả loại");
            foreach (LoaiSanPhamDTO loaisp in listLoaiSanPham)
            {
                string item = $"{loaisp.MaLoai + " - " + loaisp.TenLoai}";
                itemCbb_loaiSP.Add(item);
            }
            cbbLoaiSP.Items.AddRange(itemCbb_loaiSP.ToArray());
            cbbLoaiSP.SelectedIndex = 0;
        }

        public void loadDateTable()
        {
            DataTable data,dataChart,dataHetHang, dataHetHSD;
            if (cbbLoaiSP.SelectedIndex == 0)
            {
                data = ThongKeBUS.Instance.ThongKeTonKho();
                dataChart = ThongKeBUS.Instance.ThongKeSoLuongTonKho();
                dataHetHang = ThongKeBUS.Instance.ThongKeSapHetHang();
                dataHetHSD = ThongKeBUS.Instance.ThongKeSapHetHSD();
            }
            else
            {
                string itemCbbLoaiSP = cbbLoaiSP.Text;
                string[] stringLoaiSP = itemCbbLoaiSP.Split('-');
                string loaisp = stringLoaiSP[0].Trim();
                data = ThongKeBUS.Instance.ThongKeTonKho(loaisp);
                dataChart = ThongKeBUS.Instance.ThongKeSoLuongTonKho(loaisp);
                dataHetHang = ThongKeBUS.Instance.ThongKeSapHetHang(loaisp);
                dataHetHSD = ThongKeBUS.Instance.ThongKeSapHetHSD(loaisp);
            }
            tblThongTin.Items.Clear();
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count - 1; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }

                if(Convert.ToBoolean(row["trangthai"].ToString()))
                {
                    item.SubItems.Add("Đang bán");
                }
                else
                {
                    item.SubItems.Add("Nghỉ bán");
                }

                tblThongTin.Items.Add(item);
            }
            LoadDataTableHetHang(dataHetHang);
            LoadDataTableHetHSD(dataHetHSD);
            drawChart(dataChart);
        }
        private void FormThongKeTonKho_Load(object sender, EventArgs e)
        {
            loadCbbLoaiSP();
            loadDateTable();
        }

        public void drawChart(DataTable data)
        {
            chartTonKho.Series["SoLuong"].Points.Clear();
            foreach (DataRow row in data.Rows)
            {
                int soluong = Convert.ToInt32(row["soluong"]);
                DataPoint tonKhoPoint = new DataPoint
                {
                    AxisLabel = row["masp"].ToString(),
                    YValues = new double[] { soluong },
                    ToolTip = $"{row["masp"]} Số lượng: {soluong}"
                };
                chartTonKho.Series["SoLuong"].Points.Add(tonKhoPoint);
            }
            chartTonKho.Series["SoLuong"].IsXValueIndexed = true;
            chartTonKho.ChartAreas[0].AxisX.Interval = 1;
            chartTonKho.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartTonKho.Titles.Clear();
            chartTonKho.Titles.Add("Biểu đồ tồn kho theo loại sản phẩm " + cbbLoaiSP.Text);
        }

        public void LoadDataTableHetHang(DataTable data)
        {
            tblHetHang.Items.Clear();
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["masp"].ToString());
                int soluong = Convert.ToInt32(row["soluong"]);
                item.SubItems.Add(row["tensp"].ToString());
                item.SubItems.Add(row["soluong"].ToString());
                item.SubItems.Add(soluong > 0 ? "Sắp hết hàng" : "Hết hàng");
                tblHetHang.Items.Add(item);
            }
        }

        public void LoadDataTableHetHSD(DataTable data) {
            tblHetHSD.Items.Clear();
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row["mact"].ToString());
                int songay = Convert.ToInt32(row["songay"]);
                item.SubItems.Add(row["masp"].ToString());
                item.SubItems.Add(row["losx"].ToString());
                item.SubItems.Add(row["tensp"].ToString());
                item.SubItems.Add(row["hansd"].ToString());
                item.SubItems.Add(songay < 0 ? "Sắp hết hạn" : "Hết hạn");
                tblHetHSD.Items.Add(item);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            loadDateTable();
        }
    }
}
