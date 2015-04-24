using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class PO1Seg: SegmentBase
    {
        public PO1Seg() : base("PO1")
        {
            
        }
        public string PO101_AssignedID { get; set; }
        public double? PO102_QuantityOrdered { get; set; }
        [EDILength(2)]
        public string PO103_UOM { get; set; }
        public double? PO104_UnitPrice { get; set; }
        [EDILength(2)]
        public string PO105_PriceBasis { get; set; }
        [EDILength(2)]
        public string PO106_ProductQual { get; set; }
        public string PO107_ProductID { get; set; }
        
        [EDILength(2)]
        public string PO108_ProductQual { get; set; }
        public string PO109_ProductID { get; set; }

        [EDILength(2)]
        public string PO110_ProductQual { get; set; }
        public string PO111_ProductID { get; set; }

        [EDILength(2)]
        public string PO112_ProductQual { get; set; }
        public string PO113_ProductID { get; set; }

        [EDILength(2)]
        public string PO114_ProductQual { get; set; }
        public string PO115_ProductID { get; set; }

        [EDILength(2)]
        public string PO116_ProductQual { get; set; }
        public string PO117_ProductID { get; set; }

        [EDILength(2)]
        public string PO118_ProductQual { get; set; }
        public string PO119_ProductID { get; set; }

        [EDILength(2)]
        public string PO120_ProductQual { get; set; }
        public string PO121_ProductID { get; set; }

        [EDILength(2)]
        public string PO122_ProductQual { get; set; }
        public string PO123_ProductID { get; set; }

        [EDILength(2)]
        public string PO124_ProductQual { get; set; }
        public string PO125_ProductID { get; set; }

    }

}