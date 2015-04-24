using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.Loops
{
    /// <summary>
    /// THis is the basic NameLoop used in 
    /// 2310, 2430 etc...
    /// </summary>
    public class LoopNM1Basic:EDIBase
    {
        public NM1Seg NM1 { get; set; }

        public PRVSeg PRV { get; set; }
        
        public List<N2Seg> N2 { get; set; }
        public List<N3Seg> N3 { get; set; }
        public N4Seg N4 { get; set; }

        //Max 2 segments
        public List<REFSeg> REF { get; set; }

        public List<PERSeg> PER { get; set; }
    }
}
