using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class RELSeg : SegmentBase
    {
        public RELSeg()
            : base("REL")
        {

        }
        [EDILength(2)]
        public string REL01_Relastionship { get; set; }
        public int? REL02_Number { get; set; }
       
    }
}