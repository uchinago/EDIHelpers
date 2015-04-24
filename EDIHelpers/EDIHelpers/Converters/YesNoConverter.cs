using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using EDIHelpers.Enums;

namespace EDIHelpers.Converters
{


    public class YesNoConverter: ConverterBase
    {
        public override string FieldToString(object from)
        {
            switch ((YesNo)from)
            {
                case YesNo.No:
                    return "N";
                case YesNo.NotApplicable:
                    return "W";
                case YesNo.Unknown:
                    return "U";
                case YesNo.Yes:
                    return "Y";
                default:
                    return "";
            }
        }
        public override object StringToField(string from)
        {
            if (string.IsNullOrWhiteSpace(from.ToString()))
                return YesNo.Blank;
            switch (from.ToString().ToUpper()[0])
            {
                case 'N': return YesNo.No;
                case 'W': return YesNo.NotApplicable;
                case 'U': return YesNo.Unknown;
                case 'Y': return YesNo.Yes;
                default: return YesNo.Blank;
            }
        }
    }



    public class YesNoTypeConverter : System.ComponentModel.EnumConverter
    {
        public YesNoTypeConverter(Type type)
            : base(type)
        {

        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            switch ((YesNo)value)
            {
                case YesNo.No:
                    return "N";
                case YesNo.NotApplicable:
                    return "W";
                case YesNo.Unknown:
                    return "U";
                case YesNo.Yes:
                    return "Y";
                default:
                    return "";
            }
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
                return YesNo.Blank;
            switch (value.ToString().ToUpper()[0])
            {
                case 'N': return YesNo.No;
                case 'W': return YesNo.NotApplicable;
                case 'U': return YesNo.Unknown;
                case 'Y': return YesNo.Yes;
                default: return YesNo.Blank;
            }
        }
    }
}

