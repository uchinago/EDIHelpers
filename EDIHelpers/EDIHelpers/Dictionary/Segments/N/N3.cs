namespace EDIHelpers.Dictionary.Segments
{
    public class N3Seg : SegmentBase
    {
        public N3Seg()
            : base("N3")
        {
        }

        public N3Seg(string N301, string N302 = null)
            : base("N3")
        {
            _addr1 = N301;
            _addr2 = N302;
        }

        private string _addr1;
        private string _addr2;

        public string Addr1
        {
            get { return _addr1; }
            set { _addr1 = value; }
        }

        public string Addr2
        {
            get { return _addr2; }
            set { _addr2 = value; }
        }

    }
}