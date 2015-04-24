using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class PRVSeg: SegmentBase
    {
        public PRVSeg() : base("PRV")
        {
            
        }

        public string PRV01_ProviderCode { get; set; }
        public string PRV02_Qualifier { get; set; }
        public string PRV03_ReferenceID { get; set; }
        [EDILength(2)]
        public string PRV04_State { get; set; }
        public CO35_SpecialtyInfo PRV05_Specialty { get; set; }
        [EDILength(3)]
        public string PRV06_OrganizationCode { get; set; }

    }
}
