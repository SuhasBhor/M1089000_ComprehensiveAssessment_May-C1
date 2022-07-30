using NPOI.XSSF.UserModel;
using System;


namespace TideWebsite_NUnit.Utility
{
    public class ExcelSheet
    {
        public static string excelRead(int rowNumber, int cellNumber)
        {
            String path = @"C:\Users\mindc1may35\Desktop\ComprehensiveAssessment\Testing\AutomationTesing\TideWebsite_NUnit\Utility\TestData.xlsx";
            XSSFWorkbook workbook = new XSSFWorkbook(File.Open(path, FileMode.Open));
            var sheet = workbook.GetSheetAt(0).GetRow(rowNumber).GetCell(cellNumber).StringCellValue.Trim();
            return sheet;
        }
    }
}
