using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Composites
{
        public class C043_ClaimStatus: CompositeBase
        {
            public C043_ClaimStatus()
                : base('^')
            {

            }
            public string C04301_Code { get; set; }
            public string C04302_Code { get; set; }

            public string C04303_EntityIdentCode { get; set; }
            public string C04304_Qualifier { get; set; }
        }
}
