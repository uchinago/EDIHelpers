using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;
namespace EDIDocuments.ANSI.X12_271
{
    public class Loop2000: EDIBase
    {
        public Loop2000()
        {

        }
        public HLSeg HL { get; set; }
        public List<TRNSeg> TRN { get; set; }
        public List<AAASeg> AAA { get; set; }
        [EDILoop("NM1", 1, "", 0, "", "LS", "LE")]
        public List<Loop2100> IndOrgName { get; set; }
    }
}
