using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class PMSeg : SegmentBase
    {
        public PMSeg()
            : base("PM")
        { }
        public string PM01_DFINumber { get; set; }
        public string PM02_AccountNumber { get; set; }
        public YesNo PM03_ResponseCode { get; set; }
        public YesNo PM04_ResponseCode { get; set; }
        public string PM05_AcctNumQualifier { get; set; }
        [EDILength(2)]
        public string PM06_DFIQualifier { get; set; }
    }
}