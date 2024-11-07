using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietSanPhamBUS
    {
        private static ChiTietSanPhamBUS instance;

        public static ChiTietSanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietSanPhamBUS();
                }
                return instance;
            }
        }

        public List<ChiTietSanPhamDTO> GetAllCTSP()
        {
            return ChiTietSanPhamDAO.Instance.GetAllCTSP();
        }

        public List<ChiTietSanPhamDTO> GetLoSXAndCheckHSD(string masp)
        {
            return ChiTietSanPhamDAO.Instance.GetLoSXAndCheckHSD(masp);
        }

        public decimal GetGiaBanByMaCT(int mact)
        {
            return ChiTietSanPhamDAO.Instance.GetGiaBanByMaCT(mact);
        }

        public int GetSoLuongByMaCT(int mact)
        {
            return ChiTietSanPhamDAO.Instance.GetSoLuongByMaCT(mact);
        }

        public bool AddChiTietSanPham(int maCT, string maSP, string loSX, DateTime ngaySX, DateTime hanSD, decimal giaBan, int soLuong)
        {
            return ChiTietSanPhamDAO.Instance.AddChiTietSanPham(maCT, maSP, loSX, ngaySX, hanSD, giaBan, soLuong);
        }

        public bool UpdateSoLuongChiTietSanPham(int maCT, int soLuong)
        {
            return ChiTietSanPhamDAO.Instance.UpdateSoLuongChiTietSanPham(maCT, soLuong);
        }

        public int GetLastMaCT()
        {
            return ChiTietSanPhamDAO.Instance.GetLastMaCT();
        }
    }
}
