using System;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Line Item Schedule
    /// </summary>
    public class SCHSeg : SegmentBase
    {
        public SCHSeg()
            : base("SCH")
        {

        }
        public double? SCH01_Quantity { get; set; }
        [EDILength(2)]
        public string SCH02_UOM { get; set; }

        public string SCH03_EntityID { get; set; }
        public string SCH04_Name { get; set; }
        [EDILength(3)]
        public string SCH05_DTMQual { get; set; }
        [EDIFormat("D8")]
        public DateTime SCH06_Date { get; set; }
        [EDIFormat("TM")]
        public string SCH07_Time { get; set; }
        [EDILength(3)]
        public string SCH08_DTMQual { get; set; }
        [EDIFormat("D8")]
        public DateTime SCH09_Date { get; set; }
        [EDIFormat("TM")]
        public string SCH10_Time { get; set; }

        public string SCH11_RequestRefID { get; set; }
        public string SCH12_AssignedID { get; set; }

    }
}