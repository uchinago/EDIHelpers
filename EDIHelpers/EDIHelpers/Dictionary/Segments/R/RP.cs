using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class RPSeg : SegmentBase
    {
        public RPSeg()
            : base("RP")
        {

        }
        [EDILength(3)]
        public string RP01_MaintenanceType { get; set; }
        public string RP02_InsuranceLine { get; set; }
        public string RP03_MaintenanceReason { get; set; }
        public string RP04_Description { get; set; }
        public string RP05_ParticipantStatus { get; set; }
        public YesNo RP06_ResponseCode { get; set; }
        public string RP07_SpecialProcessing { get; set; }
        public string RP08_Authority { get; set; }
        public string RP09_CoverageDesc { get; set; }
    }
}