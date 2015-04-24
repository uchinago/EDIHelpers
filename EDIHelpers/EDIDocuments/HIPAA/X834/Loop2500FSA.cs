using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X834
{
    public class Loop2500FSA : EDIBase
    {
        public FSASeg FSA { get; set; }
        public List<AMTSeg> AMT { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<REFSeg> REF { get; set; } 
    }
}