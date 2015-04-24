using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class FSASeg : SegmentBase
    {
        public FSASeg()
            : base("FSA")
        {
        }
        [EDILength(3)]
        public string FSA01_MaintenanceType { get; set; }
        public char FSA02_FSASelection { get; set; }
        public string FSA03_MaintenanceReason { get; set; }
        public string FSA04_AccountNumber { get; set; }
        public char FSA05_Frequency { get; set; }
        public string FSA06_CoverageDescription { get; set; }
        public string FSA07_ProductOption { get; set; }
        public string FSA08_ProductOption { get; set; }
        public string FSA09_ProductOption { get; set; }
    }
}