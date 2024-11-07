using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;

        public static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapDAO();
                }
                return instance;
            }
        }

        public List<NhaCungCapDTO> GetAllNhaSanXuat()
        {
            List<NhaCungCapDTO> nhaCungCapList = new List<NhaCungCapDTO>();
            string query = "SELECT * FROM nhacungcap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                NhaCungCapDTO nhaCungCap = new NhaCungCapDTO
                {
                    MaNCC = row["mancc"].ToString(),
                    TenNCC = row["tenncc"].ToString(),
                    DiaChi = row["diachi"].ToString(),
                    SoDT = row["sodt"].ToString(),
                    Email = row["email"].ToString(),
                    TrangThai = Convert.ToBoolean(row["trangthai"])
                };

                nhaCungCapList.Add(nhaCungCap);
            }

            return nhaCungCapList;
        }

        public List<NhaCungCapDTO> GetNhaCungCapByTrangThai()
        {
            List<NhaCungCapDTO> nhaCungCapList = new List<NhaCungCapDTO>();
            string query = "SELECT * FROM nhacungcap Where trangthai = true";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                NhaCungCapDTO nhaCungCap = new NhaCungCapDTO
                {
                    MaNCC = row["mancc"].ToString(),
                    TenNCC = row["tenncc"].ToString(),
                    DiaChi = row["diachi"].ToString(),
                    SoDT = row["sodt"].ToString(),
                    Email = row["email"].ToString(),
                    TrangThai = Convert.ToBoolean(row["trangthai"])
                };

                nhaCungCapList.Add(nhaCungCap);
            }

            return nhaCungCapList;
        }

        public string getTenNcc(string value)
        {
            string query = "SELECT tenncc FROM nhacungcap WHERE mancc = @Value ";

            object[] parameters = { value };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            string tenNcc = "";

            if (data.Rows.Count > 0)
            {
                tenNcc = data.Rows[0]["tenncc"].ToString();
            }

            return tenNcc;
        }
        public string GetLastMaNCC()
        {
            string query = "SELECT mancc FROM nhacungcap ORDER BY mancc DESC LIMIT 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            string lastMaNCC = "NCC0000";

            if (data.Rows.Count > 0)
            {
                lastMaNCC = data.Rows[0]["mancc"].ToString();
            }

            return lastMaNCC;
        }

        public List<NhaCungCapDTO> GetNhaCungCapByTrangThai(bool trangThai)
        {
            List<NhaCungCapDTO> nhaCungCapList = new List<NhaCungCapDTO>();

            string query = "SELECT * FROM nhacungcap WHERE trangthai = @TrangThai ";
            object[] parameters = { trangThai };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                NhaCungCapDTO nhaCungCap = new NhaCungCapDTO
                {
                    MaNCC = row["mancc"].ToString(),
                    TenNCC = row["tenncc"].ToString(),
                    DiaChi = row["diachi"].ToString(),
                    SoDT = row["sodt"].ToString(),
                    Email = row["email"].ToString(),
                    TrangThai = Convert.ToBoolean(row["trangthai"])
                };

                nhaCungCapList.Add(nhaCungCap);
            }

            return nhaCungCapList;
        }

        public List<NhaCungCapDTO> FindNhaCungCap(string param, string value)
        {
            List<NhaCungCapDTO> nhaCungCapList = new List<NhaCungCapDTO>();

            string query = "SELECT * FROM nhacungcap WHERE " + param + " LIKE @Value ";

            // Tham số cần được truyền dưới dạng pattern cho LIKE
            object[] parameters = { "%" + value + "%" };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                NhaCungCapDTO nhaCungCap = new NhaCungCapDTO
                {
                    MaNCC = row["mancc"].ToString(),
                    TenNCC = row["tenncc"].ToString(),
                    DiaChi = row["diachi"].ToString(),
                    SoDT = row["sodt"].ToString(),
                    Email = row["email"].ToString(),
                    TrangThai = Convert.ToBoolean(row["trangthai"])
                };

                nhaCungCapList.Add(nhaCungCap);
            }

            return nhaCungCapList;
        }

        // thêm sửa xoá
        public bool InsertNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDT, string email, bool trangThai)
        {
            string query = "INSERT INTO nhacungcap (mancc, tenncc, diachi, sodt, email, trangthai) " +
                           "VALUES ( @MaNCC , @TenNCC , @DiaChi , @SoDT , @Email , @TrangThai )";

            object[] parameters =
            {
                maNCC,
                tenNCC,
                diaChi,
                soDT,
                email,
                trangThai
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDT, string email)
        {
            string query = "UPDATE nhacungcap SET tenncc = @TenNCC , diachi = @DiaChi , sodt = @SoDT , email = @Email " +
                           "WHERE mancc = @MaNCC ";

            object[] parameters =
            {
                tenNCC,
                diaChi,
                soDT,
                email,
                maNCC
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateTrangThaiNhaCungCap(string maNCC, bool trangThai)
        {
            string query = "UPDATE nhacungcap SET trangthai = @TrangThai WHERE mancc = @MaNCC ";

            object[] parameters =
            {
        trangThai,
        maNCC
    };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


        public bool DeleteNhaCungCap(string maNCC)
        {
            string query = "DELETE FROM nhacungcap WHERE mancc = @MaNCC ";

            object[] parameters = { maNCC };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }






    }
}