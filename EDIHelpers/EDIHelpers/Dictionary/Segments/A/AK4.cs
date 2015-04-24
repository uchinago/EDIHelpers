using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class AK4Seg : SegmentBase
    {
        public AK4Seg()
            : base("AK4")
        {

        }
        public C030_Position AK401_AckCode { get; set; }
        public int? AK402_ReferenceNumber { get; set; }
        public string AK403_SyntaxCode { get; set; }
        public string AK404_Data { get; set; }

    }
}