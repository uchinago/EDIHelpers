using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X837
{
    public class ST837: EDIBase
    {
        public ST837()
        {
            
        }

        public STSeg ST { get; set; }
        public BHTSeg BHT { get; set; }
        //Custom Attributes
        public List<REFSeg> REF { get; set; }

        //Submitter 1000A single occurence
        public NM1Seg Submitter { get; set; }
        public PERSeg SubmitterContact { get; set; }
        
        //Receiver 1000B
        public NM1Seg Receiver { get; set; }
        
        //Billing HL 2000A
        [EDILoop("HL", 3, "20")]
        public List<LoopBilling> Billing { get; set; }

        public SESeg SE { get; set; }
    }
}
