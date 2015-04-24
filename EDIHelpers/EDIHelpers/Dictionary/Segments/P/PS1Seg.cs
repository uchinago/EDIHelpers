using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class PS1Seg: SegmentBase
    {
        public PS1Seg() : base("PS1")
        {}

        public string PS101_ReferenceID { get; set; }

        public double? PS102_Amount { get; set; }
        [EDILength(2)]
        public string PS103_State { get; set; }
    }
}