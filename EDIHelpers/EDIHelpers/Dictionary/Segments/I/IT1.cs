using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class IT1Seg : SegmentBase
    {
        public IT1Seg()
            : base("IT1")
        {

        }
        public string IT101_AssignedID { get; set; }
        public double? IT102_QuantityInvoiced { get; set; }
        [EDILength(2)]
        public string IT103_UOM { get; set; }
        public double? IT104_UnitPrice { get; set; }
        [EDILength(2)]
        public string IT105_PriceBasis { get; set; }
        [EDILength(2)]
        public string IT106_ProductQual { get; set; }
        public string IT107_ProductID { get; set; }

        [EDILength(2)]
        public string IT108_ProductQual { get; set; }
        public string IT109_ProductID { get; set; }

        [EDILength(2)]
        public string IT110_ProductQual { get; set; }
        public string IT111_ProductID { get; set; }

        [EDILength(2)]
        public string IT112_ProductQual { get; set; }
        public string IT113_ProductID { get; set; }

        [EDILength(2)]
        public string IT114_ProductQual { get; set; }
        public string IT115_ProductID { get; set; }

        [EDILength(2)]
        public string IT116_ProductQual { get; set; }
        public string IT117_ProductID { get; set; }

        [EDILength(2)]
        public string IT118_ProductQual { get; set; }
        public string IT119_ProductID { get; set; }

        [EDILength(2)]
        public string IT120_ProductQual { get; set; }
        public string IT121_ProductID { get; set; }

        [EDILength(2)]
        public string IT122_ProductQual { get; set; }
        public string IT123_ProductID { get; set; }

        [EDILength(2)]
        public string IT124_ProductQual { get; set; }
        public string IT125_ProductID { get; set; }

    }
}