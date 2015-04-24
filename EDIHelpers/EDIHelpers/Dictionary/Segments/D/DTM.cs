using System;
using EDIHelpers.Attributes;
using EDIHelpers.DataTypes;

namespace EDIHelpers.Dictionary.Segments
{
    public class DTMSeg : SegmentBase
    {
        public DTMSeg()
            : base("DTM")
        {
        }
        public string DTM01_Qualifier { get; set; }
        public DateTime DTM02_Date { get; set; }
        public string DTM03_Time { get; set; }
        [EDILength(2)]
        public string DTM04_TimeCode { get; set; }
        public string DTM05_DateFormat { get; set; }
        public DateString DTM06_Date { get; set; }


        //TOOD:  Possibly put the getfrom there if we need to...



    }
}