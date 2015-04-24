using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_278
{
    public class GS278: EDIBase
    {
        public GS278()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST278> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
