using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class TRNSeg: SegmentBase
    {
        public TRNSeg() : base("TRN")
        {
            
        }

        public TRNSeg(string trn01, string trn02)
            : base("TRN")
        {
            TRN01_TraceType = trn01;
            TRN02_ReferenceID = trn02;
        }


        public string TRN01_TraceType { get; set; }
        public string TRN02_ReferenceID { get; set; }
        [EDILength(10)]
        public string TRN03_CompanyId { get; set; }
        public string TRN04_ReferenceID { get; set; }


    }
}
