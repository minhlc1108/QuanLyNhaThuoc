using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangDAO();
                }
                return instance;
            }
        }

        public List<KhachHangDTO> GetAllKhachHang()
        {
            List<KhachHangDTO> khachHangList = new List<KhachHangDTO>();
            string query = "SELECT * FROM khachhang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    MaKH = int.Parse(row["makh"].ToString()),
                    HoTen = row["hoten"].ToString(),
                    NgaySinh = DateTime.Parse(row["ngaysinh"].ToString()),
                    GioiTinh = row["gioitinh"].ToString(),
                    SoDT = row["sodt"].ToString(),
                    Diem = int.Parse(row["diem"].ToString())
                };

                khachHangList.Add(khachHang);
            }

            return khachHangList;
        }

        public List<KhachHangDTO> FindKhachHang(string param, string value)
        {
            List<KhachHangDTO> khachHangList = new List<KhachHangDTO>();
            string query = "SELECT * FROM khachhang WHERE " + param + " LIKE @Value ";

            object[] parameters = { "%" + value + "%" };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    MaKH = int.Parse(row["makh"].ToString()),
                    HoTen = row["hoten"].ToString(),
                    NgaySinh = DateTime.Parse(row["ngaysinh"].ToString()),
                    GioiTinh = row["gioitinh"].ToString(),
                    SoDT = row["sodt"].ToString(),
                    Diem = int.Parse(row["diem"].ToString())
                };

                khachHangList.Add(khachHang);
            }

            return khachHangList;
        }

        public List<KhachHangDTO> FindKhachHangByNgaySinh(DateTime date1, DateTime date2)
        {
            List<KhachHangDTO> khachHangList = new List<KhachHangDTO>();
            string query = "SELECT * FROM khachhang WHERE ngaysinh >= @value1 AND ngaysinh <= @value2 ";

            object[] parameters = { date1, date2 };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    MaKH = int.Parse(row["makh"].ToString()),
                    HoTen = row["hoten"].ToString(),
                    NgaySinh = DateTime.Parse(row["ngaysinh"].ToString()),
                    GioiTinh = row["gioitinh"].ToString(),
                    SoDT = row["sodt"].ToString(),
                    Diem = int.Parse(row["diem"].ToString())
                };

                khachHangList.Add(khachHang);
            }

            return khachHangList;
        }

        public KhachHangDTO GetKhachHangByMaKH(int maKH)
        {
            string query = "SELECT * FROM khachhang WHERE makh = @MaKH ";
            object[] parameters = { maKH };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    MaKH = int.Parse(row["makh"].ToString()),
                    HoTen = row["hoten"].ToString(),
                    NgaySinh = DateTime.Parse(row["ngaysinh"].ToString()),
                    GioiTinh = row["gioitinh"].ToString(),
                    SoDT = row["sodt"].ToString(),
                    Diem = int.Parse(row["diem"].ToString())
                };

                return khachHang;
            }

            return null;
        }

        public int GetLastMaKH()
        {
            string query = "SELECT makh FROM khachhang ORDER BY makh DESC LIMIT 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return int.Parse(data.Rows[0]["makh"].ToString());
            }

            return 0;
        }

        public bool KhachHangDaTonTai(KhachHangDTO khachHang)
        {
            string query = "SELECT COUNT(*) FROM khachhang WHERE hoten = @HoTen AND ngaysinh = @NgaySinh " +
                           "AND gioitinh = @GioiTinh AND sodt = @SoDT ";

            object[] parameters = new object[]
            {
                khachHang.HoTen,
                khachHang.NgaySinh,
                khachHang.GioiTinh,
                khachHang.SoDT
            };

            long result = (long)DataProvider.Instance.ExecuteScalar(query, parameters);

            // Nếu có ít nhất 1 bản ghi, tức là khách hàng đã tồn tại
            return result > 0;
        }


        public bool AddKhachHang(int MaKH, string HoTen, DateTime NgaySinh,string GioiTinh, string SoDT,int Diem)
        {
            string query = "INSERT INTO khachhang(makh, hoten, ngaysinh, gioitinh, sodt, diem) " +
                           "VALUES ( @MaKH , @HoTen , @NgaySinh , @GioiTinh , @SoDT , @Diem )";

            object[] parameters =
            {
                MaKH,
                HoTen,
                NgaySinh,
                GioiTinh,
                SoDT,
                Diem
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateKhachHang(int MaKH, string HoTen, DateTime NgaySinh, string GioiTinh, string SoDT, int Diem)
        {
            string query = "UPDATE khachhang SET hoten = @HoTen , ngaysinh = @NgaySinh , gioitinh = @GioiTinh , sodt = @SoDT , diem = @Diem WHERE makh = @MaKH ";

            object[] parameters =
            {
                HoTen,
                NgaySinh,
                GioiTinh,
                SoDT,
                Diem,
                MaKH
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public int GetDiemKhachHang(int maKH)
        {
            string query = "SELECT diem FROM khachhang WHERE makh = @MaKH ";
            object[] parameters = { maKH };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                return int.Parse(data.Rows[0]["diem"].ToString());
            }

            return 0;
        }

        public bool UpdateDiemKhachHang(int maKH, int diemMoi)
        {
            string query = "UPDATE khachhang SET diem = @Diem WHERE makh = @MaKH ";

            object[] parameters =
            {
                diemMoi,
                maKH   
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

    }
}
