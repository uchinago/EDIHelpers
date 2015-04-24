using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Cabelas.X856
{
    public class LoopPack : EDIBase
    {
        public HLSeg HL { get; set; }
        public List<MANSeg> MAN { get; set; }

        [EDILoop("HL", 3, "I", 0)]
        public List<LoopItem> Items { get; set; }
    }
}