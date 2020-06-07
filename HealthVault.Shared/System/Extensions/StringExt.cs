namespace HealthVault.Shared.System.Extensions
{
    public static class StringExt
    {
        public static short TryParseShort(this string str, short DefValue)
        {
            short res;
            if (true == short.TryParse(str, out res))
                return res;
            else
                return DefValue;
        }

        public static void TestTryParse()
        {
            string TestStr = "10";
            short y = TestStr.TryParseShort(0);
        }
    }
}
