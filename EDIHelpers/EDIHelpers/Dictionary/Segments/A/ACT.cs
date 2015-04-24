namespace EDIHelpers.Dictionary.Segments
{
    public class ACTSeg : SegmentBase
    {
        public ACTSeg()
            : base("ACT")
        {
        }

        public string ACT01_AccountNumber { get; set; }
        public string ACT02_Name { get; set; }
        public string ACT03_IDQualifier { get; set; }
        public string ACT04_ID { get; set; }
        public string ACT05_AcctQualifier { get; set; }
        public string ACT06_Account { get; set; }
        public string ACT07_Description { get; set; }
        public string ACT08_PaymentMethod { get; set; }
        public string ACT09_BenefitStatus { get; set; }

    }
}