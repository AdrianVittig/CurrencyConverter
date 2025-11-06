using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    // Class with hardcoded currency data
    internal class CurrencyData
    {
        // Method to get all available currencies
        public List<Currency> GetAll()
        {
            return new List<Currency>
            {
                new Currency("USD", "US Dollar", 1.0m),
                new Currency("EUR", "Euro", 0.92m),
                new Currency("BGN", "Bulgarian Lev", 1.80m),
                new Currency("GBP", "British Pound", 0.79m),
                new Currency("JPY", "Japanese Yen", 151.3m),
                new Currency("AUD", "Australian Dollar", 1.52m)
            };

        }
    }
}
