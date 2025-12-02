using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace BUS
{
    public class ExportHelper
    {
        public static void ExportToExcel(DataGridView dgv, string sheetName)
        {
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.");
                return;
            }

            Excel.Application app = new Excel.Application();
            Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Sheets[1];
            ws = (Excel.Worksheet)wb.ActiveSheet;
            ws.Name = sheetName;

            // Header
            for (int i = 1; i <= dgv.Columns.Count; i++)
                ws.Cells[1, i] = dgv.Columns[i - 1].HeaderText;

            // Dữ liệu
            for (int i = 0; i < dgv.Rows.Count; i++)
                for (int j = 0; j < dgv.Columns.Count; j++)
                    ws.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";

            SaveFileDialog save = new SaveFileDialog();
            save.FileName = sheetName + ".xlsx";
            save.Filter = "Excel files (*.xlsx)|*.xlsx";
            if (save.ShowDialog() == DialogResult.OK)
            {
                wb.SaveAs(save.FileName);
                MessageBox.Show("Xuất Excel thành công!");
            }

            app.Quit();
        }
    }
}
