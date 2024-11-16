using DTO;
using MySqlX.XDevAPI.Common;
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

        public bool IsProductExists(string maSP)
        {
            string query = "SELECT COUNT(1) FROM sanpham WHERE masp = @masp AND trangthai = 1";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { maSP });
            int count = result != null ? Convert.ToInt32(result) : 0;

            return count > 0;
        }


        public List<SanPhamDTO> GetProductsByTrangThai()
        {
            List<SanPhamDTO> products = new List<SanPhamDTO>();
            string query = "SELECT * FROM sanpham WHERE trangthai = true";
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
        public string GetTenSPByMaSP(string maSP)
        {
            string tenSP = string.Empty;
            string query = "SELECT tensp FROM sanpham WHERE masp = @MaSP ";

            object[] parameters = { maSP };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                tenSP = data.Rows[0]["tensp"].ToString();
            }

            return tenSP; 
        }

        public SanPhamDTO GetSPByMaSP(string maSP)
        {
            string tenSP = string.Empty;
            string query = "SELECT * FROM sanpham WHERE masp = @MaSP ";

            object[] parameters = { maSP };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            SanPhamDTO dataSP = new SanPhamDTO();

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
                dataSP = product;
            }
            return dataSP;
        }

        public bool InsertProduct(string masp, string tensp, string loaisp, string nhasanxuat, string quycach, string xuatxu, bool canketoa, bool trangthai)
        {
            string query = "INSERT INTO sanpham(masp ,tensp, loaisp, nhasanxuat, quycach, xuatxu, canketoa, trangthai) VALUES ( @MaSP , @TenSP , @LoaiSP , @NhaSanXuat , @QuyCach , @XuatXu , @CanKeToa , @TrangThai )";
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
       
        public bool UpdateSanPham(string masp, string tensp, string loaisp, string nhasanxuat, string quycach, string xuatxu, bool canketoa)
        {
            string query = "UPDATE sanpham SET tensp = @TenSP , loaisp = @LoaiSP , nhasanxuat = @NhaSanXuat , quycach = @QuyCach , xuatxu = @XuatXu , canketoa = @CanKeToa WHERE masp = @MaSP ";
            object[] parameters =
            {
                tensp,
                loaisp,
                nhasanxuat,
                quycach,
                xuatxu,
                canketoa,
                masp

            };
            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public bool UpdateTrangThaiSanPham(string MaSP, bool TrangThai)
        {
            string query = "UPDATE sanpham SET trangthai = @TrangThai WHERE masp = @MaSP ";

            object[] parameters =
            {
                TrangThai,
                MaSP
            };

            int result = DataProvider.Instance.ExecuteNonQuery(query, parameters);
            return result > 0;
        }
        public int getSoLuongByMaSP(string MaSP)
        {
            int soLuong=0;
            string query = "SELECT SUM(soLuong) AS soLuong FROM chitietsanpham WHERE masp = @MaSP GROUP BY masp;";
            object[] parameters = { MaSP };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                soLuong=Convert.ToInt16(data.Rows[0]["soLuong"].ToString());
            }

            return soLuong;
        }
    }
}
