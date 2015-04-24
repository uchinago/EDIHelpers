using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.Loops
{
    //NM1 loop till HL segmetns
    public class Loop1000: EDIBase
    {
        public NM1Seg NM1 { get; set; }

        public N2Seg N2 { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }

        //Max 2 segments
        public List<REFSeg> REF { get; set; }

        public PERSeg PER { get; set; }
        
    }
}
