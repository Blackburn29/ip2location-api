using System;
using System.Linq;
using Ip2Location.Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ip2Location.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {
        private readonly Ip2LocationContext _database;
        
        public LookupController(Ip2LocationContext database)
        {
            _database = database;
        }
        
        [HttpGet]
        public ActionResult<IpGeoLocation> Get([FromQuery] string ip)
        {
            if (ip == null)
            {
                return BadRequest();
            }

            uint ipNum;
            try
            {
                ipNum = ip.ParseIpAddress();
            }
            catch (FormatException e)
            {
                return BadRequest("Invalid IP Address.");
            }
            
            return _database.IpGeoLocation
                .Where(i => i.IpFrom <= ipNum)
                .OrderByDescending(i => i.IpFrom)
                .FirstOrDefault();
        }
    }
}