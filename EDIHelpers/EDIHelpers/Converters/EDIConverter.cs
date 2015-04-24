using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.DataTypes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;
using EDIHelpers.Converters;
using EDIHelpers.Helpers;

namespace EDIHelpers.Converters
{
    public static class EDIConverter
    {
   
        /// <summary>
        /// THis is where we need to replace with common ConverterBase action and 
        /// types.
        /// </summary>
        /// <param name="original"></param>
        /// <param name="fieldType"></param>
        /// <param name="attributes"></param>
        /// <returns></returns>
        public static object FromEDIString(this string original, Type fieldType, Attribute[] attributes)
        {
            //TODO: Make typeconverter for enums so we only have to make a single call
            if (fieldType == typeof (YesNo))
            {
                return original.ToYesNo();
            }
            else if (fieldType == typeof (DateString))
            {
                return new DateString(original);
            }
            else
            {

                switch (Type.GetTypeCode(fieldType.GetUnderlyingType()))
                {

                    case TypeCode.DateTime:
                        //process to string using format
                        string f = "D8";
                        if (attributes.Any(z => z.GetType() == typeof(EDIFormat)))
                        {
                            f =
                                ((EDIFormat)attributes.FirstOrDefault(z => z.GetType() == typeof(EDIFormat)))
                                    .GetFormat();
                        }
                        if (f.Equals("TM"))
                            return original.TimeConverter();
                        else
                        {
                            //TODO:  How to handle the RD8 scenario
                            return DateTime.ParseExact(original.Trim(),
                                                       f.DTMFormat().Substring(0, original.Trim().Length),
                                                       CultureInfo.InvariantCulture);
                        }

                    case TypeCode.Double:
                        return Convert.ToDouble(original);
                    case TypeCode.Int16:
                        return Convert.ToInt16(original);
                    case TypeCode.Int32:
                        return Convert.ToInt32(original);
                    case TypeCode.Boolean:
                        return original.Equals("1");
                    case TypeCode.Char:
                        if (String.IsNullOrWhiteSpace(original))
                            return 0;
                        return original[0];
                    default:
                        return original;
                }
            }
        }


        /// <summary>
        /// Purely for Data conversion of object value to string... 
        /// No delimiters at all for this...
        /// </summary>
        /// <param name="propertyInfo"></param>
        /// <param name="value"></param>
        /// <param name="seperators"></param>
        /// <returns></returns>
        public static string EDI2String(this PropertyInfo propertyInfo, object value)
        {
            StringBuilder rtnVal = new StringBuilder();
            Attribute[] attrs = Attribute.GetCustomAttributes(propertyInfo);
            var fieldType = propertyInfo.PropertyType;
            // Try to assign a default Converter
            if (value != null)
            {
                if (fieldType == typeof (YesNo))
                {
                    return ((YesNo) value).FromYesNo();
                }
                else if (fieldType == typeof (DateString))
                {
                    return value.ToString();
                }
                else
                {
                    switch (Type.GetTypeCode(fieldType.GetUnderlyingType()))
                    {
                        case TypeCode.DateTime:
                            //process to string using format
                            if (!(((DateTime) (value)) == DateTime.MinValue))
                            {
                                string f = "D8";
                                if (attrs.Any(x => x.GetType() == typeof (EDIFormat)))
                                {
                                    f =
                                        ((EDIFormat)
                                         attrs.FirstOrDefault(x => x.GetType() == typeof (EDIFormat)))
                                            .GetFormat();
                                }
                                rtnVal.Append(((DateTime) value).ToEDIDTP(f));
                            }
                            break;
                        case TypeCode.Double:
                            if ((value != null))
                            {
                                if (((double) value).Equals(0.0))
                                    rtnVal.Append("0");
                                else
                                {
                                    rtnVal.Append(
                                        ((double)value).ToString("#.##"));
                                }
                            }
                            break;
                        case TypeCode.Boolean:
                            rtnVal.Append((((bool) value) ? "1" : "0"));
                            break;
                        case TypeCode.Char:
                            if (((char) value) != 0)
                            {
                                rtnVal.Append(value.SafeString());
                            }
                            break;
                        default:
                            if (attrs.Any(x => x.GetType() == typeof (EDIFixedLen)))
                            {
                                var l =
                                    (EDIFixedLen)
                                    attrs.FirstOrDefault(x => x.GetType() == typeof (EDIFixedLen));
                                rtnVal.Append(value.SafeString()
                                                   .PadRight(l.GetFormat(), l.GetFiller()));
                            }
                            else if (attrs.Any(x => x.GetType() == typeof (EDILength)))
                            {
                                //TODO:  Add required attribute...
                                if (!String.IsNullOrWhiteSpace(value.SafeString()))
                                {
                                    var l =
                                        (EDILength)
                                        attrs.FirstOrDefault(x => x.GetType() == typeof (EDILength));
                                    rtnVal.Append(value.SafeString()
                                                       .PadRight(l.GetFormat(), l.GetFiller()));
                                }
                            }
                            else
                            {
                                rtnVal.Append(value.SafeString().TrimEnd());
                            }
                            break;
                    }
                }
            }
            return rtnVal.ToString();
        }


