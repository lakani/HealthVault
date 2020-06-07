using HealthVault.Entity.Context;
using HealthVault.Entity.Model;
using System.Collections.Generic;
using System.Linq;

namespace HealthVault.DAL
{
    public partial class CodesDAL
    {
        public IEnumerable<lut_city> lut_city_GetAll()
        {
            var db = new HealthvaultContext();
            return db.lut_city.ToList();
        }

        public IEnumerable<lut_city> lut_city_Filter(lut_city filterObj)
        {
            var db = new HealthvaultContext();

            return from c in db.lut_city
                   where (filterObj.Identifier > 0 && c.Identifier == filterObj.Identifier)
                   select c;
        }

        //lut_organizationtype
        public IEnumerable<lut_organizationtype> lut_organizationtype_GetAll()
        {
            var db = new HealthvaultContext();
            return db.lut_organizationtype.ToList();
        }

        public IEnumerable<lut_organizationtype> lut_organizationtype_Filter(lut_organizationtype filterObj)
        {
            var db = new HealthvaultContext();

            return from c in db.lut_organizationtype
                   where (filterObj.Identifier > 0 && c.Identifier == filterObj.Identifier)
                   select c;
        }

    }
}

