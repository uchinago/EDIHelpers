using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_271
{
    public class GS271: EDIBase
    {
        public GS271()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST271> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
