namespace EDIHelpers.Dictionary.Segments
{
    public class AK3Seg : SegmentBase
    {
        public AK3Seg()
            : base("AK3")
        {

        }
        public string AK401_SegmentID { get; set; }
        public int? AK402_SegmentPosition { get; set; }
        public string AK403_LoopID { get; set; }
        public string AK404_SyntaxCode { get; set; }

    }
}