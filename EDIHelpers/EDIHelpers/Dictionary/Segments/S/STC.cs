using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class STCSeg: SegmentBase
    {
        public STCSeg() : base("STC")
        {
        }
        public C043_ClaimStatus STC01_ClaimStatus { get; set; }
        [EDIFormat("D8")]
        public DateTime STC02_Date { get; set; }
        public string STC03_ActionCode { get; set; }
        
        public double? STC04_Amount { get; set; }
        public double? STC05_Amount { get; set; }
        [EDIFormat("D8")]
        public DateTime STC06_Date { get; set; }
        [EDILength(3)]
        public string STC07_PaymentMethod { get; set; }
        [EDIFormat("D8")]
        public DateTime STC08_Date { get; set; }
        public string STC09_CheckNumber { get; set; }
        public C043_ClaimStatus STC10_ClaimStatus { get; set; }
        public C043_ClaimStatus STC11_ClaimStatus { get; set; }
        public string STC12_Text { get; set; }
    }
}

