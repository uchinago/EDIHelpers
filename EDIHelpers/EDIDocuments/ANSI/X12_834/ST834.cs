using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_834
{
    public class ST834: EDIBase
    {
        public ST834()
        {
            
        }

        public STSeg ST { get; set; }
        public BGNSeg BGN { get; set; }

        public List<REFSeg> REF { get; set; }

        public List<DTPSeg> DTP { get; set; }

        public List<AMTSeg> AMT { get; set; }

        public List<QTYSeg> QTY { get; set; }

        [EDILoop("N1", 0, "", 1, "INS")]
        public List<Loop1000PartyID> L1000 { get; set; }
        [EDILoop("INS", 1)]
        public List<Loop2000InsuredBenefit> Insured { get; set; }
        public SESeg SE { get; set; }
    }
}
