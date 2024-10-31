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

        public bool AddTieuHuy(TieuHuyDTO tieuHuy)
        {
            return TieuHuyDAO.Instance.InsertTieuHuy(tieuHuy);
        }

        public bool UpdateTieuHuy(TieuHuyDTO tieuHuy)
        {
            return TieuHuyDAO.Instance.UpdateTieuHuy(tieuHuy);
        }

        public bool DeleteTieuHuy(int maCT)
        {
            return TieuHuyDAO.Instance.DeleteTieuHuy(maCT);
        }
    }
}
