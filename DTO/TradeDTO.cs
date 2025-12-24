using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
 
        public class TradeDTO
    {
        public string Ca { get; set; } = "";
        public string NhanVien { get; set; } = "";
        public string ThanhToan { get; set; } = "";
        public int MaHD { get; set; }
        public int? MaKH { get; set; }
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; } = "";
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
        public DateTime NgayLap { get; set; }
    }
    }

