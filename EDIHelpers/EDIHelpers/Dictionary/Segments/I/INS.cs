using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class INSSeg: SegmentBase
    {
        public INSSeg() : base("INS")
        {
            
        }

        public INSSeg(YesNo INS01, string INS02, string INS03, string INS04)
            : base("INS")
        {
            INS01_YesNoCode = INS01;
            INS02_RelationCode = INS02;
            INS03_MaintenanceType = INS03;
            INS04_MaintenanceReason = INS04;
        }


        /// <summary>
        /// N = No
        /// U = Unknown
        /// W = Not Applicable
        /// Y = Yes
        /// </summary>
        public YesNo INS01_YesNoCode { get; set; }
        [EDILength(2)]
        public string INS02_RelationCode { get; set; }
        [EDILength(3)]
        public string INS03_MaintenanceType { get; set; }
        public string INS04_MaintenanceReason { get; set; }
        /// <summary>
        /// A = Active
        /// C = COBRA
        /// I = Involuntary
        /// S = Surviving INsured
        /// T = Tax Equity and Fiscal Resp Act (TEFRA)
        /// V = Volunatry
        /// </summary>
        public char INS05_BenefitStatus { get; set; }

        public C052_StatusCodes INS06_MedicareStatus { get; set; }
        public string INS07_COBRA { get; set; }
        [EDILength(2)]
        public string INS08_EmploymentStatus { get; set; }
        /// <summary>
        /// F = Full Time
        /// N = Not a student
        /// P = Part Time
        /// </summary>
        public char INS09_StudentStatus { get; set; }
        /// <summary>
        /// N = No
        /// U = Unknown
        /// W = Not Applicable
        /// Y = Yes
        /// </summary>
        public YesNo INS10_YesNoCode { get; set; }

        public string INS11_DateQualifier { get; set; }
        
        //TODO: Create structure for datetime so we can have to from in one field
        public DateTime INS12_Date { get; set; }
        /// <summary>
        /// O = Other Restrictions
        /// R = Restricted Access
        /// U = Unrestricted access
        /// </summary>
        public char INS13_ConfidentialityCode { get; set; }

        public string INS14_City { get; set; }
        [EDILength(2)]
        public string INS15_State { get; set; }
        public string INS16_CountryCode { get; set; }
        public string INS17_Number { get; set; }

    }
}

