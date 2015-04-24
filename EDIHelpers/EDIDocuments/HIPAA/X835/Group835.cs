using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X835
{
    public class Group835: EDIBase
    {
        public Group835()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST835> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
