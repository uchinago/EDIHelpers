using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Linq.Mapping;
using System.Reflection;
using System.Text;
using EDIHelpers.Acks;
using EDIHelpers.Attributes;
using EDIHelpers.Converters;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;
using EDIHelpers.Helpers;

namespace EDIHelpers.Dictionary.Segments
{
    public class SegmentBase
    {

        private BindingFlags internalFlags = (BindingFlags.Instance | BindingFlags.NonPublic);
        private string _segmentID ;
        CultureInfo provider = CultureInfo.InvariantCulture;
        public string RawData;

        public SegmentBase(string segmentID)
        {
            _segmentID = segmentID;
        }


        /// <summary>
        /// In order to try to avoid issues with someone calling this wrong
        /// Make it internal as reflection should all happen here...
        /// </summary>
        /// <param name="segment"></param>
        /// <param name="seperators"></param>
        /// <param name="isGeneric">Only used for Acknowledgements</param>
        internal void FromEDIString(string segment, EDIDelim seperators)
        {

            string[] elements = segment.Split(seperators.Element);
            if (GetType() == typeof(GenericSeg))
            {
                _segmentID = elements[0];
                RawData = segment;
            }
            else
            {
                int x = 1;
                foreach (PropertyInfo propertyInfo in GetType().GetProperties())
                {
                    if (propertyInfo.CanRead)
                    {

                        Attribute[] attrs = Attribute.GetCustomAttributes(propertyInfo);

                        object propertyValue = propertyInfo.GetValue(this, null);


                        var bType = propertyInfo.PropertyType.BaseType;
                        if (bType == typeof (CompositeBase))
                        {
                            if (propertyValue == null)
                            {
                                //How do we put this as the property value
                                ConstructorInfo ctor = propertyInfo.PropertyType.GetConstructor(System.Type.EmptyTypes);
                                object instance = ctor.Invoke(null);

                                propertyInfo.SetValue(this, Convert.ChangeType(instance, propertyInfo.PropertyType),
                                                      null);
                                propertyValue = propertyInfo.GetValue(this, null);
                            }

                            //This allowed us to get past the 834 issue... 
                            if (!string.IsNullOrWhiteSpace(elements[x]))
                            {
                                MethodInfo ediMethod = propertyValue.GetType().GetMethod("FromEDIString", internalFlags);
                                //This should always do the later but for testing have it here...
                                ediMethod.Invoke(propertyValue, new object[] {elements[x], seperators.Subelement});
                            }

                            x++;
                            if (x > elements.Count() - 1)
                                break;
                        }
                        else
                        {

                            if (!String.IsNullOrWhiteSpace(elements[x]) ||
                                attrs.Any(ax => ax.GetType() == typeof (EDIFixedLen)))
                            {
                                //The extension of FromEDIString is the actual converter... we need to do this differently
                                //get converter and set value
                                propertyInfo.SetValue(this, elements[x].FromEDIString(propertyInfo.PropertyType, attrs),
                                                      null);
                            }
                            x++;
                            if (x > elements.Count() - 1)
                                break;

                        }

                    }


                }

            }
        }

 

        /// <summary>
        /// This is the default write method.
        /// In Case of the EBSegment it needs to overwrite this 
        /// </summary>
        /// <returns></returns>
        internal string ToEDIString(EDIDelim seperators)
        {
            StringBuilder rtnVal = new StringBuilder(_segmentID + seperators.Element);
            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {
                if (propertyInfo.CanRead)
                {
                    //Attribute[] attrs = Attribute.GetCustomAttributes(propertyInfo);
                    //Custom types need to be done outside.
                    object propertyValue = propertyInfo.GetValue(this, null);
                    if (propertyValue != null)
                    {
                        if (propertyInfo.PropertyType.BaseType == typeof(CompositeBase))
                        {
                            //Grab the function we are going to use
                            MethodInfo method = propertyValue.GetType().GetMethod("ToEDIString", internalFlags);
                            //Invoke the function of that class on the class
                            rtnVal.Append(method.Invoke(propertyValue, new object[] { seperators.Subelement }).ToString());
                        }
                        else
                        {
                            //TODO: Implement a custome ConveterType here.
                            //Location to add the TypecOnverter... allows for input of one from outside
                            rtnVal.Append(propertyInfo.EDI2String(propertyValue));
                        }
                    }
                    rtnVal.Append(seperators.Element);

                }
            }


            return rtnVal.ToString().TrimEnd(seperators.Element);
        }


        /// <summary>
        /// THis only sets the the EDIFortmat attribute.
        /// </summary>
        /// <param name="position"></param>
        /// <param name="frmt"></param>
        public void SetFormat(int position, string frmt)
        {
            //TODO: Determine how to only getproperties for the CanRead only... 
            //      otherwise the position value might be out of synce with private properties
            //PropertyInfo[] propertyInfos = GetType().GetProperties();


            int p = 0;
            foreach (PropertyInfo propertyInfo in GetType().GetProperties())
            {
                if (propertyInfo.CanRead)
                {
                    if (p == position)
                    {
                        Attribute[] attrs = Attribute.GetCustomAttributes(propertyInfo);
                        var firstOrDefault = (EDIFormat) attrs.FirstOrDefault(z => z.GetType() == typeof (EDIFormat));
                        if (firstOrDefault != null)
                            firstOrDefault.SetFormat(frmt);
                    }
                }
            }

            //var attr = TypeDescriptor.GetProperties(typeof(UserContact))["UserName"].Attributes[typeof(ReadOnlyAttribute)] as ReadOnlyAttribute;
            //attr.GetType().GetField("isReadOnly", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(attr, username_readonly);
            
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


    public static class ObjectExt
    {
        public static T Clone<T>(this T obj) where T : new()
        {
            return ObjectExtCache<T>.Clone(obj);
        }
        static class ObjectExtCache<T> where T : new()
        {
            private static readonly Func<T, T> cloner;
            static ObjectExtCache()
            {
                ParameterExpression param = Expression.Parameter(typeof(T), "in");

                var bindings = from prop in typeof(T).GetProperties()
                               where prop.CanRead && prop.CanWrite
                               let column = Attribute.GetCustomAttribute(prop, typeof(ColumnAttribute))
                                   as ColumnAttribute
                               where column == null || !column.IsPrimaryKey
                               select (MemberBinding)Expression.Bind(prop,
                                   Expression.Property(param, prop));

                cloner = Expression.Lambda<Func<T, T>>(
                    Expression.MemberInit(
                        Expression.New(typeof(T)), bindings), param).Compile();
            }
            public static T Clone(T obj)
            {
                return cloner(obj);
            }

        }
    }
}
