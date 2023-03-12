using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseEX.Persistence.Model;

namespace HouseEx.Constants
{
    public static class ExpensesConstant
    {
        internal static readonly List<Expense> mockExpenses = new List<Expense>
        {
            new Expense(){Id = 4, Name = "Grocery", Value = 666.00M},
            new Expense(){Id = 5, Name = "Internet", Value = 123.12M},
            new Expense(){Id = 6, Name = "Power", Value = 23.12M},
            new Expense(){Id = 7, Name = "Rent", Value = 35.00M},
            new Expense(){Id = 8, Name = "FoodDelivery", Value = 54M},
            new Expense(){Id = 9, Name = "HealthPlan", Value = 23.34M},
            new Expense(){Id = 10, Name = "DogFood", Value = 55M},
            new Expense(){Id = 11, Name = "DogBath", Value = 22.44M},
            new Expense(){Id = 12, Name = "Travels", Value = 74.11M}
        };
    }
}