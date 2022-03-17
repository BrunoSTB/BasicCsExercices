using MyMonthlyBudget.Helpers;

namespace MyMonthlyBudget.Objects
{
    public class LivingEssentials : BudgetHelper
    {
        public decimal Rent { get; set; }

        public LivingEssentials(decimal startingBudget)
        {
            const decimal RentPercentage = 50M;
            Rent = ValueByPercentage( RentPercentage, startingBudget);
            TotalBalance = startingBudget;
        }
    }
}