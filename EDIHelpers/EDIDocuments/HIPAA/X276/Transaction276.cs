using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary;
using EDIHelpers.Dictionary.Segments;

namespace EDIDocuments.HIPAA.X276
{
    public class Transaction276 : EDIBase
    {
        public Transaction276()
        {
        }

        public STSeg ST { get; set; }
        public BHTSeg BHT { get; set; }

        //THis works great....
        //[EDILoop("HL")]
        //public List<Loop2000> HList { get; set; } 

        //We leave the last element off to account for the SE segment
        [EDILoop("HL", 3, "20")]
        public List<LoopInfoSource276> Source { get; set; }


        public SESeg SE { get; set; }

        /// <summary>
        /// This is for LX and HL counts
        /// </summary>
        internal void EnsureCounts()
        {
            int HLCnt = 0;
            foreach (var src in Source)
            {
                src.HL.HL01_HierID = HLCnt++;
                src.HL.HL02_ParentID = null;
                src.HL.HL03_LevelCode = "20";
                src.HL.HL04_HasChildFlag = true;
                foreach (var rcvr in src.Receiver)
                {
                    rcvr.HL.HL01_HierID = HLCnt++;
                    rcvr.HL.HL02_ParentID = src.HL.HL01_HierID.ToString();
                    rcvr.HL.HL03_LevelCode = "21";
                    rcvr.HL.HL04_HasChildFlag = true;
                    foreach (var sp in rcvr.ServiceProvider)
                    {
                        sp.HL.HL01_HierID = HLCnt++;
                        sp.HL.HL02_ParentID = rcvr.HL.HL01_HierID.ToString();
                        sp.HL.HL03_LevelCode = "19";
                        sp.HL.HL04_HasChildFlag = true;

                        foreach (var subs in sp.Subscriber)
                        {
                            subs.HL.HL01_HierID = HLCnt++;
                            subs.HL.HL02_ParentID = sp.HL.HL01_HierID.ToString();
                            subs.HL.HL03_LevelCode = "22";
                            subs.HL.HL04_HasChildFlag = (subs.Dependent != null);
                            if (subs.HL.HL04_HasChildFlag.Value)
                            {
                                foreach (var depd in subs.Dependent)
                                {
                                    depd.HL.HL01_HierID = HLCnt++;
                                    depd.HL.HL02_ParentID = rcvr.HL.HL01_HierID.ToString();
                                    depd.HL.HL03_LevelCode = "23";
                                    depd.HL.HL04_HasChildFlag = false;

                                }
                            }

                        }



                    }
                }

            }
        }
    }
}
