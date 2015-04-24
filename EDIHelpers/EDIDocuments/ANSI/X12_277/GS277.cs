using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_277
{
    public class GS277: EDIBase
    {
        public GS277()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST277> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
