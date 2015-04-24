using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Cabelas.X856
{
    public class ST856: EDIBase
    {

        public STSeg ST { get; set; }
        public BSNSeg BSN { get; set; }

        [EDILoop("HL", 3, "S", 2, new[] {"CTT", "SE"})]
        public List<LoopShipment> Shipments { get; set; }
       
        public CTTSeg CTT { get; set; }
        
        public SESeg SE { get; set; }
    }
}