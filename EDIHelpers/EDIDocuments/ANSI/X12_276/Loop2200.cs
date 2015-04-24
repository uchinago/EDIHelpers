using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_276
{
    public class Loop2200: EDIBase
    {
        public Loop2200()
        {

        }
        public TRNSeg TRN { get; set; }
        public List<REFSeg> REF { get; set; }
        public AMTSeg AMT { get; set; }
        public List<DTPSeg> DTP { get; set; }
        [EDILoop("SVC", 0)]
        public List<Loop2210> L2210 { get; set; } 
       
    }
}
