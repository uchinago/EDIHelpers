using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.BassProShop.X856
{
    public class LoopOrder : EDIBase
    {
        public HLSeg HL { get; set; }
        public PRFSeg PRF { get; set; }
        public List<TD1Seg> TD1 { get; set; }
        //This is loop but the guides say only using N1 segment
        public List<N1Seg> N1 { get; set; }

        [EDILoop("HL", 3, "P", 0)]
        public List<LoopPack> Packs { get; set; }

    }
}