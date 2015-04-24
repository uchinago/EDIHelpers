using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Ambulance Certification
    /// </summary>
    public class CR1Seg : SegmentBase
    {
        public CR1Seg()
            : base("CR1")
        {
        }
        [EDILength(2)]
        public string CR101_UOM { get; set; }
        public double? CR102_Weight { get; set; }
        public char CR103_TransportCode { get; set; }
        public char CR104_TransportReason { get; set; }
        [EDILength(2)]
        public string CR105_UOM { get; set; }
        public double? CR106_Quantity { get; set; }
        public string CR107_AddrInfo { get; set; }
        public string CR108_AddrInfo { get; set; }
        public string CR109_Description { get; set; }
        public string CR110_Description { get; set; }


    }
}