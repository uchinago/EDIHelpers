using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X276
{
    public class LoopClaimStatusTracking: EDIBase
    {

        public TRNSeg TRN { get; set; }
        public List<REFSeg> REF { get; set; }
        public AMTSeg AMT { get; set; }
        public DTPSeg DTP { get; set; }

        public List<LoopServiceLineInfo> L2210 { get; set; } 

    }
}
