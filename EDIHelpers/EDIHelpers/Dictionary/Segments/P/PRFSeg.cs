using System;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class PRFSeg : SegmentBase
    {
        public PRFSeg()
            : base("PRF")
        {

        }
        public string PRF01_PONumber { get; set; }
        public string PRF02_ReleaseNumber { get; set; }
        public string PRF03_SequenceNumber { get; set; }
        [EDIFormat("D8")]
        public DateTime? PRF04_Date { get; set; }
        public string PRF05_ID { get; set; }
        public string PRF06_ContractNumber { get; set; }
        [EDILength(2)]
        public string PRF07_POType { get; set; }

    }
}