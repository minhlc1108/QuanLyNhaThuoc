using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TieuHuyDTO
    {
        public int MaCT { get; set; } // Mã chi tiết sản phẩm
        public DateTime NgayTieuHuy { get; set; } // Ngày tiêu hủy
        public string NguoiLap { get; set; } // Người lập đơn tiêu hủy
        public string LyDo { get; set; } // Lý do tiêu hủy
        public decimal? ThietHai { get; set; } // Thiệt hại, kiểu decimal và có thể null

        public TieuHuyDTO(int maCT, DateTime ngayTieuHuy, string nguoiLap, string lyDo, decimal? thietHai)
        {
            MaCT = maCT;
            NgayTieuHuy = ngayTieuHuy;
            NguoiLap = nguoiLap;
            LyDo = lyDo;
            ThietHai = thietHai;
        }

        public TieuHuyDTO() { }
    }

}
