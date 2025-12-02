using System;
using System.Data;
using DAO;

namespace BUS
{
    public class SearchReportBUS
    {
        public static DataTable Search(string keyword)
        {
            try
            {
                return SearchReportDAO.Search(keyword);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi BUS: " + ex.Message);
            }
        }
    }
}
