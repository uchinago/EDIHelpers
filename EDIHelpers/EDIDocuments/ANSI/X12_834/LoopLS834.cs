using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_834
{
    public class LoopLS834: EDIBase
    {
        public LSSeg LS { get; set; }

        [EDILoop("LX")]
        public List<Loop2700834> L2700 { get; set; } 

        public LESeg LE { get; set; }
    }


    public class Loop2700834 : EDIBase
    {
        public LXSeg LX { get; set; }
        [EDILoop("N1", 0)]
        public List<Loop2750834> L2750 { get; set; }
    }

    public class Loop2750834 : EDIBase
    {
        public N1Seg N1 { get; set; }
        public REFSeg REF { get; set; }
        public DTPSeg DTP { get; set; }
    }
}