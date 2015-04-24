using System;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class ISASeg: SegmentBase
    {
        public ISASeg()
            : base("ISA")
        {
        }


        private string ISA01_SecurityQualifier;
        private string ISA03_SecurityQualifier;
        private string ISA04_ReceiverSecurity;
        private string ISA05_SenderQualifier;
        private string ISA06_SenderID;
        private string ISA07_ReceiverQualifier;
        private string ISA08_ReceiverID;
        private DateTime ISA09_Date;
        private char ISA11_RepetitionDelim;
        private string ISA12_Version;
        private string ISA13_ControlNumber;
        private string ISA14_AckRequest;
        private string ISA15_TestProdFlag;
        private char ISA16_SubElementDelim;

        [EDIFixedLen(2)]
        public string ISA01SecurityQualifier
        {
            get { return String.IsNullOrWhiteSpace(ISA01_SecurityQualifier) ? "00" : ISA01_SecurityQualifier; }
            set { ISA01_SecurityQualifier = value; }
        }

        [EDIFixedLen(10)]
        public string ISA02SenderSecurity { get; set; }

        [EDIFixedLen(2)]
        public string ISA03SecurityQualifier
        {
            get { return String.IsNullOrWhiteSpace(ISA03_SecurityQualifier) ? "00" : ISA03_SecurityQualifier; }
            set { ISA03_SecurityQualifier = value; }
        }

        [EDIFixedLen(10)]
        public string ISA04ReceiverSecurity
        {
            get { return ISA04_ReceiverSecurity; }
            set { ISA04_ReceiverSecurity = value; }
        }
        [EDIFixedLen(2)]
        public string ISA05SenderQualifier
        {
            get { return ISA05_SenderQualifier; }
            set { ISA05_SenderQualifier = value; }
        }
        [EDIFixedLen(15)]
        public string ISA06SenderID
        {
            get { return ISA06_SenderID ?? "".PadRight(15); }
            set { ISA06_SenderID = value.PadRight(15); }
        }
        [EDIFixedLen(2)]
        public string ISA07ReceiverQualifier
        {
            get { return ISA07_ReceiverQualifier; }
            set { ISA07_ReceiverQualifier = value; }
        }
        [EDIFixedLen(15)]
        public string ISA08ReceiverID
        {
            get { return ISA08_ReceiverID ?? "".PadRight(15); }
            set { ISA08_ReceiverID = value.PadRight(15); }
        }

        [EDIFormat("D6")]
        public DateTime ISA09Date
        {
            get { return ISA09_Date; }
            set { ISA09_Date = value; }
        }

        [EDIFormat("TM")]
        public DateTime ISA10Time
        {
            get { return ISA09_Date; }
            set
            {
                ISA09_Date = new DateTime(ISA09_Date.Year, ISA09_Date.Month, ISA09_Date.Day, value.Hour, value.Minute, 0, 0);
            }
        }

        public char ISA11RepetitionDelim
        {
            get { return ISA11_RepetitionDelim; }
            set { ISA11_RepetitionDelim = value; }
        }
        [EDILength(5)]
        public string ISA12Version
        {
            get { return ISA12_Version; }
            set { ISA12_Version = value; }
        }

        public string ISA13ControlNumber
        {
            get { return ISA13_ControlNumber??"000000001"; }
            set { ISA13_ControlNumber = value.PadLeft(9, '0'); }
        }

        public string ISA14AckRequest
        {
            get { return ISA14_AckRequest; }
            set { ISA14_AckRequest = value; }
        }

        public string ISA15TestProdFlag
        {
            get { return ISA15_TestProdFlag; }
            set { ISA15_TestProdFlag = value; }
        }

        public char ISA16SubElementDelim
        {
            get { return ISA16_SubElementDelim; }
            set { ISA16_SubElementDelim = value; }
        }
    }
}