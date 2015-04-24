using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIHelpers.Acks.X12_997
{
    public class LoopAK2: EDIBase
    {
        public AK2Seg AK2 { get; set; }

        [EDILoop("AK3",0, "", 2, "AK5")]
        public List<LoopAK3> DataNotes { get; set; } 
        public AK5Seg AK5 { get; set; }
    }
}