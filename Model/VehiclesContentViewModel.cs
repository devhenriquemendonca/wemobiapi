using System;
using Newtonsoft.Json;

namespace webmobiapi.wemobiapi.Model
{
    public class VehiclesContentViewModel
    {
       public VehiclesContentResultViewModel Result { get; set; }

    }

    public class VehiclesContentResultViewModel
    {
        [JsonProperty("origin")]
        public PlaceViewModel Origin { get; set; }

        [JsonProperty("destination")]
        public PlaceViewModel Destination { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("serviceId")]
        public int ServiceId { get; set; } 
    }

    public class SeatMapContentViewModel {

        [JsonProperty("serviceId")]
        public int X { get; set; }

        [JsonProperty("serviceId")]
        public int Y { get; set; }

        [JsonProperty("avaliable")]
        public bool Avaliable { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }
    }
}