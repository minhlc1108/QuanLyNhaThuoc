using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ThanhPhanDAO
    {
        private static ThanhPhanDAO instance;

        public static ThanhPhanDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThanhPhanDAO();
                }
                return instance;
            }
        }
        // get all
    
        public List<ThanhPhanDTO> GetALLThanhPhanByMa(string MaThanhPhan)
        {

            List<ThanhPhanDTO> listThanhPhanByMa = new List<ThanhPhanDTO>();
            string query = "SELECT * FROM thanhphan WHERE mathuoc = @MaThanhPhan ";
            object[] parameters = { MaThanhPhan };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                ThanhPhanDTO thanhPhan = new ThanhPhanDTO
                {
                    MaThanhPhan = row["mathuoc"].ToString(),
                    TenThanhPhan = row["thanhphan"].ToString(),
                };

                listThanhPhanByMa.Add(thanhPhan);
            }

            return listThanhPhanByMa;

        }
        public bool themThanhPhan(string MaThanhPhan, string ThanhPhan)
        {
            string query = "INSERT INTO thanhphan(mathuoc, thanhphan ) VALUES ( @MaThanhPhan , @ThanhPhan )";
            object[] parameters =
            {
                MaThanhPhan,
                ThanhPhan
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool deleteThanhPhan(string MaThanhPhan)
        {
            string query = "DELETE FROM thanhphan WHERE mathuoc = @MaThanhPhan ";
            object[] parameters =
            {
                MaThanhPhan
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
