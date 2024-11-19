using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThongKeDAO
    {
        private static ThongKeDAO instance;

        public static ThongKeDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThongKeDAO();
                }
                return instance;
            }
        }

        //public List<ThongKeDTO> ThongKeDoanhThu()
        //{

        //}
    }
}
