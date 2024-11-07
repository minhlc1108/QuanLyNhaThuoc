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
    public class DieuTriDAO
    {
        private static DieuTriDAO instance;

        public static DieuTriDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DieuTriDAO();
                }
                return instance;
            }
        }
        // get all

        public List<DieuTriDTO> GetALLDieuTriByMa(string MaThuoc)
        {

            List<DieuTriDTO> listDieuTriByMa = new List<DieuTriDTO>();
            string query = "SELECT * FROM dieutri WHERE mathuoc = @MaThuoc ";
            object[] parameters = { MaThuoc };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                DieuTriDTO dieutri = new DieuTriDTO
                {
                    MaThuoc = row["mathuoc"].ToString(),
                    BenhDieuTri = row["benhdieutri"].ToString(),
                };

                listDieuTriByMa.Add(dieutri);
            }

            return listDieuTriByMa;

        }
        public bool themDieuTri(string MaThuoc, string BenhDieuTri)
        {
            string query = "INSERT INTO dieutri(mathuoc, benhdieutri) VALUES ( @MaThuoc , @BenhDieuTri )";
            object[] parameters =
            {
                MaThuoc,
                BenhDieuTri
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool deleteDieuTri(string MaThuoc)
        {
            string query = "DELETE FROM dieutri WHERE mathuoc = @MaThuoc ";
            object[] parameters =
            {
                MaThuoc
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

    }
}
