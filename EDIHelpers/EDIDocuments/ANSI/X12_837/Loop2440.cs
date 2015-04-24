using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_837
{
    public class Loop2440: EDIBase
    {
        public LQSeg LQ { get; set; }
        public List<FRMSeg> FRM { get; set; }
    }
}
