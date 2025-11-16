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
            try
            {
                return amount / fromCurrency.RateToUSD * toCurrency.RateToUSD;
            }
            catch (DivideByZeroException)
            {
                throw new ArgumentException("Conversion rate cannot be zero.");
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred during conversion: " + ex.Message);
            }
        }
    }
}
