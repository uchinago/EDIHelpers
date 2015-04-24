namespace EDIHelpers.Dictionary.Segments
{
    public class HLHSeg : SegmentBase
    {
        public HLHSeg()
            : base("HLH")
        {
        }
        public char HLH01_HealthRelated { get; set; }
        public double? HLH02_Height { get; set; }
        public double? HLH03_Weight { get; set; }
        public double? HLH04_Weight { get; set; }
        public string HLH05_Description { get; set; }
        public char HLH06_CurrentHealthCond { get; set; }
        public string HLH07_Description { get; set; }
    }
}