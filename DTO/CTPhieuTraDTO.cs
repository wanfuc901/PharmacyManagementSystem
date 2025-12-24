namespace DTO
{
    public class CTPhieuTraDTO
    {
        public int Id { get; set; }
        public int MaTra { get; set; }
        public string TenThuoc { get; set; }
        public int SoLuong { get; set; }
        public decimal GiaTra { get; set; }
        public decimal ThanhTien => SoLuong * GiaTra;
    }
}
