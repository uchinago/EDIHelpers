using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_278
{

    public class LoopName278 : EDIBase
    {
        public NM1Seg NM1 { get; set; }
        public List<REFSeg> REF { get; set; }
        public N2Seg N2 { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
        public List<PERSeg> PER { get; set; }
        public List<AAASeg> AAA { get; set; } 
        public PRVSeg PRV { get; set; }
        public DMGSeg DMG { get; set; }
        public INSSeg INS { get; set; }
        public DTPSeg DTP { get; set; }


        
    }
}
