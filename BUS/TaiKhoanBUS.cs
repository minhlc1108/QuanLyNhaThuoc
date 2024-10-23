using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private static TaiKhoanBUS instance;

        public static TaiKhoanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TaiKhoanBUS();
                }
                return instance;
            }
        }

        public List<TaiKhoanDTO> GetAllTaiKhoan()
        {
            return TaiKhoanDAO.Instance.GetAllTaiKhoan();
        }

        public bool InsertTaiKhoan(string matk, string username, string password, int quyen)
        {
            return TaiKhoanDAO.Instance.InsertTaiKhoan(matk, username, password, quyen);
        }

        public bool DeleteTaiKhoan(string matk)
        {
            return TaiKhoanDAO.Instance.DeleteTaiKhoan(matk);
        }
    }
}
