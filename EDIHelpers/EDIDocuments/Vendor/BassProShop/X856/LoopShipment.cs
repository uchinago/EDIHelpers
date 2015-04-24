using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.BassProShop.X856
{
    public class LoopShipment: EDIBase
    {
        public HLSeg HL { get; set; }
        public List<TD5Seg> TD5 { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<DTMSeg> DTM { get; set; }
        
        public List<N1Seg> N1 { get; set; }

        [EDILoop("HL", 3, "O", 0)]
        public List<LoopOrder> Orders { get; set; }
        

    }
}