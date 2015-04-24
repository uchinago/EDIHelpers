using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class EQSeg: SegmentBase
    {
        public EQSeg() : base("EQ")
        {
            
        }

        public string EQ01_ServiceType { get; set; }
        public C003_MedicalProc EQ02_ProcedureCode { get; set; }
        [EDILength(3)]
        public string EQ03_CoverageLevel { get; set; }
        public C004_DiagnosisPointer EQ04_DiagPointers { get; set; }
    }
}
