using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIDocuments.ANSI.Loops;
using EDIDocuments.ANSI.X12_271;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;
namespace EDIDocuments.ANSI.X12_837
{
    public class LoopLS:EDIBase
    {
        public LoopLS()
        {
            
        }

        public LSSeg LS { get; set; }
        [EDILoop("NM1" )]
        public List<Loop2120> L2120 { get; set; }

        public LESeg LE { get; set; }
    }
}
