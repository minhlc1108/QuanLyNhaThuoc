using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoanDTO
    {
        public string MaTK { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Quyen { get; set; }

        public TaiKhoanDTO(string maTK, string username, string password, int quyen)
        {
            MaTK = maTK;
            Username = username;
            Password = password;
            Quyen = quyen;
        }

        public TaiKhoanDTO()
        {
        }

    }
}
