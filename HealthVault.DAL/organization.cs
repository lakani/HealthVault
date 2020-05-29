using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using HealthVault.Entity.Model;
using HealthVault.Entity.Context;

namespace HealthVault.DAL
{
    public partial class organization
    {
        public IEnumerable<organization> Filter(organization filterObj)
        {
            return from c in db.organization
                   where c.identifier == filterObj.identifier
                   select c;
        }
        
    }
}
