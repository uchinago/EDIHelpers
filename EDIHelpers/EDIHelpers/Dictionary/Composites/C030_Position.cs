namespace EDIHelpers.Dictionary.Composites
{
    public class C030_Position : CompositeBase
    {
        public C030_Position()
            : base('^')
        {
        }

        public int? C030_01_ElementPosition { get; set; }
        public int? C030_02_CompositionPosition { get; set; }
        public int? C030_03_RepeatingPosition { get; set; }

    }
}