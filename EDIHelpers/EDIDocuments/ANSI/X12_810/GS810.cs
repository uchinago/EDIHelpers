using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_810
{
    public class GS810: EDIBase
    {
        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST810> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}

