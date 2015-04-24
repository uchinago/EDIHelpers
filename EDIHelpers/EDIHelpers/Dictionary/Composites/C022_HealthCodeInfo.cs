using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Composites
{
    public class C022_HealthCodeInfo: CompositeBase
    {
        public C022_HealthCodeInfo():base('^')
        {}

        public string C022_01_Qualifier { get; set; }
        public string C022_02_IndustryCode { get; set; }
        public string C022_03_DtpQualifier { get; set; }
        public DateTime C022_04_Date { get; set; }
        public double? C022_05_Amount { get; set; }
        public double? C022_06_Quantity { get; set; }
        public string C022_07_Version { get; set; }
        public string C022_08_IndustryCode { get; set; }
        public char C022_09_ResponseCode { get; set; }

    }
}
