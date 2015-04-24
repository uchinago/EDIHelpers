using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class CASSeg: SegmentBase
    {
        public CASSeg():base("CAS")
        {}
        public string CAS01_AdjustmentGroup { get; set; }
        
        public string CAS02_AdjustmentReason { get; set; }
        public double? CAS03_Amount { get; set; }
        public double? CAS04_Quantity { get; set; }

        public string CAS05_AdjustmentReason { get; set; }
        public double? CAS06_Amount { get; set; }
        public double? CAS07_Quantity { get; set; }

        public string CAS08_AdjustmentReason { get; set; }
        public double? CAS09_Amount { get; set; }
        public double? CAS10_Quantity { get; set; }

        public string CAS11_AdjustmentReason { get; set; }
        public double? CAS12_Amount { get; set; }
        public double? CAS13_Quantity { get; set; }

        public string CAS14_AdjustmentReason { get; set; }
        public double? CAS15_Amount { get; set; }
        public double? CAS16_Quantity { get; set; }

        public string CAS17_AdjustmentReason { get; set; }
        public double? CAS18_Amount { get; set; }
        public double? CAS19_Quantity { get; set; }
    }
}
