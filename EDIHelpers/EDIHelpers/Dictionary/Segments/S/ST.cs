namespace EDIHelpers.Dictionary.Segments
{
    public class STSeg: SegmentBase
    {
        public STSeg() : base("ST")
        {
        }


        public STSeg(string st01, string st02, string st03)
            : base("ST")
        {
            ST01_TransactionID = st01;
            ST02_ControlNumber = st02;
            ST03_Version = st03;
        }



        private string ST01_TransactionID;
        private string ST02_ControlNumber;
        private string ST03_Version;

        public string ST01TransactionID
        {
            get { return ST01_TransactionID; }
            set { ST01_TransactionID = value; }
        }

        public string ST02ControlNumber
        {
            get { return ST02_ControlNumber; }
            set { ST02_ControlNumber = value; }
        }

        public string ST03Version
        {
            get { return ST03_Version; }
            set { ST03_Version = value; }
        }
    }
}