using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;

        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangBUS();
                }
                return instance;
            }
        }

        public List<KhachHangDTO> GetAllKhachHang()
        {
            return KhachHangDAO.Instance.GetAllKhachHang();
        }

        public List<KhachHangDTO> FindKhachHang(string param,string value)
        {
            return KhachHangDAO.Instance.FindKhachHang(param, value);
        }

        public List<KhachHangDTO> FindKhachHangByNgaySinh(DateTime date1, DateTime date2)
        {
            return KhachHangDAO.Instance.FindKhachHangByNgaySinh(date1, date2);
        }

        public KhachHangDTO GetKhachHangByMaKH(int makh)
        {
            return KhachHangDAO.Instance.GetKhachHangByMaKH(makh);
        }

        public int GetLastMaKH()
        {
            return KhachHangDAO.Instance.GetLastMaKH();
        }

        public bool KhachHangDaTonTai(KhachHangDTO kh)
        {
            return KhachHangDAO.Instance.KhachHangDaTonTai(kh);
        }

        public bool AddKhachHang(int MaKH, string HoTen, DateTime NgaySinh, string GioiTinh, string SoDT, int Diem)
        {
            return KhachHangDAO.Instance.AddKhachHang(MaKH, HoTen, NgaySinh, GioiTinh, SoDT, Diem);
        }

        public bool UpdateKhachHang(int MaKH, string HoTen, DateTime NgaySinh, string GioiTinh, string SoDT, int Diem)
        {
            return KhachHangDAO.Instance.UpdateKhachHang(MaKH, HoTen, NgaySinh, GioiTinh, SoDT, Diem);
        }

        public int GetDiemKhachHang(int MaKH)
        {
            return KhachHangDAO.Instance.GetDiemKhachHang(MaKH);
        }

        public bool UpdateDiemKhachHang(int MaKH, int Diem)
        {
            return KhachHangDAO.Instance.UpdateDiemKhachHang(MaKH, Diem);
        }
    }
}
