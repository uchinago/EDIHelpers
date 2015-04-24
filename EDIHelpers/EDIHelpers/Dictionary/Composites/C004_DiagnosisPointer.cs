using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Composites
{
    public class C004_DiagnosisPointer: CompositeBase
    {

        public C004_DiagnosisPointer() : base('^')
        {
            
        }

        public int C00401_DiagPointer { get; set; }
        public int? C00402_DiagPointer { get; set; }
        public int? C00403_DiagPointer { get; set; }
        public int? C00404_DiagPointer { get; set; }


    }
}
