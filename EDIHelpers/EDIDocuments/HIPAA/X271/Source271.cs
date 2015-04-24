using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X271
{
    //descript how the loop is distinquished.
    public class Source271: EDIBase
    {
        public Source271()
        {
        }

        //HL03 = 20
        public HLSeg HL { get; set; }
        public List<AAASeg> AAA_2000A { get; set; }
        public NM1Seg NM1 { get; set; }
        public List<PERSeg> PER { get; set; }
        public List<AAASeg> AAA_2100A { get; set; }
        [EDILoop("HL", 3, "21", 0)]
        public List<Receiver271> Receiver { get; set; }
        
    }
}
