using DTO;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanDAO();
                }
                return instance;
            }
        }

        public List<TaiKhoanDTO> GetAllTaiKhoan()
        {
            List<TaiKhoanDTO> taiKhoanList = new List<TaiKhoanDTO>();
            string query = "SELECT * FROM taikhoan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                TaiKhoanDTO taiKhoan = new TaiKhoanDTO
                {
                    MaTK = row["matk"].ToString(),
                    Username = row["username"].ToString(),
                    Password = row["password"].ToString(),
                    Quyen = Convert.ToInt32(row["quyen"])
                };

                taiKhoanList.Add(taiKhoan);
            }

            return taiKhoanList;
        }

        public bool InsertTaiKhoan(string matk, string username, string password, int quyen)
        {
            string query = "INSERT INTO taikhoan(matk, username, password, quyen) VALUES ( @MaTK , @Username , @Password , @Quyen )";
            object[] parameters =
            {
                matk,
                username,
                password,
                quyen
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


        public int getQuyen(string value)
        {
            string query = "SELECT quyen FROM taikhoan WHERE matk = @Value ";

            object[] parameters = { value };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            int quyen = 0;

            if (data.Rows.Count > 0)
            {
                quyen = Convert.ToInt32(data.Rows[0]["quyen"]);
            }

            return quyen;
        }

        public bool UpdateQuyen(string matk, int value)
        {
            string sql = @"UPDATE taikhoan SET quyen = @value WHERE matk = @matk ";
            object[] parameters =
         {
                value,
                matk
            };

            int result = DataProvider.Instance.ExecuteNonQuery(sql, parameters);
            return result > 0;
        }

        public string GetPassword(string value)
        {
            string query = "SELECT password FROM taikhoan WHERE matk = @Value ";

            object[] parameters = { value };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            string password = "";

            if (data.Rows.Count > 0)
            {
                password = data.Rows[0]["password"].ToString();
            }

            return password;
        }

        public bool UpdatePassword(string matk, string password)
        {

            string sql = @"UPDATE taikhoan SET password = @password WHERE matk = @matk ";
            object[] parameters =
         {
                password,
                matk
            };

            int result = DataProvider.Instance.ExecuteNonQuery(sql, parameters);
            return result > 0;
        }
    }
}
