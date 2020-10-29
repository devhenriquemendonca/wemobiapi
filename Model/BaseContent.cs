namespace webmobiapi
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class BaseContent<T>
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("result")]
        public IList<T> Result { get; set; } = new List<T>();
    }
}