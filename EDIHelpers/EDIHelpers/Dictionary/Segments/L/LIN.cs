using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class LINSeg: SegmentBase
    {
        public LINSeg() : base("LIN")
        {
        }
        public string LIN01_AssignedID { get; set; }
        [EDILength(2)]
        public string LIN02_Qualifier { get; set; }
        public string LIN03_Code { get; set; }

        [EDILength(2)]
        public string LIN04_Qualifier { get; set; }
        public string LIN05_Code { get; set; }

        [EDILength(2)]
        public string LIN06_Qualifier { get; set; }
        public string LIN07_Code { get; set; }

        [EDILength(2)]
        public string LIN08_Qualifier { get; set; }
        public string LIN09_Code { get; set; }

        [EDILength(2)]
        public string LIN10_Qualifier { get; set; }
        public string LIN11_Code { get; set; }

        [EDILength(2)]
        public string LIN12_Qualifier { get; set; }
        public string LIN13_Code { get; set; }
        [EDILength(2)]
        public string LIN14_Qualifier { get; set; }
        public string LIN15_Code { get; set; }
        [EDILength(2)]
        public string LIN16_Qualifier { get; set; }
        public string LIN17_Code { get; set; }
        [EDILength(2)]
        public string LIN18_Qualifier { get; set; }
        public string LIN19_Code { get; set; }



        [EDILength(2)]
        public string LIN20_Qualifier { get; set; }
        public string LIN21_Code { get; set; }

        [EDILength(2)]
        public string LIN22_Qualifier { get; set; }
        public string LIN23_Code { get; set; }
        [EDILength(2)]
        public string LIN24_Qualifier { get; set; }
        public string LIN25_Code { get; set; }
        [EDILength(2)]
        public string LIN26_Qualifier { get; set; }
        public string LIN27_Code { get; set; }
        [EDILength(2)]
        public string LIN28_Qualifier { get; set; }
        public string LIN29_Code { get; set; }



        [EDILength(2)]
        public string LIN30_Qualifier { get; set; }
        public string LIN31_Code { get; set; }

    }
}
