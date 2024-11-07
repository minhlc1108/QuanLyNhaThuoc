using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietPhieuNhapDAO
    {
        private static ChiTietPhieuNhapDAO instance;

        public static ChiTietPhieuNhapDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietPhieuNhapDAO();
                }
                return instance;
            }
        }

        public List<ChiTietPhieuNhapDTO> GetAllCTPN()
        {
            List<ChiTietPhieuNhapDTO> chiTietPNList = new List<ChiTietPhieuNhapDTO>();
            string query = "SELECT * FROM chitietphieunhap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                ChiTietPhieuNhapDTO chiTietPN = new ChiTietPhieuNhapDTO
                {
                    MaPN = row["mapn"].ToString(),
                    MaCT = Convert.ToInt32(row["mact"]),
                    GiaNhap = decimal.Parse(row["gianhap"].ToString()),
                    SoLuong = Convert.ToInt32(row["soluong"])

                };

                chiTietPNList.Add(chiTietPN);
            }

            return chiTietPNList;
        }

        public bool AddChiTietPhieuNhap(string maPN, int maCT, decimal giaNhap, int soLuong)
        {
            string query = "INSERT INTO chitietphieunhap(mapn, mact, gianhap, soluong) " +
                           "VALUES ( @MaPN , @MaCT , @GiaNhap , @SoLuong )";

            object[] parameters =
            {
                maPN,
                maCT,
                giaNhap,
                soLuong
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
