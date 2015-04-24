using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X835
{
    public class ST835: EDIBase
    {
        public ST835()
        {
            
        }

        public STSeg ST { get; set; }
        public BPRSeg BPR { get; set; }
        public TRNSeg TRN { get; set; }
        public CURSeg CUR { get; set; }

        //Max 2...
        public List<REFSeg> REF { get; set; }

        public DTMSeg DTM { get; set; }

      
        //How to split EDILoop based on qualifier...when they are at the same level... 

        [EDILoop("N1", 1, "", 0, new[] {"N1", "LX", "PLB", "SE"})]
        public Loop1000PartyID Payer { get; set; }
        //public N1Seg PayerName { get; set; }
        //public N3Seg PayerAddress { get; set; }
        //public N4Seg PayerCityState { get; set; }
        //public List<REFSeg> PayerREF { get; set; }
        //public List<PERSeg> PayerContacts { get; set; }
        

        [EDILoop("N1", 1, "", 0, new[] { "LX", "PLB", "SE" })]
        public Loop1000PartyID Payee { get; set; }

        //public N1Seg PayeeName { get; set; }
        //public N3Seg PayeeAddress { get; set; }
        //public N4Seg PayeeCityState { get; set; }
        //public List<REFSeg> PayeeREF { get; set; }
        //public RDMSeg RDM { get; set; }



        [EDILoop("LX", 0, "", 1, new[] { "PLB", "SE" })]
        public List<Loop2000TransactionSet> ClaimPayment { get; set; }

        public List<PLBSeg> PLB { get; set; } 

        public SESeg SE { get; set; }
    }
}
