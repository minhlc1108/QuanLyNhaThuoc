using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThongKeBUS
    {
        private static ThongKeBUS instance;

        public static ThongKeBUS Instance
        {
            get { if (instance == null) instance = new ThongKeBUS(); return instance; }
            private set { instance = value; }
        }


    }
}
