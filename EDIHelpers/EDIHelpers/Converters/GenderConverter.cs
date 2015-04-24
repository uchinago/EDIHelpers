using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using EDIHelpers.Enums;

namespace EDIHelpers.Converters
{
    public class GenderConverter: ConverterBase
    {
        public override string FieldToString(object from)
        {
            return base.FieldToString(from);
        }

        public override object StringToField(string from)
        {
            if (string.IsNullOrWhiteSpace(from.ToString()))
                return Gender.Blank;
            return from.ToString().ToGender();
        }

    }


    public class GenderTypeConverter : System.ComponentModel.EnumConverter
    {
        public GenderTypeConverter()
            : base(typeof(Gender))
        {

        }

        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
        {
            return ((Gender) value).FromGender();
        }


        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType)
        {
            if (string.IsNullOrWhiteSpace(value.ToString()))
                return Gender.Blank;
            return value.ToString().ToGender();
        }
    }



}
