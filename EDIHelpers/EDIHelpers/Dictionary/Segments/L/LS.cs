using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class LSSeg: SegmentBase
    {
        public LSSeg() : base("LS")
        {
            
        }

        public LSSeg(string ID)
            : base("LS")
        {
            LS01_ID = ID;
        }


        public string LS01_ID { get; set; }
    }
}

