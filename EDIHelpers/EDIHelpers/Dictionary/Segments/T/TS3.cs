using System;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Transaction Statistics
    /// </summary>
    public class TS3Seg : SegmentBase
    {
        public TS3Seg()
            : base("TS3")
        {

        }
        public string TS301_ReferenceID { get; set; }
        public string TS302_FacilityCode { get; set; }
        [EDIFormat("D8")]
        public DateTime TS303_Date { get; set; }
        public double? TS304_Quantity { get; set; }
        public double? TS305_Amount { get; set; }
        public double? TS306_Amount { get; set; }
        public double? TS307_Amount { get; set; }
        public double? TS308_Amount { get; set; }
        public double? TS309_Amount { get; set; }
        public double? TS310_Amount { get; set; }
        public double? TS311_Amount { get; set; }
        public double? TS312_Amount { get; set; }
        public double? TS313_Amount { get; set; }
        public double? TS314_Amount { get; set; }
        public double? TS315_Amount { get; set; }
        public double? TS316_Amount { get; set; }
        public double? TS317_Amount { get; set; }
        public double? TS318_Amount { get; set; }
        public double? TS319_Amount { get; set; }
        public double? TS320_Amount { get; set; }
        public double? TS321_Amount { get; set; }
        public double? TS322_Amount { get; set; }
        public double? TS323_Quantity { get; set; }
        public double? TS324_Amount { get; set; }
    }
}