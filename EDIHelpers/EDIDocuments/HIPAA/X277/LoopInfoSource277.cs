using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X277
{
    //descript how the loop is distinquished.
    public class LoopInfoSource277: EDIBase
    {
        public LoopInfoSource277()
        {
        }

        //HL03 = 20
        public HLSeg HL { get; set; }
        public NM1Seg NM1 { get; set; }
        public PERSeg PER { get; set; }
        [EDILoop("HL", 3, "21", 0)]
        public List<LoopInfoReceiver277> Receiver { get; set; }
        
    }
}
