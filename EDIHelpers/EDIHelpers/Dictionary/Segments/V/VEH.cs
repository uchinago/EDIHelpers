using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;
using EDIHelpers.Enums;

namespace EDIHelpers.Dictionary.Segments
{
    public class VEHSeg : SegmentBase
    {
        public VEHSeg()
            : base("VEH")
        {

        }

        public int VEH01_AssignedNum { get; set; }
        public string VEH02_IdentNum { get; set; }
        //Might need to say left or right alignment
        public int VEH03_Year { get; set; }
        public string VEH04_AgencyQualifier { get; set; }
        public string VEH05_RefID { get; set; }
        public string VEH06_RefID { get; set; }
        public string VEH07_RefID { get; set; }
        /// <summary>
        /// Largest Horizontal dimension of an object
        /// </summary>
        public double VEH08_Length { get; set; }

        public string VEH09_RefID { get; set; }
        public string VEH10_State { get; set; }

        public string VEH11_LocationID { get; set; }
        /// <summary>
        /// Y or N
        /// </summary>
        public YesNo VEH12_YesNo { get; set; }

        public double VEH13_Amount { get; set; }

        public YesNo VEH14_YesNo { get; set; }
        public double VEH15_Amount { get; set; }

        public string VEH16_ActionCode { get; set; }
        public string VEH17_CountryCode { get; set; }
        public string VEH18_Name { get; set; }
        public string VEH19_CountryCode { get; set; }
        public string VEH20_DescriptionCode { get; set; }
        public string VEH21_RefID { get; set; }

    }
}
