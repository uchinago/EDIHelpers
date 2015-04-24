using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X276
{
    //descript how the loop is distinquished.
    public class LoopInfoSource276: EDIBase
    {
        public LoopInfoSource276()
        {
        }

        //HL03 = 20
        public HLSeg HL { get; set; }
        public NM1Seg NM1 { get; set; }
        [EDILoop("HL", 3, "21", 0)]
        public List<LoopInfoReceiver276> Receiver { get; set; }
        
    }
}
