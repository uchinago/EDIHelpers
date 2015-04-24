using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class SV1Seg : SegmentBase
    {
        public SV1Seg()
            : base("SV1")
        { }

        public C003_MedicalProc SV101_Procedure { get; set; }
        public double? SV102_ChargeAmount { get; set; }
        [EDILength(2)]
        public string SV103_UOM { get; set; }
        public double? SV104_Quantity { get; set; }
        public string SV105_FacilityCode { get; set; }
        public string SV106_ServiceType { get; set; }
        public C004_DiagnosisPointer SV107_Diagnosis { get; set; }
        public double? SV108_Amount { get; set; }
        public YesNo SV109_ResponseCode { get; set; }
        public string SV110_MultipleProcCode { get; set; }
        public YesNo SV111_ResponseCode { get; set; }
        public YesNo SV112_ResponseCode { get; set; }
        public string SV113_ReviewCode { get; set; }
        public string SV114_NationalReviewCode { get; set; }
        public char SV115_CopayStatus { get; set; }
        public char SV116_ShortageArea { get; set; }
        public string SV117_ReferenceID { get; set; }
        public string SV118_PostalCode { get; set; }
        public double? SV119_Amount { get; set; }
        public char SV120_LevelOfCare { get; set; }
        public char SV121_ProviderAgreement { get; set; }
    }
}
