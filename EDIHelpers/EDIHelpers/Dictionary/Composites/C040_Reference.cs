using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Composites
{
    public class C040_Reference: CompositeBase
    {
        public C040_Reference()
            : base('^')
        {
        }

        public string C040_01_Qualifier { get; set; }
        public string C040_02_ReferenceID { get; set; }
        public string C040_03_Qualifier { get; set; }
        public string C040_04_ReferenceID { get; set; }
        public string C040_05_Qualifier { get; set; }
        public string C040_06_ReferenceID { get; set; }

    }
}
