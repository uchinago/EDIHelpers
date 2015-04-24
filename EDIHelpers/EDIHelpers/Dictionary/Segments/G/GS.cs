namespace EDIHelpers.Dictionary.Segments
{
    public class GSSeg : SegmentBase
    {
        public GSSeg()
            : base("GS")
        {
        }

        private string GS01_GroupID;
        private string GS02_SenderID;
        private string GS03_ReceiverID;
        private string GS04_Date;
        private string GS05_Time;
        private string GS06_ControlNumber;
        private string GS07_ResponsibleAgencyCode = "X";
        private string GS08_Version;

        public string GS01GroupID
        {
            get { return GS01_GroupID; }
            set { GS01_GroupID = value; }
        }

        public string GS02SenderID
        {
            get { return GS02_SenderID; }
            set { GS02_SenderID = value; }
        }

        public string GS03ReceiverID
        {
            get { return GS03_ReceiverID; }
            set { GS03_ReceiverID = value; }
        }

        public string GS04Date
        {
            get { return GS04_Date; }
            set { GS04_Date = value; }
        }

        public string GS05Time
        {
            get { return GS05_Time; }
            set { GS05_Time = value; }
        }

        public string GS06ControlNumber
        {
            get { return GS06_ControlNumber; }
            set { GS06_ControlNumber = value; }
        }

        public string GS07ResponsibleAgencyCode
        {
            get { return GS07_ResponsibleAgencyCode; }
            set { GS07_ResponsibleAgencyCode = value; }
        }

        public string GS08Version
        {
            get { return GS08_Version; }
            set { GS08_Version = value; }
        }
    }
}