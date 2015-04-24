using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class PATSeg: SegmentBase
    {
        public PATSeg()
            : base("PAT")
        {
            
        }
        [EDILength(2)]
        public string PAT01_RelationCode { get; set; }
        
        public char PAT02_ParentLocation { get; set; }

        [EDILength(2)]
        public string PAT03_EmploymentStatus { get; set; }
        public char PAT04_StudentStatus { get; set; }

        public string PAT05_DTPQualifier { get; set; }
        public string PAT06_Date { get; set; }
        [EDILength(2)]
        public string PAT07_UnitOfMeasure { get; set; }
       
        public double? PAT08_Weight { get; set; }
       
        public YesNo PAT09_ResponseCode { get; set; }
    }
}
