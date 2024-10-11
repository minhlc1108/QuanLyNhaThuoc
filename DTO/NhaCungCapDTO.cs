using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        public NhaCungCapDTO()
        {
        }

        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string Email { get; set; }
        public bool TrangThai { get; set; }

        public NhaCungCapDTO(string maNCC, string tenNCC, string diaChi, string soDT, string email, bool trangThai)
        {
            MaNCC = maNCC;
            TenNCC = tenNCC;
            DiaChi = diaChi;
            SoDT = soDT;
            Email = email;
            TrangThai = trangThai;
        }
    }
}
