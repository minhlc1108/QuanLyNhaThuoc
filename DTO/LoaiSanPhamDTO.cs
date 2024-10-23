using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPhamDTO
    {
        public string MaLoai { get; set; }
        public string TenLoai { get; set; }
        public bool TrangThai { get; set; }

        public LoaiSanPhamDTO(string maLoai, string tenLoai, bool trangThai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
            TrangThai = trangThai;
        }

        public LoaiSanPhamDTO()
        {
        }
    }

}
