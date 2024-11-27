using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DataProvider
    {
        private static string connectionString = "server=localhost;port=3306;database=quanlynhathuoc;user=root;password=;";

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }

        // trả về dữ liệu DataTable (SELECT * )
        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {
            DataTable data = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        string[] listParams = query.Split(' ');
                        Console.WriteLine(listParams.ToString());
                        int i = 0;
                        foreach (string param in listParams)
                        {
                            if (param.Contains("@"))
                            {
                                command.Parameters.AddWithValue(param, parameters[i]);
                                i++;
                            }
                        }
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(data);
                }
                connection.Close();
            }
            return data;
        }
     

        //INSERT, UPDATE, DELETE
        public int ExecuteNonQuery(string query, object[] parameters = null)
        {
            int data = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        // Sử dụng Regex để tìm tất cả các tham số bắt đầu bằng '@' trong query
                        var paramNames = System.Text.RegularExpressions.Regex.Matches(query, @"@\w+")
                                              .Cast<System.Text.RegularExpressions.Match>()
                                              .Select(m => m.Value)
                                              .ToArray();

                        if (paramNames.Length != parameters.Length)
                        {
                            throw new ArgumentException("Số lượng tham số không khớp với mảng parameters.");
                        }

                        for (int i = 0; i < paramNames.Length; i++)
                        {
                            command.Parameters.AddWithValue(paramNames[i], parameters[i]);
                        }
                    }

                    data = command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return data;
        }


        public DataTable GetChiTietSanPham()
        {
            string query = "SELECT DISTINCT chitietsanpham.loSX, chitietsanpham.mact, sanpham.tensp " +
                "FROM chitietsanpham " +
                "JOIN sanpham ON   chitietsanpham.masp = sanpham.masp " +
                "WHERE chitietsanpham.loSX IS NOT NULL AND chitietsanpham.masp IS NOT NULL";

            return ExecuteQuery(query);
        }
        public DataTable GetDanhSachDuocSi()
        {
            string query = "SELECT mads, hoten FROM duocsi WHERE trangthai = 1"; // Chỉ lấy dược sĩ đang hoạt động
            return ExecuteQuery(query);
        }
        public DataTable GetListTieuHuy()
        {
            string query = "SELECT tieuHuy.masp, chitietsanpham.loSX, tieuHuy.ngaytieuhuy, duocsi.hoten AS nguoilap, tieuHuy.lydo " +
                           "FROM TieuHuy " +
                           "JOIN chitietsanpham ON tieuHuy.mact = chitietsanpham.mact " +
                           "JOIN duocsi ON tieuHuy.nguoilap = duocsi.mads";
            return ExecuteQuery(query);
        }
        public decimal CalculateThietHai(int maCT)
        {
            string query = "SELECT ct.gianhap * sp.soLuong AS ThietHai " +
                           "FROM chitietphieunhap AS ct " +
                           "JOIN chitietsanpham AS sp ON ct.mact = sp.mact " +
                           "WHERE ct.mact = @maCT";
            object result = ExecuteScalar(query, new object[] { maCT });
            return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
        }
        public static DataTable GetTieuHuyInDateRange(DateTime startDate, DateTime endDate)
        {
            // Chuẩn bị câu lệnh SQL để lấy dữ liệu trong khoảng thời gian
            string query = "SELECT * FROM TieuHuy WHERE ngaytieuhuy BETWEEN @StartDate AND @EndDate";

            // Convert các tham số ngày vào định dạng chuẩn của SQL
            object[] parameters = new object[] { startDate, endDate };

            // Thực hiện truy vấn và trả về kết quả
            return Instance.ExecuteQuery(query, parameters);
        }


        //dùng cho các lệnh SELECT COUNT(*), MAX, SUM
        public object ExecuteScalar(string query, object[] parameters = null)
        {
            object data = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);

                if (parameters != null)
                {
                    string[] listParams = query.Split(' ');
                    int i = 0;
                    foreach (string param in listParams)
                    {
                        if (param.Contains("@"))
                        {
                            command.Parameters.AddWithValue(param, parameters[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }

}
