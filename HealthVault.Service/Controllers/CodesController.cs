using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HealthVault.Entity.Model;

  
namespace HealthVault.Service.Controllers  
{  
    public class CodesController : Controller  
    {  
  
        //[HttpGet]
        //public IEnumerable<WeatherForecast> Get()

        [HttpGet]  
        [Route("v1/api/codes/city/{id}")]  
        public IEnumerable<lut_city> GetCityByID(string id)  
        {  
            lut_city[] cities = new lut_city[]
            {
                new lut_city{Identifier = 1, Name = "Cairo"},
                new lut_city{Identifier = 2, Name = "Alex"}
            };

            return cities;

        }

        [HttpGet]  
        [Route("v1/api/codes/city")]  
        public IEnumerable<lut_city> GetCities()  
        {  
            lut_city[] cities = new lut_city[]
            {
                new lut_city{Identifier = 1, Name = "Cairo"},
                new lut_city{Identifier = 2, Name = "Alex"}
            };

            return cities;
        }
    }  
}  