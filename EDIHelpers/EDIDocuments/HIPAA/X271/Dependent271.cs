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
    public class Dependent271: EDIBase
    {
        public Dependent271()
        {
            //These are typical values for the Dependent in a single transaction.
            HL = new HLSeg();
            HL.HL01_HierID = 4;
            HL.HL02_ParentID = "3";
            HL.HL03_LevelCode = "23";
            HL.HL04_HasChildFlag = null;
        }
        //HL03 = 23
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

        [EDILoop("EB", 0, "", 0)]
        public List<Benefits271> EB { get; set; }
    }
}
