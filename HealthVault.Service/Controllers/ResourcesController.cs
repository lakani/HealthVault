using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HealthVault.Entity.Model;
using HealthVault.Entity.Context;

namespace HealthVault.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
        [HttpGet]
        [Route("v1/api/Resources/Organization")]
        public IEnumerable<organization> GetOrganization(string Identifier)
        {
            var db = new HealthvaultContext();

            return db.organization.ToList();
        }
    }
}