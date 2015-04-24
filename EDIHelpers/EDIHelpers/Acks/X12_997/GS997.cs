using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIHelpers.Acks.X12_997
{
    public class GS997: EDIBase
    {
        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST997> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}