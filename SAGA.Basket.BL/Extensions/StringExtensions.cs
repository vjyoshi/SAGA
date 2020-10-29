using System;

namespace SAGA.Basket.BL.Extensions
{
    public static class StringExtensions
    {
        public static int? ToNullableInt(this string s)
        {
            int i;
            if (int.TryParse(s, out i)) return i;
            return null;
        }

        public static int ToInt(this string s)
        {
            int i;
            if (int.TryParse(s, out i))
                return i;
            else
                return 0;
        }

        public static DateTime ToDateTime(this string s)
        {
            DateTime d;
            if (DateTime.TryParse(s, out d)) return d;
            return d;
        }
    }
}
