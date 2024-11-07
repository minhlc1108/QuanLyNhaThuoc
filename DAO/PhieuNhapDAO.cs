using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapDAO
    {
        private static PhieuNhapDAO instance;

        public static PhieuNhapDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuNhapDAO();
                }
                return instance;
            }
        }

        public List<PhieuNhapDTO> GetAllPhieuNhap()
        {
            List<PhieuNhapDTO> phieuNhapList = new List<PhieuNhapDTO>();
            string query = "SELECT * FROM phieunhap";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                PhieuNhapDTO phieuNhap = new PhieuNhapDTO
                {
                    MaPN = row["mapn"].ToString(),
                    NgayLap = DateTime.Parse(row["ngaylap"].ToString()),
                    NguoiLap = row["nguoilap"].ToString(),
                    NhaCungCap = row["nhacungcap"].ToString(),
                    TongTien = decimal.Parse(row["tongTien"].ToString()),
                };

                phieuNhapList.Add(phieuNhap);
            }

            return phieuNhapList;
        }

        public bool AddPhieuNhap(string maPN, DateTime ngayLap, string nguoiLap, string nhaCungCap, decimal tongTien)
        {
            string query = "INSERT INTO phieunhap(mapn, ngaylap, nguoilap, nhacungcap, tongTien) " +
                           "VALUES ( @MaPN , @NgayLap , @NguoiLap , @NhaCungCap , @TongTien )";

            object[] parameters =
            {
                maPN,
                ngayLap,
                nguoiLap,
                nhaCungCap,
                tongTien
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public string GetLastMaPN()
        {
            string query = "SELECT mapn FROM phieunhap ORDER BY mapn DESC LIMIT 1";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                return data.Rows[0]["mapn"].ToString();
            }

            return null;
        }


        public List<PhieuNhapDTO> SearchPhieuNhap(string theLoai,string value,DateTime date1, DateTime date2)
        {
            List<PhieuNhapDTO> phieuNhapList = new List<PhieuNhapDTO>();

            string query = "SELECT * FROM phieunhap WHERE ";

            List<object> parameters = new List<object>();

            if (theLoai == "mapn")
            {
                query += "mapn LIKE @Value ";
                parameters.Add($"%{value}%");
            }
            else if (theLoai == "ngaylap")
            {
                query += "ngaylap >= @value1 AND ngaylap <= @value2 ";
                parameters.Add(date1);
                parameters.Add(date2);
            }
            else if (theLoai == "nguoinhap")
            {
                query += "nguoilap LIKE @Value ";
                parameters.Add($"%{value}%");
            }
            else if (theLoai == "nhacungcap")
            {
                query += "nhacungcap LIKE @Value ";
                parameters.Add($"%{value}%");
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters.ToArray());

            foreach (DataRow row in data.Rows)
            {
                PhieuNhapDTO phieuNhap = new PhieuNhapDTO
                {
                    MaPN = row["mapn"].ToString(),
                    NgayLap = DateTime.Parse(row["ngaylap"].ToString()),
                    NguoiLap = row["nguoilap"].ToString(),
                    NhaCungCap = row["nhacungcap"].ToString(),
                    TongTien = decimal.Parse(row["tongTien"].ToString())
                };

                phieuNhapList.Add(phieuNhap);
            }
            return phieuNhapList;
        }
    }
}
