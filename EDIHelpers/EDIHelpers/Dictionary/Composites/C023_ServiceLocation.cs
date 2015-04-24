using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Composites
{
    public class C023_ServiceLocation: CompositeBase
    {
        public string C02301_FacilityCode { get; set; }
        public string C02302_FacilityQualifier { get; set; }
        public char C02303_FrequencyCode { get; set; }
    }
}

