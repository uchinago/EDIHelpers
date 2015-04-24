using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X277
{
    //Descript how the loop is distinquised
    public class Dependent277: EDIBase
    {
        public Dependent277()
        {
        }
        //HL03 = 23
        public HLSeg HL { get; set; }
        public NM1Seg NM1 { get; set; }

        [EDILoop("TRN", 0)]
        public List<LoopClaimStatusTracking> L2200 { get; set; }
    }
}
