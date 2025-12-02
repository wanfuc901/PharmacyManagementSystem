using System;
using System.Data;
using DAO;

namespace BUS
{
    public class DoanhThuBUS
    {
        public static DataTable LayBaoCao(DateTime tuNgay, DateTime denNgay)
        {
            return DoanhThuDAO.LayDoanhThu(tuNgay, denNgay);
        }
    }
}
