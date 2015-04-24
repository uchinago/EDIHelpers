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
    public class LoopInfoReceiver276: EDIBase
    {
        public LoopInfoReceiver276()
        {
        }
        //HL03 = 21
        public HLSeg HL { get; set; }
        public NM1Seg NM1 { get; set; }
        
        
        [EDILoop("HL", 3, "19", 0)]
        public List<LoopServiceProvider> ServiceProvider { get; set; }

    }
}
