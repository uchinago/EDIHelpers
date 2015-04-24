namespace EDIHelpers.Dictionary.Segments
{
    public class IDCSeg : SegmentBase
    {
        public IDCSeg()
            : base("IDC")
        {

        }
        public string IDC01_CoverageDesc { get; set; }
        public char IDC02_CardType { get; set; }
        public double? IDC03_Quantity { get; set; }
        public string IDC04_ActionCode { get; set; }
    }
}