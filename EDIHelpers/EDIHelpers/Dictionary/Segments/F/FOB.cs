using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class FOBSeg: SegmentBase
    {
        public FOBSeg() : base("FOB")
        {
            
        }
        [EDILength(2)]
        public string FOB01_ShipmentMethod { get; set; }
        public string FOB02_LocationQual { get; set; }
        public string FOB03_Description { get; set; }
        [EDILength(2)]
        public string FOB04_TransTermQual { get; set; }
        [EDILength(3)]
        public string FOB05_TransTermCode { get; set; }
        public string FOB06_LocationQualifier { get; set; }
        public string FOB07_Description { get; set; }
        [EDILength(2)]
        public string FOB08_RiskLossCode { get; set; }
        public string FOB09_Description { get; set; }

    }
}