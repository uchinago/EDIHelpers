using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class FCSeg : SegmentBase
    {
        public FCSeg()
            : base("FC")
        {

        }
        [EDILength(2)]
        public string FC01_ContributionCode { get; set; }
        public double? FC02_Percent { get; set; }
        public double? FC03_Amount { get; set; }
        public int? FC04_Number { get; set; }
        public YesNo FC05_ResponseCode { get; set; }
        
    }
}