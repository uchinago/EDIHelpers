using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Item Physical Details
    /// </summary>
    public class PO4Seg: SegmentBase
    {
        public PO4Seg() : base("PO4")
        {
            
        }
        public int? PO401_Pack { get; set; }
        public double? PO402_Size { get; set; }
        [EDILength(2)]
        public string PO403_UOM { get; set; }
        public string PO404_PackagingCode { get; set; }
        public string PO405_WeightQual { get; set; }
        public double? PO406_WeightPack { get; set; }
        [EDILength(2)]
        public string PO407_UOM { get; set; }
        public double? PO408_VolumePack { get; set; }
        [EDILength(2)]
        public string PO409_UOM { get; set; }
        public double? PO410_Length { get; set; }
        public double? PO411_Width { get; set; }
        public double? PO412_Height { get; set; }
        [EDILength(2)]
        public string PO413_UOM { get; set; }
        public string PO414_InnerPack { get; set; }
        [EDILength(2)]
        public string PO415_PositionCode { get; set; }
        public string PO416_ID { get; set; }
        public string PO417_ID { get; set; }
        public int? PO418_Number { get; set; }

    }
}