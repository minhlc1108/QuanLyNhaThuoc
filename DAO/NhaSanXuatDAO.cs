using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaSanXuatDAO
    {
        private static NhaSanXuatDAO instance;

        public static NhaSanXuatDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaSanXuatDAO();
                }
                return instance;
            }
        }

        public List<NhaSanXuatDTO> GetAllNhaSanXuat()
        {
            List<NhaSanXuatDTO> nhaSanXuatList = new List<NhaSanXuatDTO>();
            string query = "SELECT * FROM nhasanxuat";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                NhaSanXuatDTO nhaSanXuat = new NhaSanXuatDTO
                {
                    MaNSX = row["mansx"].ToString(),
                    TenNSX = row["tennsx"].ToString(),
                    TrangThai = Convert.ToBoolean(row["trangthai"])
                };

                nhaSanXuatList.Add(nhaSanXuat);
            }

            return nhaSanXuatList;
        }

       
    }

}
