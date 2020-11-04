using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace webmobiapi.wemobiapi.Model
{
    public class UserContentViewModel
    {
        [JsonProperty("user")]
        public UserViewModel User { get; set; }
        
        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }
        
        [JsonProperty("authenticated")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("expiredAt")]
        public DateTime ExpiredAt { get; set; }
        
        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class UserViewModel { 
   
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }
        
        [JsonProperty("image")]
        public string Image { get; set; }
        
        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("systemId")]
        public int SystemId { get; set; }

        [JsonProperty("birthDate")]
        public DateTime? BirthDate { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("cpf")]
        public string Cpf { get; set; }

        [JsonProperty("optin")]
        public bool Optin { get; set; }

        [JsonProperty("refreshPassword")]
        public string RefreshPassword { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }
        
        [JsonProperty("document")]
        public string Document { get; set; }
        
        [JsonProperty("areaCode")]
        public string AreaCode { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("Company")]
        public string Company { get; set; }

        [JsonProperty("registrationCampaign")]
        public string RegistrationCampaign { get; set; }

        [JsonProperty("paymentToken")]
        public string PaymentToken { get; set; }

        [JsonProperty("documentType")]
        public int DocumentType { get; set; }

        [JsonProperty("phoneType")]
        public int PhoneType { get; set; }

        [JsonProperty("genre")]
        public int Genre { get; set; }

        [JsonProperty("groups")]
        public string Groups { get; set; }

        [JsonProperty("groupIds")]
        public string GroupIds { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("tokenGoogle")]
        public string TokenGoogle { get; set; }

        [JsonProperty("addresses")]
        public ICollection<string> Addresses { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("totalCount")]
        public string TotalCount { get; set; }

     }
}