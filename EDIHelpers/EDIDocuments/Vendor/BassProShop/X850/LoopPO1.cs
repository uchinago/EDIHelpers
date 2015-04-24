using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.BassProShop.X850
{
    public class LoopPO1: EDIBase
    {
        public PO1Seg PO1 { get; set; }
        public List<PIDSeg> PID { get; set; }
        public List<PO4Seg> PO4 { get; set; }
        public List<SACSeg> SAC { get; set; } 
    }
}