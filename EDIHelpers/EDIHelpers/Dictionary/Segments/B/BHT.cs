using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class BHTSeg :SegmentBase
    {
        public BHTSeg() : base("BHT")
        {}

        private string BHT01_StructureCode;
        private string BHT02_PurposeCode;
        private string BHT03_ReferenceID;
        private DateTime BHT04_Date;
        private string BHT06_TransType;

        [EDILength(4)]
        public string Bht01StructureCode
        {
            get { return BHT01_StructureCode; }
            set { BHT01_StructureCode = value; }
        }
        [EDILength(2)]
        public string Bht02PurposeCode
        {
            get { return BHT02_PurposeCode; }
            set { BHT02_PurposeCode = value; }
        }

        public string Bht03ReferenceID
        {
            get { return BHT03_ReferenceID; }
            set { BHT03_ReferenceID = value; }
        }

        [EDIFormat("D8")]
        public DateTime Bht04Date
        {
            get { return BHT04_Date; }
            set { BHT04_Date = value; }
        }

        [EDIFormat("TMS")]
        public DateTime Bht05Time
        {
            get { return BHT04_Date; }
            set { BHT04_Date = new DateTime(Bht04Date.Year, Bht04Date.Month, Bht04Date.Day, value.Hour, value.Minute, value.Second, value.Millisecond); }
        }
        [EDILength(2)]
        public string Bht06TransType
        {
            get { return BHT06_TransType; }
            set { BHT06_TransType = value; }
        }
    }
}
