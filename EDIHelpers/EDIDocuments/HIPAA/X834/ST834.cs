using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X834
{
    public class ST834: EDIBase
    {
        public ST834()
        {
            
        }

        public STSeg ST { get; set; }
        public BGNSeg BGN { get; set; }

        public REFSeg REF { get; set; }

        public List<DTPSeg> DTP { get; set; }

        public List<QTYSeg> QTY { get; set; }

        public N1Seg L1000ASponsorName { get; set; }

        public N1Seg L1000BPayerName { get; set; }

        [EDILoop("N1", 0, "", 0, new[] {"INS", "SE"})]
        public List<Loop1000PartyID> L1000CBrokers { get; set; }

        [EDILoop("INS", 1)]
        public List<Loop2000MemberLevel> Insured { get; set; }
        public SESeg SE { get; set; }
    }
}
