using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Cabelas.X856
{
    public class LoopName: EDIBase
    {
        public N1Seg N1 { get; set; }
        public N2Seg N2 { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
        public PERSeg PER { get; set; }

    }
}