using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X271
{
    //Descript how the loop is distinquised
    public class Subscriber271: EDIBase
    {
        public Subscriber271()
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
        public List<AAASeg> AAA { get; set; }

        public PRVSeg PRV { get; set; }
        public DMGSeg DMG { get; set; }
        public INSSeg INS { get; set; }
        public HISeg HI { get; set; }

        public List<DTPSeg> DTP { get; set; }
        
        //MPI Not implemented

        //TODO: Determine end element as either the EQ or HL...
        [EDILoop("EB", 0, "", 0, "HL")]
        public List<Benefits271> EB { get; set; }
        [EDILoop("HL", 3, "23", 0)]
        public List<Dependent271> Dependents { get; set; }

    }
}
