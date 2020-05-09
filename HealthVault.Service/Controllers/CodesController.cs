using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HealthVault.Entity.Model;
using HealthVault.Entity.Context;
using HealthVault.Shared.System.Extensions;


namespace HealthVault.Service.Controllers  
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodesController : ControllerBase
    {  
  
        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()

        [HttpGet]  
        [Route("v1/api/codes/city")]  
        public IEnumerable<lut_city> GetCity(string Identifier)  
        {
            var db = new HealthvaultContext();

            try
            {
                if (string.IsNullOrEmpty(Identifier))
                    return db.lut_city.ToList();
                else
                {
                    short res;
                    if (false == short.TryParse(Identifier, out res))
                        throw new ArgumentOutOfRangeException("identifier");

                    return from c in db.lut_city
                           where c.Identifier == res
                           select c;
                }
            }
            catch
            {
                throw;
            }
        }
    

        //lut_organizationtype
        [HttpGet]
        [Route("v1/api/codes/organizationtype")]
        public IEnumerable<lut_organizationtype> GetOrganizationType(string identifier)
        {
            var db = new HealthvaultContext();

            try
            {
                if(string.IsNullOrEmpty(identifier))
                    return db.lut_organizationtype.ToList();
                else
                {
                    short res;
                    if (false == short.TryParse(identifier, out res))
                        throw new ArgumentOutOfRangeException("identifier");

                    return from c in db.lut_organizationtype
                    where c.Identifier == res
                    select c;
                }
            }
            catch
            {
                throw;
            }
        }

    }  
}  