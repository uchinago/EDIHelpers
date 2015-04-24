using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class NTESeg: SegmentBase
    {
        public NTESeg() : base("NTE")
        {
        }
        [EDILength(3)]
        public string NTE01_ReferenceCode { get; set; }
        public string NTE02_Description { get; set; }
    }
}

