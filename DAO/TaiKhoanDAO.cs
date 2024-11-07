using DTO;
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
    }
}
