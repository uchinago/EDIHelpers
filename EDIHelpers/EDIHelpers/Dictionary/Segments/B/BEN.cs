using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class BENSeg : SegmentBase
    {
        public BENSeg()
            : base("BEN")
        {
        }
        public char BEN01_PrimaryContingent { get; set; }
        public double? BEN02_Percent { get; set; }
        [EDILength(2)]
        public string BEN03_RelationCode { get; set; }
        public YesNo BEN04_ResponseCode { get; set; }
        public YesNo BEN05_ResponseCode { get; set; }
        [EDILength(2)]
        public string BEN06_AccountType { get; set; }
    }
}