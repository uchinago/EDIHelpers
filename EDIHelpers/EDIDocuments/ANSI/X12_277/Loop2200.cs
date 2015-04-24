using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_277
{
    public class Loop2200: EDIBase
    {
        public Loop2200()
        {

        }
        public TRNSeg TRN { get; set; }
        public List<STCSeg> STC { get; set; } 
        public List<REFSeg> REF { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<QTYSeg> QTY { get; set; } 
        public List<AMTSeg> AMT { get; set; }

        [EDILoop("PWK", 0, "", 0, "SVC")]
        public List<LoopPaperwork> L2210 { get; set; }

        [EDILoop("SVC", 0)]
        public List<Loop2220> L2220 { get; set; } 
       
    }
}
