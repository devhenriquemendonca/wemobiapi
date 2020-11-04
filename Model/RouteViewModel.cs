using Newtonsoft.Json;

namespace webmobiapi.wemobiapi.Model
{

    public class RouteViewModel
    {
        [JsonProperty("origin")]
        public int Origin { get; set; }

        [JsonProperty("destination")]
        public int Destination { get; set; }

        [JsonProperty("departureDate")]
        public string DepartureDate { get; set; }

    }
}