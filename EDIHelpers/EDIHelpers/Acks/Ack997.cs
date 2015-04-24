using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Acks.X12_997;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIHelpers.Acks
{
    public class Ack997: EDIBase    
    {
        public Ack997()
        {
        }
        public ISASeg ISA { get; set; }
        [EDILoop("GS")]
        public List<GS997> GSLoop { get; set; }
        public IEASeg IEA { get; set; }

        /// <summary>
        /// Designed to set the counts for IEA, GE, and SE segments by reading non null objects in the SE area.
        /// Sets all ST-SE control numbers to 0001 to start with per GS group and then counts forward.
        /// </summary>
        public void SetCounts()
        {
            IEA.IEA01_GroupCount = GSLoop.Count;
            foreach (var grp in GSLoop)
            {
                grp.GE.GE01_TransactionCount = grp.STLoops.Count;
                int stCnt = 0;
                for (int i = 0; i < grp.STLoops.Count; i++)
                {
                    var stl = grp.STLoops[i];
                    stl.ST.ST02ControlNumber = (stCnt++).ToString().PadLeft(4, '0');
                    stl.SE.SE02_ControlNumber = stl.ST.ST02ControlNumber;
                    stl.SE.SE01_SegmentCount = stl.GetSegmentCount();
                    
                }
            }
        }

    }

    public class GenericEDI: EDIBase
    {
        public ISASeg ISA { get; set; }
        [EDILoop("GS")]
        public List<GenericGS> GSLoop { get; set; }
        public IEASeg IEA { get; set; }
    }

    public class GenericGS: EDIBase
    {
        public GSSeg GS { get; set; }
        [EDILoop("ST")]
        public List<GenericST> STLoops { get; set; }
        public GESeg GE { get; set; }
    }

    public class GenericST: EDIBase
    {
        public STSeg ST { get; set; }
        //How to get all of these by themselves
        public List<GenericSeg> Segments { get; set; } 
        public SESeg SE { get; set; }
    }

    public class GenericSeg: SegmentBase
    {
        public GenericSeg() : base("")
        {
            
        }
    }
}
