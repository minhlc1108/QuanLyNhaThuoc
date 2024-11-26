using DTO;
using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
        public bool IsNSXLinkedToOtherTables(string maNSX)
        {
            // Kiểm tra nhà sản xuất có đang bị liên kết với bảng `sanpham` không
            string query = "SELECT COUNT(*) FROM sanpham WHERE nhasanxuat = @maNSX";

            // Sử dụng DataProvider để thực thi truy vấn
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maNSX });

            // Nếu có liên kết (count > 0), trả về true
            return Convert.ToInt32(result) > 0;
        }


        // Thêm nhà sản xuất
        public bool InsertNhaSanXuat(string maNSX, string tenNSX, bool trangThai)
        {
            string query = "INSERT INTO nhasanxuat (mansx, tennsx, trangthai) VALUES (@MaNSX, @TenNSX, @TrangThai)";
            object[] parameters = { maNSX, tenNSX, trangThai };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            return result > 0;
        }
        public NhaSanXuatDTO GetNhaSanXuatByMaNSX(string maNSX)
        {
            string query = "SELECT * FROM nhasanxuat WHERE mansx = @maNSX";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNSX });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                return new NhaSanXuatDTO
                {
                    MaNSX = row["mansx"].ToString(),
                    TenNSX = row["tennsx"].ToString(),
                    TrangThai = Convert.ToBoolean(row["trangthai"])
                };
            }

            return null;
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
