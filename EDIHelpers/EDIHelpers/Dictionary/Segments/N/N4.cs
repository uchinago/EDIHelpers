namespace EDIHelpers.Dictionary.Segments
{
    public class N4Seg : SegmentBase
    {
        public N4Seg()
            : base("N4")
        {
        }

        public N4Seg(string N401, string N402, string N403, string N404 = null, string N405 = null)
            : base("N4")
        {
            _city = N401;
            _state = N402;
            _postalCode = N403;
            _country = N404;
            _countrySubdivision = N405;
        }

        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        private string _postalCode;

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
        private string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        private string _countrySubdivision;

        public string CountrySubdivision
        {
            get { return _countrySubdivision; }
            set { _countrySubdivision = value; }
        }
        

    }
}