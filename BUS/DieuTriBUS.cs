using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DieuTriBUS
    {
        private static DieuTriBUS instance;

        public static DieuTriBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DieuTriBUS();
                }
                return instance;
            }
        }

        public List<DieuTriDTO> GetALLDieuTriByMa(string MaBenh)
        {
            return DieuTriDAO.Instance.GetALLDieuTriByMa(MaBenh);
        }
        public bool themDieuTri(string MaThuoc, string BenhDieuTri)
        {
            return DieuTriDAO.Instance.themDieuTri(MaThuoc, BenhDieuTri);
        }
        public bool deleteDieuTri(string MaThuoc)
        {
            return DieuTriDAO.Instance.deleteDieuTri(MaThuoc);
        }

    }
}
