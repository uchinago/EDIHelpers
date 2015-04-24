using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIDocuments.ANSI.X12_837;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X837
{
    public class Loop2400Line: EDIBase
    {
        public LXSeg LX { get; set; }
        //837P
        public SV1Seg SV1 { get; set; }
        //837I
        public SV2Seg SV2 { get; set; }
        
        //837D
        public SV3Seg SV3 { get; set; }
        //837D
        public TOOSeg TOO { get; set; }
        
        //public SV4Seg SV4 { get; set; }
        //837P
        public SV5Seg SV5 { get; set; }
        //public SV6Seg SV6 { get; set; }
        //public SV7Seg SV7 { get; set; }
        //public List<HISeg> HI { get; set; }
        public List<PWKSeg> PWK { get; set; }
        //837P 
        public CR1Seg CR1 { get; set; }
        //public List<CR2Seg> CR2 { get; set; }

        //837P
        public CR3Seg CR3 { get; set; }
        //public List<CR4Seg> CR4 { get; set; }
        //public CR5Seg CR5 { get; set; }
        //837P
        public List<CRCSeg> CRC { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<QTYSeg> QTY { get; set; }

        public List<MEASeg> MEA { get; set; }
        //CN1
        public CN1Seg CN1 { get; set; }

        public List<REFSeg> REF { get; set; }
        public List<AMTSeg> AMT { get; set; }
        public List<K3Seg> K3 { get; set; } 

        public List<NTESeg> NTE { get; set; }
        public PS1Seg PS1 { get; set; }
        //IMM
        //public HSDSeg HSD { get; set; }
        public HCPSeg HCP { get; set; }

        ////TODO: Allow the loop to search multiple possible endings...
        [EDILoop("LIN", 0, "", 0, new string[] { "NM1", "SVD", "LQ" })]
        public List<Loop2410> DrugInformation { get; set; }
        
        ////TODO: Allow the loop to search multiple possible endings...
        /// <summary>
        /// Use LINQ to get the value you are looking for.  Keeps it simpler in code and what not.
        /// </summary>
        [EDILoop("NM1", 0, "", 0, new string[] { "SVD", "LQ" })]
        public List<LoopNM1Basic> ProviderLoops { get; set; }

        [EDILoop("SVD", 0, "", 0, "LQ")]
        public List<Loop2430> L2430Adjudication { get; set; }
        [EDILoop("LQ", 0)]
        public List<Loop2440> L2440FormID { get; set; } 
    }
}