using EDIHelpers.Attributes;

namespace EDIHelpers.Dictionary.Segments
{
    /// <summary>
    /// Carrier Details Equipment
    /// </summary>
    public class TD3Seg : SegmentBase
    {
        public TD3Seg()
            : base("TD3")
        {

        }
        [EDILength(2)]
        public string TD301_DescriptionCode { get; set; }
        public string TD302_EquipmentInitial { get; set; }
        public string TD303_EquipmentNumber { get; set; }
        public string TD304_WeightQual { get; set; }
        public double? TD305_Weight { get; set; }
        [EDILength(2)]
        public string TD306_UOM { get; set; }
        public char TD307_OwnershipCode { get; set; }
        [EDILength(2)]
        public string TD308_SealStatus { get; set; }
        public string TD309_SealNumber { get; set; }
        [EDILength(4)]
        public string TD310_EquipmentType { get; set; }
    }
}