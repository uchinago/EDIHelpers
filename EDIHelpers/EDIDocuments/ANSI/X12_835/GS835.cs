using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_835
{
    public class GS835: EDIBase
    {
        public GS835()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST835> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
