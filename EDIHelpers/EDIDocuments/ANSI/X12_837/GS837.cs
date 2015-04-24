using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_837
{
    public class GS837: EDIBase
    {
        public GS837()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST837> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
