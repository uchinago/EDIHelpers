using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class SBRSeg: SegmentBase
    {
        public SBRSeg() : base("SBR")
        {
            
        }

        public char SBR01_PayerSequence { get; set; }
        [EDILength(2)]
        public string SBR02_RelationCode { get; set; }
        public string SBR03_ReferenceID { get; set; }
        public string SBR04_Name { get; set; }
        public string SBR05_InsuranceType { get; set; }
        public char SBR06_COBCode { get; set; }
        public YesNo SBR07_ResponseCode { get; set; }
        [EDILength(2)]
        public string SBR08_EmploymentStatus { get; set; }
        public string SBR09_ClaimFilingInd { get; set; }
    }
}
