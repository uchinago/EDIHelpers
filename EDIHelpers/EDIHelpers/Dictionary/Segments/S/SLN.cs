using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class SLNSeg : SegmentBase
    {
        public SLNSeg()
            : base("SLN")
        {

        }
        public string SLN01_AssignedID { get; set; }
        public string SLN02_AssignedID { get; set; }

        public char SLN03_RelationshipCode { get; set; }
        public double? SLN04_Quantity { get; set; }
        
        public C001_UOM SLN05_UOM { get; set; }
        
        public double? SLN06_Price { get; set; }
        [EDILength(2)]
        public string SLN07_PriceBasis { get; set; }

        public char SLN08_RelationshipCode { get; set; }

        [EDILength(2)]
        public string SLN09_ProductQual { get; set; }
        public string SLN10_ProductID { get; set; }

        [EDILength(2)]
        public string SLN11_ProductQual { get; set; }
        public string SLN12_ProductID { get; set; }

        [EDILength(2)]
        public string SLN13_ProductQual { get; set; }
        public string SLN14_ProductID { get; set; }

        [EDILength(2)]
        public string SLN15_ProductQual { get; set; }
        public string SLN16_ProductID { get; set; }

        [EDILength(2)]
        public string SLN17_ProductQual { get; set; }
        public string SLN18_ProductID { get; set; }

        [EDILength(2)]
        public string SLN19_ProductQual { get; set; }
        public string SLN20_ProductID { get; set; }

        [EDILength(2)]
        public string SLN21_ProductQual { get; set; }
        public string SLN22_ProductID { get; set; }

        [EDILength(2)]
        public string SLN23_ProductQual { get; set; }
        public string SLN24_ProductID { get; set; }

        [EDILength(2)]
        public string SLN25_ProductQual { get; set; }
        public string SLN26_ProductID { get; set; }

        [EDILength(2)]
        public string SLN27_ProductQual { get; set; }
        public string SLN28_ProductID { get; set; }

    }
}