using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X834
{
    public class Group834: EDIBase
    {
        public Group834()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST834> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
