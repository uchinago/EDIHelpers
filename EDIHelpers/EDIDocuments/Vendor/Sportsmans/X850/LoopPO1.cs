using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Sportsmans.X850
{
    public class LoopPO1: EDIBase
    {
        public PO1Seg PO1 { get; set; }
        //public CTPSeg CTP { get; set; }
        public List<PIDSeg> PID { get; set; }
        //public List<PO4Seg> PO4 { get; set; }
        //public List<REFSeg> REF { get; set; } 

        //public List<SACSeg> SAC { get; set; }

        public List<SDQSeg> SDQ { get; set; }

        //public List<DTMSeg> DTM { get; set; }
        public List<MTXSeg> MTX { get; set; }

        public AMTSeg AMT { get; set; }
        //public List<SCHSeg> SCH { get; set; } 
    }
}