using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Contract Information
    /// </summary>
    public class CN1Seg: SegmentBase
    {
        public CN1Seg() : base("CN1")
        {
        }
        [EDILength(2)]
        public string CN101_ContractType { get; set; }
        public double? CN102_Amount { get; set; }
        public double? CN103_Percent { get; set; }

        public string CN104_Reference { get; set; }
        public double? CN105_DiscountPercent { get; set; }
        public string CN106_Version { get; set; }
    }
}