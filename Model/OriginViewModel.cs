namespace webmobiapi.wemobiapi.Model
{
    using Newtonsoft.Json;

    public class OriginViewModel
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