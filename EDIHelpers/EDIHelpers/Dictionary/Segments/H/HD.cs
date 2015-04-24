using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class HDSeg : SegmentBase
    {
        public HDSeg() : base("HD")
        {
            
        }
        [EDILength(3)]
        public string HD01_MaintenanceType { get; set; }
        public string HD02_MaintenanceReason { get; set; }
        public string HD03_InsuranceLine { get; set; }
        public string HD04_CoverageDescription { get; set; }
        [EDILength(3)]
        public string HD05_CoverageLevel { get; set; }
        public int? HD06_Count { get; set; }
        public int? HD07_Count { get; set; }
        public char HD08_UnderwritingDescision { get; set; }
        public YesNo HD09_ResponseCode { get; set; }
        public string HD10_DrugHouse { get; set; }
        public YesNo HD11_ResponseCode { get; set; }
    }
}