using BUS;
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
    public partial class FormThongKeSPBan : Form
    {
        public FormThongKeSPBan()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormThongKeSPBan_Load(object sender, EventArgs e)
        {
            cbbLoc.SelectedIndex = 0;
            LoadDataTable();
        }

        public void LoadDataTable()
        {
            DataTable table;
            if (cbbLoc.SelectedIndex != 0)
            {
                table = ThongKeBUS.Instance.GetListSanPhamBan(cbbLoc.SelectedIndex);
            }
            else
            {
                table = ThongKeBUS.Instance.GetListSanPhamBan();
            }

            LoadTable(table);
            DrawPieChartSP(table);
            DrawPieChartLoaiSP(table);
        }

        public void LoadTable(DataTable data)
        {
            tblThongtin.Items.Clear();

            foreach (DataRow row in data.Rows)
            {
                ListViewItem listViewItem = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    listViewItem.SubItems.Add(row[i].ToString());
                }
                tblThongtin.Items.Add(listViewItem);
            }
        }

        public void DrawPieChartSP(DataTable data)
        {
            chartSP.Series["SoLuong"].Points.Clear();
            foreach (DataRow row in data.Rows)
            {
                int soluong = Convert.ToInt32(row["soLuong"]);
                DataPoint point = new DataPoint
                {
                    AxisLabel = row["masp"].ToString(),
                    YValues = new double[] { soluong },
                    ToolTip = $"{row["tensp"]} Số lượng: {soluong}"
                };
                chartSP.Series["SoLuong"].Points.Add(point);
            }
            chartSP.ChartAreas[0].AxisX.Interval = 1;
        }

        public void DrawPieChartLoaiSP(DataTable data)
        {
            DataTable groupedData = new DataTable();
            groupedData.Columns.Add("LoaiSanPham", typeof(string));
            groupedData.Columns.Add("TongSoLuong", typeof(int));

            var grouped = data.AsEnumerable()
                     .GroupBy(row => row["loaisp"].ToString())
                     .Select(g => new
                     {
                         LoaiSanPham = g.Key,
                         TongSoLuong = g.Sum(r => Convert.ToInt32(r["soLuong"]))
                     });
            foreach (var item in grouped)
            {
                groupedData.Rows.Add(item.LoaiSanPham, item.TongSoLuong);
            }

            chartLSP.Series["SoLuong"].Points.Clear();
            foreach (DataRow row in groupedData.Rows)
            {
                int soluong = Convert.ToInt32(row["TongSoLuong"]);
                DataPoint tonKhoPoint = new DataPoint
                {
                    AxisLabel = row["LoaiSanPham"].ToString(),
                    YValues = new double[] { soluong },
                    ToolTip = $"{row["LoaiSanPham"]} Số lượng: {soluong}"
                };
                chartLSP.Series["SoLuong"].Points.Add(tonKhoPoint);
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadDataTable();
        }
    }
}
