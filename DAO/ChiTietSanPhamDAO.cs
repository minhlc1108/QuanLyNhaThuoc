using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietSanPhamDAO
    {
        private static ChiTietSanPhamDAO instance;

        public static ChiTietSanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietSanPhamDAO();
                }
                return instance;
            }
        }

        public List<ChiTietSanPhamDTO> GetAllCTSP()
        {
            List<ChiTietSanPhamDTO> chiTietSPList = new List<ChiTietSanPhamDTO>();
            string query = "SELECT * FROM chitietsanpham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                ChiTietSanPhamDTO chiTietSP = new ChiTietSanPhamDTO
                {
                    MaCT = Convert.ToInt32(row["mact"]),
                    MaSP = row["masp"].ToString(),
                    LoSX = row["losx"].ToString(),
                    NgaySX = DateTime.Parse(row["ngaysx"].ToString()),
                    HanSD = DateTime.Parse(row["hansd"].ToString()),
                    GiaBan = decimal.Parse(row["giaban"].ToString()),
                    SoLuong = Convert.ToInt32(row["soluong"])

                };

                chiTietSPList.Add(chiTietSP);
            }

            return chiTietSPList;
        }

        public List<ChiTietSanPhamDTO> GetLoSXAndCheckHSD(string maSP)
        {
            List<ChiTietSanPhamDTO> chiTietSPList = new List<ChiTietSanPhamDTO>();
            string query = "SELECT * FROM chitietsanpham WHERE masp = @MaSP AND hansd >= @hansd ";
            object[] parameters = { maSP, DateTime.Now };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                DateTime hanSD = DateTime.Parse(row["hansd"].ToString());
                ChiTietSanPhamDTO chiTietSP = new ChiTietSanPhamDTO
                {
                    MaCT = Convert.ToInt32(row["mact"]),
                    MaSP = row["masp"].ToString(),
                    LoSX = row["losx"].ToString(),
                    NgaySX = DateTime.Parse(row["ngaysx"].ToString()),
                    HanSD = hanSD,
                    GiaBan = decimal.Parse(row["giaban"].ToString()),
                    SoLuong = Convert.ToInt32(row["soluong"])
                };
                chiTietSPList.Add(chiTietSP);
            }
            return chiTietSPList;
        }

        public decimal GetGiaBanByMaCT(int maCT)
        {
            string query = "SELECT giaban FROM chitietsanpham WHERE mact = @MaCT ";
            object[] parameters = { maCT };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                return decimal.Parse(data.Rows[0]["giaban"].ToString());
            }

            return 0;
        }

        public int GetSoLuongByMaCT(int maCT)
        {
            string query = "SELECT soluong FROM chitietsanpham WHERE mact = @MaCT ";
            object[] parameters = { maCT };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                return int.Parse(data.Rows[0]["soluong"].ToString());
            }

            return 0;
        }


        public bool AddChiTietSanPham(int maCT, string maSP, string loSX, DateTime ngaySX, DateTime hanSD, decimal giaBan, int soLuong)
        {
            string query = "INSERT INTO chitietsanpham(mact, masp, losx, ngaysx, hansd, giaban, soluong) " +
                           "VALUES ( @MaCT , @MaSP , @LoSX , @NgaySX , @HanSD , @GiaBan , @SoLuong )";

            object[] parameters =
            {
                maCT,
                maSP,
                loSX,
                ngaySX,
                hanSD,
                giaBan,
                soLuong
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public int GetLastMaCT()
        {
            string query = "SELECT mact FROM chitietsanpham ORDER BY mact DESC LIMIT 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);


            int lastMact = 0;
            if (data.Rows.Count > 0)
            {
                lastMact =  Convert.ToInt32(data.Rows[0]["mact"]);
            }

            return lastMact;
        }


        public bool UpdateSoLuongChiTietSanPham(int maCT, int soLuong)
        {
            string query = "UPDATE chitietsanpham SET soluong = @SoLuong WHERE mact = @MaCT ";

            object[] parameters =
            {
                soLuong,
                maCT   
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

    }
}
