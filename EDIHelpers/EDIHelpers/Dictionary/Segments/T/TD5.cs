using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class TD5Seg: SegmentBase
    {
        public TD5Seg() : base("TD5")
        {
            
        }
        public string TD501_RouteSequence { get; set; }
        public string TD502_IDQual { get; set; }
        public string TD503_ID { get; set; }
        public string TD504_TransportType { get; set; }
        public string TD505_Routing { get; set; }
        [EDILength(2)]
        public string TD506_OrderStatus { get; set; }
        public string TD507_LocationQual { get; set; }
        public string TD508_LocationID { get; set; }
        [EDILength(2)]
        public string TD509_TransitDirection { get; set; }
        [EDILength(2)]
        public string TD510_TransitTimeQual { get; set; }
        public double? TD511_TransitTime { get; set; }
        [EDILength(2)]
        public string TD512_ServiceLevel { get; set; }
        [EDILength(2)]
        public string TD513_ServiceLevel { get; set; }
        [EDILength(2)]
        public string TD514_ServiceLevel { get; set; }
        public string TD515_CountryCode { get; set; }
    }
}