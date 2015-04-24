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
    public class Loop2400:EDIBase
    {
        public LXSeg LX { get; set; }
        public SV1Seg SV1 { get; set; }
        public SV2Seg SV2 { get; set; }
        public SV3Seg SV3 { get; set; }
        public TOOSeg TOO { get; set; }
        public SV4Seg SV4 { get; set; }
        public SV5Seg SV5 { get; set; }
        public SV6Seg SV6 { get; set; }
        public SV7Seg SV7 { get; set; }
        public List<HISeg> HI { get; set; } 
        public List<PWKSeg> PWK { get; set; } 
        public CR1Seg CR1 { get; set; }
        public List<CR2Seg> CR2 { get; set; }
        public CR3Seg CR3 { get; set; }
        public List<CR4Seg> CR4 { get; set; }
        public CR5Seg CR5 { get; set; }
        public List<CRCSeg> CRC { get; set; } 
        public List<DTPSeg> DTP { get; set; } 
        public List<QTYSeg> QTY { get; set; } 
        
        public List<MEASeg> MEA { get; set; } 
        //CN1
        public List<REFSeg> REF { get; set; } 
        public List<AMTSeg> AMT { get; set; } 
        //K3
        public List<NTESeg> NTE { get; set; } 
        //PS1
        //IMM
        public HSDSeg HSD { get; set; }
        public HCPSeg HCP { get; set; }

        //TODO: Allow the loop to search multiple possible endings...
        [EDILoop("LIN", 0, "", 0, new string[] { "NM1", "SVD", "LQ" } )]

        public List<Loop2410> L2410 { get; set; }
        //TODO: Allow the loop to search multiple possible endings...
        [EDILoop("NM1", 0, "", 0, new string[] { "SVD", "LQ" })]
        public List<LoopNM1Basic> L2420 { get; set; }
        
        [EDILoop("SVD", 0, "", 0, "LQ")]
        public List<Loop2430> L2430 { get; set; }
        [EDILoop("LQ", 0)]
        public List<Loop2440> L2440 { get; set; } 

    }
}
