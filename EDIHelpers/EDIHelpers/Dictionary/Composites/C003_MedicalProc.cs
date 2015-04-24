using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Composites
{
    public class C003_MedicalProc: CompositeBase
    {
        public C003_MedicalProc() : base('^')
        {
            
        }
        [EDILength(2)] 
        public string C00301_Qualifier { get; set; }
        public string C00302_ProcedureCode { get; set; }
         [EDILength(2)] 
        public string C00303_Modifier { get; set; }
         [EDILength(2)] 
        public string C00304_Modifier { get; set; }
         [EDILength(2)] 
        public string C00305_Modifier { get; set; }
         [EDILength(2)] 
        public string C00306_Modifier { get; set; }
    }
}
