using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class AK2Seg : SegmentBase
    {
        public AK2Seg()
            : base("AK2")
        {

        }

        public AK2Seg(string ak201, string ak202, string ak203)
            : base("AK2")
        {
            AK201_TransationID = ak201;
            AK202_STControlNumber = ak202;
            AK203_GroupVersion = ak203;

        }

        /// <summary>
        /// Usually this is the ST01 value
        /// </summary>
        [EDILength(3)]
        public string AK201_TransationID { get; set; }
        public string AK202_STControlNumber { get; set; }
        public string AK203_GroupVersion { get; set; }

    }
}