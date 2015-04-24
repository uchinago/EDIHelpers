using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Composites
{
    public class C042_AdjustmentID : CompositeBase
    {
        public C042_AdjustmentID()
            : base('^')
        {
        }
        [EDILength(2)]
        public string C042_01_Reason { get; set; }
        public string C042_02_ReferenceID { get; set; }

    }
}