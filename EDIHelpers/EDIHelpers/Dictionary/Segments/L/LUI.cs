namespace EDIHelpers.Dictionary.Segments
{
    public class LUISeg : SegmentBase
    {
        public LUISeg()
            : base("LUI")
        {
        }

        public string LUI01_Qualifier { get; set; }
        public string LUI02_Code { get; set; }
        public string LUI03_Description { get; set; }
        public string LUI04_UsageIndicator { get; set; }
        public char LUI05_Proficiency { get; set; }
    }
}