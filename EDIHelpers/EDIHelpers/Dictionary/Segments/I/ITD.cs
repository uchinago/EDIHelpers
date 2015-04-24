using System;
using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    public class ITDSeg:SegmentBase
    {
        public ITDSeg() : base("ITD")
        {
            
        }
        [EDILength(2)]
        public string ITD01_TermsType { get; set; }
        public string ITD02_TermsBasisDate { get; set; }
        public double? ITD03_DiscountPercent { get; set; }
        [EDIFormat("D8")]
        public DateTime ITD04_DiscountDueDate { get; set; }
        public int? ITD05_DiscountDueDays { get; set; }
        public int? ITD06_NetDueDays { get; set; }
        public int? ITD07_NetDays { get; set; }
        public double? ITD08_DiscountAmount { get; set; }
        [EDIFormat("D8")]
        public DateTime ITD09_DeferredDueDate { get; set; }
        public double? ITD10_DeferredAmount { get; set; }
        public double? ITD11_PercentPayable { get; set; }
        public string ITD12_Description { get; set; }
        public string ITD13_DayOfMonth { get; set; }
        public string ITD14_PaymentMethod { get; set; }
        public double? ITD15_Percent { get; set; }
    }
}