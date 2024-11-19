using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LoaiSanPhamBUS
    {
        private static LoaiSanPhamBUS instance;

        public static LoaiSanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiSanPhamBUS();
                }
                return instance;
            }
        }

        public List<LoaiSanPhamDTO> GetAllLoaiSanPham()
        {
            return LoaiSanPhamDAO.Instance.GetAllLoaiSanPham();
        }

        

        public List<LoaiSanPhamDTO> GetLoaiSanPhamByTrangThai(bool trangthai)
        {
            return LoaiSanPhamDAO.Instance.GetLoaiSanPhamByTrangThai(trangthai);
        }

        

        public bool InsertLoaiSanPham(string maloai, string tenloai, bool trangthai)
        {
            return LoaiSanPhamDAO.Instance.InsertLoaiSanPham(maloai, tenloai, trangthai);
        }

        public bool UpdateTenLoaiSanPham(string maloai, string tenloai)
        {
            return LoaiSanPhamDAO.Instance.UpdateTenLoaiSanPham(maloai, tenloai);
        }

        public bool UpdateTrangThaiLoaiSanPham(string maloai, bool trangThai)
        {
            return LoaiSanPhamDAO.Instance.UpdateTrangThaiLoaiSanPham(maloai, trangThai);
        }

        public bool DeleteLoaiSanPham(string maloai)
        {
            return LoaiSanPhamDAO.Instance.DeleteLoaiSanPham(maloai);
        }
        public int checkSanPham(string maloai)
        {
            return LoaiSanPhamDAO.Instance.checkSanPham(maloai);
        }
    }
}
