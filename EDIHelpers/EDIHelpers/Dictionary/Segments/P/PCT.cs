using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class PCTSeg: SegmentBase
    {
        public PCTSeg():base("PCT")
        {}
        public string PCT01_Qualifier { get; set; }
        public double? PCT02_Percentage { get; set; }
    }
}
