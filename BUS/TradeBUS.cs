using System;
using System.Collections.Generic;
using DTO;
using DAO;

namespace BUS
{
    public class TradeBUS
    {
        public static int ThanhToan(TradeDTO hd, List<TradeDTO> chiTiet)
        {
            if (chiTiet.Count == 0)
                throw new Exception("Giỏ hàng trống!");

            hd.NgayLap = DateTime.Now;
            return TradeDAO.TaoHoaDon(hd, chiTiet);
        }
    }
}
