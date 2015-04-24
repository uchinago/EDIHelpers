using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_270
{
    public class GS270: EDIBase
    {
        public GS270()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST270> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
