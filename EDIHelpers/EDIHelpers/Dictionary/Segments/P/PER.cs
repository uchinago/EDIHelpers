using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class PERSeg: SegmentBase
    {
        public PERSeg() : base("PER")
        {
        }

        private string PER01_FunctionCode;
        private string PER02_Name;
        private string PER03_Qualifier;
        private string PER04_Number;
        private string PER05_Qualifier;
        private string PER06_Number;
        private string PER07_Qualifier;
        private string PER08_Number;
        private string PER09_InquiryReference;

        [EDILength(2)]
        public string Per01FunctionCode
        {
            get { return PER01_FunctionCode; }
            set { PER01_FunctionCode = value; }
        }

        public string Per02Name
        {
            get { return PER02_Name; }
            set { PER02_Name = value; }
        }

        [EDILength(2)]
        public string Per03Qualifier
        {
            get { return PER03_Qualifier; }
            set { PER03_Qualifier = value; }
        }

        public string Per04Number
        {
            get { return PER04_Number; }
            set { PER04_Number = value; }
        }
        [EDILength(2)]
        public string Per05Qualifier
        {
            get { return PER05_Qualifier; }
            set { PER05_Qualifier = value; }
        }

        public string Per06Number
        {
            get { return PER06_Number; }
            set { PER06_Number = value; }
        }
        [EDILength(2)]
        public string Per07Qualifier
        {
            get { return PER07_Qualifier; }
            set { PER07_Qualifier = value; }
        }

        public string Per08Number
        {
            get { return PER08_Number; }
            set { PER08_Number = value; }
        }

        public string Per09InquiryReference
        {
            get { return PER09_InquiryReference; }
            set { PER09_InquiryReference = value; }
        }
    }
}


