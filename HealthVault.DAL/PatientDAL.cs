using HealthVault.Entity.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using Model = HealthVault.Entity.Model;

namespace HealthVault.DAL
{
    public partial class PatientDAL
    {
        public IEnumerable<Model.patient> GetAll()
        {
            var db = new HealthvaultContext();
            return db.patient.ToList();
        }


        /*
         * string           Identifier,
         * string           addressCity
         string             addressState
         * 
         * */

        /*
         * blic IEnumerable<organization> GetOrganization(     string Identifier,
                                                            string addressCity,
                                                            string partof,
                                                            string type,
                                                            string active,
                                                            string addressState)
        */

        public IEnumerable<Model.patient> Filter(Model.patient filterObj)
        {

            var db = new HealthvaultContext();

            var ret = from o in db.patient
                      select o;

            if (String.IsNullOrEmpty(filterObj.identifier) == false)
                ret = ret.Where(o => o.identifier == filterObj.identifier);

            if (filterObj.address_city > 0)
                ret = ret.Where(o => o.address_city == filterObj.address_city);

            if (String.IsNullOrEmpty(filterObj.address) == false)
                ret = ret.Where(o => o.address.Contains(filterObj.address) == true);

            if (filterObj.deceased == true)
            {
                ret = ret.Where(o => o.deceased == true);
                if( filterObj.deceased_date > DateTime.MinValue)
                    ret = ret.Where(o => o.deceased_date == filterObj.deceased_date);
            }

            if (String.IsNullOrEmpty(filterObj.email) == false)
                ret = ret.Where(o => o.email.Contains(filterObj.email) == true);

            if (String.IsNullOrEmpty(filterObj.familyname) == false)
                ret = ret.Where(o => o.familyname.Contains(filterObj.familyname) == true);

            if (String.IsNullOrEmpty(filterObj.name) == false)
                ret = ret.Where(o => o.name.Contains(filterObj.name) == true);


            return ret.ToList();
        }

    }
}
