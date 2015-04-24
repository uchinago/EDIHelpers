using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Claim Codes
    /// 
    /// </summary>
    public class CL1Seg:SegmentBase
    {
        public CL1Seg() : base("CL1")
        {
        }
        public char CL101_AdmissionType { get; set; }
        public char CL102_AdmissionSource { get; set; }
        public string CL103_PatientStatus { get; set; }
        public char CL104_NursingHomeResident { get; set; }
    }
}
