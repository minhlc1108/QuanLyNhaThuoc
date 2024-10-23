using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DuocSiBUS
    {
        private static DuocSiBUS instance;

        public static DuocSiBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DuocSiBUS();
                }
                return instance;
            }
        }

        public List<DuocSiDTO> GetAllDuocSi()
        {
            return DuocSiDAO.Instance.GetAllDuocSi();
        }

        public List<DuocSiDTO> FindDuocSi(string param, string value)
        {
            return DuocSiDAO.Instance.FindDuocSi(param, value);
        }

        public List<DuocSiDTO> GetDuocSiByTrangThai(bool trangthai)
        {
            return DuocSiDAO.Instance.GetDuocSiByTrangThai(trangthai);
        }

        public string GetLastMaDS()
        {
            return DuocSiDAO.Instance.GetLastMaDS();
        }

        public bool InsertDuocSi(string mads, string hoTen, string sdt, string email, bool trangThai)
        {
            return DuocSiDAO.Instance.InsertDuocSi(mads, hoTen, sdt, email, trangThai);
        }

        public bool UpdateDuocSi(string mads, string hoTen, string sdt, string email)
        {
            return DuocSiDAO.Instance.UpdateDuocSi(mads, hoTen, sdt, email);
        }

        public bool UpdateTrangThaiDuocSi(string mads, bool trangThai)
        {
            return DuocSiDAO.Instance.UpdateTrangThaiDuocSi(mads, trangThai);
        }

        public bool DeleteDuocSi(string mads)
        {
            return DuocSiDAO.Instance.DeleteDuocSi(mads);
        }
    }

}
