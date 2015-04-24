using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_270
{
    public class Loop2110: EDIBase
    {
        public Loop2110()
        {
          
        }
        public EQSeg EQ { get; set; }
        public List<AMTSeg> AMT { get; set; }
        public VEHSeg VEH { get; set; }
        //PDR  //not implementing
        //PDP  //not implementing
        public List<IIISeg> III { get; set; }
        public List<REFSeg> REF { get; set; }
        public List<DTPSeg> DTP { get; set; }

   

     
    }
}
