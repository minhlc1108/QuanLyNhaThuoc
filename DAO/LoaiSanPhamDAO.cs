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
    public class LoaiSanPhamDAO
    {
        private static LoaiSanPhamDAO instance;

        public static LoaiSanPhamDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoaiSanPhamDAO();
                }
                return instance;
            }
        }
        // get all
        public List<LoaiSanPhamDTO> GetAllLoaiSanPham()
        {
            List<LoaiSanPhamDTO> loaiSanPhamList = new List<LoaiSanPhamDTO>();
            string query = "SELECT * FROM loaisanpham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                LoaiSanPhamDTO loaiSP = new LoaiSanPhamDTO
                {
                    MaLoai = row["maloai"].ToString(),
                    TenLoai = row["tenloai"].ToString(),
                    TrangThai = Convert.ToBoolean(row["trangthai"].ToString())
                };

                loaiSanPhamList.Add(loaiSP);
            }

            return loaiSanPhamList;
        }
        public List<LoaiSanPhamDTO> GetLoaiSanPhamByTrangThai(bool trangthai)
        {
            List<LoaiSanPhamDTO> loaiSanPhamList = new List<LoaiSanPhamDTO>(); 
            string query = "SELECT * FROM loaisanpham WHERE trangthai = @TrangThai ";

            object[] parameters = { trangthai };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                LoaiSanPhamDTO loaisanpham = new LoaiSanPhamDTO
                {
                    MaLoai = row["maloai"].ToString(),
                    TenLoai = row["tenloai"].ToString(),
                    TrangThai = Convert.ToBoolean(row["trangthai"].ToString())
                };

                loaiSanPhamList.Add(loaisanpham);
            }

            return loaiSanPhamList;
        }
        public bool InsertLoaiSanPham(string maloai, string tenloai, bool trangthai)
        {
            string query = "INSERT INTO loaisanpham(maloai, tenloai, trangthai) VALUES ( @MaLoai , @TenLoai , @TrangThai )";

            object[] parameters =
            {
                maloai,
                tenloai,
                trangthai
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }

        public bool UpdateTenLoaiSanPham(string maloai, string tenloai)
        {
            string query = "UPDATE loaisanpham SET tenloai = @TenLoai WHERE maloai = @MaLoai ";

            object[] parameters =
            {
                tenloai,
                maloai
                
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


        public bool UpdateTrangThaiLoaiSanPham(string maloai, bool trangthai)
        {
            string query = "UPDATE loaisanpham SET trangthai = @TrangThai WHERE maloai = @Maloai ";

            object[] parameters =
            {
                trangthai,
                maloai
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }


        public bool DeleteLoaiSanPham(string maloai)
        {
           
                string query = "DELETE FROM loaisanpham WHERE maloai = @MaLoai ";

                object[] parameters =
                {
                maloai
                };

                int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
                return result>0;
           
        }
        public int checkSanPham(string maloai)
        {
            List<SanPhamDTO>listSPbyMaLoai=new List<SanPhamDTO>();
            int dem = 0;
            string query = "SELECT * FROM sanpham WHERE loaisp = @LoaiSP ";
            object[] parameters =
                {
                maloai
                };

            DataTable data = DataProvider.Instance.ExecuteQuery(query,parameters);

            foreach (DataRow row in data.Rows)
            {
                SanPhamDTO sanpham = new SanPhamDTO
                {
                    
                    TrangThai = Convert.ToBoolean(row["trangthai"].ToString())
                };
                if (sanpham.TrangThai)
                {
                    dem++;
                }
            }
            return dem;
        }

    }
}
