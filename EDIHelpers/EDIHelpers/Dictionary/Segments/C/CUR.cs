using System;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class CURSeg : SegmentBase
    {
        public CURSeg()
            : base("CUR")
        {

        }
        public string CUR01_EntityID { get; set; }
        [EDILength(3)]
        public string CUR02_CurrencyCode { get; set; }
        public double? CUR03_ExchangeRate { get; set; }
        public string CUR04_EntityID { get; set; }
        [EDILength(3)]
        public string CUR05_CurrencyCode { get; set; }
        [EDILength(3)]
        public string CUR06_MarketCode { get; set; }
        [EDILength(3)]
        public string CUR07_DateQualifier { get; set; }
        public DateTime CUR08_Date { get; set; }
        public string CUR09_Time { get; set; }

        [EDILength(3)]
        public string CUR10_DateQualifier { get; set; }
        public DateTime CUR11_Date { get; set; }
        public string CUR12_Time { get; set; }

        [EDILength(3)]
        public string CUR13_DateQualifier { get; set; }
        public DateTime CUR14_Date { get; set; }
        public string CUR15_Time { get; set; }

        [EDILength(3)]
        public string CUR16_DateQualifier { get; set; }
        public DateTime CUR17_Date { get; set; }
        public string CUR18_Time { get; set; }


        [EDILength(3)]
        public string CUR19_DateQualifier { get; set; }
        public DateTime CUR20_Date { get; set; }
        public string CUR21_Time { get; set; }
    }
}