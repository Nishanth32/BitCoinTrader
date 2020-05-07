using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Nextmethod.Cex;
using System.Runtime.CompilerServices;

namespace SimpleExample.LocalArbitrage
{
    internal class ArbitrageCalculator
    {
        private CexApi CexClient { get; set; }

        public ArbitrageCalculator(CexApi client)
        {
            this.CexClient = client;
        }


        public void GetAllCurrencyPairs(bool logparis=true)
        {
            var symbolPairType = typeof(SymbolPair);
            PropertyInfo[] propertyInfo = symbolPairType.GetProperties(BindingFlags.Public|BindingFlags.Static);
            Dictionary<string, SymbolPair> currencyToSymbolPairs = propertyInfo.ToDictionary(x => x.Name, y => y.GetValue(null, null) as SymbolPair);

            if (logparis) 
            {
                Console.WriteLine(string.Join("\n", currencyToSymbolPairs.Keys));                    
            }           

        }

    }
}
