using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class MSGSeg: SegmentBase
    {
        public MSGSeg() : base("MSG")
        {
        }
        public MSGSeg(string message)
            : base("MSG")
        {
            MSG01_Message = message;
        }

        public string MSG01_Message { get; set; }
        [EDILength(2)]
        public string MSG02_PrinterCode { get; set; }
        public int? MSG03_Number { get; set; }
    }
}
