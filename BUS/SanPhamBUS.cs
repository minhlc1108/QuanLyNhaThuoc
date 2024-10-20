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

        public bool InsertProduct(string masp, string tensp, string loaisp, string nhasanxuat, string quycach, string xuatxu, bool canketoa, bool trangthai)
        {
            return SanPhamDAO.Instance.InsertProduct(masp, tensp, loaisp, nhasanxuat, quycach, xuatxu, canketoa, trangthai);
        }
    }
}
