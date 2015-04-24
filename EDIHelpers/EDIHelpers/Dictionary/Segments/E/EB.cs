using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class EBSeg:SegmentBase

    {
        public EBSeg() : base("EB")
        {
        }
        public string EB01_BenefitInfoCode { get; set; }
        [EDILength(3)]
        public String EB02_CoverageLevel { get; set; }
        public String EB03_ServiceType { get; set; }
        public String EB04_InsuranceType { get; set; }
        public String EB05_PlanCoverageDesc { get; set; }
        public String EB06_TimeQual { get; set; }
        public double? EB07_Amount { get; set; }
        public double? EB08_Percentage { get; set; }
        [EDILength(2)]
        public String EB09_QtyQual { get; set; }
        public double? EB10_Quantity { get; set; }
        public YesNo EB11_AuthCertInd { get; set; }
        public YesNo EB12_InNetworkInd { get; set; }

        public C003_MedicalProc EB13_MedicalProc { get; set; }
        public C004_DiagnosisPointer EB14_DiagnosisPointer { get; set; }

    }
}
