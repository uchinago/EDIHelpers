using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_271
{
    public class Loop2100: EDIBase
    {
        public Loop2100()
        {

        }

        public NM1Seg NM1 { get; set; }
        //Max 9 segments
        public List<REFSeg> REF { get; set; }

        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }

        public List<PERSeg> PER { get; set; }
        public List<AAASeg> AAA { get; set; } 

        public PRVSeg PRV { get; set; }
        public DMGSeg DMG { get; set; }
        public INSSeg INS { get; set; }
        public HISeg HI { get; set; }

        public List<DTPSeg> DTP { get; set; }
        //LUI
        //MPI  Military Personal
        [EDILoop("EB", 0, "", 0)]
        public List<Loop2110> L2110 { get; set; }

       
    }

}
