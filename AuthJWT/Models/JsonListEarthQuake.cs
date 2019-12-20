using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthJWT.Models
{
    public class JsonListEarthQuake
    {
        [JsonProperty(PropertyName = "features")]
        public List<JsonEarthQuake> Features { get; set; }
    }
}
