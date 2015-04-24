using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class UMSeg: SegmentBase
    {
        public UMSeg() : base("UM")
        {
        }
        public string UM01_RequestCategory { get; set; }
        public char UM02_CertificationType { get; set; }
        public string UM03_ServiceType { get; set; }
        public C023_ServiceLocation UM04_ServiceLocation { get; set; }
        public C024_RelatedCauses UM05_RelatedCauses { get; set; }
        public string UM06_ServiceLevel { get; set; }
        public char UM07_CurrentHealthCond { get; set; }
        public char UM08_PrognosisCode { get; set; }
        public char UM09_ReleaseInformation { get; set; }
        public string UM10_DelayReason { get; set; }
    }
}