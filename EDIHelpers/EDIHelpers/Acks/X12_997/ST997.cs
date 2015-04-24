using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIHelpers.Acks.X12_997
{
    public class ST997: EDIBase
    {
        public STSeg ST { get; set; }
        public AK1Seg AK1 { get; set; }

        [EDILoop("AK2", 0, "", 2, new[] { "AK9", "SE" })]
        public List<LoopAK2> TransactionReponse { get; set; } 

        public AK9Seg AK9 { get; set; }
        public SESeg SE { get; set; }



       
    }
}
