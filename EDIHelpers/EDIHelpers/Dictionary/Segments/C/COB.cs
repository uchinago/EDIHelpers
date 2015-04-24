namespace EDIHelpers.Dictionary.Segments
{
    public class COBSeg : SegmentBase
    {
        public COBSeg()
            : base("COB")
        {
        }
        public char COB01_PayerSequence { get; set; }
        public string COB02_ReferenceID { get; set; }
        public char COB03_COB { get; set; }
        public string COB04_ServiceType { get; set; }

    }
}