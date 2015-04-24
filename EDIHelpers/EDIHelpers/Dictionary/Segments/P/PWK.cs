using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class PWKSeg: SegmentBase
    {
        public PWKSeg():base("PWK")
        {}

        [EDILength(2)]
        public string PWK01_ReportType { get; set; }
        public string PWK02_RptTransmission { get; set; }
        public int PWK03_CopiesNeeded { get; set; }
        public string PWK04_EntityIdentifier { get; set; }
        public string PWK05_Qualifier { get; set; }
        public string PWK06_Code { get; set; }
        public string PWK07_Description { get; set; }
        public C002_Actions PWK08_Actions { get; set; }
        public string PWK09_RequestCategory { get; set; }


    }
}
