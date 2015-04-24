using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X277
{
    //Descript how the loop is distinquised
    public class LoopServiceProvider: EDIBase
    {
        public LoopServiceProvider()
        {
        }
        //HL03 = 19
        public HLSeg HL { get; set; }
        public List<NM1Seg> NM1 { get; set; }
        public TRNSeg TRN { get; set; }
        public List<STCSeg> STC { get; set; }
        //TODO: Determine end element as either the EQ or HL...
        [EDILoop("HL", 3, "22", 0)]
        public List<Subscriber277> Subscriber { get; set; }

    }
}
