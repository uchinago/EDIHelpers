using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_276
{
    public class GS276: EDIBase
    {
        public GS276()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST276> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
