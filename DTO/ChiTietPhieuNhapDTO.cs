using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuNhapDTO
    {
        public ChiTietPhieuNhapDTO()
        {
        }

        public ChiTietPhieuNhapDTO(string maPN, int maCT, decimal giaNhap, int soLuong)
        {
            MaPN = maPN ?? throw new ArgumentNullException(nameof(maPN));
            MaCT = maCT;
            GiaNhap = giaNhap;
            SoLuong = soLuong;
        }

        public string MaPN { get; set; }
        public int MaCT { get; set; }
        public decimal GiaNhap { get; set; }
        public int SoLuong { get; set; }
    }
}
