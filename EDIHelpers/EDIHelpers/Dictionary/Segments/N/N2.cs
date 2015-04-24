using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class N2Seg: SegmentBase
    {
        public N2Seg() : base("N2")
        {
            
        }

        public string N201_Name { get; set; }
        public string N202_Name { get; set; }
    }
}
