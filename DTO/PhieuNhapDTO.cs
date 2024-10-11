using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        public PhieuNhapDTO()
        {
        }

        public string MaPN { get; set; }
        public DateTime NgayLap { get; set; }
        public string NguoiLap { get; set; }
        public string NhaCungCap { get; set; }
        public decimal TongTien { get; set; }

        public PhieuNhapDTO(string maPN, DateTime ngayLap, string nguoiLap, string nhaCungCap, decimal tongTien)
        {
            MaPN = maPN;
            NgayLap = ngayLap;
            NguoiLap = nguoiLap;
            NhaCungCap = nhaCungCap;
            TongTien = tongTien;
        }
    }
}
