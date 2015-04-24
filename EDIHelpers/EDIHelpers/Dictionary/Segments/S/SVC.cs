using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class SVCSeg: SegmentBase
    {
        public SVCSeg() : base("SVC")
        {
        }
        public C003_MedicalProc SVC01_ProcedureCode { get; set; }
        public double? SVC02_Amount { get; set; }
        public double? SVC03_Amount { get; set; }
        public string SVC04_ProductID { get; set; }
        public double? SVC05_Quantity { get; set; }
        public C003_MedicalProc SVC06_ProcedureCode { get; set; }
        public double? SVC07_Quantity { get; set; }
    }
}
