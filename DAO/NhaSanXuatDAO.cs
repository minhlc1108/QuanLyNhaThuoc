using DTO;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class NhaSanXuatDAO
    {
        private static NhaSanXuatDAO instance;

        public static NhaSanXuatDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaSanXuatDAO();
                }
                return instance;
            }
        }

        // Lấy danh sách tất cả nhà sản xuất
        public List<NhaSanXuatDTO> GetAllNhaSanXuat()
        {
            List<NhaSanXuatDTO> nhaSanXuatList = new List<NhaSanXuatDTO>();
            string query = "SELECT * FROM nhasanxuat";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                NhaSanXuatDTO nsx = new NhaSanXuatDTO
                {
                    MaNSX = row["mansx"].ToString(),
                    TenNSX = row["tennsx"].ToString(),
                    TrangThai = Convert.ToBoolean(row["trangthai"])
                };

                nhaSanXuatList.Add(nsx);
            }

            return nhaSanXuatList;
        }

        // Thêm nhà sản xuất
        public bool InsertNhaSanXuat(string maNSX, string tenNSX, bool trangThai)
        {
            // Câu truy vấn với các tham số được định nghĩa đúng
            string query = "INSERT INTO nhasanxuat (mansx, tennsx, trangthai) VALUES (@MaNSX, @TenNSX, @TrangThai)";

            // Mảng tham số với thứ tự chính xác
            object[] parameters = { maNSX, tenNSX, trangThai };

            // Gọi phương thức ExecuteNonQuery và truyền các tham số
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public string GenerateMaNhaSanXuat()
        {
            string query = "SELECT MAX(mansx) FROM nhasanxuat";
            object result = DataProvider.Instance.ExecuteScalar(query);

            if (result != null && result != DBNull.Value)
            {
                // Mã hiện có, ví dụ: NSX002
                string maxMaNSX = result.ToString();

                // Lấy phần số và tăng lên 1
                int number = int.Parse(maxMaNSX.Substring(3)) + 1;

                // Tạo mã mới với định dạng NSXxxx (với số có 3 chữ số)
                return "NSX" + number.ToString("D3");
            }
            else
            {
                // Nếu chưa có mã nào thì bắt đầu từ NSX001
                return "NSX001";
            }
        }



        // Cập nhật tên nhà sản xuất
        public bool UpdateTenNhaSanXuat(string maNSX, string tenNSX)
        {
            string query = "UPDATE nhasanxuat SET tennsx = @TenNSX WHERE mansx = @MaNSX";
            object[] parameters = { tenNSX, maNSX };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Cập nhật trạng thái nhà sản xuất
        public bool UpdateTrangThaiNhaSanXuat(string maNSX, bool trangThai)
        {
            string query = "UPDATE nhasanxuat SET trangthai = @TrangThai WHERE mansx = @MaNSX";
            object[] parameters = { trangThai, maNSX };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        // Xóa nhà sản xuất
        public bool DeleteNhaSanXuat(string maNSX)
        {
            string query = "DELETE FROM nhasanxuat WHERE mansx = @MaNSX";
            object[] parameters = { maNSX };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
