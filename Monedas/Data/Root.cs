using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monedas.Data;

namespace Monedas.Data
{

    public class Root
    {

        [JsonProperty("ETH/RUB")]
        public ETHRUB ETHRUB { get; set; }

        [JsonProperty("USD/RUB")]
        public USDRUB USDRUB { get; set; }

        [JsonProperty("EUR/RUB")]
        public EURRUB EURRUB { get; set; }

        [JsonProperty("BTC/RUB")]
        public BTCRUB BTCRUB { get; set; }

        [JsonProperty("GBP/RUB")]
        public GBPRUB GBPRUB { get; set; }

    }
}
