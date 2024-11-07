using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;

        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonBUS();
                }
                return instance;
            }
        }

        public List<HoaDonDTO> GetAllHoaDon()
        {
            return HoaDonDAO.Instance.GetAllHoaDon();
        }

        public List<HoaDonDTO> FindHoaDon(string param, string value)
        {
            return HoaDonDAO.Instance.FindHoaDon(param, value);
        }

        public List<HoaDonDTO> FindHoaDonByNgayLap(DateTime date1, DateTime date2)
        {
            return HoaDonDAO.Instance.FindHoaDonByNgayLap(date1, date2);
        }

        public bool AddHoaDon(string maHD, DateTime ngayLap, string nguoiLap, int khachHangID, string toaThuoc, int diemTichLuy, decimal tongTien)
        {
            return HoaDonDAO.Instance.AddHoaDon(maHD, ngayLap, nguoiLap, khachHangID, toaThuoc, diemTichLuy, tongTien);
        }

        public string GetLastMaHD()
        {
            return HoaDonDAO.Instance.GetLastMaHD();
        }
    }
}
