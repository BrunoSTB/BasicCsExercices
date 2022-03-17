using MyMonthlyBudget.Helpers;
using MyMonthlyBudget.Objects;
using ClosedXML.Excel;

namespace MyMonthlyBudget
{
    public class ExcelFile
    {
        private static XLWorkbook workbook = new XLWorkbook();

        public ExcelFile(string? FilePath = null)
        {
            if(string.IsNullOrEmpty(FilePath))
                CreateExcelFile();
        }
        public static void CreateExcelFile()
        {
            var personalBudget = new PersonalBudget();
            var worksheet = workbook.Worksheets.Add("My Budget");
            worksheet.Range("A1:Z1000").Style.Fill.BackgroundColor = XLColor.Gray;

            CreateTable(worksheet, "Living Expenses", "B", "C", personalBudget.LivingEssentials);
            CreateTable(worksheet, "Discretionary Expenses", "F", "G", personalBudget.DiscretionaryExpenses);
            CreateTable(worksheet, "Savings", "J", "K", personalBudget.Savings);

            workbook.SaveAs("MyBudget.xlsx");
        }

        private static void CreateTable(IXLWorksheet worksheet, string tableName,string startCol, string finishCol, BudgetHelper Budget) 
        {
            var columnOne = worksheet.Column($"{startCol}");
            var columnTwo =worksheet.Column($"{finishCol}");
            columnOne.Width =18;
            columnTwo.Width =13;
            
            var tableHeading = worksheet.Range(columnOne.Cell(1), columnTwo.Cell(3));
            StyleTableHeading(tableHeading);

            StyleMoneyColumn(columnTwo);

            columnOne.Cell(1).Value = tableName;
            worksheet.Range(columnOne.Cell(1), columnTwo.Cell(1)).Merge();

            columnOne.Cell(2).Value = "Starting";
            columnTwo.Cell(2).Value = Budget.TotalBalance;

            columnOne.Cell(3).Value = "Remaining";
            columnTwo.Cell(3).FormulaA1 = $"{finishCol}2+SUM({finishCol}4:{finishCol}50)";

            var tableBody = worksheet.Range(columnOne.Cell(4), columnTwo.Cell(50)); 
            StyleTableBody(tableBody);
        }


        public static void StyleTableBody(IXLRange tableBody)
        {
            tableBody.Style.Fill.BackgroundColor = XLColor.LightGray;
            tableBody.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
            tableBody.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
        }

        public static void StyleTableHeading(IXLRange tableHeading)
        {
            tableHeading.Style.Font.Bold = true;
            tableHeading.Style.Fill.BackgroundColor = XLColor.DarkGray;
            tableHeading.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
            tableHeading.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
            tableHeading.Style.Border.BottomBorder = XLBorderStyleValues.Medium;
            
        }

        public static void StyleMoneyColumn(IXLColumn columnTwo)
        {
            columnTwo.AddConditionalFormat().WhenEqualOrGreaterThan(0).Fill.BackgroundColor = XLColor.PastelGreen;
            columnTwo.AddConditionalFormat().WhenLessThan(0).Fill.BackgroundColor = XLColor.PastelRed;
            columnTwo.Style.NumberFormat.Format = "$ #,##0.00";
        }
    }
}





