using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Cabelas.X856
{
    public class LoopOrder : EDIBase
    {
        public HLSeg HL { get; set; }
        public PRFSeg PRF { get; set; }
        public List<REFSeg> REF { get; set; } 

        /// <summary>
        /// Normally loop but they only use N1 segment
        /// Marked For
        /// Country of Origin
        /// </summary>
        public List<N1Seg> N1 { get; set; }

        [EDILoop("HL", 3, "P", 0)]
        public List<LoopPack> Packs { get; set; }

    }
}