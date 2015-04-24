using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class CTTSeg: SegmentBase
    {
        public CTTSeg() : base("CTT")
        {
            
        }

        public int? CTT01_NumberOfLines { get; set; }
        public double? CTT02_HashTotal { get; set; }
        public double? CTT03_Weight { get; set; }
        [EDILength(2)]
        public string CTT04_UOM { get; set; }
        public double? CTT05_Volume { get; set; }
        [EDILength(2)]
        public string CTT06_UOM { get; set; }
        public string CTT07_Description { get; set; }

    }
}