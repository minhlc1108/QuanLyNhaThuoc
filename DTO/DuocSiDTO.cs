using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DuocSiDTO
    {
        public string MaDS { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string TrangThai { get; set; }

        // Danh sách hóa đơn mà dược sĩ này đã lập (quan hệ 1 - nhiều)
     

        public DuocSiDTO()
        {
           
        }

        public DuocSiDTO(string maDS, string hoTen, string sDT, string email, string trangThai)
        {
            MaDS = maDS;
            HoTen = hoTen;
            SDT = sDT;
            Email = email;
            TrangThai = trangThai;
        }
    }
}
