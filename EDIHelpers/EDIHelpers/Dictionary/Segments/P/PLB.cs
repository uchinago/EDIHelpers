using System;
using EDIHelpers.Attributes;
using EDIHelpers.Dictionary.Composites;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Provider Level Adjustments
    /// </summary>
    public class PLBSeg : SegmentBase
    {
        public PLBSeg()
            : base("PLB")
        {

        }
        public string PLB01_ReferenceID { get; set; }
        [EDIFormat("D8")]
        public DateTime PLB02_Date { get; set; }
        public C042_AdjustmentID PLB03_AdjustmentID { get; set; }
        public double? PLB04_Amount { get; set; }
        public C042_AdjustmentID PLB05_AdjustmentID { get; set; }
        public double? PLB06_Amount { get; set; }
        public C042_AdjustmentID PLB07_AdjustmentID { get; set; }
        public double? PLB08_Amount { get; set; }
        public C042_AdjustmentID PLB09_AdjustmentID { get; set; }
        public double? PLB10_Amount { get; set; }
        public C042_AdjustmentID PLB11_AdjustmentID { get; set; }
        public double? PLB12_Amount { get; set; }
        public C042_AdjustmentID PLB13_AdjustmentID { get; set; }
        public double? PLB14_Amount { get; set; }

    }
}