using System;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Pacemake Certification
    /// </summary>
    public class CR8Seg: SegmentBase
    {
        public CR8Seg() : base("CR8")
        {
        }
        public char CR801_ImplantType { get; set; }
        public char CR802_ImplantStatus { get; set; }
        public DateTime CR803_Date { get; set; }
        public DateTime CR804_Date { get; set; }
        public string CR805_RefernceID { get; set; }
        public string CR806_ReferenceID { get; set; }
        public string CR807_ReferenceID { get; set; }
        public YesNo CR808_ResponseCode { get; set; }
        public YesNo CR809_ResponseCode { get; set; }
    }
}