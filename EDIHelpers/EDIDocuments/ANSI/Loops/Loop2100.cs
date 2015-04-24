using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.Loops
{
    public class Loop2100: EDIBase
    {
        public Loop2100()
        {

        }

        public NM1Seg NM1 { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
        public List<PERSeg> PER { get; set; }
    }

}
