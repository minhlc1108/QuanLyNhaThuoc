using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaSanXuatDTO
    {
        public NhaSanXuatDTO()
        {
        }

        public string MaNSX { get; set; }
        public string TenNSX { get; set; }
        public bool TrangThai { get; set; }

        public NhaSanXuatDTO(string maNSX, string tenNSX, bool trangThai)
        {
            MaNSX = maNSX;
            TenNSX = tenNSX;
            TrangThai = trangThai;
        }
    }

}
