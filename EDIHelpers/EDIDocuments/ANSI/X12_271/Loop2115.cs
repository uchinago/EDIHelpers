using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_271
{
    public class Loop2115: EDIBase
    {

        public IIISeg III { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<AMTSeg> AMT { get; set; }
        public List<PCTSeg> PCT { get; set; } 

        //Loop2117
        [EDILoop("LQ")]
        public List<Loop2117> L2117 { get; set; } 


    }
}

