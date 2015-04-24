using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.BassProShop.X856
{
    public class GS856: EDIBase
    {
        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<ST856> STLoops { get; set; }
        public GESeg GE { get; set; }
    }
}

