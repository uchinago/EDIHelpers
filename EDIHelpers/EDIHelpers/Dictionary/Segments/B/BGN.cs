using System;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class BGNSeg : SegmentBase
    {
        public BGNSeg()
            : base("BGN")
        { }

        private string BGN01_PurposeCode;
        private string BGN02_ReferenceID;
        private DateTime BGN03_Date;
        //BGN04 is put with BGN03 as part of the time within the date field
        private string BGN05_TimeCode;
        private string BGN06_ReferenceID;
        private string BGN07_TransactionType;
        private string BGN08_ActionCode;
        private string BGN09_SecurityLevel;


        public string Bgn01PurposeCode
        {
            get { return BGN01_PurposeCode; }
            set { BGN01_PurposeCode = value; }
        }

        public string Bgn02ReferenceID
        {
            get { return BGN02_ReferenceID; }
            set { BGN02_ReferenceID = value; }
        }

        [EDIFormat("D8")]
        public DateTime Bgn03Date
        {
            get { return BGN03_Date; }
            set { BGN03_Date = value; }
        }

        [EDIFormat("TM")]
        public DateTime BGN04Time
        {
            get { return BGN03_Date; }
            set { BGN03_Date = new DateTime(BGN03_Date.Year, BGN03_Date.Month, BGN03_Date.Day, value.Hour, value.Minute, value.Second, value.Millisecond); }
        }

        public string Bgn05TimeCode
        {
            get { return BGN05_TimeCode; }
            set { BGN05_TimeCode = value; }
        }

        public string Bgn06ReferenceID
        {
            get { return BGN06_ReferenceID; }
            set { BGN06_ReferenceID = value; }
        }

        public string Bgn07TransactionType
        {
            get { return BGN07_TransactionType; }
            set { BGN07_TransactionType = value; }
        }

        public string Bgn08ActionCode
        {
            get { return BGN08_ActionCode; }
            set { BGN08_ActionCode = value; }
        }

        public string Bgn09SecurityLevel
        {
            get { return BGN09_SecurityLevel; }
            set { BGN09_SecurityLevel = value; }
        }
    }
}