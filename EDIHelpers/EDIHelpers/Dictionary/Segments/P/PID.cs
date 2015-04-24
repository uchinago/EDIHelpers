using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class PIDSeg: SegmentBase
    {
        public PIDSeg() : base("PID")
        {
            
        }
        public char PID01_DescriptionType { get; set; }
        public string PID02_CharacteristicCode { get; set; }
        [EDILength(2)]
        public string PID03_AgencyCode { get; set; }
        public string PID04_DescriptionCode { get; set; }
        public string PID05_Description { get; set; }
        [EDILength(2)]
        public string PID06_PositionCode { get; set; }
        public string PID07_SourceSubQual { get; set; }
        public YesNo PID08_YesNoResponse { get; set; }
        public string PID09_Language { get; set; }
    }
}