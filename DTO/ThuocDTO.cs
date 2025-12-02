namespace DTO
{
    public class ThuocDTO
    {
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; } = "";
        public string LoaiThuoc { get; set; } = "";
        public DateTime? NSX { get; set; }
        public DateTime? HanSuDung { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; } = "";
    }
}
