using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        private static ChiTietHoaDonDAO instance;

        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonDAO();
                }
                return instance;
            }
        }

        public List<ChiTietHoaDonDTO> GetAllChiTietHoaDon()
        {
            List<ChiTietHoaDonDTO> chiTietHoaDonList = new List<ChiTietHoaDonDTO>();
            string query = "SELECT * FROM chitiethoadon";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                ChiTietHoaDonDTO chiTietHoaDon = new ChiTietHoaDonDTO
                {
                    MaHD = row["mahd"].ToString(),
                    MaCT = int.Parse(row["mact"].ToString()),
                    GiaBan = decimal.Parse(row["giaban"].ToString()),
                    SoLuong = int.Parse(row["soluong"].ToString())
                };

                chiTietHoaDonList.Add(chiTietHoaDon);
            }

            return chiTietHoaDonList;
        }

        public bool AddChiTietHoaDon(string maHD, int maCT, decimal giaBan, int soLuong)
        {
            string query = "INSERT INTO chitiethoadon (mahd, mact, giaban, soluong) " +
                           "VALUES ( @mahd , @mact , @giaban , @soluong )";

            object[] parameters = new object[]
            {
                maHD,
                maCT,
                giaBan,
                soLuong
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

    }
}
