namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Transaction Supplemental Statistics
    /// </summary>
    public class TS2Seg : SegmentBase
    {
        public TS2Seg()
            : base("TS2")
        {

        }
        public double? TS201_Amount { get; set; }
        public double? TS202_Amount { get; set; }
        public double? TS203_Amount { get; set; }
        public double? TS204_Amount { get; set; }
        public double? TS205_Amount { get; set; }
        public double? TS206_Amount { get; set; }
        public double? TS207_Quantity { get; set; }
        public double? TS208_Amount { get; set; }
        public double? TS209_Amount { get; set; }
        public double? TS210_Quantity { get; set; }
        public double? TS211_Quantity { get; set; }
        public double? TS212_Quantity { get; set; }
        public double? TS213_Quantity { get; set; }
        public double? TS214_Quantity { get; set; }
        public double? TS215_Amount { get; set; }
        public double? TS216_Quantity { get; set; }
        public double? TS217_Amount { get; set; }
        public double? TS218_Amount { get; set; }
        public double? TS219_Amount { get; set; }
    }
}