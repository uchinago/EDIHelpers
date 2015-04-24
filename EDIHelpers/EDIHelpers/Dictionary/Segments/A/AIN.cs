using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class AINSeg : SegmentBase
    {
        public AINSeg()
            : base("AIN")
        {
        }
        [EDILength(2)]
        public string AIN01_IncomeType { get; set; }
        public char AIN02_Frequency { get; set; }
        public double? AIN03_Amount { get; set; }
        public double? AIN04_Quantity { get; set; }
        public YesNo AIN05_ResponseCode { get; set; }
        public string AIN06_ReferenceID { get; set; }
        public string AIN07_AmtQualifier { get; set; }
        public char AIN08_TaxTreatment { get; set; }
        public double? AIN09_EarningsRate { get; set; }
        [EDILength(2)]
        public string AIN10_UOM { get; set; }
        public double? AIN11_Quantity { get; set; }
        public string AIN12_Code { get; set; }
        public string AIN13_Description { get; set; }
    }
}