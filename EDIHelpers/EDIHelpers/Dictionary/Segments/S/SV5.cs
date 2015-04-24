using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class SV5Seg : SegmentBase
    {
        public SV5Seg()
            : base("SV5")
        { }

        public C003_MedicalProc SV501_Procedure { get; set; }
        public string SV502_UOM { get; set; }
        public double? SV503_Quantity { get; set; }
        public double? SV504_Amount { get; set; }
        public double? SV505_Amount { get; set; }
        public char SV506_FrequencyCode { get; set; }
        public char SV507_PrognosisCode { get; set; }

        
    }
}
