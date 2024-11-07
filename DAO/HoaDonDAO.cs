using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAO();
                }
                return instance;
            }
        }

        public List<HoaDonDTO> GetAllHoaDon()
        {
            List<HoaDonDTO> hoaDonList = new List<HoaDonDTO>();
            string query = "SELECT * FROM hoadon";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                HoaDonDTO hoaDon = new HoaDonDTO
                {
                    MaHD = row["mahd"].ToString(),
                    NgayLap = DateTime.Parse(row["ngaylap"].ToString()),
                    NguoiLap = row["nguoilap"].ToString(),
                    KhachHangID = int.Parse(row["khachhang"].ToString()),
                    ToaThuoc = row["toathuoc"].ToString(),
                    DiemTichLuy = int.Parse(row["diemtichluy"].ToString()),
                    TongTien = decimal.Parse(row["tongtien"].ToString())
                };

                hoaDonList.Add(hoaDon);
            }
            return hoaDonList;
        }

        public List<HoaDonDTO> FindHoaDon(string param, string value)
        {
            List<HoaDonDTO> hoaDonList = new List<HoaDonDTO>();
            string query = "SELECT * FROM hoadon WHERE " + param + " LIKE @Value ";

            object[] parameters = { "%" + value + "%" };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                HoaDonDTO hoaDon = new HoaDonDTO
                {
                    MaHD = row["mahd"].ToString(),
                    NgayLap = DateTime.Parse(row["ngaylap"].ToString()),
                    NguoiLap = row["nguoilap"].ToString(),
                    KhachHangID = int.Parse(row["khachhang"].ToString()),
                    ToaThuoc = row["toathuoc"].ToString(),
                    DiemTichLuy = int.Parse(row["diemtichluy"].ToString()),
                    TongTien = decimal.Parse(row["tongtien"].ToString())
                };

                hoaDonList.Add(hoaDon);
            }

            return hoaDonList;
        }

        public List<HoaDonDTO> FindHoaDonByNgayLap( DateTime date1, DateTime date2)
        {
            List<HoaDonDTO> hoaDonList = new List<HoaDonDTO>();
            string query = "SELECT * FROM hoadon WHERE ngaylap >= @value1 AND ngaylap <= @value2 ";

            object[] parameters = { date1, date2 };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                HoaDonDTO hoaDon = new HoaDonDTO
                {
                    MaHD = row["mahd"].ToString(),
                    NgayLap = DateTime.Parse(row["ngaylap"].ToString()),
                    NguoiLap = row["nguoilap"].ToString(),
                    KhachHangID = int.Parse(row["khachhang"].ToString()),
                    ToaThuoc = row["toathuoc"].ToString(),
                    DiemTichLuy = int.Parse(row["diemtichluy"].ToString()),
                    TongTien = decimal.Parse(row["tongtien"].ToString())
                };

                hoaDonList.Add(hoaDon);
            }

            return hoaDonList;
        }


        public bool AddHoaDon(string maHD, DateTime ngayLap, string nguoiLap, int khachHangID, string toaThuoc, int diemTichLuy, decimal tongTien)
        {
            string query = "INSERT INTO hoadon (mahd, ngaylap, nguoilap, khachhang, toathuoc, diemtichluy, tongtien) " +
                           "VALUES ( @mahd , @ngaylap , @nguoilap , @khachhang , @toathuoc , @diemtichluy , @tongtien )";

            object[] parameters = new object[]
            {
                maHD,
                ngayLap,
                nguoiLap,
                khachHangID,
                toaThuoc,
                diemTichLuy,
                tongTien
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public string GetLastMaHD()
        {
            string query = "SELECT mahd FROM hoadon ORDER BY mahd DESC LIMIT 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            string lastMaHD = "HĐ0000";

            if (data.Rows.Count > 0)
            {
                lastMaHD = data.Rows[0]["mahd"].ToString();
            }

            return lastMaHD;
        }

    }
}
