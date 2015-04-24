using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_837
{
    public class Loop2320: EDIBase
    {
        public SBRSeg SBR { get; set; }
        public List<CASSeg> CAS { get; set; }
        public List<AMTSeg> AMT { get; set; } 
        public DMGSeg DMG { get; set; }

        public OISeg OI { get; set; }
        public MIASeg MIA { get; set; }
        public MOASeg MOA { get; set; }
        //Loop2330
        [EDILoop("NM1", 0)]
        public List<Loop2330> L2330 { get; set; } 
    }
}
