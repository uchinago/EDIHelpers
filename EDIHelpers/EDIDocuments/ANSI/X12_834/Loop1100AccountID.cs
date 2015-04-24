using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_834
{
    public class Loop1100AccountID: EDIBase
    {
        public ACTSeg ACT { get; set; }
        public List<REFSeg> REF { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
        public List<PERSeg> PER { get; set; }
        public DTPSeg DTP { get; set; }
        public AMTSeg AMT { get; set; }
    }
}