using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class SACSeg: SegmentBase
    {
        
        public SACSeg() : base("SAC")
        {
            
        }

        public char SAC01_ChargeIndicator { get; set; }
        [EDILength(4)]
        public string SAC02_ChargeCode { get; set; }
        [EDILength(2)]
        public string SAC03_AgencyCode { get; set; }
        public string SAC04_ChargeCode { get; set; }

        public double? SAC05_Amount { get; set; }
        public char SAC06_ { get; set; }
        public double? SAC07_Percent { get; set; }
        public double? SAC08_Rate { get; set; }
        [EDILength(2)]
        public string SAC09_UOM { get; set; }
        public double? SAC10_Quantity { get; set; }
        public double? SAC11_Quantity { get; set; }
        [EDILength(2)]
        public string SAC12_HandlingCode { get; set; }
        public string SAC13_RefernenceID { get; set; }
        public string SAC14_OptionNumber { get; set; }
        public string SAC15_Description { get; set; }
        public string SAC16_Language { get; set; }

    }
}