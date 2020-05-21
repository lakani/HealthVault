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
    //[Route("api/[controller]")]
    //[ApiController]
    public class ResourcesController : ControllerBase
    {
        /*
        active                  bool            Organization.active
        address                 string          Organization.address
        address-city            string          Organization.address.city
        address-country         string          Organization.address.country
        address-postalcode      string          Organization.address.postalCode
        address-state           string          Organization.address.state
        address-use             token           Organization.address.use
        endpoint                reference       Organization.endpoint
        identifier              token           Organization.identifier
        name                    string          Organization.name | Organization.alias
        partof                  reference       Organization.partOf
        phonetic                string          Organization.name
        type                    token           Organization.type
        */

        [HttpGet]
        //[Route("v1/api/resources/organization/")]
        [Route("v1/api/resources/organization/")]
        public IEnumerable<organization> GetOrganization(string Identifier, string addressCity)
        {
            var db = new HealthvaultContext();

            try
            {
                if (string.IsNullOrEmpty(Identifier))
                    return db.organization.ToList();
                else
                {
                    short res;
                    if (false == short.TryParse(Identifier, out res))
                        throw new ArgumentOutOfRangeException("identifier");

                    return from c in db.organization
                           where c.identifier == res
                           select c;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [HttpGet]
        //[Route("v1/api/resources/organization/")]
        [Route("v1/api/resources/{or}/download")]
        public IEnumerable<organization> GetDownload(string or/*string res/*, string Identifier*/)
        {
            var db = new HealthvaultContext();

            try
            {
                return db.organization.ToList();
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}