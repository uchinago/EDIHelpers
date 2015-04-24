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
    public class Subscriber270: EDIBase
    {
        public Subscriber270()
        {
        }
        //HL03 = 22
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
        
        //TODO: Determine end element as either the EQ or HL...
        [EDILoop("EQ", 0, "", 0, "HL")]
        public List<Loop2110> EQ { get; set; }
        [EDILoop("HL", 3, "23", 0)]
        public List<Dependent270> Dependents { get; set; }

    }
}
