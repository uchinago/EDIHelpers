using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X276
{
    //Descript how the loop is distinquised
    public class Subscriber276: EDIBase
    {
        public Subscriber276()
        {
        }
        //HL03 = 22
        public HLSeg HL { get; set; }
        public DMGSeg DMG { get; set; }
        public NM1Seg NM1 { get; set; }

        [EDILoop("TRN", 0, "", 0, "HL")]
        public List<LoopClaimStatusTracking> L2200 { get; set; }

        [EDILoop("HL", 3, "23", 0)]
        public List<Dependent276> Dependent { get; set; }

        
    }
}
