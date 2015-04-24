using System;
using EDIHelpers.DataTypes;

namespace EDIHelpers.Dictionary.Segments
{
    public class DTPSeg : SegmentBase
    {
        public DTPSeg()
            : base("DTP")
        {
        }

        public DTPSeg(string DTP01, string DTP03, string DTP02 = "D8")
            : base("DTP")
        {
            DTP01_Qualifier = DTP01;
            DTP02_DateFormat = DTP02;
            DTP03_Date = DTP03;
        }

        public string DTP01_Qualifier { get; set; }
        public string DTP02_DateFormat { get; set; }
        public DateString DTP03_Date { get; set; }

        //TOOD:  Possibly put the getfrom there if we need to...



    }
}