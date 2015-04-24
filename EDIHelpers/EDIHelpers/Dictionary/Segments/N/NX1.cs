namespace EDIHelpers.Dictionary.Segments
{
    public class NX1Seg : SegmentBase
    {
        public NX1Seg()
            : base("NX1")
        {

        }
        public string NX101_EntityID { get; set; }
        public string NX102_EntityID { get; set; }
        public string NX103_EntityID { get; set; }
        public string NX104_EntityID { get; set; }
        public string NX105_EntityID { get; set; }
    }
}