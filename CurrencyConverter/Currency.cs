using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    // Class representing a currency with its code, name, and exchange rate to USD
    internal class Currency
    {
        private string Code { get; set; }
        private string Name { get; set;  }
        private decimal RateToUSD { get; set; }

        // Constructor to initialize currency properties
        public Currency(string code, string name, decimal rateToUSD)
        {
            Code = code;
            Name = name;
            RateToUSD = rateToUSD;
        }
        
        public override string ToString()
        {
            return $"{Name} ({Code})";
        }
    }
}
