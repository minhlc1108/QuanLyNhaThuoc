using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public SanPhamDTO()
        {
        }

        public string MaSP { get; set; }
        public string LoaiSP { get; set; }
        public string NhaSanXuat { get; set; }
        public string TenSP { get; set; }
        public string QuyCach { get; set; }
        public string XuatXu { get; set; }
        public bool CanKeToa { get; set; }
        public bool TrangThai { get; set; }

        public SanPhamDTO(string maSP, string loaiSP, string nhaSanXuat, string tenSP, string quyCach, string xuatXu, bool canKeToa, bool trangThai)
        {
            MaSP = maSP;
            LoaiSP = loaiSP;
            NhaSanXuat = nhaSanXuat;
            TenSP = tenSP;
            QuyCach = quyCach;
            XuatXu = xuatXu;
            CanKeToa = canKeToa;
            TrangThai = trangThai;
        }
    }

}
