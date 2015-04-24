using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class ICMSeg : SegmentBase
    {
        public ICMSeg()
            : base("ICM")
        {

        }

        public char ICM01_Frequency { get; set; }
        public double? ICM02_Amount { get; set; }
        public double? ICM03_Quantity { get; set; }
        public string ICM04_LocationID { get; set; }
        public string ICM05_SalaryGrade { get; set; }
        [EDILength(3)]
        public string ICM06_CurrencyCode { get; set; }


    }
}

