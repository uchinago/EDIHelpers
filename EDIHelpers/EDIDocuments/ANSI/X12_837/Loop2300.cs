using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_837
{
    public class Loop2300: EDIBase
    {
        public CLMSeg CLM { get; set; }
        public List<DTPSeg> DTP { get; set; } 

        public CL1Seg CL1 { get; set; }
        public DN1Seg DN1 { get; set; }
        public List<DN2Seg> DN2 { get; set; }
        public List<PWKSeg> PWK { get; set; } 
        public CN1Seg CN1 { get; set; }
        
        //DSB
        //public DSBSeg DSB { get; set; }
        //UR

        public List<AMTSeg> AMT { get; set; } 
        public List<REFSeg> REF { get; set; } 
        //K3
        public List<K3Seg> K3 { get; set; } 
        //NTE
        public List<NTESeg> NTE { get; set; } 
        //CR1
        public CR1Seg CR1 { get; set; }
        public CR2Seg CR2 { get; set; }
        public CR3Seg CR3 { get; set; }
        public List<CR4Seg> CR4 { get; set; }
        public CR5Seg CR5 { get; set; }
        public CR6Seg CR6 { get; set; }
        public List<CR8Seg> CR8 { get; set; }
        public List<CRCSeg> CRC { get; set; } 
        public List<HISeg> HI { get; set; } 
        public List<QTYSeg> QTY { get; set; } 
        public HCPSeg HCP { get; set; }
        
        //Loop2305
        [EDILoop("CR7",0,"", 0, new[] {"NM1", "SBR", "LX" })]
        public List<Loop2305> L2305 { get; set; } 
        //Loop2310
        //TODO:  This could be a little tricky... 
        [EDILoop("NM1", 0, "", 0, new[] { "SBR", "LX" }, "SBR", "REF")]
        public List<LoopNM1Basic> L2310 { get; set; } 
        //Loop2320
        [EDILoop("SBR", 0, "", 0, "LX" )]
        public List<Loop2320> L2320 { get; set; }

        [EDILoop("LX", 0, "", 0, "CLM")]
        public List<Loop2400> L2400 { get; set; } 
    }
}
