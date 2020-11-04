namespace webmobiapi.wemobiapi.Model
{
        using Newtonsoft.Json;

    public class UserCreateViewModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("birthDate")]
        public string BirthDate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("cpf")]
        public string Cpf { get; set; }

        [JsonProperty("optin")]
        public bool Optin { get; set; }

        [JsonProperty("refreshPassword")]
        public bool RefreshPassword { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("areaCode")]
        public string AreaCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("registrationCampaign")]
        public string RegistrationCampaign { get; set; }

        [JsonProperty("paymentToken")]
        public string PaymentToken { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("phoneType")]
        public string PhoneType { get; set; }

        [JsonProperty("genre")]
        public string Genre { get; set; }
    }
}