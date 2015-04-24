using System.Collections.Generic;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.ANSI.X12_270
{
    public class ST270: EDIBase
    {
        public ST270()
        {
            
        }

        public STSeg ST { get; set; }
        public BHTSeg BHT { get; set; }

        [EDILoop("HL")]
        public List<Loop2000> HL { get; set; }


        public SESeg SE { get; set; }



        /// <summary>
        /// This is for LX and HL counts
        /// </summary>
        internal void EnsureCounts()
        {
            int HLCnt = 0;
            int sourceParent = 0;
            int provParent = 0;
            int subParent = 0;
            for (int i = 0; i < HL.Count; i++)
            {
                var lvl = HL[i];
                lvl.HL.HL01_HierID = HLCnt++;
                switch (lvl.HL.HL03_LevelCode)
                {
                    case "20": //Source -- never has a parent is the top level
                        sourceParent = HLCnt;
                        break;
                    case "21": //Provider
                        provParent = HLCnt;
                        lvl.HL.HL02_ParentID = sourceParent.ToString();
                        break;
                    case "22": //subscriber
                        subParent = HLCnt;
                        lvl.HL.HL02_ParentID = provParent.ToString();
                        if (i < HL.Count - 1)
                        {
                           lvl.HL.HL04_HasChildFlag = HL[i].HL.HL03_LevelCode.Equals("23");
                        }
                        break;
                    case "23": //Dependent
                        lvl.HL.HL02_ParentID = subParent.ToString();
                        break;
                }
            }
        }




    }
}
