using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class SV4Seg : SegmentBase
    {
        public SV4Seg()
            : base("SV4")
        { }
        public string SV401_ReferenceID { get; set; }
        public C003_MedicalProc SV402_Procedure { get; set; }

        public string SV403_ReferenceID { get; set; }
        public YesNo SV404_ResponseCode { get; set; }
        public char SV405_DispenseAsWritten { get; set; }
        public string SV406_LevelOfService { get; set; }
        public char SV407_PrescriptionOrigin { get; set; }
        public string SV408_Description { get; set; }

        public YesNo SV409_ResponseCode { get; set; }
        public YesNo SV410_ResponseCode { get; set; }
        public char SV411_UnitDose { get; set; }

        public string SV412_BasisOfCost { get; set; }
        public char SV413_BasisOfDays { get; set; }
        [EDILength(2)]
        public string SV414_DosageForm { get; set; }
        public char SV415_CopayStatus { get; set; }
        public char SV416_PatientLocation { get; set; }
        public char SV417_LevelOfCare { get; set; }
        public char SV418_PriorAuthType { get; set; }


    }
}
