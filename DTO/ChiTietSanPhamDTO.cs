using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietSanPhamDTO
    {
        public ChiTietSanPhamDTO()
        {
        }

        public int MaCT { get; set; }
        public string MaSP { get; set; }
        public string LoSX { get; set; }
        public DateTime NgaySX { get; set; }
        public DateTime HanSD { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }

        public ChiTietSanPhamDTO(int maCT, string maSP, string loSX, DateTime ngaySX, DateTime hanSD, decimal giaBan, int soLuong)
        {
            MaCT = maCT;
            MaSP = maSP;
            LoSX = loSX;
            NgaySX = ngaySX;
            HanSD = hanSD;
            GiaBan = giaBan;
            SoLuong = soLuong;
        }
    }

}
