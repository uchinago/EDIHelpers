using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EDIHelpers.Converters
{
    public static class Converters
    {
        public static DateTime TimeConverter(this string original)
        {
            switch (original.Trim().Length)
            {
                case 4: return DateTime.ParseExact(original.Trim(), "HHmm", CultureInfo.InvariantCulture);
                case 6: return DateTime.ParseExact(original.Trim(), "HHmmss", CultureInfo.InvariantCulture);
                case 7: return DateTime.ParseExact(original.Trim(), "HHmmssf", CultureInfo.InvariantCulture);
                case 8: return DateTime.ParseExact(original.Trim(), "HHmmssff", CultureInfo.InvariantCulture);
                default:
                    return DateTime.Now;
            }
        }
        
    }
}
