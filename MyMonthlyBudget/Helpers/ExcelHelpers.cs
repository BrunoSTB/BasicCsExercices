using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace MyMonthlyBudget.Helpers
{
    public class ExcelHelpers
    {
        public static string SumRange(IXLCell startingCell, IXLCell finishingCell) =>
            $"SUM{startingCell}:{finishingCell}";
    }
}