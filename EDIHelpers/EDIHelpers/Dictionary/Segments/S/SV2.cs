using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class SV2Seg : SegmentBase
    {
        public SV2Seg()
            : base("SV2")
        { }

        public string SV201_RevenueCode { get; set; }
        
        public C003_MedicalProc SV202_Procedure { get; set; }
        
        public double? SV203_ChargeAmount { get; set; }

        [EDILength(2)]
        public string SV204_UOM { get; set; }

        public double? SV205_Quantity { get; set; }
        public double? SV206_UnitRate { get; set; }

        public double? SV207_DeniedAmount { get; set; }
        public YesNo SV208_ResponseCode { get; set; }
        public char SV209_NursingHomeStatus { get; set; }
        public char SV210_LevelOfCare { get; set; }
    }
}
