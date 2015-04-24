using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class DSBSeg : SegmentBase
    {
        public DSBSeg()
            : base("DSB")
        {
        }

        public char DSB01_DisabilityType { get; set; }
        public double? DSB02_Quantity { get; set; }
        public string DSB03_Occupation { get; set; }
        public char DSB04_WorkIntensity { get; set; }
        public string DSB05_ProductOption { get; set; }
        public double? DSB06_Amount { get; set; }
        [EDILength(2)]
        public string DSB07_Qualifier { get; set; }
        public string DSB08_MedicalCode { get; set; }


    }
}