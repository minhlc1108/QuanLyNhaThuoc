using System;
using System.Data;
using DTO;
using System.Collections.Generic;

namespace DAO
{
    public class TieuHuyDAO
    {
        private static TieuHuyDAO instance;

        public static TieuHuyDAO Instance
        {
            get { if (instance == null) instance = new TieuHuyDAO(); return instance; }
            private set { instance = value; }
        }

        private TieuHuyDAO() { }

        public bool InsertTieuHuy(TieuHuyDTO tieuHuy)
        {
            string query = "INSERT INTO TieuHuy (mact, ngaytieuhuy, nguoilap, lydo, thiethai) VALUES (@maCT , @ngayTieuHuy , @nguoiLap , @lyDo , @thietHai ) ";
            object[] parameters = { tieuHuy.MaCT, tieuHuy.NgayTieuHuy, tieuHuy.NguoiLap, tieuHuy.LyDo, tieuHuy.ThietHai };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateTieuHuy(TieuHuyDTO tieuHuy)
        {
            string query = "UPDATE TieuHuy SET ngaytieuhuy = @ngayTieuHuy, nguoilap = @nguoiLap, lydo = @lyDo, thiethai = @thietHai WHERE mact = @maCT";

            // Các tham số cần truyền vào cho câu truy vấn
            object[] parameters = { tieuHuy.NgayTieuHuy, tieuHuy.NguoiLap, tieuHuy.LyDo, tieuHuy.ThietHai, tieuHuy.MaCT };

            // Thực thi câu lệnh SQL với tham số đã truyền
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);

            // Trả về true nếu câu lệnh thành công (số lượng bản ghi bị ảnh hưởng > 0), false nếu không
            return result > 0;
        }



        public bool DeleteTieuHuy(int maCT)
        {
            string query = "DELETE FROM TieuHuy WHERE mact = @maCT";
            object[] parameters = { maCT };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool UpdateSoLuongToZero(int maCT)
        {
            string query = "UPDATE chitietsanpham SET soluong = 0 WHERE mact = @maCT";
            object[] parameters = { maCT };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public int GetSoLuong(int maCT)
        {
            string query = "SELECT soluong FROM chitietsanpham WHERE mact = @maCT";
            object[] parameters = { maCT };
            DataTable result = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                return Convert.ToInt32(result.Rows[0]["soluong"]);
            }
            return -1; // Return -1 if not found or error
        }
        public TieuHuyDTO GetTieuHuyByMaCT(int maCT)
        {
            // Write your SQL query to fetch data from database using maCT
            string query = "SELECT * FROM TieuHuy WHERE MaCT = @MaCT";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maCT });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                TieuHuyDTO tieuHuy = new TieuHuyDTO
                {
                    MaCT = Convert.ToInt32(row["mact"]),
                    NgayTieuHuy = Convert.ToDateTime(row["ngaytieuhuy"]),
                    NguoiLap = row["nguoilap"].ToString(),
                    LyDo = row["lydo"].ToString(),
                    ThietHai = Convert.ToDecimal(row["thiethai"])
                };
                return tieuHuy;
            }
            return null;
        }
        public DataTable SearchTieuHuyByDate(DateTime startDate, DateTime endDate)
        {
            string query = @"SELECT * FROM tieuhuy
                         WHERE NgayTieuHuy BETWEEN @startDate AND @endDate";

            object[] parameters = new object[] { startDate, endDate };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public DataTable GetListTieuHuy()
        {
            string query = "SELECT * FROM TieuHuy";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetTieuHuyByDateRange(DateTime startDate, DateTime endDate)
        {
            string query = "SELECT tieuhuy.mact, chitietsanpham.masp, chitietsanpham.loSX, tieuhuy.ngaytieuhuy, duocsi.hoten AS nguoilap, tieuhuy.lydo, tieuhuy.thiethai " +
                     "FROM tieuhuy " +
                     "JOIN chitietsanpham ON tieuhuy.mact = chitietsanpham.mact " +
                     "JOIN duocsi ON tieuhuy.nguoilap = duocsi.mads " +
                     "WHERE tieuhuy.ngaytieuhuy BETWEEN @startDate AND @endDate";



            object[] parameters = { startDate, endDate };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
        public bool UpdateLyDo(int maCT, string lyDo)
        {
            // SQL update query
            string query = "UPDATE TieuHuy SET lyDo = @lyDo WHERE maCT = @maCT";

            // Thực hiện câu lệnh SQL với các tham số
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { lyDo, maCT }) > 0;
        }

    }
}
