using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_834
{
    public class GS834: EDIBase
    {
        public GS834()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST834> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
