using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_837
{
    public class Loop2330 : EDIBase
    {
        public NM1Seg NM1 { get; set; }

        public List<N2Seg> N2 { get; set; }
        public List<N3Seg> N3 { get; set; }
        public N4Seg N4 { get; set; }
        public List<PERSeg> PER { get; set; }

        public List<DTPSeg> DTP { get; set; } 

        public List<REFSeg> REF { get; set; }

        
    }



}
