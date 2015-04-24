using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Conditions Indicator
    /// </summary>
    public class CRCSeg: SegmentBase
    {
        public CRCSeg() : base("CRC")
        {
        }
        [EDILength(2)]
        public string CRC01_Category { get; set; }
        public YesNo CRC02_ResponseCode { get; set; }
        public string CRC03_ConditionIndicator { get; set; }
        public string CRC04_ConditionIndicator { get; set; }
        public string CRC05_ConditionIndicator { get; set; }
        public string CRC06_ConditionIndicator { get; set; }
        public string CRC07_ConditionIndicator { get; set; }
    }
}
