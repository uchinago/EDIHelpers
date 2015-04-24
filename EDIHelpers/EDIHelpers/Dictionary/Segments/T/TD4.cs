using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Carrier Details Special Handling or Hazardous Material
    /// </summary>
    public class TD4Seg: SegmentBase
    {
        public TD4Seg() : base("TD4")
        {
            
        }
        public string TD401_SpecialHandlingCode { get; set; }
        public char TD402_HazMatQual { get; set; }
        public string TD403_HazMatClass { get; set; }
        public string TD404_Description { get; set; }
        public YesNo TD405_ResponseCode { get; set; }
    }
}