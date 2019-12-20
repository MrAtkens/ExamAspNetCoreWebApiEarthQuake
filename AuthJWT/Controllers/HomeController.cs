using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using AuthJWT.DTOs;
using AuthJWT.Models;
using AuthJWT.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace AuthJWT.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class HomeController : ControllerBase
    {
        private readonly EarthQuakeService earthQuakeService;
        public HomeController(EarthQuakeService earthQuakeService)
        {
            this.earthQuakeService = earthQuakeService;
        }

        [HttpGet]
        public IActionResult GetSecureInfo()
        {
            string data = Request.Headers["Authorization"].ToString();
            string jwtToken = data.Remove(0, 7); 
            var handler = new JwtSecurityTokenHandler();
            var tokenMeta = handler.ReadToken(jwtToken) as JwtSecurityToken;
            return Ok(new { tokenMeta.Payload });
        }

        [HttpPost]
        public async Task<IActionResult> GetEarthQuakes(CountDTO count)
        {
            JsonListEarthQuake earthQuakes = await earthQuakeService.GetEarthQuake(count.Count);
            return Ok(new { earthQuakes });
        }
    }
}