using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenhDTO
    {
        public BenhDTO()
        {
        }

        public BenhDTO(string maBenh, string tenBenh)
        {
            MaBenh = maBenh;
            TenBenh = tenBenh;
        }

        public string MaBenh { get; set; }

        public string TenBenh { get; set; }

    }
}
