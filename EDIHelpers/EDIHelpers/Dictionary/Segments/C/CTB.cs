using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class CTBSeg : SegmentBase
    {
        public CTBSeg()
            : base("CTB")
        {

        }
        [EDILength(2)]
        public string CTB01_Qualifier { get; set; }
        public string CTB02_Description { get; set; }
        [EDILength(2)]
        public string CTB03_QuantityQual { get; set; }
        public double? CTB04_Quantity { get; set; }
        public string CTB05_AmountQual { get; set; }
        public double? CTB06_Amount { get; set; }

    }
}