using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class LXSeg: SegmentBase
    {
        public LXSeg() : base("LX")
        {
            
        }
        public int LX01_AssignedNumber { get; set; }
    }
}
