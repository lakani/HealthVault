using System;

namespace HealthVault.Shared.System.Extensions
{
    public static class ShortExt
    {
        public static short TryParse(this short i, string s)
        {
            short res;
            if (true == short.TryParse(s, out res))
                return res;
            else
                return 0;
        }
    }
}
