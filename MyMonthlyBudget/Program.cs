using System;
using MyMonthlyBudget.Helpers;

namespace MyMonthlyBudget
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nThis calculator uses the following budget format:");
            Console.WriteLine($"{Consts.LIVING_EXPENSES_PERCENTAGE}% Of your total income goes to your living essentials, such as rent, food, energy and so on;");
            Console.WriteLine($"{Consts.DISCRETIONARY_EXPENSES_PERCENTAGE}% Goes to discretionary expenses, like shopping, going out for a meal, giving to charity, etc;");
            Console.WriteLine($"{Consts.SAVINGS_PERCENTAGE}% Is for your future - investing, paying off debts and emergencies.\n");
            new ExcelFile();            
        }
    }
}





