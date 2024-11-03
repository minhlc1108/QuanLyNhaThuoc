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
            string query = "UPDATE TieuHuy SET ngaytieuhuy = @ngayTieuHuy , nguoilap = @nguoiLap , lydo = @lyDo , thiethai = @thietHai WHERE mact = @maCT";
            object[] parameters = { tieuHuy.NgayTieuHuy, tieuHuy.NguoiLap, tieuHuy.LyDo, tieuHuy.ThietHai, tieuHuy.MaCT };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


        public bool DeleteTieuHuy(int maCT)
        {
            string query = "DELETE FROM TieuHuy WHERE mact = @maCT";
            object[] parameters = { maCT };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public DataTable GetListTieuHuy()
        {
            string query = "SELECT * FROM TieuHuy";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
