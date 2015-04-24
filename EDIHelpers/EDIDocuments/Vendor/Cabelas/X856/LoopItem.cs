using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Cabelas.X856
{
    public class LoopItem : EDIBase
    {
        public HLSeg HL { get; set; }
        public LINSeg LIN { get; set; }
        public SN1Seg SN1 { get; set; }
        public PO4Seg PO4 { get; set; }
        public List<PIDSeg> PID { get; set; }
        public TD4Seg TD4 { get; set; }
    }
}