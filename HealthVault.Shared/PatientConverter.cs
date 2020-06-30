using System;
using HealthVault.Entity.Model;
using HealthVault.Shared.System.Extensions;
using System.Collections.Generic;

namespace HealthVault.Shared.ParamsConverter
{
    class PatientConverter
    {
        public static patient ConvertParams(string Identifier, string active, string type,
                           string address_city, string address_state, string partOf)
        {
            return new patient();

        }
    }
}
