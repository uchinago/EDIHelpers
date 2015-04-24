using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class SVDSeg : SegmentBase
    {
        public SVDSeg()
            : base("SVD")
        {

        }
        public string SVD01_Code { get; set; }
        public double? SVD02_Amount { get; set; }
        public C003_MedicalProc SVD03_Procedure { get; set; }
        public string SVD04_ProductID { get; set; }
        public double? SVD05_Quantity { get; set; }
        public int SVD06_AssignedNum { get; set; }

    }
}
