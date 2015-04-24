using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIDocuments.ANSI.X12_271;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X271
{
    public class Benefits271: EDIBase
    {
        public EBSeg EB { get; set; }
        public List<HSDSeg> HSD { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<AAASeg> AAA { get; set; }
        public List<MSGSeg> MSG { get; set; }
        public List<IIISeg> III { get; set; }
        [EDILoop("LS", 0, "", 0)]
        public List<LoopLS> LS { get; set; } 
    }
}
