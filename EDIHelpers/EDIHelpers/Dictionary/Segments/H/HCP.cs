using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class HCPSeg: SegmentBase
    {
        public HCPSeg() : base("HCP")
        {}
        [EDILength(2)]
        public string HCP01_PricingMethod { get; set; }
        public double? HCP02_Amount { get; set; }
        public double? HCP03_Amount { get; set; }
        public string HCP04_ReferenceID { get; set; }
        public double? HCP05_Rate { get; set; }
        public string HCP06_ReferenceID { get; set; }
        public double? HCP07_Amount { get; set; }
        public string HCP08_ProductID { get; set; }
        [EDILength(2)]
        public string HCP09_IDQualifier { get; set; }
        public string HCP10_ProductID { get; set; }
        [EDILength(2)]
        public string HCP11_UOM { get; set; }
        public double? HCP12_Quanitty { get; set; }
        [EDILength(2)]
        public string HCP13_RejectReason { get; set; }
        public string HCP14_PolicyCompliance { get; set; }
        public string HCP15_ExceptionCode { get; set; }
        
    }
}
