using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class SV6Seg : SegmentBase
    {
        public SV6Seg()
            : base("SV6")
        { }

        public C003_MedicalProc SV601_Procedure { get; set; }
        public string SV602_FacilityQualifier { get; set; }
        public string SV603_FacilityCode { get; set; }
        public double? SV604_Amount { get; set; }
        public C004_DiagnosisPointer SV605_Diagnosis { get; set; }
        public double? SV606_Quantity { get; set; }
        public YesNo SV607_ResponseCode { get; set; }
        
    }
}
