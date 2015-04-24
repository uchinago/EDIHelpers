using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_837
{
    public class Loop2430: EDIBase
    {

        public SVDSeg SVD { get; set; }
        public List<CASSeg> CAS { get; set; }
        public List<DTPSeg> DTP { get; set; }
        public List<AMTSeg> AMT { get; set; } 
    }
}
