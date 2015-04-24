using System.Collections.Generic;
using EDIDocuments.Vendor.BassProShop.X856;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.Vendor.BassProShop
{
    public class VICS856 : EDIBase
    {
        public ISASeg ISA { get; set; }
        [EDILoop("GS")]
        public List<GS856> GSLoop { get; set; }
        public IEASeg IEA { get; set; }

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
                    //           stl.EnsureCounts();
                }
            }
        }
    }
}