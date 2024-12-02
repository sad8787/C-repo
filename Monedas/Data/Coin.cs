using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Monedas.Data
{
    public class Coin
    {
        public Meta meta { get; set; }
        public List<Value> values { get; set; }
        public string status { get; set; }

        public string Percentage() 
        {
            return(((double.Parse(values[0].close) - double.Parse(values[1].close)) * 100) / double.Parse(values[1].close)).ToString();
        }
        public string[] CoinToString()
        {
            return new string[] { meta.symbol, values[0].datetime, values[0].open, values[0].high, values[0].low, values[0].close, Percentage() };
        }
       
    }
    public class Meta
    {
        public string symbol { get; set; }
        public string interval { get; set; }
        public string currency_base { get; set; }
        public string currency_quote { get; set; }
        public string type { get; set; }
    }
    public class Value
    {
        public string datetime { get; set; }
        public string open { get; set; }
        public string high { get; set; }
        public string low { get; set; }
        public string close { get; set; }
    }

   
    public class ETHRUB : Coin {}
    public class BTCRUB : Coin { }
    public class USDRUB : Coin { }
    public class EURRUB : Coin { }    
    public class GBPRUB : Coin { }
   
}
