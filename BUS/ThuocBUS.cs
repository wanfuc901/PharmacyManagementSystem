using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class ThuocBUS
    {
        public static DataTable GetAll() => ThuocDAO.GetAll();
        public static bool Insert(ThuocDTO thuoc) => ThuocDAO.Insert(thuoc);
        public static bool Update(ThuocDTO thuoc) => ThuocDAO.Update(thuoc);
        public static bool Delete(int maThuoc) => ThuocDAO.Delete(maThuoc);
        public static DataTable Search(string keyword) => ThuocDAO.Search(keyword);
        public static ThuocDTO GetById(int maThuoc) => ThuocDAO.GetById(maThuoc);
        public static bool UpdateSoLuong(int maThuoc, int soLuongThayDoi)
            => ThuocDAO.UpdateSoLuong(maThuoc, soLuongThayDoi);
        public static List<ThuocDTO> GetList() => ThuocDAO.GetList();
    }
}
