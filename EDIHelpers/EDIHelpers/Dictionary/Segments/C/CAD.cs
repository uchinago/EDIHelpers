using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class CADSeg : SegmentBase
    {
        public CADSeg()
            : base("CAD")
        {

        }
        public string CAD01_TransportType { get; set; }
        public string CAD02_EquipmentInitial { get; set; }
        public string CAD03_EquipmentNumber { get; set; }
        public string CAD04_StandardCarrier { get; set; }
        public string CAD05_Routing { get; set; }
        /// <summary>
        /// Shipment/Order status code
        /// </summary>
        [EDILength(2)]
        public string CAD06_StatusCode { get; set; }
        public string CAD07_ReferenceQual { get; set; }
        public string CAD08_ReferenceID { get; set; }
        [EDILength(2)]
        public string CAD09_ServiceLevel { get; set; }
    }
}