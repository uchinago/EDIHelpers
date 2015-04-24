using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_278
{
    public class ST278: EDIBase
    {
        public ST278()
        {
            
        }

        public STSeg ST { get; set; }
        public BHTSeg BHT { get; set; }

        [EDILoop("HL")]
        public List<HL278> HL { get; set; }


        public SESeg SE { get; set; }
    }
}