        private static string SafeString(this object original)
        {
            if (original == null)
                return "";
            return original.ToString();
        }
        


        //Would love to have this as a single converter someplace instead of in 2 locations

        ////TODO: What seperators do we really need to know about... just the subelement?  This is one field at a time...
        //public static string ToEDIField(this PropertyInfo propertyInfo, EDIDelim seperators)
        //{
            /*  if (fieldType == typeof(Int16))
                //return new Int16Converter();
            else if (fieldType == typeof(Int32))
                //return new Int32Converter();
            else if (fieldType == typeof(Int64))
                //return new Int64Converter();
            else if (fieldType == typeof(SByte))
                return new ConvertHelpers.SByteConverter();
            else if (fieldType == typeof(UInt16))
                return new ConvertHelpers.UInt16Converter();
            else if (fieldType == typeof(UInt32))
                return new ConvertHelpers.UInt32Converter();
            else if (fieldType == typeof(UInt64))
                return new UInt64Converter();
            else if (fieldType == typeof(Byte))
                return new ByteConverter();
            else if (fieldType == typeof(Decimal))
                return new DecimalConverter();
            else if (fieldType == typeof(Double))
                return new DoubleConverter();
            else if (fieldType == typeof(Single))
                return new SingleConverter();
            else if (fieldType == typeof(DateTime))
                return new DateTimeConverter();
            else if (fieldType == typeof(Boolean))
                return new BooleanConverter();
            return "":
             * */
              
        //    var pType = propertyInfo.PropertyType;
        //    object propertyValue = propertyInfo.GetValue(this, null);
        //            if (propertyValue != null)
        //            {
        //                    #region DataType converters

        //                        //TODO: Make this a standard data type converter that all can call
        //                        if (pType == typeof (YesNo))
        //                        {
        //                            switch (((YesNo) propertyValue))
        //                            {
        //                                case YesNo.No:
        //                                    rtnVal.Append(seperators.Element + "N");
        //                                    break;
        //                                case YesNo.Yes:
        //                                    rtnVal.Append(seperators.Element + "Y");
        //                                    break;
        //                                case YesNo.NotApplicable:
        //                                    rtnVal.Append(seperators.Element + "W");
        //                                    break;
        //                                default:
        //                                    rtnVal.Append(seperators.Element);
        //                                    break;
        //                            }
        //                        }
        //                        else
        //                        {
        //                            switch (Type.GetTypeCode(pType.GetUnderlyingType()))
        //                            {

        //                                case TypeCode.DateTime:
        //                                    //process to string using format
        //                                    rtnVal.Append(seperators.Element);
        //                                    if (!(((DateTime) (propertyInfo.GetValue(this, null))) == DateTime.MinValue))
        //                                    {
        //                                        string f = "D8";
        //                                        if (attrs.Any(x => x.GetType() == typeof (EDIFormat)))
        //                                        {
        //                                            f =
        //                                                ((EDIFormat)
        //                                                 attrs.FirstOrDefault(x => x.GetType() == typeof (EDIFormat)))
        //                                                    .GetFormat();
        //                                        }
        //                                        rtnVal.Append(((DateTime) (propertyInfo.GetValue(this, null))).ToEDIDTP(
        //                                                          f));
        //                                    }
        //                                    break;
        //                                case TypeCode.Double:
        //                                    rtnVal.Append(seperators.Element);

        //                                    if ((propertyInfo.GetValue(this, null) != null) && (((double)propertyInfo.GetValue(this, null)) >= 0))
        //                                    {
        //                                        rtnVal.Append(
        //                                            ((double) propertyInfo.GetValue(this, null)).ToString("#.##"));
        //                                    }
        //                                    break;
        //                                case TypeCode.Boolean:
        //                                    rtnVal.Append(seperators.Element +
        //                                                  (((bool) propertyInfo.GetValue(this, null)) ? "1" : "0"));
        //                                    break;
        //                                case TypeCode.Char:
        //                                    rtnVal.Append(seperators.Element);
        //                                    if (((char)propertyValue) != 0)
        //                                    {
        //                                        rtnVal.Append(_safeString(propertyValue));
        //                                    }
        //                                    break;
        //                                default:
        //                                    rtnVal.Append(seperators.Element);
        //                                    object pv = propertyInfo.GetValue(this, null);
        //                                    if (attrs.Any(x => x.GetType() == typeof (EDIFixedLen)))
        //                                    {
        //                                        var l =
        //                                                (EDIFixedLen)
        //                                                attrs.FirstOrDefault(x => x.GetType() == typeof(EDIFixedLen));
        //                                        rtnVal.Append(_safeString(pv)
        //                                                          .PadRight(l.GetFormat(), l.GetFiller()));
        //                                    }
        //                                    else if (attrs.Any(x => x.GetType() == typeof (EDILength)))
        //                                        {
        //                                            var l =
        //                                                (EDILength)
        //                                                attrs.FirstOrDefault(x => x.GetType() == typeof (EDILength));
        //                                            rtnVal.Append(_safeString(pv)
        //                                                              .PadRight(l.GetFormat(), l.GetFiller()));
        //                                        }
        //                                        else
        //                                        {
        //                                            rtnVal.Append(_safeString(pv).TrimEnd());
        //                                        }
        //                                    break;
        //                            }


