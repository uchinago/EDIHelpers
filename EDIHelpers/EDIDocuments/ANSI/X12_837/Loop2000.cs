using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_837
{
    public class Loop2000: EDIBase
    {
        public Loop2000()
        {

        }
        public HLSeg HL { get; set; }
        public PRVSeg PRV { get; set; }
        public SBRSeg SBR { get; set; }
        public PATSeg PAT { get; set; }
        public List<DTPSeg> DTP { get; set; }
        //TODO: Build CUR segment
        //public CURSeg CUR { get; set; }

        [EDILoop("NM1", 1, "", 0, "CLM")]
        public List<Loop2010> L2010 { get; set; }

        [EDILoop("CLM", 0)]
        public List<Loop2300> L2300 { get; set; }

    }
}
