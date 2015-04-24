using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// File Information
    /// </summary>
    public class K3Seg: SegmentBase
    {
        public K3Seg() : base("K3")
        {
        }
        public string K301_FixedFormat { get; set; }
        public string K302_RecordFormat { get; set; }
        public C001_UOM K303_UOM { get; set; }
    }
}