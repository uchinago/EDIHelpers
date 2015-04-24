using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_277
{
    public class Loop2000: EDIBase
    {
        public Loop2000()
        {

        }
        public HLSeg HL { get; set; }
        public SBRSeg SBR { get; set; }
        public PATSeg PAT { get; set; }

        public DMGSeg DMG { get; set; }
        [EDILoop("NM1", 1, "", 0, "TRN")]
        public List<Loop2100> L2100 { get; set; }
        [EDILoop("TRN",0)]
        public List<Loop2200> L2200 { get; set; } 
    }
}
