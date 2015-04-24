using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.Loops
{
    public class LoopPaperwork: EDIBase
    {
        public LoopPaperwork()
        {

        }
        public PWKSeg PWK { get; set; }
        public PERSeg PER { get; set; }
        public N1Seg N1 { get; set; }
        public N3Seg N3 { get; set; }
        public N4Seg N4 { get; set; }
       
    }
}
