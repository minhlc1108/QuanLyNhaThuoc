using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class NhaSanXuatBUS
    {
        private static NhaSanXuatBUS instance;

        public static NhaSanXuatBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaSanXuatBUS();
                }
                return instance;
            }
        }

        // Lấy tất cả nhà sản xuất
        public List<NhaSanXuatDTO> GetAllNhaSanXuat()
        {
            return NhaSanXuatDAO.Instance.GetAllNhaSanXuat();
        }

        // Thêm nhà sản xuất mới
        public bool InsertNhaSanXuat(string maNSX, string tenNSX, bool trangThai)
        {
            return NhaSanXuatDAO.Instance.InsertNhaSanXuat(maNSX, tenNSX, trangThai);
        }
        public bool InsertNewNhaSanXuat(string tenNSX, bool trangThai)
        {
            string newMaNSX = GenerateMaNhaSanXuat();
            return InsertNhaSanXuat(newMaNSX, tenNSX, trangThai);
        }

        // Cập nhật tên nhà sản xuất
        public bool UpdateTenNhaSanXuat(string maNSX, string tenNSX)
        {
            return NhaSanXuatDAO.Instance.UpdateTenNhaSanXuat(maNSX, tenNSX);
        }

        // Cập nhật trạng thái nhà sản xuất
        public bool UpdateTrangThaiNhaSanXuat(string maNSX, bool trangThai)
        {
            return NhaSanXuatDAO.Instance.UpdateTrangThaiNhaSanXuat(maNSX, trangThai);
        }

        // Xóa nhà sản xuất
        public bool DeleteNhaSanXuat(string maNSX)
        {
            return NhaSanXuatDAO.Instance.DeleteNhaSanXuat(maNSX);
        }
        public string GenerateMaNhaSanXuat()
        {
            return NhaSanXuatDAO.Instance.GenerateMaNhaSanXuat();
        }
    }
}
