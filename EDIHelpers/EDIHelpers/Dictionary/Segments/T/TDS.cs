namespace EDIHelpers.Dictionary.Segments
{
    public class TDSSeg: SegmentBase
    {
        public TDSSeg() : base("TDS")
        {
            
        }
        public double? TS301_Amount { get; set; }
        public double? TS302_Amount { get; set; }
        public double? TS303_Amount { get; set; }
        public double? TS304_Amount { get; set; }
    }
}