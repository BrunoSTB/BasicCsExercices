using MyMonthlyBudget.Helpers;

namespace MyMonthlyBudget.Objects
{
    public class Savings : BudgetHelper
    {
        // public decimal TotalSaved { get; private set; }
        // public decimal FixedIncome { get; set; }   
        // public decimal VariableIncome { get; set; }
        public Savings(decimal startingBudget) =>
            TotalBalance = startingBudget;
    }
}