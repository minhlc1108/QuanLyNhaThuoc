using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable ThongKeDoanhThu(DateTime ngaybd, DateTime ngaykt)
        {
            string sql = @" SELECT 
               CONCAT(YEAR(ngaylap), '-', LPAD(MONTH(ngaylap), 2, '0')) as NgayLap,
                SUM(CASE WHEN Source = 'hoadon' THEN tongtien ELSE 0 END) AS DoanhThu,
                SUM(CASE WHEN Source = 'phieunhap' THEN tongtien ELSE 0 END) AS ChiPhi
            FROM (
                SELECT ngaylap, tongtien, 'hoadon' AS Source
                FROM hoadon
                UNION ALL
                SELECT ngaylap, tongtien, 'phieunhap' AS Source
                FROM phieunhap
            ) AS CombinedData
                WHERE ngaylap >=  @NgayBD AND ngaylap <= @NgayKT 
            GROUP BY MONTH(ngaylap), YEAR(NGAYlAP) ";

            object[] parameters = { ngaybd, ngaykt };

            return DataProvider.Instance.ExecuteQuery(sql, parameters);
        }

     
        public DataTable ThongKeTonKho(string? loaisp = null)
        {
            string sql;
            if(loaisp == null)
            {
                sql = @"SELECT mact,sanpham.masp, sanpham.loaisp, losx, sanpham.tensp, chitietsanpham.hansd, chitietsanpham.soLuong, sanpham.trangthai FROM chitietsanpham,sanpham WHERE chitietsanpham.masp = sanpham.masp ORDER BY mact ";
                return DataProvider.Instance.ExecuteQuery(sql);
            }
            else
            {
                sql = @"SELECT mact,sanpham.masp, sanpham.loaisp, losx, sanpham.tensp, chitietsanpham.hansd, chitietsanpham.soLuong, sanpham.trangthai FROM chitietsanpham,sanpham 
                        WHERE chitietsanpham.masp = sanpham.masp
                               AND sanpham.loaisp = @loaisp ORDER BY mact";
                return DataProvider.Instance.ExecuteQuery(sql, new object[] { loaisp });
            }
        }

        public DataTable ThongKeSoLuongTonKho(string? loaisp = null)
        {
            string sql;
            if (loaisp == null)
            {
                sql = @"SELECT SUM(chitietsanpham.soluong) as soluong,sanpham.masp FROM chitietsanpham,sanpham WHERE chitietsanpham.masp = sanpham.masp GROUP BY sanpham.masp";
                return DataProvider.Instance.ExecuteQuery(sql);
            }
            else
            {
                sql = @"SELECT SUM(chitietsanpham.soluong) as soluong,sanpham.masp FROM chitietsanpham,sanpham WHERE chitietsanpham.masp = sanpham.masp
                               AND sanpham.loaisp = @loaisp GROUP BY sanpham.masp";
                return DataProvider.Instance.ExecuteQuery(sql, new object[] { loaisp });
            }
        }

        public DataTable ThongKeSapHetHang(string? loaisp = null)
        {
            string sql;
            if (loaisp == null)
            {
                sql = @"SELECT SUM(chitietsanpham.soluong) as soluong,sanpham.masp, sanpham.tensp FROM chitietsanpham,sanpham WHERE chitietsanpham.masp = sanpham.masp AND sanpham.trangthai = 1 AND soLuong < 30 GROUP BY sanpham.masp";
                return DataProvider.Instance.ExecuteQuery(sql);
            }
            else
            {
                sql = @"SELECT SUM(chitietsanpham.soluong) as soluong,sanpham.masp, sanpham.tensp FROM chitietsanpham,sanpham WHERE chitietsanpham.masp = sanpham.masp AND sanpham.trangthai = 1 AND soLuong < 30 AND sanpham.loaisp = @loaisp GROUP BY sanpham.masp";
                return DataProvider.Instance.ExecuteQuery(sql, new object[] { loaisp });
            }
        }

        public DataTable ThongKeSapHetHSD(string? loaisp = null)
        {
            string sql;
            if (loaisp == null)
            {
                sql = @"SELECT 
                         chitietsanpham.mact, 
                         sanpham.masp, 
                         sanpham.tensp,
                         chitietsanpham.losx,
                         chitietsanpham.hansd,
                         DATEDIFF(CURRENT_DATE, chitietsanpham.hansd) AS songay
                            FROM 
                                chitietsanpham 
                            INNER JOIN 
                                sanpham 
                            ON 
                            chitietsanpham.masp = sanpham.masp 
                        WHERE sanpham.trangthai = 1 AND
                      chitietsanpham.hansd < DATE_ADD(CURRENT_DATE, INTERVAL 30 DAY);";
                return DataProvider.Instance.ExecuteQuery(sql);
            }
            else
            {
                sql = @"SELECT 
                         chitietsanpham.mact, 
                         sanpham.masp, 
                         sanpham.tensp, 
                         chitietsanpham.losx,
                         chitietsanpham.hansd,
                         DATEDIFF(CURRENT_DATE, chitietsanpham.hansd) AS songay
                            FROM 
                                chitietsanpham 
                            INNER JOIN 
                                sanpham 
                            ON 
                            chitietsanpham.masp = sanpham.masp 
                        WHERE sanpham.trangthai = 1 AND
                      sanpham.loaisp = @loaisp 
                     AND chitietsanpham.hansd < DATE_ADD(CURRENT_DATE, INTERVAL 30 DAY);";
                return DataProvider.Instance.ExecuteQuery(sql, new object[] { loaisp });
            }
        }

        public DataTable GetListSanPhamBan(int? top)
        {
            string sql;
            if(top != null)
            {
                sql = @"SELECT loaisp,sanpham.masp,tensp,SUM(chitiethoadon.soLuong) as soLuong FROM chitietsanpham,chitiethoadon,sanpham WHERE chitietsanpham.mact = chitiethoadon.mact AND chitietsanpham.masp = sanpham.masp GROUP BY masp ORDER BY soLuong DESC LIMIT @top ";
                return DataProvider.Instance.ExecuteQuery(sql, new object[] { top });
            }
            else
            {
                sql = @"SELECT loaisp,sanpham.masp,tensp,SUM(chitiethoadon.soLuong) as soLuong FROM chitietsanpham,chitiethoadon,sanpham WHERE chitietsanpham.mact = chitiethoadon.mact AND chitietsanpham.masp = sanpham.masp GROUP BY masp ORDER BY soLuong DESC";
                return DataProvider.Instance.ExecuteQuery(sql); 
            }
        }

    }
}
