using Newtonsoft.Json;

namespace webmobiapi.wemobiapi.Model
{
    public class PlaceViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }
}