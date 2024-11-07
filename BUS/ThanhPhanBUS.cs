using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThanhPhanBUS
    {
        private static ThanhPhanBUS instance;

        public static ThanhPhanBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThanhPhanBUS();
                }
                return instance;
            }
        }

        public List<ThanhPhanDTO> GetALLThanhPhanByMa(string MaThanhPhan)
        {
            return ThanhPhanDAO.Instance.GetALLThanhPhanByMa(MaThanhPhan);
        }
        public bool themThanhPhan(string MaThanhPhan, string ThanhPhan)
        {
            return ThanhPhanDAO.Instance.themThanhPhan(MaThanhPhan, ThanhPhan);
        }
        public bool deleteThanhPhan(string MaThanhPhan)
        {
            return ThanhPhanDAO.Instance.deleteThanhPhan(MaThanhPhan);
        }
        }
    }
