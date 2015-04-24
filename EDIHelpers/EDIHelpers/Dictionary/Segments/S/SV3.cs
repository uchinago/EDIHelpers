using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class SV3Seg : SegmentBase
    {
        public SV3Seg()
            : base("SV3")
        { }

        public C003_MedicalProc SV301_Procedure { get; set; }
        public double? SV302_ChargeAmount { get; set; }
        public string SV303_FacilityCode { get; set; }
        public C006_OralCavity SV304_CavityCode { get; set; }
        public char SV305_CrownInlayCode { get; set; }
        public double? SV306_Quantity { get; set; }
        public string SV307_Description { get; set; }

        public char SV308_CopayStatus { get; set; }
        public char SV309_ProviderAgreement { get; set; }
        public YesNo SV310_ResponseCode { get; set; }

        public C004_DiagnosisPointer SV311_Diagnosis { get; set; }
       
    }
}
