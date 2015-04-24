using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_834
{
    public class Loop2200Disability: EDIBase
    {
        public DSBSeg DSB { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<AD1Seg> AD1 { get; set; } 
    }
}