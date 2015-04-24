using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDIHelpers.Dictionary.Composites
{
    public class C056_RaceInfo: CompositeBase
    {
        public C056_RaceInfo()
        {
            
        }
        public C056_RaceInfo(string element, char seperator = '^')
        {
            FromEDIString(element, seperator);
        }

        /// <summary>
        /// 7 = Not Provided
        /// 8 = Not Applicable
        /// A = Asian or Pacific Islander
        /// B = Black
        /// C = Caucasian
        /// D = Subcontinent Asian American
        /// E = Other Race or Ethnicity
        /// F = Asian Pacific American
        /// G = Native American
        /// H = Hispanic
        /// I = American Indian or Alaskan Native
        /// J = Native Hawaiian
        /// N = Black (Non-Hispanic) -> A person having origins in any of the black racial groups of Africa who is not of Mexican, Puerto Rican, Cuban, or South or Central American origin or of any other Spanish culture or origin regardless of race
        /// O = White (Non-Hispanic) -> A person having origins in any of the original peoples of Europe, North Africa, or the Middle East who is not of Mexican, Puerto Rican, Cuban, or South or Central American origin or of any other Spanish culture or origin regardless of race
        /// P = Pacific Islander
        /// Q = Black or African American (Office of Management and Budget 1997)
        /// R = Hispanic or Latino (Office of Management and Budget 1997)
        /// S = White (Office of Management and Budget 1997)
        /// T = American Indian or Alaska Native (Office of Management and Budget 1997)
        /// U = Asian (Office of Management and Budget 1997)
        /// V = Native Hawaiian or Other Pacific Islander (Office of Management and Budget 1997)
        /// W = Not Hispanic or Latino (Office of Management and Budget 1997)
        /// Z = Mutually Defined
        /// </summary>
        private char C05601_Race;

        private string C05602_Qualifier;
        private string C05603_Code;

        /// <summary>
        /// 7 = Not Provided
        /// 8 = Not Applicable
        /// A = Asian or Pacific Islander
        /// B = Black
        /// C = Caucasian
        /// D = Subcontinent Asian American
        /// E = Other Race or Ethnicity
        /// F = Asian Pacific American
        /// G = Native American
        /// H = Hispanic
        /// I = American Indian or Alaskan Native
        /// J = Native Hawaiian
        /// N = Black (Non-Hispanic) -> A person having origins in any of the black racial groups of Africa who is not of Mexican, Puerto Rican, Cuban, or South or Central American origin or of any other Spanish culture or origin regardless of race
        /// O = White (Non-Hispanic) -> A person having origins in any of the original peoples of Europe, North Africa, or the Middle East who is not of Mexican, Puerto Rican, Cuban, or South or Central American origin or of any other Spanish culture or origin regardless of race
        /// P = Pacific Islander
        /// Q = Black or African American (Office of Management and Budget 1997)
        /// R = Hispanic or Latino (Office of Management and Budget 1997)
        /// S = White (Office of Management and Budget 1997)
        /// T = American Indian or Alaska Native (Office of Management and Budget 1997)
        /// U = Asian (Office of Management and Budget 1997)
        /// V = Native Hawaiian or Other Pacific Islander (Office of Management and Budget 1997)
        /// W = Not Hispanic or Latino (Office of Management and Budget 1997)
        /// Z = Mutually Defined
        /// </summary>
        public char C05601Race
        {
            get { return C05601_Race; }
            set { C05601_Race = value; }
        }

        public string C05602Qualifier
        {
            get { return C05602_Qualifier; }
            set { C05602_Qualifier = value; }
        }

        public string C05603Code
        {
            get { return C05603_Code; }
            set { C05603_Code = value; }
        }
    }
}
