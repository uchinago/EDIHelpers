using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X276
{
    public class LoopServiceLineInfo: EDIBase
    {
        public SVCSeg SVC { get; set; }
        public REFSeg REF { get; set; }
        public DTPSeg DTP { get; set; }
    }
}