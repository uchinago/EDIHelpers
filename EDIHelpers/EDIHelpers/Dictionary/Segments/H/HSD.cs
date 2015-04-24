using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class HSDSeg: SegmentBase
    {
        public HSDSeg() : base("HSD")
        {}
        [EDILength(2)]
        public string HSD01_QTYQualifier { get; set; }
        public double? HSD02_QTY { get; set; }
        [EDILength(2)]
        public string HSD03_UnitOfMeasure { get; set; }
        public double? HSD04_SampleModulus { get; set; }
        public string HSD05_DTPQualifier { get; set; }
        public int? HSD06_NumberOfPeriods { get; set; }
        public string HSD07_CalendarPattern { get; set; }
        public string HSD08_TimePattern { get; set; }
    }
}
