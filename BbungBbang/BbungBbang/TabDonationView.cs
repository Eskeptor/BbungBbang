using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace BbungBbang
{
    public partial class TabDonationView : Form
    {
        public TabDonationView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 생성한 보고서를 엑셀로 내보내는 메소드
        /// </summary>
        /// <returns></returns>
        private bool ExportToExcel(DateTime dateTime)
        {
            // https://jasmintime.com/111
            // https://ehdrn.tistory.com/431
            // http://www.csharpstudy.com/Practical/Prac-excel.aspx
            bool bResult = false;

            Excel.Application excelApp = null;
            Excel.Workbook excelWorkbook = null;
            Excel.Worksheet excelWorksheet = null;

            try
            {
                excelApp = new Excel.Application();
                excelWorkbook = excelApp.Workbooks.Add();
                excelWorksheet = excelWorkbook.ActiveSheet as Excel.Worksheet;
                //excelWorksheet = excelWorkbook.Worksheets.Item[1] as Excel.Worksheet;

                // 셀 병합 =============================================================================================
                // 보고서 타이틀
                string strText = string.Format("{0}년 {1}월 {2}일({3}째주) 회계보고서"
                    , dateTime.Year, dateTime.Month, dateTime.Day, GetWeeks(dateTime));
                Global.MergeCell(ref excelWorksheet, "A2", "J2", 2, 1, 20, true, strText, Color.FromArgb(204, 255, 255));

                // 전주까지의 잔액
                Global.MergeCell(ref excelWorksheet, "B4", "D4", 4, 2, 12, true, "전주까지의 잔액", Color.White);
                Global.MergeCell(ref excelWorksheet, "E4", "G4", 4, 7, 12, true, "Test", Color.White);

                // 금주총수입
                Global.MergeCell(ref excelWorksheet, "B5", "D5", 5, 2, 12, true, "금 주 총 수 입", Color.FromArgb(255, 255, 153));
                Global.MergeCell(ref excelWorksheet, "E5", "G5", 5, 7, 12, true, "Test", Color.FromArgb(255, 255, 153));

                // 금주총지출
                Global.MergeCell(ref excelWorksheet, "B6", "D6", 6, 2, 12, true, "금 주 총 지 출", Color.White);
                Global.MergeCell(ref excelWorksheet, "E6", "G6", 6, 7, 12, true, "Test", Color.White);

                // 현잔액
                Global.MergeCell(ref excelWorksheet, "B7", "D7", 7, 2, 12, true, "현      잔      액", Color.FromArgb(204, 255, 255));
                Global.MergeCell(ref excelWorksheet, "E7", "G7", 7, 7, 12, true, "Test", Color.FromArgb(204, 255, 255));

                // 누계
                Global.MergeCell(ref excelWorksheet, "H4", "J4", 4, 8, 12, true, "누 계", Color.White);

                // 누계 - 수입
                excelWorksheet.Cells[5, 8].Font.Size = 12;
                excelWorksheet.Cells[5, 8].Font.Bold = true;
                excelWorksheet.Cells[5, 8] = "수입";
                Global.MergeCell(ref excelWorksheet, "I5", "J5", 5, 9, 12, true, "Test", Color.White);

                // 누계 - 지출
                excelWorksheet.Cells[6, 8].Font.Size = 12;
                excelWorksheet.Cells[6, 8].Font.Bold = true;
                excelWorksheet.Cells[6, 8] = "지출";
                Global.MergeCell(ref excelWorksheet, "I6", "J6", 6, 9, 12, true, "Test", Color.White);
                // ====================================================================================================

                // 셀 그리기 ===========================================================================================
                Global.DrawLineCell(ref excelWorksheet, "B4", "G7", Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                Global.DrawLineCell(ref excelWorksheet, "B4", "D7", Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, true);
                Global.DrawLineCell(ref excelWorksheet, "E4", "G7", Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, true);
                Global.DrawLineCell(ref excelWorksheet, "H4", "J6", Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThin);
                Global.DrawLineCell(ref excelWorksheet, "H4", "J6", Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick, true);
                // ====================================================================================================


                excelWorkbook.SaveAs(@"E:\Test.xls", Excel.XlFileFormat.xlWorkbookNormal);
                excelWorkbook.Close(true);
                excelApp.Quit();
                bResult = true;
            }
            finally
            {
                ReleaseExcel(excelWorksheet);
                ReleaseExcel(excelWorkbook);
                ReleaseExcel(excelApp);
            }

            return bResult;
        }

        private static void ReleaseExcel(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        /// <summary>
        /// 엑셀 내보내기 버튼 액션
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel(DateTime.Now);
        }


        private int GetWeeks(DateTime dateTime)
        {
            int nWeeks = 0;

            DateTime baseTime = new DateTime(dateTime.Year, dateTime.Month, 1);
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;
            nWeeks = calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstDay, DayOfWeek.Sunday)
                   - calendar.GetWeekOfYear(baseTime, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);

            return nWeeks;
        }
    }
}
