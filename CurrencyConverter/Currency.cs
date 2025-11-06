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
        public string Code { get; }
        public string Name { get; }
        public decimal RateToUSD { get; }

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
