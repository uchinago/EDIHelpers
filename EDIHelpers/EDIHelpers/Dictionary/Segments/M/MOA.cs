namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Medicare Outpatient Adjudication
    /// </summary>
    public class MOASeg : SegmentBase
    {
        public MOASeg()
            : base("MOA")
        {
        }
        public double? MOA01_Percent { get; set; }
        public double? MOA02_Amount { get; set; }
        public string MOA03_ReferenceID { get; set; }
        public string MOA04_ReferenceID { get; set; }
        public string MOA05_ReferenceID { get; set; }
        public string MOA06_ReferenceID { get; set; }
        public string MOA07_ReferenceID { get; set; }
        public double? MOA08_Amount { get; set; }
        public double? MOA09_Amount { get; set; }

    }
}