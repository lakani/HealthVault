using HealthVault.Entity.Model;
using System;

namespace HealthVault.Shared
{
    public partial class lut_organizationtypeExt
    {
        public static lut_organizationtype ConvertParams(string Identifier)
        {
            lut_organizationtype NewObj = new lut_organizationtype();

            // Convert Identifier
            if (false == string.IsNullOrEmpty(Identifier))
            {
                short temp;
                if (false == short.TryParse(Identifier, out temp))
                    throw new ArgumentOutOfRangeException("identifier");
                else
                    NewObj.Identifier = temp;
            }
            return NewObj;
        }
    }
}
