using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        public string MaHD { get; set; }
        public DateTime NgayLap { get; set; }
        public string NguoiLap { get; set; } // Mã dược sĩ (khóa ngoại)
        public int KhachHangID { get; set; } // Khóa ngoại đến bảng KhachHang
        public string ToaThuoc { get; set; }
        public int DiemTichLuy { get; set; }
        public decimal TongTien { get; set; }

        
        public HoaDonDTO()
        { }

        public HoaDonDTO(string maHD, DateTime ngayLap, string nguoiLap, int khachHangID, string toaThuoc, int diemTichLuy, decimal tongTien)
        {
            MaHD = maHD;
            NgayLap = ngayLap;
            NguoiLap = nguoiLap;
            KhachHangID = khachHangID;
            ToaThuoc = toaThuoc;
            DiemTichLuy = diemTichLuy;
            TongTien = tongTien;
        }

    }
}
