using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMonthlyBudget.Helpers;

namespace MyMonthlyBudget.Objects
{
    public class DiscretionaryExpenses : BudgetHelper   
    {
        public DiscretionaryExpenses(decimal startingBudget) =>
            TotalBalance = startingBudget;
        
    }
}