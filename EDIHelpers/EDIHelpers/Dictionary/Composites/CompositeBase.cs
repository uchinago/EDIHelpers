using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Converters;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Composites
{
    public class CompositeBase
    {

        CultureInfo provider = CultureInfo.InvariantCulture;
        private BindingFlags internalFlags = (BindingFlags.Instance | BindingFlags.NonPublic);

        public CompositeBase(char subelement = '^')
        {
            
        }


        internal void FromEDIString(string segment, char elem = '^')
        {
            if (!String.IsNullOrWhiteSpace(segment))
            {
                string[] elements = segment.Split(elem);
                int x = 0;

                foreach (PropertyInfo propertyInfo in GetType().GetProperties())
                {
                    if (propertyInfo.CanRead)
                    {

                        Attribute[] attrs = Attribute.GetCustomAttributes(propertyInfo);
                        propertyInfo.SetValue(this, elements[x].FromEDIString(propertyInfo.PropertyType, attrs), null);
                        x++;
                        if (x > elements.Count() - 1)
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// This is the default write method.
        /// In Case of the EBSegment it needs to overwrite this 
        /// </summary>
        /// <returns></returns>
        internal string ToEDIString(char elem = '^')
        {
            StringBuilder rtnVal = new StringBuilder();
            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {
                if (propertyInfo.CanRead)
                {

                    object propertyValue = propertyInfo.GetValue(this, null);
                    if (propertyValue != null)
                    {
                        rtnVal.Append(propertyInfo.EDI2String(propertyValue));
                    }
                    rtnVal.Append(elem);
                }
            }

            string tmp = rtnVal.ToString().TrimEnd(elem);

            return rtnVal.ToString().TrimEnd(elem);
        }


        private string _safeString(object original)
        {
            if (original == null)
                return "";
            else
            {
                return original.ToString();

            }
        }

    }
}
