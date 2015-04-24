using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.Sportsmans.X850
{
    public class GS850: EDIBase
    {
        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST850> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}

