using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class QTYSeg : SegmentBase
    {
        public QTYSeg()
            : base("QTY")
        {

        }

        [EDILength(2)]
        public string QTY01_Qualifier { get; set; }

        public double? QTY02_Quantity { get; set; }
        public C001_UOM QTY03_UOM { get; set; }
        public string QTY04_Text { get; set; }

    }
}
