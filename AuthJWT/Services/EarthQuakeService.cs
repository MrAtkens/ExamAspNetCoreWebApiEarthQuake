using AuthJWT.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AuthJWT.Services
{
    public class EarthQuakeService
    {
        public async Task<JsonListEarthQuake> GetEarthQuake(int count)
        {
            var client = new RestClient("https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&limit=" + count);
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteTaskAsync(request);
            var list = JsonConvert.DeserializeObject<JsonListEarthQuake>(response.Content);
            return list;    
        }
    }
}
