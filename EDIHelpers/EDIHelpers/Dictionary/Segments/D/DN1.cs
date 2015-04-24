using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class DN1Seg : SegmentBase
    {
        public DN1Seg()
            : base("DN1")
        {
        }
        public double? DN101_Quantity { get; set; }
        public double? DN102_Quantity { get; set; }
        public YesNo DN103_ResponseCode { get; set; }
        public string DN104_Description { get; set; }
    }
}