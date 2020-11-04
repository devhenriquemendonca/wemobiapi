using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace webmobiapi.wemobiapi.Model
{
    public class RoutesContentViewModel
    {
        [JsonProperty("result")]
        public RouteContentViewModel Result { get; set; }

        [JsonProperty("sucess")]
        public bool Sucess { get; set; }

    }

    public class RouteContentViewModel {

        [JsonProperty("origin")]
        public PlaceViewModel Origin { get; set; }

        [JsonProperty("destination")]
        public PlaceViewModel Destination { get; set; }
        
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        [JsonProperty("servicesList")]
        public IList<ServiceContentViewModel> ServicesList { get; set; } = new List<ServiceContentViewModel>();
    }

    public class RouteContentErroViewModel{

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("sucess")]
        public bool Sucess { get; set; }

    }
}