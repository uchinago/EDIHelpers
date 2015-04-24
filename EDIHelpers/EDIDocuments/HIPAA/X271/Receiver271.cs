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
    public class Receiver271: EDIBase
    {
        public Receiver271()
        {
        }
        //HL03 = 21
        public HLSeg HL { get; set; }
        public NM1Seg NM1 { get; set; }
        public List<REFSeg> REF { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
        public List<AAASeg> AAA { get; set; }
        public PRVSeg PRV { get; set; }

        [EDILoop("HL", 3, "22", 0)]
        public List<Subscriber271> Subscribers { get; set; }

    }
}
