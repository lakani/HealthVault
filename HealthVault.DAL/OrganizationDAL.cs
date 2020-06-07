using HealthVault.Entity.Context;
using System.Collections.Generic;
using System.Linq;
using Model = HealthVault.Entity.Model;

namespace HealthVault.DAL
{
    public partial class OrganizationDAL
    {
        public IEnumerable<Model.organization> GetAll()
        {
            var db = new HealthvaultContext();
            return db.organization.ToList();
        }
        public IEnumerable<Model.organization> Filter(Model.organization filterObj)
        {

            var db = new HealthvaultContext();

            var ret = from o in db.organization
                      select o;

            if (filterObj.identifier > 0)
                ret = ret.Where(o => o.identifier == filterObj.identifier);
            if (filterObj.address_city > 0)
                ret = ret.Where(o => o.address_city == filterObj.address_city);
            if (filterObj.partOf > 0)
                ret = ret.Where(o => o.partOf == filterObj.partOf);
            if (filterObj.type > 0)
                ret = ret.Where(o => o.type == filterObj.type);

            return ret.ToList();
        }

    }
}
