using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_837
{
    public class Loop2305: EDIBase
    {

        public CR7Seg CR7 { get; set; }
        public List<HSDSeg> HSD { get; set; } 
    }
}
