using HealthVault.Entity.Model;
using System;

namespace HealthVault.Shared
{
    public partial class lut_cityExt
    {
        public static lut_city ConvertParams(string Identifier)
        {
            lut_city NewObj = new lut_city();

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
