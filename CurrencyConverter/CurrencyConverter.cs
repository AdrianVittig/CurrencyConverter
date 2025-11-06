using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class CurrencyConverter
    {
        // Method to convert an amount from one currency to another
        public decimal Convert(decimal amount, Currency fromCurrency, Currency toCurrency)
        {
            return amount / fromCurrency.RateToUSD * toCurrency.RateToUSD;
        }
    }
}
