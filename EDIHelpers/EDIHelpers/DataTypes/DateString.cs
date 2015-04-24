using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EDIHelpers.DataTypes
{
    public class DateString
    {
        private readonly string _value;

        private string _format;

        public DateString(string value = null)
        {
            _value = value;
        }

        #region Ways to handle it as a normal string
        public static implicit operator string(DateString d)
        {
            return d.ToString();
        }


        public static implicit operator DateString(string d)
        {
            return d == null? null : new DateString(d);
        }
        #endregion


        public override string ToString()
        {
            return _value;
        }


        //TODO: Extend this to all dates but these are the most common for HIPAA
        public DateTime GetFromDate()
        {
            if (String.IsNullOrWhiteSpace(_value))
                return DateTime.MinValue;
            switch (_value.Length)
            {
                case 8: //D8
                    return DateTime.ParseExact(_value, "yyyyMMdd", CultureInfo.InvariantCulture);
                case 12: //DT
                    return DateTime.ParseExact(_value, "yyyyMMddHHmm", CultureInfo.InvariantCulture);
                case 17: //RD8
                    return DateTime.ParseExact(_value.Substring(0, 8), "yyyyMMdd", CultureInfo.InvariantCulture);
                default:
                    return DateTime.MinValue;
            }
        }

        //TODO: Extend this to all dates but these are the most common for HIPAA
        public DateTime GetThruDate()
        {
            if (String.IsNullOrWhiteSpace(_value))
                return DateTime.MinValue;
            switch (_value.Length)
            {
                case 8: //D8
                   return DateTime.ParseExact(_value, "yyyyMMdd", CultureInfo.InvariantCulture);
                case 12: //DT
                   return DateTime.ParseExact(_value, "yyyyMMddHHmm", CultureInfo.InvariantCulture);
                case 17: //RD8
                   return DateTime.ParseExact(_value.Substring(9,8), "yyyyMMdd", CultureInfo.InvariantCulture);
                default:
                    return DateTime.MinValue;
            }
            
        }
        

        public void SetFromDate(DateTime dtm)
        {
            //do something here
        }

        public void SetThruDate(DateTime dtm)
        {
            
        }

        public void SetFormat(string format)
        {
            _format = format;
        }


        
    }
}
