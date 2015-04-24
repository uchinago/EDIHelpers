namespace EDIHelpers.Dictionary.Segments
{
    public class REFSeg : SegmentBase
    {
        public REFSeg(): base("REF")
        {
        }

        public REFSeg(string ref01, string ref02, string ref03 = null)
            : base("REF")
        {
            _Qualifier = ref01;
            _ID = ref02;
            _description = ref03;
        }

        private string _Qualifier;

        public string REF01Qualifier
        {
            get { return _Qualifier; }
            set { _Qualifier = value; }
        }

        private string _ID;

        public string REF02ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _description;

        public string REF03Description
        {
            get { return _description; }
            set { _description = value; }
        }

    }
}