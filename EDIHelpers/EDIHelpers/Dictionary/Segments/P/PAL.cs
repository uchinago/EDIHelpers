using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class PALSeg : SegmentBase
    {
        public PALSeg()
            : base("PAL")
        {

        }
        public string PAL01_PalletType { get; set; }
        public int? PAL02_PalletTiers { get; set; }
        public int? PAL03_PalletBlocks { get; set; }
        public int? PAL04_Pack { get; set; }
        public double? PAL05_Weight { get; set; }
        [EDILength(2)]
        public string PAL06_UOM { get; set; }
        public double? PAL07_Length { get; set; }
        public double? PAL08_Width { get; set; }
        public double? PAL09_Height { get; set; }
        [EDILength(2)]
        public string PAL10_UOM { get; set; }
        public double? PAL11_WeightPerPack { get; set; }
        [EDILength(2)]
        public string PAL12_UOM { get; set; }
        public double? PAL13_VolumePerPack { get; set; }
        [EDILength(2)]
        public string PAL14_UOM { get; set; }
        public char PAL15_PalletExchangeCode { get; set; }
        public int? PAL16_InnerPack { get; set; }
        public char PAL17_PalletStructure { get; set; }
    }
}