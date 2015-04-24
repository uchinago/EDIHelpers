using System;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class N9Seg: SegmentBase
    {
        public N9Seg() : base("N9")
        {
            
        }

        public string N901_RefQual { get; set; }
        public string N902_ReferenceID { get; set; }
        public string N903_Description { get; set; }
        [EDIFormat("D8")]
        public DateTime N904_Date { get; set; }
        [EDIFormat("TM")]
        public DateTime N905_Time { get; set; }
        [EDILength(2)]
        public string N906_TimeCode { get; set; }
        public C040_Reference N907_References { get; set; }


    }
}