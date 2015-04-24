using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_278
{
    public class HL278: EDIBase
    {
        public HL278()
        {

        }
        public HLSeg HL { get; set; }
        public List<TRNSeg> TRN { get; set; }
        public List<AAASeg> AAA { get; set; }
        public UMSeg UM { get; set; }

        public HCRSeg HCR { get; set; }

        public List<REFSeg> REF { get; set; }
        public List<DTPSeg> DTP { get; set; }

        public HISeg HI { get; set; }

        public SV1Seg SV1 { get; set; }
        public SV2Seg SV2 { get; set; }
        public SV3Seg SV3 { get; set; }

        public List<TOOSeg> TOO { get; set; } 

        public List< DN2Seg> DN2 { get; set; }

        public HSDSeg HSD { get; set; }


        public List<CRCSeg> CRC { get; set; }
        public CL1Seg CL1 { get; set; }

        public CR1Seg CR1 { get; set; }
        public CR2Seg CR2 { get; set; }
        public CR4Seg CR4 { get; set; }
        public CR5Seg CR5 { get; set; }
        public CR6Seg CR6 { get; set; }
        public CR7Seg CR7 { get; set; }
        public CR8Seg CR8 { get; set; }

        public List<PWKSeg> PWK { get; set; }

        public MSGSeg MSG { get; set; }

        [EDILoop("NM1", 0)]
        public List<LoopName278> L2100 { get; set; }

    }
}
