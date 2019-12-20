using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthJWT.Models
{
    public class EarthQuake
    {
        [JsonProperty(PropertyName = "mag")]
        public double Magnitude { get; set; }
        [JsonProperty(PropertyName = "place")]
        public string Place { get; set; }
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; } 
    }
}
