using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {

        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SanPhamDAO();
                }
                return instance;
            }
        }
        public List<SanPhamDTO> GetAllProducts()
        {
            List<SanPhamDTO> products = new List<SanPhamDTO>();
            string query = "SELECT * FROM sanpham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                SanPhamDTO product = new SanPhamDTO
                {
                    MaSP = row["masp"].ToString(),
                    TenSP = row["tensp"].ToString(),
                    LoaiSP = row["loaisp"].ToString(),
                    NhaSanXuat = row["nhasanxuat"].ToString(),
                    QuyCach = row["quycach"].ToString(),
                    XuatXu = row["xuatxu"].ToString(),
                    CanKeToa = Convert.ToBoolean(row["canketoa"].ToString()),
                    TrangThai = Convert.ToBoolean(row["trangthai"].ToString())
                };

                products.Add(product);
            }
            return products;
        }
        
        public bool InsertProduct(string masp, string tensp, string loaisp, string nhasanxuat, string quycach, string xuatxu, bool canketoa, bool trangthai)
        {
            string query = "INSERT INTO sanpham(masp,tensp,loaisp,nhasanxuat,quycach,xuatxu,canketoa,trangthai) VALUES (@MaSP,@TenSP,@LoaiSP,@NhaSanXuat,@QuyCach,@XuatXu,@CanKeToa,@TrangThai)";
            object[] parameters =
            {
                masp,
                tensp,
                loaisp, 
                nhasanxuat,
                quycach, 
                xuatxu, 
                canketoa,
                trangthai
            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
    }
}
