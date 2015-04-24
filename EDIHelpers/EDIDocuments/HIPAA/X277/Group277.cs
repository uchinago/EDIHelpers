using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X277
{
    public class Group277: EDIBase
    {
        public Group277()
        {

        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<Transaction277> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
