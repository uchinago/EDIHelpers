using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    public class DMGSeg : SegmentBase
    {
        public DMGSeg()
            : base("DMG")
        {

        }

        public DMGSeg(string qualifier, DateTime dtm, char gender): base("DMG")
        {
            DMG01_Qualifer = qualifier;
            DMG02_Date = dtm;
            DMG03_Gender = gender;

        }


        public string DMG01_Qualifer { get; set; }
        public DateTime DMG02_Date { get; set; }
        /// <summary>
        /// A = Not Provided
        /// B = Not APplicable
        /// F = Female
        /// M = Male
        /// N = Non-sexed
        /// U = Unknown
        /// x = Unsexable
        /// </summary>
        public char DMG03_Gender { get; set; }

        public char DMG04_MaritialStatus { get; set; }
        public C056_RaceInfo DMG05_Race { get; set; }
        public string DMG06_Citizenship { get; set; }
        public string DMG07_CountryCode { get; set; }
        public string DMG08_VerificationBasis { get; set; }
        public double? DMG09_Quantity { get; set; }
        public string DMG10_Qualifier { get; set; }
        public string DMG11_Code { get; set; }


    }
}
