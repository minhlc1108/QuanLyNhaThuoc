using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DieuTriDTO
    {
        public DieuTriDTO()
        {
        }

        public string MaThuoc { get; set; }
        public string BenhDieuTri { get; set; }

        public DieuTriDTO(string maThuoc, string benhDieuTri)
        {
            MaThuoc = maThuoc;
            BenhDieuTri = benhDieuTri;
        }
    }

}
