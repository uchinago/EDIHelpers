namespace EDIHelpers.Dictionary.Segments
{

    /// <summary>
    /// Medicare Inpatient Adjudication
    /// </summary>
    public class MIASeg : SegmentBase
    {
        public MIASeg()
            : base("MIA")
        {
        }
        public double? MIA01_Quantity { get; set; }
        public double? MIA02_Amount { get; set; }
        public double? MIA03_Quantity { get; set; }
        public double? MIA04_Amount { get; set; }
        public string MIA05_ReferenceID { get; set; }
        public double? MIA06_Amount { get; set; }
        public double? MIA07_Amount { get; set; }
        public double? MIA08_Amount { get; set; }
        public double? MIA09_Amount { get; set; }
        public double? MIA10_Amount { get; set; }
        public double? MIA11_Amount { get; set; }
        public double? MIA12_Amount { get; set; }
        public double? MIA13_Amount { get; set; }
        public double? MIA14_Amount { get; set; }
        public double? MIA15_Quantity { get; set; }
        public double? MIA16_Amount { get; set; }
        public double? MIA17_Amount { get; set; }
        public double? MIA18_Amount { get; set; }
        public double? MIA19_Amount { get; set; }
        public string MIA20_ReferenceID { get; set; }
        public string MIA21_ReferenceID { get; set; }
        public string MIA22_ReferenceID { get; set; }
        public string MIA23_ReferenceID { get; set; }
        public double? MIA24_Amount { get; set; }
    }
}