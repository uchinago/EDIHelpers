using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_271
{
    public class Loop2117: EDIBase
    {

        public LQSeg LQ { get; set; }
        public List<AMTSeg> AMT { get; set; }
        public List<PCTSeg> PCT { get; set; } 
     
    }
}
