using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_810
{
    public class LoopN1: EDIBase
    {
        public N1Seg N1 { get; set; }
        public List<N3Seg> N3 { get; set; }
        public List<N4Seg> N4 { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<PERSeg> PER { get; set; } 
    }
}