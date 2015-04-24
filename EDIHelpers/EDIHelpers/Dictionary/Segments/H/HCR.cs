using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Health Care Services Review
    /// </summary>
    public class HCRSeg: SegmentBase
    {
        public HCRSeg() : base("HCR")
        {
        }

        public string HCR01_ActionCode { get; set; }
        public string HCR01_ReferenceID { get; set; }
        public string HCR01_Code { get; set; }
        public YesNo HCR01_ResponseCode { get; set; }
    }
}