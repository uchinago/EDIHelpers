using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_834
{
    public class Loop2100Name:EDIBase
    {
        public NM1Seg NM1 { get; set; }
        public PERSeg PER { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
        public DMGSeg DMG { get; set; }

        public PMSeg PM { get; set; }
        public List<ECSeg> EC { get; set; }
        public ICMSeg ICM { get; set; }

        public List<AMTSeg> AMT { get; set; }

        public HLHSeg HLH { get; set; }
        public List<HISeg> HI { get; set; }
        public List<LUISeg> LUI { get; set; } 

    }
}