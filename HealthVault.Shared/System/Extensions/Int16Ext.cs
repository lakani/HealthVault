namespace HealthVault.Shared.System.Extensions
{
    public static class ShortExt
    {
        public static short TryParse(this short i, string s, short Def)
        {
            short res;
            if (true == short.TryParse(s, out res))
                return res;
            else
                return Def;
        }

    }
}
