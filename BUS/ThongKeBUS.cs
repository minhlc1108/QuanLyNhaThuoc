using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeBUS
    {
        private static ThongKeBUS instance;

        public static ThongKeBUS Instance
        {
            get { if (instance == null) instance = new ThongKeBUS(); return instance; }
            private set { instance = value; }
        }

        public DataTable ThongKeDoanhThu(DateTime ngaybd, DateTime ngaykt)
        {
            return ThongKeDAO.Instance.ThongKeDoanhThu(ngaybd, ngaykt);
        }

        public DataTable ThongKeTonKho(string? loaisp = null)
        {
            return ThongKeDAO.Instance.ThongKeTonKho(loaisp);
        }
        public DataTable ThongKeSoLuongTonKho(string? loaisp = null)
        {
            return ThongKeDAO.Instance.ThongKeSoLuongTonKho(loaisp);
        }

        public DataTable ThongKeSapHetHang(string? loaisp=null)
        {
            return ThongKeDAO.Instance.ThongKeSapHetHang(loaisp);
        }

        public DataTable ThongKeSapHetHSD(string? loaisp = null)
        {
            return ThongKeDAO.Instance.ThongKeSapHetHSD(loaisp);
        }

        public DataTable GetListSanPhamBan(int? top = null)
        {
            return ThongKeDAO.Instance.GetListSanPhamBan(top);
        }

    }
}
