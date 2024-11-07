using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhapBUS
    {
        private static PhieuNhapBUS instance;

        public static PhieuNhapBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuNhapBUS();
                }
                return instance;
            }
        }

        public List<PhieuNhapDTO> GetAllPhieuNhap()
        {
            return PhieuNhapDAO.Instance.GetAllPhieuNhap();
        }

        public List<PhieuNhapDTO> SearchPhieuNhap(string theloai, string value, DateTime date1, DateTime date2)
        {
            return PhieuNhapDAO.Instance.SearchPhieuNhap(theloai, value, date1, date2);
        }

        public bool AddPhieuNhap(string maPN, DateTime ngayLap, string nguoiLap, string nhaCungCap, decimal tongTien)
        {
            return PhieuNhapDAO.Instance.AddPhieuNhap(maPN, ngayLap, nguoiLap, nhaCungCap, tongTien);
        }

        public string GetLastMaPN()
        {
            return PhieuNhapDAO.Instance.GetLastMaPN();
        }
    }
}
