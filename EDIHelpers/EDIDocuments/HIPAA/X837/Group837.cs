using System.Collections.Generic;
using EDIDocuments.ANSI.X12_837;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X837
{
    public class Group837: EDIBase
    {
        public Group837()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST837> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
