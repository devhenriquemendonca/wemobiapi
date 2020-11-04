namespace webmobiapi.wemobiapi.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ErroResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        
        [JsonProperty("validations")]
        public IList<Validation> Validations { get; set; } = new List<Validation>();

    }

    public class Validation{

        [JsonProperty("Key")]
        public string Key { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

 }