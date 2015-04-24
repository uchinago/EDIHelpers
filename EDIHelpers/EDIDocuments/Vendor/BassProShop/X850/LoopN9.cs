using System.Collections.Generic;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.BassProShop.X850
{
    public class LoopN9: EDIBase
    {
        public N9Seg N9 { get; set; }
        public List<MSGSeg> MSG { get; set; }
    }
}