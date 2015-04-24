using System;

namespace EDIHelpers.Dictionary.Segments
{
    public class PLASeg : SegmentBase
    {
        public PLASeg()
            : base("PLA")
        {

        }

        public string PLA01_Action { get; set; }
        public string PLA02_Entity { get; set; }
        public DateTime PLA03_Date { get; set; }
        public string PLA04_Time { get; set; }
        public char PLA05_MaintenanceReason { get; set; }
    }
}