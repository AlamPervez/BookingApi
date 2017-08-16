using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Net.Http;

namespace BookingApi.Models
{
    public static class CurrencyConverter
    {
        public static readonly Dictionary<Currency, decimal> rates;

        static CurrencyConverter()
        {
            rates = new Dictionary<Currency, decimal>();
            //conversion rates w.r.t USD
            rates.Add(Currency.EUR, 0.84998M);
            rates.Add(Currency.INR, 64.17M);
            rates.Add(Currency.GBP, 0.77046M);
            rates.Add(Currency.USD, 1M);
        }

        //EUR, USD, 200
        public static decimal Convert(Currency from, Currency to, decimal value)
        {

            return value / rates[from] * rates[to];

        }

    }
}
