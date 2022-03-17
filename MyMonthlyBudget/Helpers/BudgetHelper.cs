using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMonthlyBudget.Helpers
{
    public class BudgetHelper
    {
        public decimal TotalBalance { get; set; }
        
        public static decimal ValueByPercentage(decimal percentual, decimal money)
        {
            if(percentual <= 0) 
                System.Console.WriteLine("ERROR: The value passed for the budget's percentual should be higher than 0!");
            return ( money * percentual / 100 );
        }

    }
}