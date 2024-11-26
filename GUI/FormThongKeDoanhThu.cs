using BUS;
using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class FormThongKeDoanhThu : Form
    {
        public FormThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void FormThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            dateBatDau.MaxDate = DateTime.Now;
            dateKetThuc.MaxDate = DateTime.Now;
            dateBatDau.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dateKetThuc.Value = dateKetThuc.MaxDate;
            btnThongKe.PerformClick();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime dateBD = dateBatDau.Value.Date;
            DateTime dateKT = dateKetThuc.Value.Date;
            if (dateBD > dateKT)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable dataTable = ThongKeBUS.Instance.ThongKeDoanhThu(dateBD, dateKT);
            var allMonths = new List<string>();
            int startYear = dateBD.Year;
            int endYear = dateKT.Year;
            for (int year = startYear; year <= endYear; year++)
            {
                int startMonth = (year == startYear) ? dateBD.Month : 1;
                int endMonth = (year == endYear) ? dateKT.Month : 12;

                // Thêm các tháng trong năm hiện tại vào danh sách
                for (int month = startMonth; month <= endMonth; month++)
                {
                    allMonths.Add(year + "-" + month.ToString("D2"));
                }
            }

            tblThongTin.Items.Clear();

            foreach (var month in allMonths)
            {
                int doanhThu = 0;
                int chiPhi = 0;
                var row = dataTable.AsEnumerable()
                          .FirstOrDefault(r => r["NgayLap"].ToString() == month);

                if (row != null)
                {
                    doanhThu = Convert.ToInt32(row["DoanhThu"]);
                    chiPhi = Convert.ToInt32(row["ChiPhi"]);
                }

                ListViewItem item = new ListViewItem(month);
                item.SubItems.Add(doanhThu.ToString());
                item.SubItems.Add(chiPhi.ToString());
                item.SubItems.Add((doanhThu - chiPhi).ToString());
                tblThongTin.Items.Add(item);
            }
            DrawChart();
        }

        private void DrawChart()
        {
            chartDoanhThu.Series["DoanhThu"].Points.Clear();
            chartDoanhThu.Series["ChiPhi"].Points.Clear();
            // Thêm dữ liệu từ ListView vào Chart
            foreach (ListViewItem item in tblThongTin.Items)
            {
                string month = item.Text; // Nhãn mm-yyyy
                int doanhThu = Convert.ToInt32(item.SubItems[1].Text);
                int chiPhi = Convert.ToInt32(item.SubItems[2].Text);

                //chartDoanhThu.Series["DoanhThu"].Points.AddXY(month, doanhThu);
                //chartDoanhThu.Series["ChiPhi"].Points.AddXY(month, chiPhi);
                DataPoint doanhThuPoint = new DataPoint
                {
                    AxisLabel = month,
                    YValues = new double[] { doanhThu },
                    ToolTip = $"{month} Doanh thu: {doanhThu} VND"
                };
                chartDoanhThu.Series["DoanhThu"].Points.Add(doanhThuPoint);

                DataPoint chiPhiPoint = new DataPoint
                {
                    AxisLabel = month,
                    YValues = new double[] { chiPhi },
                    ToolTip = $"{month} Chi phí: {chiPhi} VND"
                };
                chartDoanhThu.Series["ChiPhi"].Points.Add(chiPhiPoint);

            }

            // Thiết lập trục X
            chartDoanhThu.Series["DoanhThu"].IsXValueIndexed = true;
            chartDoanhThu.Series["ChiPhi"].IsXValueIndexed = true;

            chartDoanhThu.ChartAreas[0].AxisX.Interval = 1;
            chartDoanhThu.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartDoanhThu.ChartAreas[0].AxisX.IsMarginVisible = false;
            // Refresh the chart to update

            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add("Thống kê doanh thu theo tháng giai đoạn " + dateBatDau.Value.ToString("dd/MM/yyyy") + " - " + dateKetThuc.Value.ToString("dd/MM/yyyy"));
            chartDoanhThu.Invalidate();

        }

    }
}
