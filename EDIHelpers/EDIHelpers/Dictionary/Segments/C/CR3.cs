using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class CR3Seg : SegmentBase
    {
        public CR3Seg()
            : base("CR3")
        {
        }
        public char CR301_CertificationType { get; set; }
        [EDILength(2)]
        public string CR302_UOM { get; set; }
        public double? CR303_Quantity { get; set; }
        public char CR304_InsulinCode { get; set; }
        public string CR305_Description { get; set; }
    }
}