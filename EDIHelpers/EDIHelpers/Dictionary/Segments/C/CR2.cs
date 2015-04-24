using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class CR2Seg: SegmentBase
    {
        public CR2Seg() : base("CR2")
        {
        }
        public int CR201_Count { get; set; }
        public double? CR202_Quantity { get; set; }
        public string CR203_SubluxationLevel { get; set; }
        public string CR204_SubluxationLevel { get; set; }
        [EDILength(2)]
        public string CR205_UOM { get; set; }
        public double? CR206_Quantity { get; set; }
        public double? CR207_Quantity { get; set; }
        public char CR208_NatureOfCondition { get; set; }
        public YesNo CR209_ResponseCode { get; set; }
        public string CR210_Description { get; set; }
        public string CR211_Description { get; set; }
        public YesNo CR212_ResponseCode { get; set; }
    }
}