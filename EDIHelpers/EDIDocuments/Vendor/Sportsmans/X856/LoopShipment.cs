using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Sportsmans.X856
{
    public class LoopShipment: EDIBase
    {
        public HLSeg HL { get; set; }
        public TD1Seg TD1 { get; set; }
        public TD5Seg TD5 { get; set; }
        //public TD3Seg TD3 { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<DTMSeg> DTM { get; set; }

        public FOBSeg FOB { get; set; }

        /// <summary>
        /// ShipTo
        /// ShipFrom
        /// </summary>
        [EDILoop("N1", 0, "", 1, "HL")]
        public List<LoopName> ShippingAddresses { get; set; }

        [EDILoop("HL", 3, "O", 0)]
        public List<LoopOrder> Orders { get; set; }
    }
}