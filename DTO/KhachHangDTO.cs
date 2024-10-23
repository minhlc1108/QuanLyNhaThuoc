using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        public KhachHangDTO()
        {
        }

        public int MaKH { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string SoDT { get; set; }
        public int Diem { get; set; }

        public KhachHangDTO(int maKH, string hoTen, DateTime ngaySinh, string gioiTinh, string soDT, int diem)
        {
            MaKH = maKH;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoDT = soDT;
            Diem = diem;
        }
    }

}
