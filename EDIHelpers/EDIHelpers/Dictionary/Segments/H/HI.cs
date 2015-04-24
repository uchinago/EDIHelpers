using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class HISeg: SegmentBase
    {
        public HISeg() : base("HI")
        {
            
        }

        public C022_HealthCodeInfo HI01 { get; set; }
        public C022_HealthCodeInfo HI02 { get; set; }
        public C022_HealthCodeInfo HI03 { get; set; }
        public C022_HealthCodeInfo HI04 { get; set; }
        public C022_HealthCodeInfo HI05 { get; set; }
        public C022_HealthCodeInfo HI06 { get; set; }
        public C022_HealthCodeInfo HI07 { get; set; }
        public C022_HealthCodeInfo HI08 { get; set; }
        public C022_HealthCodeInfo HI09 { get; set; }
        public C022_HealthCodeInfo HI10 { get; set; }
        public C022_HealthCodeInfo HI11 { get; set; }
        public C022_HealthCodeInfo HI12 { get; set; }

    }
}
