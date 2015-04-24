using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class INVSeg : SegmentBase
    {
        public INVSeg()
            : base("INV")
        {

        }
        public string INV01_Description { get; set; }
        public double? INV02_Percent { get; set; }
        public double? INV03_Amount { get; set; }
        public double? INV04_Quantity { get; set; }
        [EDILength(2)]
        public string INV05_State { get; set; }
        public string INV06_Description { get; set; }
        public double? INV07_Amount { get; set; }
    }
}