using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Helpers
{
    public static class ReflectionHelpers
    {


        //REturns what we should be looking for in the segment loop.
        public static string GetSegmentID(this Type item)
        {
            return item.Name.Replace("Seg", "");
        }


        public static Type GetUnderlyingType(this Type source)
        {
            if (source.IsGenericType
                && (source.GetGenericTypeDefinition() == typeof(Nullable<>)))
            {
                // source is a Nullable type so return its underlying type
                return Nullable.GetUnderlyingType(source);
            }

            // source isn't a Nullable type so just return the original type
            return source;
        }
    }
}
