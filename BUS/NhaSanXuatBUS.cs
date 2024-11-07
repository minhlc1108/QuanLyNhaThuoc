using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaSanXuatBUS
    {
        private static NhaSanXuatBUS instance;

        public static NhaSanXuatBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaSanXuatBUS();
                }
                return instance;
            }
        }

        public List<NhaSanXuatDTO> GetAllNhaSanXuat()
        {

            return NhaSanXuatDAO.Instance.GetAllNhaSanXuat();
        }

        
    }
}
