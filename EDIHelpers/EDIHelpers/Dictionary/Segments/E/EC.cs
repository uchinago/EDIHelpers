using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class ECSeg : SegmentBase
    {
        public ECSeg()
            : base("EC")
        {

        }

        public string EC01_EmploymentClass { get; set; }
        public string EC02_EmploymentClass { get; set; }
        public string EC03_EmploymentClass { get; set; }
        public string EC04_EmploymentClass { get; set; }
        public double? EC05_Percent { get; set; }
        public char EC06_StatusCode { get; set; }
        public string EQ07_OccupationCode { get; set; }
    }
}