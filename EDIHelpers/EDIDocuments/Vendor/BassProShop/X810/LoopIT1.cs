using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.BassProShop.X810
{
    public class LoopIT1: EDIBase
    {
        public IT1Seg IT1 { get; set; }
        public PO4Seg PO4 { get; set; }
    }
}