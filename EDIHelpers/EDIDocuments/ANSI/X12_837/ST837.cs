using System.Collections.Generic;
using EDIDocuments.ANSI.Loops;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_837
{
    public class ST837: EDIBase
    {
        public ST837()
        {
            
        }

        public STSeg ST { get; set; }
        public BHTSeg BHT { get; set; }

        [EDILoop("NM1", 0, "", 1, "HL")]
        public List<Loop1000> L1000 { get; set; }
        [EDILoop("HL", 1)]
        public List<Loop2000> HL { get; set; }
        public SESeg SE { get; set; }
    }
}
