using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIDocuments.ANSI.X12_270;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X270
{
    //Descript how the loop is distinquised
    public class Dependent270: EDIBase
    {
        public Dependent270()
        {
        }
        //HL03 = 23
        public HLSeg HL { get; set; }
        public List<TRNSeg> TRN { get; set; }

        public NM1Seg NM1 { get; set; }
        //Max 9 segments
        public List<REFSeg> REF { get; set; }

        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }

        public PRVSeg PRV { get; set; }
        public DMGSeg DMG { get; set; }
        public INSSeg INS { get; set; }
        public HISeg HI { get; set; }

        public List<DTPSeg> DTP { get; set; }

        [EDILoop("EQ", 0, "", 0)]
        public List<Loop2110> EQ { get; set; }
    }
}
