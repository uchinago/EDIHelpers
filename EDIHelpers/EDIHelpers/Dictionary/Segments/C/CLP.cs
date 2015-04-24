using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Claim Level Data
    /// </summary>
    public class CLPSeg : SegmentBase
    {
        public CLPSeg()
            : base("CLP")
        {

        }
        public string CLP01_SubmittersID { get; set; }
        public string CLP02_ClaimStatus { get; set; }
        public double? CLP03_Amount { get; set; }
        public double? CLP04_Amount { get; set; }
        public double? CLP05_Amount { get; set; }
        public string CLP06_FilingIndicator { get; set; }
        public string CLP07_ReferenceID { get; set; }
        public string CLP08_FacilityCode { get; set; }
        public char CLP09_ClaimFrequency { get; set; }
        public string CLP10_PatientStatus { get; set; }
        public string CLP11_DRG { get; set; }
        public double? CLP12_Quantity { get; set; }
        public double? CLP13_Percent { get; set; }
        public YesNo CLP14_ResponseCode { get; set; }
        public double? CLP15_ExchangeRate { get; set; }
    }
}