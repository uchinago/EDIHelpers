using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class CTPSeg: SegmentBase
    {
        public CTPSeg() : base("CTP")
        {
        }
        [EDILength(2)]
        public string CTP01_ClassOfTrade { get; set; }
        [EDILength(3)]
        public string CTP02_PriceIdentifier { get; set; }
        public double? CTP03_Price { get; set; }
        public double? CTP04_Quantity { get; set; }
        public C001_UOM CTP05_UOM { get; set; }
        [EDILength(3)]
        public string CTP06_MultiplierQual { get; set; }
        public double? CTP07_Multiplier { get; set; }
        public double? CTP08_Amount { get; set; }
        [EDILength(2)]
        public string CTP09_BasisOfPrice { get; set; }
        public string CTP10_ConditionValue { get; set; }
        public int CTP11_MultiplyPriceQty { get; set; }
    }
}
