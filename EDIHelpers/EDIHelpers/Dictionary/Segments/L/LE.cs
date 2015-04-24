using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class LESeg: SegmentBase
    {
        public LESeg() : base("LE")
        {
            
        }

        public LESeg(string ID) : base("LE")
        {
            LE01_ID = ID;
        }

        public string LE01_ID { get; set; }
    }
}
