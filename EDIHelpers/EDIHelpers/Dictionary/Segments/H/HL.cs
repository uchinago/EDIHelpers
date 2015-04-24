using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Segments
{
    public class HLSeg: SegmentBase
    {
        public HLSeg() : base("HL")
        {
            
        }

        public int HL01_HierID { get; set; }
        public string HL02_ParentID { get; set; }
        public string HL03_LevelCode { get; set; }
        public bool? HL04_HasChildFlag { get; set; }

       
    }
}
