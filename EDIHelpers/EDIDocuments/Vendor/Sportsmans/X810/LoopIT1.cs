using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Sportsmans.X810
{
    public class LoopIT1: EDIBase
    {
        public IT1Seg IT1 { get; set; }
        public List<PIDSeg> PID { get; set; }

        //public List<SACSeg> SAC { get; set; } 
        //public PO4Seg PO4 { get; set; }
    }
}