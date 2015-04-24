using System;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class BIGSeg : SegmentBase
    {
        public BIGSeg()
            : base("BIG")
        {

        }
        [EDIFormat("D8")]
        public DateTime? BIG01_Date { get; set; }
        public string BIG02_InvoiceNumber { get; set; }
        [EDIFormat("D8")]
        public DateTime? BIG03_Date { get; set; }
        public string BIG04_PONumber { get; set; }
        public string BIG05_ReleaseNumber { get; set; }
        public string BIG06_ChangeOrderSeq { get; set; }
        [EDILength(2)]
        public string BIG07_TransactionType { get; set; }
        [EDILength(2)]
        public string BIG08_TransactionPurpose { get; set; }
        public string BIG09_ActionCode { get; set; }
        public string BIG10_InvoiceNumber { get; set; }
        [EDILength(4)]
        public string BIG11_HierachialStructure { get; set; }
    }
}