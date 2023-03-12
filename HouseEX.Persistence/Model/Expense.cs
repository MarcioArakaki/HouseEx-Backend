using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseEX.Persistence.Model
{
    public class Expense
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Value { get; set; }
    }
}