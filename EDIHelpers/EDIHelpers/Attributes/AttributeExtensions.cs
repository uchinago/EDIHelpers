using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EDIHelpers.Attributes
{
    public static class AttributeExtensions
    {

        public static bool HasAttribute<T>(this ICustomAttributeProvider provider) where T : Attribute
        {
            var atts = provider.GetCustomAttributes(typeof(T), true);
            return atts.Length > 0;
        }




    }
}
