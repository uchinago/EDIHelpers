using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class LCSeg : SegmentBase
    {
        public LCSeg()
            : base("LC")
        {

        }
        [EDILength(3)]
        public string LC01_MaintenanceType { get; set; }
        public string LC02_MaintenanceReason { get; set; }
        public string LC03_InsuranceLine { get; set; }
        public string LC04_CoverageDesc { get; set; }
        public double? LC05_Quantity { get; set; }
        public string LC06_ProductOption { get; set; }
        public YesNo LC07_ResponseCode { get; set; }

    }
}