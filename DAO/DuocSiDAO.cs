using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DuocSiDAO
    {
        private static DuocSiDAO instance;

        public static DuocSiDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DuocSiDAO();
                }
                return instance;
            }
        }

        // GetAllDuocSi
        public List<DuocSiDTO> GetAllDuocSi()
        {
            List<DuocSiDTO> duocSiList = new List<DuocSiDTO>();
            string query = "SELECT * FROM duocsi"; 
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                DuocSiDTO duocSi = new DuocSiDTO
                {
                    MaDS = row["mads"].ToString(),
                    HoTen = row["hoten"].ToString(),
                    SDT = row["sodt"].ToString(),
                    Email = row["email"].ToString(),
                    TrangThai = row["trangthai"].ToString()
                };

                duocSiList.Add(duocSi);
            }

            return duocSiList;
        }

        public List<DuocSiDTO> FindDuocSi(string param, string value)
        {
            List<DuocSiDTO> duocSiList = new List<DuocSiDTO>();
            string query = "SELECT * FROM duocsi WHERE " + param + " LIKE @Value ";

            object[] parameters = { "%" + value + "%" };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                DuocSiDTO duocSi = new DuocSiDTO
                {
                    MaDS = row["mads"].ToString(),
                    HoTen = row["hoten"].ToString(),
                    SDT = row["sodt"].ToString(),
                    Email = row["email"].ToString(),
                    TrangThai = row["trangthai"].ToString()
                };

                duocSiList.Add(duocSi);
            }

            return duocSiList;
        }

        public string getHoTenDuocSi( string value)
        {
            string query = "SELECT hoten FROM duocsi WHERE mads = @Value ";

            object[] parameters = {value};

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            string hoTen = "";

            if (data.Rows.Count > 0)
            {
                hoTen = data.Rows[0]["hoten"].ToString();
            }

            return hoTen;
        }

        public bool getTrangThaiDuocSi(string value)
        {
            string query = "SELECT trangthai FROM duocsi WHERE mads = @Value ";

            object[] parameters = { value };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            bool trangThai = false;

            if (data.Rows.Count > 0)
            {
                trangThai = Convert.ToBoolean(data.Rows[0]["trangthai"]);
            }

            return trangThai;
        }



        public List<DuocSiDTO> GetDuocSiByTrangThai(bool trangthai)
        {
            List<DuocSiDTO> duocSiList = new List<DuocSiDTO>();

            string query = "SELECT * FROM duocsi WHERE trangthai = @TrangThai ";

            object[] parameters = { trangthai };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                DuocSiDTO duocSi = new DuocSiDTO
                {
                    MaDS = row["mads"].ToString(),
                    HoTen = row["hoten"].ToString(),
                    SDT = row["sodt"].ToString(),
                    Email = row["email"].ToString(),
                    TrangThai = row["trangthai"].ToString()
                };

                duocSiList.Add(duocSi);
            }

            return duocSiList;
        }


        // GetLastMaDS
        public string GetLastMaDS()
        {
            string query = "SELECT mads FROM duocsi ORDER BY mads DESC LIMIT 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            string lastMaDS = "DS0000";

            if (data.Rows.Count > 0)
            {
                lastMaDS = data.Rows[0]["mads"].ToString();
            }

            return lastMaDS;
        }

        public bool DuocSiDaTonTai(DuocSiDTO duocsi)
        {
            string query = "SELECT COUNT(*) FROM duocsi WHERE hoten = @HoTen AND sodt = @SDT AND email = @Email ";

            // Tham số hóa câu truy vấn để tránh SQL Injection
            object[] parameters = new object[]
            {
                duocsi.HoTen,
                duocsi.SDT,
                duocsi.Email
            };

            // Thực hiện câu truy vấn và lấy kết quả
            long result = (long)DataProvider.Instance.ExecuteScalar(query, parameters);

            // Nếu có ít nhất 1 bản ghi, tức là dược sĩ đã tồn tại
            return result > 0;
        }


        public bool InsertDuocSi(string mads, string hoten, string sodt, string email, bool trangthai)
        {
            string query = "INSERT INTO duocsi(mads, hoten, sodt, email, trangthai) VALUES ( @MaDS , @HoTen , @Sodt , @Email , @TrangThai )";

            object[] parameters =
            {
                mads,
                hoten,
                sodt,
                email,
                trangthai
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateDuocSi(string mads, string hoten, string sodt, string email)
        {
            string query = "UPDATE duocsi SET hoten = @HoTen , sodt = @Sodt , email = @Email WHERE mads = @MaDS ";

            object[] parameters =
            {
                hoten,
                sodt,
                email,
                mads
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


        public bool UpdateTrangThaiDuocSi(string mads, bool trangthai)
        {
            string query = "UPDATE duocsi SET trangthai = @TrangThai WHERE mads = @MaDS ";

            object[] parameters =
            {
                trangthai,
                mads
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
