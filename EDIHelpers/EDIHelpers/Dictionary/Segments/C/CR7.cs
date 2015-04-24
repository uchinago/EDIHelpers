using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Home Health Treatment Plan Certification
    /// </summary>
    public class CR7Seg:SegmentBase
    {
        public CR7Seg() : base("CR7")
        {
        }
        [EDILength(2)]
        public string CR701_DisciplineType { get; set; }
        public int CR702_Number { get; set; }
        public int CR703_Number { get; set; }

    }
}