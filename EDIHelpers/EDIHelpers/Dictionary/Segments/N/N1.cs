using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class N1Seg: SegmentBase
    {
        public N1Seg() : base("N1")
        {
        }

        public string N101_EntityType { get; set; }
        public string N102_Name { get; set; }
        public string N103_IDQualifier { get; set; }
        public string N104_IDCode { get; set; }
        [EDILength(2)]
        public string N105_RelationshipCode { get; set; }
        public string N106_EntityCode { get; set; }


    }
}
