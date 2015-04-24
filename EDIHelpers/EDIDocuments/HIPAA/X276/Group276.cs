using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X276
{
    public class Group276: EDIBase
    {
        public Group276()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<Transaction276> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
