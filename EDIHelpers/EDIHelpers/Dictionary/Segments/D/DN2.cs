namespace EDIHelpers.Dictionary.Segments
{
    public class DN2Seg : SegmentBase
    {
        public DN2Seg()
            : base("DN2")
        {
        }
        public string DN201_ReferenceID { get; set; }
        public string DN202_ToothStatus { get; set; }
        public double? DN203_Quantity { get; set; }
        public string DN204_Qualifier { get; set; }
        //TODO:  Make DateString for this...
        public string DN205_Date { get; set; }
        public string DN206_Code { get; set; }
    }
}