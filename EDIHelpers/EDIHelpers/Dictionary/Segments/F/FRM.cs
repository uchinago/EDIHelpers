using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class FRMSeg: SegmentBase
    {
        public FRMSeg() : base("FRM")
        {
        }

        public string FRM01_AssignedNum { get; set; }
        public YesNo FRM02_ResponseCode { get; set; }
        public string FRM03_ReferenceID { get; set; }
        [EDIFormat("D8")]
        public DateTime FRM04_Date { get; set; }

        public double? FRM05_Percent { get; set; }
    }
}
