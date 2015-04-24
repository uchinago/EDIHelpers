using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_837
{
    public class Loop2410: EDIBase
    {
        public LINSeg LIN { get; set; }
        public CTPSeg CTP { get; set; }
        public REFSeg REF { get; set; }
    }
}
