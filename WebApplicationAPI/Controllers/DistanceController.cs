using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplicationAPI.Entity;
using WebApplicationAPI.Interfaces;
using WebApplicationAPI.Services;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DistanceController : ControllerBase
    {
         
        private readonly IDistanceService _distanceService;

        public DistanceController(IDistanceService distanceService)
        {    
            _distanceService = distanceService;
        }

        [HttpGet]
        public async Task<Distance> Get(string codePost)
        {         
            return await _distanceService.GetDistance(codePost);
                     
        }
      
    }
}
