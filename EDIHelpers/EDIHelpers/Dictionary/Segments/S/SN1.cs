using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class SN1Seg : SegmentBase
    {
        public SN1Seg()
            : base("SN1")
        {

        }
        public string SN101_ID { get; set; }
        public double? SN102_QuantityShipped { get; set; }
        [EDILength(2)]
        public string SN103_UOM { get; set; }
        public double? SN104_QtyShippedToDate { get; set; }
        public double? SN105_QtyOrdered { get; set; }
        [EDILength(2)]
        public string SN106_UOM { get; set; }
        public string SN107_ReturnableContainerCode { get; set; }
        [EDILength(2)]
        public string SN108_LineItemStatus { get; set; }

    }
}