using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_277
{
    public class Loop2220: EDIBase
    {
        public Loop2220()
        {

        }
        public SVCSeg SVC { get; set; }
        public List<STCSeg> STC { get; set; } 
        public List<REFSeg> REF { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<TOOSeg> TOO { get; set; }
        [EDILoop("PWK", 0)]
        public List<LoopPaperwork> L2225 { get; set; } 
       
    }
}
