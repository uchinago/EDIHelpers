using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.BassProShop.X856
{
    public class LoopItem : EDIBase
    {
        public HLSeg HL { get; set; }
        public LINSeg LIN { get; set; }
        public SN1Seg SN1 { get; set; }
    }
}