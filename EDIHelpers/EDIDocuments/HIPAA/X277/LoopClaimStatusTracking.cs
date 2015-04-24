using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X277
{
    public class LoopClaimStatusTracking: EDIBase
    {

        public TRNSeg TRN { get; set; }
        public List<STCSeg> STC { get; set; } 
        public List<REFSeg> REF { get; set; }
        public DTPSeg DTP { get; set; }

        [EDILoop("SVC", 0)]
        public List<LoopServiceLineInfo> L2220 { get; set; } 

    }
}
