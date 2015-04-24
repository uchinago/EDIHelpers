using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class SV7Seg : SegmentBase
    {
        public SV7Seg()
            : base("SV7")
        { }

        public string SV701_ReferenceID { get; set; }
        public string SV702_ReferenceID { get; set; }
        [EDILength(2)]
        public string SV703_DenialOverride { get; set; }
        [EDILength(3)]
        public string SV704_CoverageLevel { get; set; }

        public string SV705_CharacteristicCode { get; set; }
        public YesNo SV706_ResponseCode { get; set; }


    }
}
