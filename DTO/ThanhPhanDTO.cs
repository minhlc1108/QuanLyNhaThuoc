using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThanhPhanDTO
    {
        public ThanhPhanDTO()
        {
        }

        public string MaThanhPhan { get; set; }
        public string TenThanhPhan { get; set; }

        public ThanhPhanDTO(string maThanhPhan, string tenThanhPhan)
        {
            MaThanhPhan = maThanhPhan;
            TenThanhPhan = tenThanhPhan;
        }
    }

}
