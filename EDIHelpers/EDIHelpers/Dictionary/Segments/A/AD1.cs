using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class AD1Seg : SegmentBase
    {
        public AD1Seg()
            : base("AD1")
        {
        }
        [EDILength(2)]
        public string AD101_AdjustmentReason { get; set; }
        public double? AD102_Amount { get; set; }
        public string AD103_AdjReasonCharacteristic { get; set; }
        public char AD104_FrequencyCode { get; set; }
        [EDILength(2)]
        public string AD105_LateReason { get; set; }
    }
}