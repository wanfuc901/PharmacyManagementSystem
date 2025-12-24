namespace DTO
{
    public class CT_PhieuNhapDTO
    {
        public int Id { get; set; }
        public int MaPN { get; set; }
        public int MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal ThanhTien => SoLuong * GiaNhap;
    }
}
