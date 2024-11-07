using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        private static ChiTietPhieuNhapBUS instance;

        public static ChiTietPhieuNhapBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhieuNhapBUS();
                }
                return instance;
            }
        }

        public List<ChiTietPhieuNhapDTO> GetAllCTPN()
        {
            return ChiTietPhieuNhapDAO.Instance.GetAllCTPN();
        }

        public bool AddChiTietPhieuNhap(string maPN, int maCT, decimal giaNhap, int soLuong)
        {
            return ChiTietPhieuNhapDAO.Instance.AddChiTietPhieuNhap(maPN, maCT, giaNhap, soLuong);
        }
    }
}
