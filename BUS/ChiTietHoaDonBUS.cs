using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        private static ChiTietHoaDonBUS instance;

        public static ChiTietHoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonBUS();
                }
                return instance;
            }
        }

        public List<ChiTietHoaDonDTO> GetAllChiTietHoaDon()
        {
            return ChiTietHoaDonDAO.Instance.GetAllChiTietHoaDon();
        }

        public bool AddChiTietHoaDon(string maHD, int maCT, decimal giaBan, int soLuong)
        {
            return ChiTietHoaDonDAO.Instance.AddChiTietHoaDon(maHD, maCT, giaBan, soLuong);
        }
    }
}
