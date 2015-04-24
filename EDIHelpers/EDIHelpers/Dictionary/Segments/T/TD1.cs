using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class TD1Seg : SegmentBase
    {
        public TD1Seg()
            : base("TD1")
        {

        }
        public string TD101_PackagingCode { get; set; }
        public int? TD102_LadingQuantity { get; set; }
        public char TD103_CommodityCodeQual { get; set; }
        public string TD104_CommodityCode { get; set; }
        public string TD105_LadingDescription { get; set; }
        public string TD106_WeightQual { get; set; }
        public double? TD107_Weight { get; set; }
        [EDILength(2)]
        public string TD108_UOM { get; set; }
        public double? TD109_Volume { get; set; }
        [EDILength(2)]
        public string TD110_UOM { get; set; }

    }
}