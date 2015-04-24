using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class BPRSeg : SegmentBase
    {
        public BPRSeg()
            : base("BPR")
        {

        }
        public string BPR01_TransactionHandling { get; set; }
        public double? BPR02_Amount { get; set; }
        public char BPR03_CreditFlag { get; set; }
        [EDILength(3)]
        public string BPR04_PaymentMethod { get; set; }
        public string BPR05_PaymentFOrmat { get; set; }
        [EDILength(2)]
        public string BPR06_DFIQualifier { get; set; }
        public string BPR07_DFI { get; set; }
        public string BPR08_AcctQualifier { get; set; }
        public string BPR09_AccountNumber { get; set; }
        [EDILength(10)]
        public string BPR10_OrigCompanyID { get; set; }
        [EDILength(9)]
        public string BPR11_OrigCompCode { get; set; }
        [EDILength(2)]
        public string BPR12_DFIQualifier { get; set; }
        public string BPR13_DFI { get; set; }
        public string BPR14_AcctQualifier { get; set; }
        public string BPR15_AccountNumber { get; set; }
        [EDIFormat("D8")]
        public string BPR16_Date { get; set; }
        public string BPR17_BusinessFuncCode { get; set; }
        [EDILength(2)]
        public string BPR18_DFIQualifier { get; set; }
        public string BPR19_DFI { get; set; }
        public string BPR20_AcctQualifier { get; set; }
        public string BPR21_AccountNumber { get; set; }
    }
}