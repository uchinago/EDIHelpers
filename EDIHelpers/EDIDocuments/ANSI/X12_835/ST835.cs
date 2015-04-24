using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_835
{
    public class ST835: EDIBase
    {
        public ST835()
        {
            
        }

        public STSeg ST { get; set; }
        public BPRSeg BPR { get; set; }

        public List<NTESeg> NTE { get; set; }

        public TRNSeg TRN { get; set; }
        public CURSeg CUR { get; set; }

        public List<REFSeg> REF { get; set; }

        public List<DTMSeg> DTM { get; set; } 

        public List<DTPSeg> DTP { get; set; }


        [EDILoop("N1", 0, "", 0, new[] {"LX", "PLB", "SE" })]
        public List<Loop1000PartyID> L1000 { get; set; }
        [EDILoop("LX", 0, "", 0, new[] { "PLB", "SE" })]
        public List<Loop2000TransactionSet> L2000ClaimPayment { get; set; }


        public List<PLBSeg> PLB { get; set; } 

        public SESeg SE { get; set; }
    }
}
