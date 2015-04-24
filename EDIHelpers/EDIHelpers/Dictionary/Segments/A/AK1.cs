using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class AK1Seg : SegmentBase
    {
        public AK1Seg()
            : base("AK1")
        {

        }

        public AK1Seg(string ak101, string ak102, string ak103)
            : base("AK1")
        {
            AK101_GroupID = ak101;
            AK102_GroupControlNumber = ak102;
            AK103_GroupVersion = ak103;
        }


        /// <summary>
        /// Usually this is the GS01 value
        /// </summary>
        [EDILength(2)]
        public string AK101_GroupID { get; set; }
        public string AK102_GroupControlNumber { get; set; }
        public string AK103_GroupVersion { get; set; }

    }
}