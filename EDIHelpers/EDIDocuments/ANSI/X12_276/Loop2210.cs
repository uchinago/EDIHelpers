using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_276
{
    public class Loop2210: EDIBase
    {
        public Loop2210()
        {

        }
        public SVCSeg SVC { get; set; }
        public REFSeg REF { get; set; }
        public DTPSeg DTP { get; set; }
        public List<TOOSeg> TOO { get; set; } 
       
    }
}