        //                        }

        //                        #endregion
        //                }
        //            }
        //            else
        //            {
        //                rtnVal.Append(seperators.Element);
        //            }

        //        }



        //    return null;
        //}






            ////TODO: Make this a standard data type converter that all can call
            //                    if (pType == typeof (YesNo))
            //                    {
            //                        switch (((YesNo) propertyInfo.GetValue(this, null)))
            //                        {
            //                            case YesNo.No:
            //                                rtnVal.Append(seperators.Element + "N");
            //                                break;
            //                            case YesNo.Yes:
            //                                rtnVal.Append(seperators.Element + "Y");
            //                                break;
            //                            case YesNo.NotApplicable:
            //                                rtnVal.Append(seperators.Element + "W");
            //                                break;
            //                            default:
            //                                rtnVal.Append(seperators.Element);
            //                                break;
            //                        }
            //                    }
            //                    else
            //                    {
            //                        switch (Type.GetTypeCode(pType.GetUnderlyingType()))
            //                        {

            //                            case TypeCode.DateTime:
            //                                //process to string using format
            //                                rtnVal.Append(seperators.Element);
            //                                if (!(((DateTime) (propertyInfo.GetValue(this, null))) == DateTime.MinValue))
            //                                {
            //                                    string f = "D8";
            //                                    if (attrs.Any(x => x.GetType() == typeof (EDIFormat)))
            //                                    {
            //                                        f =
            //                                            ((EDIFormat)
            //                                             attrs.FirstOrDefault(x => x.GetType() == typeof (EDIFormat)))
            //                                                .GetFormat();
            //                                    }
            //                                    rtnVal.Append(((DateTime) (propertyInfo.GetValue(this, null))).ToEDIDTP(
            //                                                      f));
            //                                }
            //                                break;
            //                            case TypeCode.Double:
            //                                rtnVal.Append(seperators.Element);

            //                                if ((propertyInfo.GetValue(this, null) != null) && (((double)propertyInfo.GetValue(this, null)) >= 0))
            //                                {
            //                                    rtnVal.Append(
            //                                        ((double) propertyInfo.GetValue(this, null)).ToString("#.##"));
            //                                }
            //                                break;
            //                            case TypeCode.Boolean:
            //                                rtnVal.Append(seperators.Element +
            //                                              (((bool) propertyInfo.GetValue(this, null)) ? "1" : "0"));
            //                                break;
            //                            case TypeCode.Char:
            //                                rtnVal.Append(seperators.Element);
            //                                if (((char)propertyValue) != 0)
            //                                {
            //                                    rtnVal.Append(_safeString(propertyValue));
            //                                }
            //                                break;
            //                            default:
            //                                rtnVal.Append(seperators.Element);
            //                                object pv = propertyInfo.GetValue(this, null);
            //                                if (attrs.Any(x => x.GetType() == typeof (EDIFixedLen)))
            //                                {
            //                                    var l =
            //                                            (EDIFixedLen)
            //                                            attrs.FirstOrDefault(x => x.GetType() == typeof(EDIFixedLen));
            //                                    rtnVal.Append(_safeString(pv)
            //                                                      .PadRight(l.GetFormat(), l.GetFiller()));
            //                                }
            //                                else if (attrs.Any(x => x.GetType() == typeof (EDILength)))
            //                                    {
            //                                        var l =
            //                                            (EDILength)
            //                                            attrs.FirstOrDefault(x => x.GetType() == typeof (EDILength));
            //                                        rtnVal.Append(_safeString(pv)
            //                                                          .PadRight(l.GetFormat(), l.GetFiller()));
            //                                    }
            //                                    else
            //                                    {
            //                                        rtnVal.Append(_safeString(pv).TrimEnd());
            //                                    }
            //                                break;
            //                        }


            //                    }




    }
}
