using System;
using System.Linq;
using MyMonthlyBudget.Helpers;

namespace MyMonthlyBudget.Objects
{
    public class PersonalBudget : BudgetHelper
    {
        public LivingEssentials LivingEssentials { get; private set; }
        public DiscretionaryExpenses DiscretionaryExpenses { get; private set; }
        public Savings Savings { get; private set; }
    
        public PersonalBudget()
        {
            TotalBalance = GetIncome();

            LivingEssentials = new ( ValueByPercentage( Consts.LIVING_EXPENSES_PERCENTAGE, TotalBalance ) );
            DiscretionaryExpenses = new ( ValueByPercentage( Consts.DISCRETIONARY_EXPENSES_PERCENTAGE, TotalBalance ) );
            Savings = new ( ValueByPercentage( Consts.SAVINGS_PERCENTAGE, TotalBalance ) );
        }

        public decimal GetIncome()
        {
            while( true )
            {
                System.Console.Write("Type in your income: ");
                var incomeAsString = Console.ReadLine();

                try
                {
                    var incomeAsDecimal = Convert.ToDecimal(incomeAsString );
                    
                    var commaSeparatedIncome = incomeAsString.Split(",");
                    var inputHasCommas = commaSeparatedIncome.Count() > 1
                        ? true
                        : false;

                    if (inputHasCommas)
                    {
                        var digitsAfterComma = 0;
                        for(var i = 1; i < commaSeparatedIncome.Count(); i++)
                            digitsAfterComma += commaSeparatedIncome[i].Length;
                        var exponent = Convert.ToDecimal( Math.Pow(10, digitsAfterComma) );
                        return incomeAsDecimal / exponent;
                    }
                    return incomeAsDecimal;
                }
                catch(Exception)
                {
                    System.Console.WriteLine("Please type only a valid number!");
                }                
            }
        }
    }
}