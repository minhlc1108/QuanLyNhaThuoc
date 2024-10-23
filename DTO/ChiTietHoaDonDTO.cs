using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonDTO
    {
        public ChiTietHoaDonDTO()
        {
        }

        public string MaHD { get; set; }
        public int MaCT { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }

        public ChiTietHoaDonDTO(string maHD, int maCT, decimal giaBan, int soLuong)
        {
            MaHD = maHD;
            MaCT = maCT;
            GiaBan = giaBan;
            SoLuong = soLuong;
        }
    }
}
