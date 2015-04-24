using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X270
{

    public class Group270: EDIBase
    {
        public Group270()
        {
            //GS = new GSSeg();
            //STLoops = new List<Transaction270>();
            //GE = new GESeg();
        }

        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<Transaction270> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}
