using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class TXISeg : SegmentBase
    {
        public TXISeg()
            : base("TXI")
        {

        }
        [EDILength(2)]
        public string TXI01_TaxType { get; set; }
        public double? TXI02_Amount { get; set; }
        public double? TXI03_Percent { get; set; }
        [EDILength(2)]
        public string TXI04_TaxJurisdictionQual { get; set; }
        public string TXI05_TaxJurisdiction { get; set; }
        public char TXI06_TaxExemptCode { get; set; }
        public char TXI07_RelationshipCode { get; set; }
        public double? TXI08_PercentBasis { get; set; }
        public string TXI09_TaxID { get; set; }
        public string TXI10_AssignedID { get; set; }
    }
}