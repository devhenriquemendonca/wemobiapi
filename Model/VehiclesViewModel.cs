using System;
using Newtonsoft.Json;

namespace webmobiapi.wemobiapi.Model
{
    public class VehiclesViewModel
    {
        [JsonProperty("origin")]
        public int Origin { get; set; }
        
        [JsonProperty("destination")]
        public int Destination { get; set; }
        
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("serviceId")]
        public string ServiceId { get; set; }

    }

}