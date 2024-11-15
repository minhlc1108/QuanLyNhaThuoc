using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SanPhamBUS
    {
        private static SanPhamBUS instance;

        public static SanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamBUS();
                }
                return instance;
            }
        }

        public List<SanPhamDTO> GetAllProducts()
        {
            return SanPhamDAO.Instance.GetAllProducts();
        }

        public bool IsProductExists(string masp)
        {
            return SanPhamDAO.Instance.IsProductExists(masp);
        }


        public string GetTenSPByMaSP(string masp)
        {
            return SanPhamDAO.Instance.GetTenSPByMaSP(masp);
        }

        public List<SanPhamDTO> GetProductsByTrangThai()
        {
            return SanPhamDAO.Instance.GetProductsByTrangThai();
        }

        public bool InsertProduct(string masp, string tensp, string loaisp, string nhasanxuat, string quycach, string xuatxu, bool canketoa, bool trangthai)
        {
            return SanPhamDAO.Instance.InsertProduct(masp, tensp, loaisp, nhasanxuat, quycach, xuatxu, canketoa, trangthai);
        }
        public bool UpdateTrangThaiSanPham(string masp, bool trangthai)
        {
            return SanPhamDAO.Instance.UpdateTrangThaiSanPham(masp, trangthai);
        }
        public bool UpdateSanPham(string masp, string tensp, string loaisp, string nhasanxuat, string quycach, string xuatxu, bool canketoa)
        {
            return SanPhamDAO.Instance.UpdateSanPham(masp, tensp, loaisp, nhasanxuat, quycach, xuatxu, canketoa);
        }
        public SanPhamDTO GetSPByMaSP(string maSP)
        {
            return SanPhamDAO.Instance.GetSPByMaSP(maSP);
        }
        public int getSoLuongByMaSP(string MaSP)
        { 
            return SanPhamDAO.Instance.getSoLuongByMaSP(MaSP);
        }
        }
}
