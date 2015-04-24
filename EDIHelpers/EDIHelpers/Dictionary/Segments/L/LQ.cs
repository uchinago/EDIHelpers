using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class LQSeg: SegmentBase
    {
        public LQSeg() : base("LQ")
        {
            
        }

        public string LQ01_Qualifier { get; set; }
        public string LQ02_Code { get; set; }
    }
}
