using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class AAASeg: SegmentBase
    {
        public AAASeg() : base("AAA")
        {}

        public AAASeg(string reason) : base("AAA")
        {
            AAA03_RejectReason = reason;
            AAA01_ResponseCode = YesNo.Yes;
            AAA04_FollowUpAction = 'C';
        }

        public YesNo AAA01_ResponseCode { get; set; }
        [EDILength(2)]
        public string AAA02_AgencyQualifier { get; set; }
        [EDILength(2)]
        public string AAA03_RejectReason { get; set; }

        public char AAA04_FollowUpAction { get; set; }
    }
}
