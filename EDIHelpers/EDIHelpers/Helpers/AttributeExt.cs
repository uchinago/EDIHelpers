using System;
using System.Reflection;

namespace EDIHelpers.Helpers
{
    public static class AttributeExt
    {
        /// <summary>
        /// Time: 15 Minutes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="provider"></param>
        /// <returns></returns>
        public static bool HasAttribute<T>(this ICustomAttributeProvider provider) where T : Attribute
        {
            var atts = provider.GetCustomAttributes(typeof(T), true);
            return atts.Length > 0;
        }
    }
}