using System;
using Newtonsoft.Json;

namespace webmobiapi.wemobiapi.Model
{
    public class ServiceContentViewModel
    {
        [JsonProperty("serviceId")]
        public int ServiceId { get; set; }

        [JsonProperty("routeId")]
        public int RouteId { get; set; }

        [JsonProperty("brandId")]
        public int BrandId { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("lineDate")]
        public DateTime? LineDate { get; set; }

        [JsonProperty("departureDate")]
        public DateTime? DepartureDate { get; set; }

        [JsonProperty("arrivalDate")]
        public DateTime? ArrivalDate { get; set; }

        [JsonProperty("freeSeats")]
        public int FreeSeats { get; set; }

        [JsonProperty("totalSeats")]
        public int TotalSeats { get; set; }

        [JsonProperty("price")]
        public Decimal Price { get; set; }

        [JsonProperty("priceWithDiscount")]
        public Decimal PriceWithDiscount { get; set; }

        [JsonProperty("discountValue")]
        public int DiscountValue { get; set; }

        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("classMatch")]
        public string ClassMatch { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("companyId")]
        public int CompanyId { get; set; }
        
        [JsonProperty("sell")]
        public bool Sell{ get; set; }

        [JsonProperty("bpe")]
        public bool Bpe { get; set; }

        [JsonProperty("Km")]
        public Decimal Km { get; set; }

        [JsonProperty("offerId")]
        public int OfferId { get; set; }

        [JsonProperty("discountTypeId")]
        public int DiscountTypeId { get; set; }
                     
        // "offerType": "SERVICE|",
        // "discountType": "VALOR|"
        
    }
}