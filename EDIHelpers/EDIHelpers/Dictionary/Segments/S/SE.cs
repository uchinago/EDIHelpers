using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class SESeg : SegmentBase
    {
        public SESeg() : base("SE")
        {
            
        }

        public SESeg(int segCount, string controlNumber)
            : base("SE")
        {
            SE01_SegmentCount = segCount;
            SE02_ControlNumber = controlNumber;

        }
        public int SE01_SegmentCount { get; set; }
        public string SE02_ControlNumber { get; set; }

    }
}
