using Newtonsoft.Json;

namespace webmobiapi.wemobiapi.Model
{
    public class LoginViewModel
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}