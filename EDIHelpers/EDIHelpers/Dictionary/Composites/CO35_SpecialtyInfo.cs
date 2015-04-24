using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Composites
{
    public class CO35_SpecialtyInfo: CompositeBase
    {
        public CO35_SpecialtyInfo(string element, char seperator)
        {
           FromEDIString(element, seperator);   
        }

        private string C03501_SpecialtyCode;
        private string C03502_AgencyQualifier;
        /// <summary>
        /// N = No
        /// U = Unknown
        /// W = Not APplicable
        /// Y = Yes
        /// </summary>
        private char C03503_YesNoCode;

        public string C03501SpecialtyCode
        {
            get { return C03501_SpecialtyCode; }
            set { C03501_SpecialtyCode = value; }
        }
        [EDILength(2)] 
        public string C03502AgencyQualifier
        {
            get { return C03502_AgencyQualifier; }
            set { C03502_AgencyQualifier = value; }
        }

        /// <summary>
        /// N = No
        /// U = Unknown
        /// W = Not APplicable
        /// Y = Yes
        /// </summary>
        public char C03503YesNoCode
        {
            get { return C03503_YesNoCode; }
            set { C03503_YesNoCode = value; }
        }
    }
}
