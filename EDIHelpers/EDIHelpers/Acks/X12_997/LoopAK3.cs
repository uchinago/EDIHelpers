using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIHelpers.Acks.X12_997
{
    public class LoopAK3: EDIBase
    {
        public AK3Seg AK3 { get; set; }
        public AK4Seg AK4 { get; set; }
    }
}