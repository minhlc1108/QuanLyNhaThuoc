using DAO;
using DTO;
using System.Collections.Generic;
using Xceed.Wpf.Toolkit;


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
            // Kiểm tra nếu trạng thái thay đổi từ "Yes" thành "No"
            if (!trangThai)
            {
                // Kiểm tra xem nhà sản xuất có đang có liên kết nào không
                if (NhaSanXuatDAO.Instance.IsNSXLinkedToOtherTables(maNSX))
                {
                    Console.WriteLine("Không thể thay đổi trạng thái vì nhà sản xuất này đang có liên kết với dữ liệu khác.");


                    return false;
                }
            }

            // Cập nhật trạng thái nhà sản xuất
            return NhaSanXuatDAO.Instance.UpdateTrangThaiNhaSanXuat(maNSX, trangThai);
        }



        public bool DeleteNhaSanXuat(string maNSX)
        {
            // Kiểm tra xem trạng thái nhà sản xuất có phải là "No" không
            var nsx = NhaSanXuatDAO.Instance.GetNhaSanXuatByMaNSX(maNSX); // Lấy thông tin nhà sản xuất theo mã

            if (nsx != null && nsx.TrangThai)  // Nếu trạng thái là "Yes"
            {
                Console.WriteLine("Không thể xóa nhà sản xuất vì trạng thái của nó là 'Yes'.");
                return false; // Không thể xóa
            }

            // Kiểm tra xem nhà sản xuất có đang có liên kết khóa ngoại nào không
            if (NhaSanXuatDAO.Instance.IsNSXLinkedToOtherTables(maNSX))
            {
                Console.WriteLine("Không thể xóa nhà sản xuất vì nó đang có liên kết với dữ liệu khác.");
                return false; // Không thể xóa nếu có liên kết
            }

            // Nếu không có liên kết và trạng thái là "No", tiến hành xóa nhà sản xuất
            bool result = NhaSanXuatDAO.Instance.DeleteNhaSanXuat(maNSX);
            if (result)
            {
                Console.WriteLine("Xóa nhà sản xuất thành công!");
            }
            else
            {
                Console.WriteLine("Xóa nhà sản xuất thất bại!");
            }

            return result;
        }

        public string GenerateMaNhaSanXuat()
        {
            return NhaSanXuatDAO.Instance.GenerateMaNhaSanXuat();
        }
    }
}
