using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThanhPhanSanPhamDTO
    {
        public ThanhPhanSanPhamDTO()
        {
        }

        public string MaThuoc { get; set; }
        public string ThanhPhan { get; set; }

        public ThanhPhanSanPhamDTO(string maThuoc, string thanhPhan)
        {
            MaThuoc = maThuoc;
            ThanhPhan = thanhPhan;
        }
    }

}
