using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Composites
{
    public class C024_RelatedCauses: CompositeBase
    {
        public string C02401_CauseCode { get; set; }
        public string C02402_CauseCode { get; set; }
        public string C02403_CauseCode { get; set; }
        [EDILength(2)]
    
        public string C02401_State { get; set; }
        public string C02401_Country { get; set; }
    }
}