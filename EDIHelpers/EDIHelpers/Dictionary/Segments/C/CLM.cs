using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class CLMSeg: SegmentBase
    {
        public CLMSeg() : base("CLM")
        {
        }

        public string CLM01_PatientID { get; set; }
        public double? CLM02_ChargeAmount { get; set; }
        public string CLM03_FilingIndicator { get; set; }
        public string CLM04_ClaimType { get; set; }
        public C023_ServiceLocation CLM05_Location { get; set; }
        public YesNo CLM06_ResponseCode { get; set; }
        public char CLM07_AcceptAssignment { get; set; }
        public YesNo CLM08_ResponseCode { get; set; }
        public char CLM09_ReleaseInfo { get; set; }
        public char CLM10_PatientSignature { get; set; }
        public C024_RelatedCauses CLM11_RelatedCauses { get; set; }
        public string CLM12_SpecialProgram { get; set; }
        public YesNo CLM13_ResponseCode { get; set; }
        public string CLM14_ServiceLevel { get; set; }
        public YesNo CLM15_ResponseCode { get; set; }
        public char CLM16_ProviderAgreement { get; set; }
        public string CLM17_ClaimStatus { get; set; }
        public YesNo CLM18_ResponseCode { get; set; }
        [EDILength(2)]
        public string CLM19_SubmissionReason { get; set; }
        public string CLM20_DelayReason { get; set; }

    }
}
