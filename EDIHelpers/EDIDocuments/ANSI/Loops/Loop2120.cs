using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.Loops
{
    public class Loop2120: EDIBase
    {
        public Loop2120()
        {
            
        }

        public NM1Seg NM1 { get; set; }

        public List<REFSeg> REF { get; set; }

        public N2Seg N2 { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }

        public PERSeg PER { get; set; }

        public PRVSeg PRV { get; set; }


    }
}
