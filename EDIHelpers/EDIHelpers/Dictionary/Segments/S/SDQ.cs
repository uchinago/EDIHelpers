using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class SDQSeg : SegmentBase
    {
        public SDQSeg()
            : base("SDQ")
        {

        }
        [EDILength(2)]
        public string SDQ01_UOM { get; set; }
        public string SDQ02_IDQual { get; set; }
        public string SDQ03_ID { get; set; }
        public double? SDQ04_Quantity { get; set; }

        public string SDQ05_ID { get; set; }
        public double? SDQ06_Quantity { get; set; }
        public string SDQ07_ID { get; set; }
        public double? SDQ08_Quantity { get; set; }
        public string SDQ09_ID { get; set; }
        public double? SDQ10_Quantity { get; set; }
        public string SDQ11_ID { get; set; }
        public double? SDQ12_Quantity { get; set; }
        public string SDQ13_ID { get; set; }
        public double? SDQ14_Quantity { get; set; }
        public string SDQ15_ID { get; set; }
        public double? SDQ16_Quantity { get; set; }
        public string SDQ17_ID { get; set; }
        public double? SDQ18_Quantity { get; set; }
        public string SDQ19_ID { get; set; }
        public double? SDQ20_Quantity { get; set; }
        public string SDQ21_ID { get; set; }
        public double? SDQ22_Quantity { get; set; }

        public string SDQ23_LocationID { get; set; }

    
    }
}