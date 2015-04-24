using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class TOOSeg: SegmentBase
    {
        public TOOSeg() : base("TOO")
        {
        }
        public string TOO01_Qualifier { get; set; }
        public string TOO02_Code { get; set; }
        public C005_ToothSurface TOO03_ToothSurface { get; set; }
    }
}
