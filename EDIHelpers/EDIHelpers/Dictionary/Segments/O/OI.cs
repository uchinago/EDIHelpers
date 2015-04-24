using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Other Health INsurance Information
    /// </summary>
    public class OISeg:SegmentBase
    {
        public OISeg() : base("OI")
        {
        }
        public string OI01_FilingIndicator { get; set; }
        [EDILength(2)]
        public string OI02_SubmissionReason { get; set; }
        public YesNo OI03_ResponseCode { get; set; }
        public char OI04_PatientSignature { get; set; }
        public char OI05_ProviderAgreement { get; set; }
        public char OI06_ReleaseInformation { get; set; }
    }
}