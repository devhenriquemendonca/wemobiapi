using Newtonsoft.Json;

namespace webmobiapi.wemobiapi.Model
{
    public class DestinationViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
    }
}