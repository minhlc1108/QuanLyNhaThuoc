using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class TieuHuyBUS
    {
        private static TieuHuyBUS instance;

        public static TieuHuyBUS Instance
        {
            get { if (instance == null) instance = new TieuHuyBUS(); return instance; }
            private set { instance = value; }
        }

        private TieuHuyBUS() { }

        public DataTable GetListTieuHuy()
        {
            return TieuHuyDAO.Instance.GetListTieuHuy();
        }
        public static TieuHuyDTO GetTieuHuyByMaCT(int maCT)
        {
            // Assuming there's a data layer (DAO) that retrieves TieuHuy by MaCT
            return TieuHuyDAO.Instance.GetTieuHuyByMaCT(maCT);
        }

        public bool AddTieuHuy(TieuHuyDTO tieuHuy)
        {
            bool isInserted = TieuHuyDAO.Instance.InsertTieuHuy(tieuHuy);
            if (isInserted)
            {
                return TieuHuyDAO.Instance.UpdateSoLuongToZero(tieuHuy.MaCT);
            }
            return false;
        }

        public bool UpdateTieuHuy(TieuHuyDTO tieuHuy)
        {
            return TieuHuyDAO.Instance.UpdateTieuHuy(tieuHuy);
        }

        public bool DeleteTieuHuy(int maCT)
        {
            return TieuHuyDAO.Instance.DeleteTieuHuy(maCT);
        }
        public DataTable SearchTieuHuyByDateRange(DateTime startDate, DateTime endDate)
        {
            return TieuHuyDAO.Instance.GetTieuHuyByDateRange(startDate, endDate);
        }
        public bool UpdateLyDo(int maCT, string lyDo)
        {
            // Gọi DAO để thực hiện cập nhật Lý Do vào cơ sở dữ liệu
            return TieuHuyDAO.Instance.UpdateLyDo(maCT, lyDo);
        }
    }
}
