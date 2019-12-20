using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthJWT.Models
{
    public class JsonEarthQuake
    {
        [JsonProperty(PropertyName = "properties")]
        public EarthQuake Properties { get; set; }
    }
}
