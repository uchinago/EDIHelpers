namespace EDIHelpers.Dictionary.Segments
{
    public class GESeg : SegmentBase
    {
        public GESeg()
            : base("GE")
        {
        }

        public int GE01_TransactionCount { get; set; }
        public string GE02_ControlNumber { get; set; }

    }
}