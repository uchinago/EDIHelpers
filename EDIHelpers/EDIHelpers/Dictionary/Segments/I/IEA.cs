namespace EDIHelpers.Dictionary.Segments
{
    public class IEASeg : SegmentBase
    {
        public IEASeg()
            : base("IEA")
        {
        }

        public int IEA01_GroupCount { get; set; }
        public string IEA02_ControlNumber { get; set; }


    }
}