
using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private static NhaCungCapBUS instance;

        public static NhaCungCapBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapBUS();
                }
                return instance;
            }
        }

        

        public List<NhaCungCapDTO> GetNhaCungCapByTrangThai()
        {
            return NhaCungCapDAO.Instance.GetNhaCungCapByTrangThai();
        }

        public string GetLastMaNCC()
        {
            return NhaCungCapDAO.Instance.GetLastMaNCC();
        }

        public string getTenNcc(string value)
        {
            return NhaCungCapDAO.Instance.getTenNcc(value);
        }

        public List<NhaCungCapDTO> GetNhaCungCapByTrangThai(bool trangthai)
        {
            return NhaCungCapDAO.Instance.GetNhaCungCapByTrangThai(trangthai);
        }

        public List<NhaCungCapDTO> FindNhaCungCap(string param, string value)
        {
            return NhaCungCapDAO.Instance.FindNhaCungCap(param, value);
        }

        public bool InsertNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDT, string email, bool trangThai)
        {
            return NhaCungCapDAO.Instance.InsertNhaCungCap(maNCC, tenNCC, diaChi, soDT, email, trangThai);
        }

        public bool UpdateNhaCungCap(string maNCC, string tenNCC, string diaChi, string soDT, string email)
        {
            return NhaCungCapDAO.Instance.UpdateNhaCungCap(maNCC, tenNCC, diaChi, soDT, email);
        }

        public bool UpdateTrangThaiNhaCungCap(string maNCC, bool trangThai)
        {
            return NhaCungCapDAO.Instance.UpdateTrangThaiNhaCungCap(maNCC, trangThai);
        }

        public bool DeleteNhaCungCap(string maNCC)
        {
            return NhaCungCapDAO.Instance.DeleteNhaCungCap(maNCC);
        }
    }
}
