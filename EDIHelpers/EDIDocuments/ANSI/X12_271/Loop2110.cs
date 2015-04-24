using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_271
{
    public class Loop2110: EDIBase
    {
        public Loop2110()
        {
          
        }
        public EBSeg EB { get; set; }
        public List<HSDSeg> HSD { get; set; } 
        public List<REFSeg> REF { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<AAASeg> AAA { get; set; } 
        public VEHSeg VEH { get; set; }
        //PID//not implementing
        //PDR  //not implementing
        //PDP  //not implementing
        public LINSeg LIN { get; set; }
        //EM //not implementing
        //SD1 //not implementing
        //PKD //not implementing
        public List<MSGSeg> MSG { get; set; }
        [EDILoop("III", 0, "", 0, "LS")]
        public List<Loop2115> L2115 { get; set; }
        [EDILoop("LS", 0, "", 0)]
        public List<LoopLS> LS { get; set; } 

     
    }
}
