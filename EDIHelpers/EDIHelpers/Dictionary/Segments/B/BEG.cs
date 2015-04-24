using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class BEGSeg: SegmentBase
    {
        public BEGSeg() : base("BEG")
        {
            
        }
        [EDILength(2)]
        public string BEG01_PurposeCode { get; set; }
        [EDILength(2)]
        public string BEG02_OrderType { get; set; }
        public string BEG03_PONumber { get; set; }
        public string BEG04_ReleaseNumber { get; set; }
        [EDIFormat("D8")]
        public string BEG05_Date { get; set; }
        public string BEG06_ContractNumber { get; set; }
        [EDILength(2)]
        public string BEG07_AckType { get; set; }
        [EDILength(3)]
        public string BEG08_InvoiceType { get; set; }
        [EDILength(2)]
        public string BEG09_ContractType { get; set; }
        [EDILength(2)]
        public string BEG10_Category { get; set; }
        [EDILength(2)]
        public string BEG11_SecurityLevel { get; set; }
        [EDILength(2)]
        public string BEG12_TransactionType { get; set; }
    }
}